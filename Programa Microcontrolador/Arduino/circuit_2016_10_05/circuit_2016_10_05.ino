	//Software para trampa de Sedimentos S/MT 234
	//ICMyL, UNAM
	//Autor: Daniel Martinez Cruz
	//correo: fi.danielmartinez@gmail.com

/*Presentacion
 * Software de control de trampas de sedimento S/MT 234
 * Este circuito sirve como reemplazo para el circuito original de las
 * trampas de sedimento de la compania KUM.
 * 
 * Disenado en el Instituto de Ciencias del Mar y Limnologia
 * Oficina de instrumentacion Oceanografica
 * Asesor:  M en C. Arturo Ronquillo Arvizu
 * Tesista: Daniel Martinez Cruz
*/

/*	-----Notas-----
 * SCL - Amarillo
 * SDA - Naranja
 */ 


/*	-----Changelog-----
* 2016-09-09  Daniel  <Daniel@DANIEL-PC> - Version inicial del software
* 2016-09-13  Daniel  <Daniel@DANIEL-PC> - Primera implementacion de la alarma
* 2016-09-13  Daniel  <Daniel@DANIEL-PC> - Revision del circuito de la alarma
*/ 

//####Librerias requeridas
#include <Arduino.h>
#include <EEPROM.h>
#include <Wire.h>
#include <Rtc_Pcf8583P.h>

//####Iniciando el RTC
Rtc_Pcf8583P rtc;

//####Bandera de interrupcion
volatile int alarm_flag=0;

//####Datos de configuracion
const byte encoderPin	= 2;  //Pin del encoder (INT0)
const byte relojPin		= 3;  //Pin del reloj	(INT1)
const byte pinMotor		= 6; //Pin que controla al motor
const byte pos			= 21; //Numero de muestras

//####Variables internas de control para encoder
int buttonState;		//Define la variable de estado del sensor
int lastButtonState		= LOW;  //El sensor inicia en LOW
long debounceDelay		= 50; //Variable para eliminar el ruido
long lastDebounceTime	= 0;  //Variable para eliminar el ruido

//####Direcciones de memoria
byte counter	= 0;	//Variable para contar el numero de pulsos
byte numalarm	= 0;	//Direccion en la memoria de la alarma
byte i			= 0;	//Indicador de posicion en memoria
bool armed=false;
int day[pos];			//Array de dias
int month[pos];			//Array de meses
int year[pos];			//Array de anios

//####Variables de control de posicion en el motor
byte numPos	= 0;
byte pi		= 1;    //Posicion inicial
byte pmax	= pos;  //Posicion maxima permitida
byte pa;            //Posicion actual
byte paInicial;
byte pd;            //Posicion deseada
byte pdInicial;

//####Cadenas de texto
String inString = "";    // string donde se almacenara lo recibido en el puerto serie
String EEPROM_S ="EEPROM";
char dosPuntos=':';

//%%%%%Orden de ejecucion del programa%%%%%
//void startup(), Configuracion del puerto serie
//Configuracion de pines, void pines()
//Borrar EEPROM,	void borraEE()
//Reiniciar contador, "x"
//void sCommand()
//void tCommand()
//void sistemaFechas()

//%%Motor%%
//encoder(int pa, int pd), Regresa el numero de posiciones a girar
//giraCarrusel(boolean enc, byte numPos), Si ENC=TRUE, gira el motor numPos posiciones
//byte contar()	//Cuenta 2*n posiciones
//boolean debounce()//Funcion de control de encoder

//%%Control de la alarma%%
//void setAlarm(int i)
//void setAlarmFlag() //Si se activa la interrupcion de la alarma del reloj cambia alarm_flag a 1
//void clearAlarm(), Reinicia la interrupcion
//void alarmFlag(), que hacer cuando se active la interrupcion

//%%%%%Funciones auxiliares%%%%%
//void clearTerm(),	Funcion para "limpiar" la terminal
//void status(), Imprime el estado de las variables de control


//%%%%%Funciones de impresion%%%%%
//void pt(), Imprime hora y fecha de RTC
//void pr(), Imprime todas las fechas almacenadas en la trampa de sedimentos


//%%%%%%%%%%%%Funciones principales%%%%%%%%%%%%%
void startup()
{
	  // Se abre la comunicacion serial y espera a que se abra el puerto
  Serial.begin(9600);
  Serial.println("Trampa de sedimentos");
  // Fecha de compilacion del archivo
  Serial.println("Build date: " __DATE__ ", " __TIME__);
  Serial.println("Compiler version " __VERSION__);
  Serial.println(__FILE__);
  Serial.println();
  Serial.println();
	
}
//<Pines>
/*	Del Datasheet
 * 18.2.6.  Unconnected Pins
If some pins are unused, it is recommended to ensure that these pins have a defined level. Even though
most of the digital inputs are disabled in the deep sleep modes as described above, floating inputs should
be avoided to reduce current consumption in all other modes where the digital inputs are enabled (Reset,
Active mode and Idle mode).
The simplest method to ensure a defined level of an unused pin, is to enable the internal pull-up. In this
case, the pull-up will be disabled during reset. If low power consumption during reset is important, it is
recommended to use an external pull-up or pull-down. Connecting unused pins directly to V CC or GND is
not recommended, since this may cause excessive currents if the pin is accidentally configured as an
output.
* 
* 	Para activar los pullup debemos definir los pines como entrada y con un nivel alto.
*/
void pines()
{    
  //Funcion para configuracion de pines
  //pinMode(0,INPUT);	//Configurado como RX
  //pinMode(1, OUTPUT);	//Configurado como TX
  pinMode(2, INPUT);	//Encoder (INT0)
  pinMode(3, INPUT);	//Interrupcion del reloj (INT1)
  pinMode(4, INPUT);	//NC
  pinMode(5, INPUT);	//NC
  pinMode(6, OUTPUT);	//Pin del motor
  pinMode(7, INPUT);	//NC
  pinMode(8, INPUT);	//NC
  pinMode(9, INPUT);	//NC
  pinMode(10, INPUT);	//NC
  //pinMode(11, INPUT);	//MOSI
  //pinMode(12, INPUT);	//MISO
  //pinMode(13, OUTPUT);//SCK
  pinMode(14, INPUT);	//NC A0
  pinMode(15, INPUT);	//NC A1
  pinMode(16, INPUT);	//NC A2
  pinMode(17, INPUT);	//NC A3
  //pinMode(18, INPUT);	//SDA A4 
  //pinMode(19, OUTPUT);//SCL A5
  /*Activando los pullup en los pines no conectados*/
  //1
  digitalWrite(2,HIGH);
  digitalWrite(3,HIGH);       // turn on pullup resistors
  digitalWrite(4,HIGH);
  digitalWrite(5,HIGH);
  digitalWrite(7,HIGH);
  digitalWrite(8,HIGH);
  digitalWrite(9,HIGH);
  digitalWrite(10,HIGH);
  //11
  digitalWrite(pinMotor,LOW);
  //13
  digitalWrite(14,HIGH);
  digitalWrite(15,HIGH);
  digitalWrite(16,HIGH);
  digitalWrite(17,HIGH);

}
//</Pines>

//<Borrar EEPROM>
void borraEE()//Con este procedimiento se borra la memoria EEPROM del arduino
{
  for (byte j = 0; j < 100; j++)
  {
    EEPROM.write(j, 0);
  }
  delay(500);
  Serial.print(EEPROM_S);
  Serial.println(" borrada");

}
//</Borrar EEPROM>
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
		Serial.println("Primer alarma guardada");
		setAlarm(i);
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
            numalarm=0;
      }           
      if (inString.substring(0, 1) == "s")//Almacenar fechas
      {
		
        sCommand();//aqui debe de enviar a programar la primer alarma de acuerdo a la fecha 1
        armed=true;
        EEPROM.write(89,numalarm);
        //Alarma 1 programada
      }
      //cuando se active la alarma 1, programar la alarma 2
      
     
      if (inString.substring(0, 1) == "c")//Limpiar terminal
      {
        clearTerm();
      }
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

//%%%Control del motor%%%
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
    numPos = pos + (pd - pa);
    return numPos;
  }
}
//</Encoder>*********
//Girar carrusel***
void giraCarrusel(boolean enc, byte numPos) 
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
	//Si el encoder aumenta la cuenta entra a esta funcion
	//El motor gira 2*n posiciones del encoder
	//ejemplo: para girar 3 posiciones lee 6 pulsaciones del encoder
  boolean pressed = debounce();
  if (pressed == true)
  {

    counter++;
    Serial.print("Debe girar ");
    Serial.print(numPos);
    Serial.print(" y counter es ");
    if(counter==0||counter==1)	//Para evitar errores de impresion se entra en esta funcion
    Serial.println(0);
    else
    Serial.println(counter/2);
    if (counter == 2*numPos)	//Si el contador es igual al doble de posiciones a girar se detiene el motor
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
	//Funcion para eliminar el ruido de la entrada analogica del encoder
	boolean retVal = false;
	int reading = digitalRead(encoderPin);
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

//%%%Alarma%%%
//<setAlarm>
void setAlarm(int i)//Aqui se programa la alarma
{
	//Para que se active la alarma los registros deben de coincidir bit a bit
	//Por limitaciones del circuito PCF85853P, no se compara el anio, solo dia, mes y la hora.    
  Serial.print("Siguiente: setAlarm(");
  Serial.print(i+1);
  Serial.println(")");
  
    
  //Almacenar fecha
  byte alarm_day  = EEPROM.read(0+i);	//dd  
  byte alarm_month= EEPROM.read(25+i);//MM
  byte alarm_year_= EEPROM.read(50+i);//aa
  //Almacenar hora
  
  //La hora, minuto y segundo se puede definir como cero y la alarma se dara
  //en el cambio de dia
  //byte alarm_hour	=0;
  //byte alarm_minute	=0;
  byte alarm_sec	=0;
  byte alarm_hour   = rtc.getHour();  //hh
  byte alarm_minute	= rtc.getMinute()+1;//mm
  //byte alarm_sec    = 0;        //ss
  if (alarm_minute==60)
  {
	  alarm_sec=0;
	 alarm_hour++; 
  }
  if (alarm_hour==24)
  {
	  alarm_day++;
	 alarm_hour=0; 
  }
    
  //setAlarmTime(byte alarm_month, byte alarm_day, byte alarm_hour, byte alarm_minute, byte alarm_sec)
  rtc.setAlarmTime(alarm_month,alarm_day,alarm_hour,alarm_minute,alarm_sec);
  rtc.enableAlarm();//Start clock

}

//</setAlarm>
//<setAlarmFlag()>
void setAlarmFlag() //Si se activa la interrupcion de la alarma del reloj
{
	if (armed==true)
	{
		//Serial.println("INT0 Enabled");
		alarm_flag=1;
	}
	
}
//</setAlarmFlag()>

//<clr_alarm>
void clearAlarm()
{
  detachInterrupt(1);
  Serial.print("blink!\n");
  rtc.clearAlarm();
  delay(100);
  alarm_flag=0;
  attachInterrupt(1, setAlarmFlag, FALLING);
}
//</clr_alarm>

void alarmFlag()
{
	if (alarm_flag==1)
	{
		if (numalarm!=i)
		{
			numalarm++;
			clearAlarm();
			counter=0;
			numPos=1;
			giraCarrusel(true,numPos);
			setAlarm(numalarm);	//se programa la siguiente alarma
		}
		if (numalarm==i+1)
		{
			numalarm=0;
		}
		
	}
	
}

//*****Funciones de impresion*****
//<Fechas reloj>
void pt(){
	//******************Descomentar para verificar status del reloj
  //Serial.print("Status: ");
  //Serial.println(rtc.getStatus1()&0xFF,BIN);
  //Imprime dd/mm/aaaa HH:MM:SS
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
  // dd/mm/aa HH:MM:SS
  Serial.print("Alarm ");
  Serial.print(numalarm+1);
  Serial.print(": ");
  Serial.print(rtc.getAlarmDay());
  Serial.print("/");
  Serial.print(rtc.getAlarmMonth());
  Serial.print("/");
  Serial.print(rtc.getYear()); //El anio no se programa en la alarma (por limitacion del integrado)
  Serial.print(" ");
  Serial.print(rtc.getAlarmHour());
  Serial.print(dosPuntos);
  Serial.print(rtc.getAlarmMinute());
  Serial.print(dosPuntos);
  Serial.println(rtc.getAlarmSecond());
}
//</Fechas reloj>

//<Imprimir fechas>
void pr(){
  /*Se escribe en el puerto serie cada una de las fechas
  * con el formato sdd/mm/aaaa\n
  * ejemplo s09/06/2015\n es el 9 de Junio de 2015
  * las direcciones de la memoria son:
  * 0-24 dia
  * 25-49 mes
  * 50-74 anio
  */
  Serial.println();
  for (int i = 0; i<pos; i++)
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
//</Imprimir fechas>

//*****Funciones auxiliares*****
//<clearTerm>
void clearTerm()//Funcion para "limpiar" la terminal
{
  for (int j=0;j<20;j++)
  Serial.println();
}
//</clearTerm>

//<status>
void status()
{
  //Numero de muestras
  Serial.print("Numero de muestras ");
  Serial.println(pos);    
  
  Serial.print("Pin encoder ");
  Serial.println(encoderPin);
      
  Serial.print("Pin motor ");
  Serial.println(pinMotor);
  
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

}
//</status>

void setup()
{
  startup();
  pines();
  attachInterrupt(digitalPinToInterrupt(relojPin), setAlarmFlag, FALLING);//FALLING
  alarm_flag=0;
}
void loop()
{
  alarmFlag();
  sistemaFechas();
  contar();
  }





