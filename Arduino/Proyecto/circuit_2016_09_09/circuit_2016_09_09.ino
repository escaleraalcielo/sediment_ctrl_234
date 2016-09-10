//#include "mariamole_auto_generated.h"
//---------------------------------------------------------------------------
/*To Do:
Contador de posiciones
RTC Time
RTC Date
RTC Alarm

*/
//####Librerias requeridas
#include <Arduino.h>
#include <EEPROM.h>
#include <Wire.h>
#include <Rtc_Pcf8583P.h>
/*Presentacion
******Trampa de Sedimentos****************
Instituto de Ciencias del Mar y Limnologia
Oficina de instrumentacion Oceanografica

Asesor:  M en C. Arturo Ronquillo Arvizu
Tesista: Daniel Martinez Cruz
Este programa sirve para reemplazar la electronica de las trampas de sedimentos 
* del instituto de ciencias del mar.

* SCL - Amarillo
* SDA - Naranja
http://blog.kennyrasschaert.be/blog/2014/04/01/digital-input-on-an-arduino-using-a-push-button/
*/

//####Iniciando el RTC
Rtc_Pcf8583P rtc;

//####Bandera de interrupcion
volatile int alarm_flag=0;

//####Datos de configuracion
const byte buttonPin   = 2;  //Pin del encoder
const byte ledPin     = 13; //Pin que controla a nuestro LED
const byte pinMotor   = 12; //Pin que controla al motor
const byte pos      = 21; //Numero de muestras

//####Variables internas de control
int buttonState;              //Define la variable de estado del sensor
int lastButtonState   = LOW;  //El sensor inicia en LOW
long debounceDelay    = 50; //Variable para eliminar el ruido
long lastDebounceTime   = 0;  //Variable para eliminar el ruido

//####Direcciones de memoria
byte counter  = 0; //Variable para contar el numero de pulsos
byte numalarm     = 0;    //Direccion en la memoria de la alarma
int day[pos];    //Array de dias
byte i      = 0;       //Indicador de posicion en memoria
int month[pos];  //Array de meses
int year[pos];   //Array de anios

//####Variables de control de posicion en el motor
byte numPos   = 0;
byte pi     = 1;    //Posicion inicial
byte pmax     = pos;  //Posicion maxima permitida
byte pa;            //Posicion actual
byte paInicial;
byte pd;            //Posicion deseada
byte pdInicial;

//####Cadenas de texto
String inString = "";    // string donde se almacenara lo recibido en el puerto serie
String EEPROM_S ="EEPROM";
char dosPuntos=':';

//<setAlarmFlag()>
void setAlarmFlag()
{
  alarm_flag=1;
}
//</setAlarmFlag()>

//<Pines>
void pines()
{
  //Funcion para configuracion de pines
  //pinMode(1, OUTPUT);
  //pinMode(2, OUTPUT);
  pinMode(3, INPUT);
  pinMode(4, INPUT);
  pinMode(5, INPUT);
  pinMode(6, OUTPUT);
  pinMode(7, INPUT);
  pinMode(8, INPUT);
  pinMode(9, INPUT);
  pinMode(10, INPUT);
  pinMode(11, INPUT);
  pinMode(12, INPUT);
  pinMode(13, OUTPUT);
  //pinMode(A0, OUTPUT);
  //pinMode(A1, OUTPUT);
  //pinMode(A2, OUTPUT);
  //pinMode(A3, OUTPUT);
  //pinMode(A4, OUTPUT);
  //pinMode(A5, OUTPUT);
}
//</Pines>

//<Borrar EEPROM>*************************
void borraEE()
{
  //Serial.print("Borrando ");
  //Serial.println(EEPROM_S);
  //Con este procedimiento se borra la memoria EEPROM del arduino
  for (byte j = 0; j < 100; j++)
  {
    EEPROM.write(j, 0);
  }
  digitalWrite(ledPin, HIGH);
  delay(500);
  digitalWrite(ledPin, LOW);
  Serial.print(EEPROM_S);
  Serial.println(" borrada");

}
//</Borrar EEPROM>*************************

//<clearTerm>
void clearTerm()
{
  for (int j=0;j<20;j++)
  Serial.println();
}
//</clearTerm>

//<Fechas reloj>
void pt()
{
	//******************Descomentar para verificar status del reloj
  //Serial.print("Status: ");
  //Serial.println(rtc.getStatus1()&0xFF,BIN);
  //Imprime dd/MM/aaaa HH:mm:ss
  Serial.print("RTC  :");
  Serial.print(rtc.getDay());
  Serial.print("/");
  Serial.print(rtc.getMonth());
  Serial.print("/");
  Serial.print(rtc.getYear());
  Serial.print(" ");
  Serial.print(rtc.getHour());
  Serial.print(dosPuntos);
  Serial.print(rtc.getMinute());
  Serial.print(dosPuntos);
  Serial.println(rtc.getSecond());
  
  //Imprimir fecha de la alarma
  Serial.print("Alarm :");
  Serial.print(rtc.getAlarmDay());
  Serial.print("/");
  Serial.print(rtc.getAlarmMonth());
  Serial.print("/");
  Serial.print(rtc.getYear());
  Serial.print(" ");
  Serial.print(rtc.getAlarmHour());
  Serial.print(dosPuntos);
  Serial.print(rtc.getAlarmMinute());
  Serial.print(dosPuntos);
  Serial.println(rtc.getAlarmSecond());
}
//</Fechas reloj>

//<Imprimir fechas>**********************
void pr()
{
  /*Se escribe en el puerto serie cada una de las fechas
  * con el formato sdd/mm/aaaa\n
  * ejemplo s09/06/2015\n es el 9 de Junio de 2015
  * las direcciones de la memoria son:
  * 0-24 dia
  * 25-49 mes
  * 50-74 anio
  */
  Serial.println();
  for (int i = 0; i<21; i++)
  {
    /*Este procedimiento escribe lo siguiente
    * 1)dd/mm/aaaaa
    * ...
    * n)dd/mm/aaaa
    */

    Serial.print(i + 1);
    Serial.print(")");
    Serial.print(EEPROM.read(i));
    Serial.print("/");
    Serial.print(EEPROM.read(i + 25));
    Serial.print("/");
    Serial.println(EEPROM.read(i + 50));
    Serial.flush();
    delay(50);
  }

}
//</Imprimir fechas>**********************

//<Encoder>**********
int encoder(int pa, int pd)//Regresa el numero de posiciones a girar
{
  //Encoder debe de regresar el numero de posiciones que el motor debe de girar
  if (pa == pd)
  {
    numPos = 0;
    return numPos;
  }
  if (pd>pa)
  {
    numPos = pd - pa;
    return numPos;
  }
  if (pd<pa)
  {
    numPos = 21 + (pd - pa);
    return numPos;
  }
}
//</Encoder>*********

//Girar carrusel***
void giraCarrusel(boolean enc, byte numPos) //enc= Enciende motor
{
  if (enc == true)  //Si se enciende el motor
  {
    if(numPos==0)
    {
      Serial.println("El motor se encuentra en la posicion deseada");
      digitalWrite(pinMotor, LOW);
    }
    else
    {
      Serial.println("Motor encendido");
      Serial.print("El motor girara ");
      Serial.print(numPos);
      Serial.println(" posiciones");
      delay(10);
      digitalWrite(pinMotor,HIGH);
    }
  }

  if (enc == false)
  {
    digitalWrite(pinMotor, LOW);
    Serial.println("El motor se ha apagado");
    delay(500);
  }


}
//Girar carrusel***

//<Contar>
byte contar()
{
  boolean pressed = debounce();
  if (pressed == true)
  {

    counter++;
    Serial.print("Debe girar ");
    Serial.print(numPos);
    Serial.print(" y counter es ");
    if(counter==0||counter==1)
    Serial.println(0);
    else
    Serial.println(counter/2);
    if (counter == 2*numPos)
    {
      Serial.println("Se detiene el motor");
      digitalWrite(pinMotor, LOW);
    }
    return counter;
  }
}
//</Contar>

//<debounce>
boolean debounce()
{
  boolean retVal = false;
  int reading = digitalRead(buttonPin);
  if (reading != lastButtonState)
  {
    lastDebounceTime = millis();
  }
  if ((millis() - lastDebounceTime) > debounceDelay)
  {
    if (reading != buttonState)
    {
      buttonState = reading;
      if (buttonState == HIGH)
      {
        retVal = true;
      }
    }
  }
  lastButtonState = reading;
  return retVal;
}
//</debounce>

//<setAlarm>
void setAlarm()
{
    
  Serial.println("setAlarm()");
    
  //Almacenar fecha
  byte alarm_day  = EEPROM.read(0);   //dd  
  byte alarm_month= EEPROM.read(25);    //MM
  byte alarm_year_= EEPROM.read(50);    //aa
  
  //Almacenar hora
  byte alarm_hour   = rtc.getHour();  //hh
  byte alarm_minute   = rtc.getMinute()+1;//mm
  byte alarm_sec    = 0;        //ss
  
  //rtc.initClock();
  //setAlarmTime(byte alarm_month, byte alarm_day, byte alarm_hour, byte alarm_minute, byte alarm_sec)
  rtc.setAlarmTime(alarm_month,alarm_day,alarm_hour,alarm_minute,alarm_sec);
  rtc.enableAlarm();//Start clock
  
  //Para mostrar la alarma almacenada, descomentar
  //Serial.println("De la alarma");
  //Serial.print(rtc.getAlarmDay());
  //Serial.print("/");
  //Serial.print(rtc.getAlarmMonth());
  //Serial.print(" ");
  //Serial.print(rtc.getAlarmHour());
  //Serial.print(dosPuntos);
  //Serial.print(rtc.getAlarmMinute());
  //Serial.print(dosPuntos);	
  //Serial.println(rtc.getAlarmSecond());
}

//</setAlarm>

//<enableAlarm>
void enableAlarm()
{
  
  Serial.println("enableAlarm()");
  //Almacenar fecha
  int alarm_day = inString.substring(1, 3).toInt();   //83
  int alarm_month = inString.substring(4, 6).toInt();   //84
  //int year_ = inString.substring(7, 11).toInt()-2000;
  
  //Almacenar hora
  int alarm_hour    = inString.substring(12, 14).toInt(); //86
  int alarm_minute  = inString.substring(15,17).toInt();  //87
  int alarm_sec     = inString.substring(18,20).toInt();    //88
  //Fecha almacenada en memoria
  EEPROM.write(83, alarm_day);
  EEPROM.write(84, alarm_month);
  //Hora almacenada en memoria
  EEPROM.write(86, alarm_hour);
  EEPROM.write(87, alarm_minute);
  EEPROM.write(88, alarm_sec);
  //Set alarm
  rtc.initClock();
  //setAlarmTime(byte alarm_month, byte alarm_day, byte alarm_hour, byte alarm_minute, byte alarm_sec)
  rtc.setAlarmTime(EEPROM.read(84),EEPROM.read(83),EEPROM.read(86),EEPROM.read(87),EEPROM.read(88));
  rtc.enableAlarm();//Start clock
  //read alarm
  Serial.print(rtc.getAlarmDay());
  Serial.print("/");
  Serial.print(rtc.getAlarmMonth());
  Serial.print(" ");
  Serial.print(rtc.getAlarmHour());
  Serial.print(dosPuntos);
  Serial.print(rtc.getAlarmMinute());
  Serial.print(dosPuntos);
  Serial.println(rtc.getAlarmSecond());

  
}

//</enableAlarm>

void sCommand()
{
	
	
  
  //Se almacena la fecha en una variable temporal dd/mm/aaaa
  int day_ = inString.substring(1, 3).toInt();
  int month_ = inString.substring(4, 6).toInt();
  int year_ = inString.substring(7, 11).toInt() - 2000;
  //Se almacena la fecha en su array correspondiente
  day[i] = day_;
  month[i] = month_;
  year[i] = year_;
  EEPROM.write(i, day[i]);      //Day start on 0
  EEPROM.write(i + 25, month[i]); //Month start from 25
  EEPROM.write(i + 50, year[i]);  //Year start from 50
  if (i==0)
	{
		Serial.println("Fecha guardada");
		setAlarm();
	}
  Serial.print(i + 1);
  Serial.print(") ");
  Serial.print(day_);
  Serial.print("/");
  Serial.print(month_);
  Serial.print("/");
  Serial.println(year_);
  i++;
}

void tCommand()
{
  Serial.println("Hora y fecha guardada");
  //Almacenar fecha
  int day_  = inString.substring(1, 3).toInt();
  int month_  = inString.substring(4, 6).toInt();
  int year_ = inString.substring(7, 11).toInt()-2000;
  //Almacenar hora
  int hour_ = inString.substring(12, 14).toInt();
  int minute_ = inString.substring(15,17).toInt();
  int second_ = inString.substring(18,20).toInt();
  //Fecha almacenada en memoria
  EEPROM.write(75, day_);
  EEPROM.write(76, month_);
  EEPROM.write(77, year_);
  //Hora almacenada en memoria
  EEPROM.write(78, hour_);
  EEPROM.write(79, minute_);
  EEPROM.write(80, second_);

  //Impresion de fecha
  //Formato dd/MM/aaaa
  Serial.print(day_);
  Serial.print("/");
  Serial.print(month_);
  Serial.print("/");
  Serial.print(year_);

  //Impresion de hora
  //Formato hh:mm:ss
  Serial.print(" ");
  Serial.print(hour_);
  Serial.print(dosPuntos);
  Serial.print(minute_);
  Serial.print(dosPuntos);
  Serial.println(second_);

  rtc.initClock();
  //hr, min, sec
  rtc.setTime(EEPROM.read(78), EEPROM.read(79), EEPROM.read(80));
  //day, weekday, month, century(1=1900, 0=2000), year(0-99)
  rtc.setDate(EEPROM.read(75), 1, EEPROM.read(76), 0, EEPROM.read(77));
  rtc.enableAlarm();
  i++;
}
//<sistemaFechas>
void sistemaFechas() {
  // Se lee el puerto serie
  while (Serial.available() > 0)
  {
    /*Las siguientes dos lineas lo que hacen es que primero se recibe un caracter en el puerto serie
    *y despuas lo concatena en un string "inString" para su uso posterior
    */

    int inChar = Serial.read();
    inString += (char)inChar;
    if (inChar == '$') 
    { 
      //recibe "tdd/MM/yyyy HH:mm:ss"
      if (inString.substring(0, 1) == "t")//Sincronizar hora del reloj con la PC
      {
        tCommand();
      }
      /*
       *Para almacenar fechas recibe lo siguiente
        1) b$
        2) x$
        3) sdd/mm/aaaa$ del 1 al 21 ( o el # de muestras seleccionadas)
       *  
       */
      if (inString.substring(0, 1) == "b")//Borrar EEPROM
      {
        borraEE();
      }
      if (inString.substring(0, 1) == "x")//Reiniciar contador
      {
            i = 0;
      }
                
      if (inString.substring(0, 1) == "s")//Almacenar fechas
      {
        sCommand();
        EEPROM.write(89,numalarm);
        //setAlarm();
      }
      //aqui debe de enviar a programar la primer alarma de acuerdo a la fecha 1
      
      if (inString.substring(0, 1) == "a")//Guardar alarma en RTC
      {
        enableAlarm();
      }
      
      if (inString.substring(0, 1) == "c")//Limpiar terminal
      {
        clearTerm();
      }
      //************/
      
      if (inString.substring(0, 2) == "pr")//Imprimir fechas
      {
        pr();
      }
      if (inString.substring(0, 2) == "pt")//Imprimir tiempo
      {
        pt();
      }
      
      if (inString.substring(0, 2) == "al")//control encendido
      {
        //Interrupcion
        //Girar una posicion
        numPos=1;
        counter=0;
        giraCarrusel(true,numPos);
        //Programar siguiente alarma
        Serial.println("Proxima alarma");
        //alarma(EEPROM.read(75),EEPROM.read(78),EEPROM.read(79),EEPROM.read(80));
        //Dormir
       }
       if (inString.substring(0, 2) == "pb")//pushb awake
      {
        //Interrupcion
        //Despierta el arduino
        Serial.println("Trampa encendida");
       }
      if (inString.substring(0, 2) == "tm")//Reiniciar contador
      {
        rtc.initClock();
      }
     
      if (inString.substring(0, 3) == "mon")//Encender motor
      {
        //Posicion actual
        if (inString.substring(3, 5) == "pa")
        {
          pa = inString.substring(5, 7).toInt();
          paInicial=pa;
          EEPROM.write(81,paInicial);
        }
        //Posicion deseada
        if (inString.substring(7, 9) == "pd")
        {
          pd = inString.substring(9, 11).toInt();
          pdInicial=pd;
          EEPROM.write(82,pdInicial);
        }
        
        int numPosGiro=encoder(pa,pd);
        counter=0;
        giraCarrusel(true,numPosGiro);
        /*
        Serial.print("Reiniciando contador, ");
        Serial.print("pa es ");
        Serial.print(pa);
        Serial.print(" pd es ");
        Serial.println(pd);
        Serial.print("Debe de girar ");
        Serial.print(numPosGiro);
        Serial.println(" posiciones");
        */
      }
      if (inString.substring(0, 3) == "mof")//Apagar motor
      {
        giraCarrusel(false, 0);

      }
      if (inString.substring(0, 1) == "e")//Estado de la trampa
      {
        status();
      }

      /***************************/
      Serial.print("Comando: ");
      Serial.println(inString);
      // clear the string for new input:
      inString = "";
      //i++;

    }
  }
}
//</sistemaFechas>

//<status>
void status()
{
  //Numero de muestras
  Serial.print("Numero de muestras ");
  Serial.println(pos);    
  
  Serial.print("Pin encoder ");
  Serial.println(buttonPin);
      
  Serial.print("Pin motor ");
  Serial.println(pinMotor);
  
  Serial.print("Pin LED ");
  Serial.println(ledPin);
  
  Serial.print("Contador ");
  Serial.println(counter);
  

  Serial.print("numPos ");
  Serial.println(numPos);
  
  Serial.print("paInicial ");
  Serial.println(paInicial);  
      
  Serial.print("pdInicial ");
  Serial.println(pdInicial); 
       
  Serial.print("El motor esta");
  Serial.println(digitalRead(pinMotor));
  
  Serial.print("Hora programada");
  Serial.print(EEPROM.read(78));//hour_
  Serial.print(dosPuntos);
  Serial.print(EEPROM.read(79));//minute_
  Serial.print(dosPuntos);
  Serial.print(EEPROM.read(80));//second_
  Serial.println();
  
  Serial.print("Fecha programada");
  Serial.print(EEPROM.read(75));//hour_
  Serial.print("/");
  Serial.print(EEPROM.read(76));//minute_
  Serial.print("/");
  Serial.print(EEPROM.read(77));//second_
  Serial.println();

        //Posicion deseada
                        /*Serial.print("posAct ");
                        Serial.println(posAct);      //Posicion actual
                        Serial.print("posDes ");
                        Serial.println(posDes);      //Posicion deseada
                        */

}
//</status>
//dd,hh,mm,ss
////<alarma>
//void alarma(byte days_, byte hours_, byte minutes_, byte seconds_)
//{
  ///*
      //void enableAlarm(); // activate alarm flag and interrup
    //void setAlarm(byte min, byte hour, byte day, byte weekday); //set alarm vals, 99=ignore
    //void clearAlarm();  // clear alarm flag and interrupt
    //void resetAlarm();  // clear alarm flag but leave interrupt unchanged
  //*/
  
  //Serial.print("Alarma actual ");
  //Serial.print(days_);
  //Serial.print(" ");
  //Serial.print(hours_);
  //Serial.print(dosPuntos);
  //Serial.print(minutes_);
  //Serial.print(dosPuntos);
  //Serial.print(seconds_);
  //Serial.println();
  //Serial.print("Poxima alarma ");
  //Serial.print(days_+10);
  //Serial.print(" ");
  //Serial.print(hours_);
  //Serial.print(dosPuntos);
  //Serial.print(minutes_);
  //Serial.print(dosPuntos);
  //Serial.print(seconds_);
  //Serial.println();
  ////aqui se programa la alarma del RTC
//}
////</alarma>

//<clr_alarm>
void clearAlarm()
{
  detachInterrupt(1);
  Serial.print("blink!\r\n");
 
  rtc.clearAlarm();
  delay(1000);
  alarm_flag=0;
  attachInterrupt(1, setAlarmFlag, FALLING);
}
//</clr_alarm>

void alarmFlag()
{
	if (alarm_flag==1)
	{
	  //numalarm=EEPROM.read(89);
	  //if(numalarm==i)
	  //{
		  //numalarm=1;		  
	  //}
	  //else
	  //{
		//numalarm++;
	  
	  //switch(numalarm)
	  //{
		//case 1:
			////algo
			
			//Serial.print("Alarma ");
			//Serial.println(numalarm);
			//EEPROM.write(89,numalarm);
			//break;
		//case 2:
			////algo
			//Serial.print("Alarma ");
			//Serial.println(numalarm);
			//EEPROM.write(89,numalarm);
			//break;
		//case 3:
			////algo
			//Serial.print("Alarma ");
			//Serial.println(numalarm);
			//EEPROM.write(89,numalarm);
			//break;
		//case 4:
			////algo
			//Serial.print("Alarma ");
			//Serial.println(numalarm);
			//EEPROM.write(89,numalarm);
			//break;
		//case 5:
			////algo
			//Serial.print("Alarma ");
			//Serial.println(numalarm);
			//EEPROM.write(89,numalarm);
			//break;
		//case 6:
			////algo
			//Serial.print("Alarma ");
			//Serial.println(numalarm);
			//EEPROM.write(89,numalarm);
			//break;
		//case 7:
			////algo
			//Serial.print("Alarma ");
			//Serial.println(numalarm);
			//EEPROM.write(89,numalarm);
			//break;
		//case 8:
			////algo
			//Serial.print("Alarma ");
			//Serial.println(numalarm);
			//break;
		//case 9:
			////algo
			//Serial.print("Alarma ");
			//Serial.println(numalarm);
			//break;
		//case 10:
			////algo
			//Serial.print("Alarma ");
			//Serial.println(numalarm);
			//break;
		//case 11:
			////algo
			//Serial.print("Alarma ");
			//Serial.println(numalarm);
			//break;
		//case 12:
			////algo
			//break;
		//case 13:
			////algo
			//break;
		//case 14:
			////algo
			//break;
		//case 15:
			////algo
			//break;
		//case 16:
			////algo
			//break;
		//case 17:
			////algo
			//break;
		//case 18:
			////algo
			//break;
		//case 19:
			////algo
			//break;
		//case 20:
			////algo
			//break;
		//case 21:
			////algo
			//break;
		//}  
	  //}
	  
	  clearAlarm();
      counter=0;
      numPos=1;
      giraCarrusel(true,numPos);
      //setAlarm();	//se programa la siguiente alarma
	}
	
}

void setup()
{
  pines();
  // Se abre la comunicacion serial y espera a que se abra el puerto
  Serial.begin(9600);
  Serial.println("Trampa de sedimentos");
  // Fecha de compilacion del archivo
  Serial.println("Build date: " __DATE__ ", " __TIME__);
  Serial.println("Compiler version " __VERSION__);
  Serial.println(__FILE__);
  Serial.println();
  Serial.println();
  digitalWrite(pinMotor, LOW);//Nos aseguramos de que el motor no esta encendido
  digitalWrite(pinMotor, LOW);//Nos aseguramos de que el motor no esta encendido
  digitalWrite(3, HIGH);       // turn on pullup resistors
  attachInterrupt(1, setAlarmFlag, FALLING);
  alarm_flag=0;
  EEPROM.write(89,numalarm);
  
  
}
void loop()
{
  alarmFlag();
  sistemaFechas();
  contar();
  }



















