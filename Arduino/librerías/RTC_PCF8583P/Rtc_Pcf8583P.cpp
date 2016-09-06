/*
 * Rtc_Pcf8583P.cpp
 * 
 * Copyright 2016 Daniel <Daniel@DANIEL-PC>
 * 
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 2 of the License, or
 * (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston,
 * MA 02110-1301, USA.
 * Modification date:2016/08/09
 * 
 */

#if defined(ARDUINO) && ARDUINO >= 100
#include "Arduino.h"
#define byte uint8_t
#define send( X ) write( static_cast<uint8_t>(X) )
#define receive( X ) read( X )
#else
#include "WProgram.h"
#endif

#include <Wire.h>
#include "Rtc_Pcf8583P.h"

Rtc_Pcf8583P::Rtc_Pcf8583P(void)
{
	Wire.begin();
	RTC_ADDR = RTC_R >> 1;	//0X81 convert to 7 bit so Wire doesn't choke
}

void Rtc_Pcf8583P::initClock()
{
	//Control/Status Register;
		//bit 2 set to enable alarms.
	Wire.beginTransmission(RTC_ADDR);	//Set dir of I2C start signal
	Wire.send(STATUS);					//0x00, point to ctrl register
	Wire.send(0x84);   					//0x00->0x84 Stop count, Set alarm (bit2), on int\ will turn to vcc
	Wire.endTransmission();

	//Alarm Register;
		 //bits 4-5 set to one
		 //bit  7   alarm interrupt enable 0xB0
	Wire.beginTransmission(RTC_ADDR);//Set dir of I2C start signal
	Wire.send(DIR_ALARM);			//0x08 point to alarm/ctrl register
	Wire.send(RTC_ALARM);   		//0x08->0xB0 AL Int EN,dated alarm, no timer
	Wire.endTransmission();
	//go to set time

}
void Rtc_Pcf8583P::setTime(byte hour, byte minute, byte sec)
{
	//Example pseudocode: Setting the chip for a dated alarm
	//Stop counter - Control/Status register bit 7 = 0
	//Set Clock Time - Clock time/date/ registers 0x01 - 0x06
	//Set Alarm time - Alarm time/date registers 0x09 - 0x0e
	//Enable Alarm - Control/Status register bit 2 = 1
	//Start counter Control/Status register bit 7 = 0
	Wire.beginTransmission(RTC_ADDR);	// Set dir of I2C start signal
	Wire.send(STATUS);			//0x00 point to start address
	Wire.send(0x84);  			//0x00 ->0x84 stop counting, alarm enabled
	Wire.endTransmission();

	Wire.beginTransmission(RTC_ADDR);
	Wire.send(DIR_SEC);   			//0x02 set pointer to sec address
	Wire.send(decToBcd(sec)); 		//0x02 set seconds
	Wire.send(decToBcd(minute));	//0x03 set minutes
	Wire.send(decToBcd(hour));		//0x04 set hour
	Wire.endTransmission();
	
	Wire.beginTransmission(RTC_ADDR);  	// Set dir of I2C start signal
	Wire.send(STATUS);					//0x00 point to ctrl register
	Wire.send(0x04);					//0x00 configure ctrl register
	Wire.endTransmission();
	//go to set date
	
}

void Rtc_Pcf8583P::setDate(byte day, byte weekday, byte mon, byte century, byte year)
{
	//Example pseudocode: Setting the chip for a dated alarm
	//Stop counter - Control/Status register bit 7 = 0
	//Set Clock Time - Clock time/date/ registers 0x01 - 0x06
	//Set Alarm time - Alarm time/date registers 0x09 - 0x0e
	//Enable Alarm - Control/Status register bit 2 = 1
	//Start counter Control/Status register bit 7 = 0
	Wire.beginTransmission(RTC_ADDR);	// Set dir of I2C start signal
	Wire.send(STATUS);			//0x00 point to start address
	Wire.send(0x84);  			//0x00 ->0x84 stop counting, alarm enabled
	Wire.endTransmission();
			//Save year
	Wire.beginTransmission(RTC_ADDR);
	Wire.send(0x10);					//0x10 Save year
	year_base = year - year % 4;		//at the first byte free of RAM
	Wire.send(decToBcd(year_base));
	Wire.endTransmission();
	
			//Save (0-3) year and days
	//0 if leap year (feb has 29 days)
	//1,2,3 regular year
 	
	year=decToBcd(year%4);		//Converts 17 to 1
	year=year<<6;				//Converts 0x01 to 0x70
	year=year&0xC0;				//Mask bits (0 to 5)
								//year = 0b0100,0000
	day	=decToBcd(day);			//0 to 31 to BCD
	day =day&0x3F;				//0x05 point to year/date
	Wire.beginTransmission(RTC_ADDR);    			// Set dir of I2C start signal
	Wire.send(DIR_YEAR_DATE);	//0x05 
	Wire.send(year | day);  	//0x05 year and date
	//Wire.send(((byte)(year % 4) << 6) | dayBcd);  	//0x05
	Wire.send(decToBcd(mon) & 0x1F);  //0x06 send month
	Wire.endTransmission();
	
	//Reenable counter & alarm
	Wire.beginTransmission(RTC_ADDR);
	Wire.send(STATUS);
	Wire.send(0x04);
	Wire.endTransmission();
	
}

/* enable alarm interrupt
 * whenever the clock matches these values an int will
 * be sent out pin 3 of the Pcf8563 chip
 */

/* Private internal functions, but useful to look at if you need a similar func. */
byte Rtc_Pcf8583P::decToBcd(byte val)
{
	return ((val / 10 * 16) + (val % 10));
}

byte Rtc_Pcf8583P::bcdToDec(byte val)
{
	return ((val / 16 * 10) + (val % 16));
}

void Rtc_Pcf8583P::clearStatus()
{
	Wire.beginTransmission(RTC_ADDR);	// Set dir of I2C start signal
	Wire.send(0x0);				//point to ctrl register
	Wire.send(0x0); 			//Write 0x00 at dir 0x00 (control/status1)
	Wire.endTransmission();		//also disables alarm
}


void Rtc_Pcf8583P::setAlarmTime(byte alarm_month, byte alarm_day, byte alarm_hour, byte alarm_minute, byte alarm_sec)
{
	//Wire.beginTransmission(RTC_ADDR);	//Set dir of I2C start signal
	//Wire.send(STATUS);					//0x00 point to start address
	//Wire.send(0x84);  					//0x00 ->0x84 stop counting, alarm enabled
	//Wire.endTransmission();

	Wire.beginTransmission(RTC_ADDR);
	Wire.send(DIR_ALRM_SEC);   			//0x0A set pointer to sec address
	Wire.send(decToBcd(alarm_sec)); 	//0x0A set seconds
	Wire.send(decToBcd(alarm_minute));	//0x0B set minutes
	Wire.send(decToBcd(alarm_hour));	//0x0C set hour
	Wire.send(decToBcd(alarm_day)&0x3F);		//0x0D set days
	Wire.send(decToBcd(alarm_month)& 0x1F);	//0x0D set month
	Wire.endTransmission();
	
	Wire.beginTransmission(RTC_ADDR);	// Set dir of I2C start signal
	Wire.send(STATUS);					//0x00 point to start address
	Wire.send(0x04);  					//0x00 ->0x04 alarm enabled
	Wire.endTransmission();
	
}

void Rtc_Pcf8583P::enableAlarm()
{
	////set status1 AF val to zero
	//status1 &= ~RTC_ALARM_AF; //0bxxxx xxxx &0b0000 0010
	//status1 &= 0x84;
	////enable the interrupt
	//status1 |= alarm_enable_bit;

	//enable the interrupt
	Wire.beginTransmission(RTC_ADDR);  	// Set dir of I2C start signal
	Wire.send(STATUS);					//0x00 point to ctrl register
	Wire.send(0x04);					//0x00 configure ctrl register
	Wire.endTransmission();
}

/*
* Read status byte
* internal usage only here. see alarmEnabled, alarmActive.
*/

byte Rtc_Pcf8583P::readStatus1()
{
	// set the start byte of the status 2 data
	Wire.beginTransmission(RTC_ADDR);
	Wire.send(STATUS);
	Wire.endTransmission();

	Wire.requestFrom(RTC_ADDR, 1); //request 1 bytes
	return Wire.read();
}

/*
* Returns true if AIE is on
*
*/
boolean Rtc_Pcf8583P::alarmEnabled()
{
	return Rtc_Pcf8583P::readStatus1() & alarm_enable_bit;
}
boolean Rtc_Pcf8583P::alarmActive()
{
	return Rtc_Pcf8583P::readStatus1() & RTC_ALARM_AF;
}



/**
* Set the square wave pin output
*/
void Rtc_Pcf8583P::resetAlarm()
{
	//set status2 AF val to zero to reset alarm
	status1 &= ~RTC_ALARM_AF;
	Wire.beginTransmission(RTC_ADDR);
	Wire.send(STATUS);
	Wire.send(status1);
	Wire.endTransmission();
}

void Rtc_Pcf8583P::clearAlarm()
{
	//set status2 AF val to zero to reset alarm
	status1 &= ~RTC_ALARM_AF;
	//turn off the interrupt
	//status1 &= ~alarm_enable_bit;

	Wire.beginTransmission(RTC_ADDR);
	Wire.send(STATUS);
	Wire.send(status1);
	Wire.endTransmission();
}

/* call this first to load current date values to variables */
void Rtc_Pcf8583P::getDate()
{
	Wire.beginTransmission(RTC_ADDR);
	Wire.send(DIR_YEAR_DATE);	//0x05, point to
	Wire.endTransmission();

	Wire.requestFrom(RTC_ADDR, 2); //request 4 bytes
	incoming = Wire.read(); // year/date counter
	day = bcd_to_byte(incoming & 0x3f);
	//year = (int)((incoming >> 6) & 0x03);   
	month = bcd_to_byte(Wire.read() & 0x1f);  
	
	Wire.beginTransmission(RTC_ADDR);
	Wire.send(0x10);	//0x05, point to
	Wire.endTransmission();
	Wire.requestFrom(RTC_ADDR, 1);
	year = bcd_to_byte(Wire.read());
	
}
int Rtc_Pcf8583P::bcd_to_byte(byte bcd) {
	return ((bcd >> 4) * 10) + (bcd & 0x0f);
}

byte Rtc_Pcf8583P::int_to_bcd(int in) {
	return ((in / 10) << 4) + (in % 10);
}

/* call this first to load current time values to variables */
void Rtc_Pcf8583P::getTime()
{
	/* set the start byte , get the 2 status bytes */
	Wire.beginTransmission(RTC_ADDR);
	Wire.send(STATUS);
	Wire.endTransmission();

	Wire.requestFrom(RTC_ADDR, 5); //request 5 bytes
	status1 = Wire.receive();						//0x00 byte 1
	msec = Wire.receive();						//0x01 byte 2
	//0x7f 	= 0b01111111	mascara para asegurar que el ultimo bit sea 0 de la tabla de memoria
	sec = bcdToDec(Wire.receive() & 0x7f);	//0x02 byte 3
	minute = bcdToDec(Wire.receive() & 0x7f);	//0x03 byte 4
	//0x3f 	= 	0b00111111 mascara para programar las horas
	hour = bcdToDec(Wire.receive() & 0x3f);	//0x04 byte 5
}
void Rtc_Pcf8583P::getAlarmTime()
{
	/* set the start byte , get the 2 status bytes */
	Wire.beginTransmission(RTC_ADDR);
	Wire.send(DIR_ALRM_SEC);
	Wire.endTransmission();

	Wire.requestFrom(RTC_ADDR, 5); 					//0x0A request 5 bytes
	//
	alarm_sec 	= bcdToDec(Wire.receive() & 0x7f);	//0x0A byte  0x7f 	= 0b01111111 el ultimo bit sea 0
	alarm_minute= bcdToDec(Wire.receive() & 0x7f);	//0x0B byte 
	alarm_hour 	= bcdToDec(Wire.receive() & 0x3f);	//0x0C byte 0b00111111 mascara para programar las horas
	alarm_day 	= bcdToDec(Wire.receive() & 0x3f);
	alarm_month = bcdToDec(Wire.receive() & 0x1f);
}

char *Rtc_Pcf8583P::version() {
	return RTC_VERSION;
}

char *Rtc_Pcf8583P::formatTime(byte style)
{
	getTime();
	switch (style) {
	case RTC_TIME_HM:
		strOut[0] = '0' + (hour / 10);
		strOut[1] = '0' + (hour % 10);
		strOut[2] = ':';
		strOut[3] = '0' + (minute / 10);
		strOut[4] = '0' + (minute % 10);
		strOut[5] = '\0';
		break;
	case RTC_TIME_HMS:
	default:
		strOut[0] = '0' + (hour / 10);
		strOut[1] = '0' + (hour % 10);
		strOut[2] = ':';
		strOut[3] = '0' + (minute / 10);
		strOut[4] = '0' + (minute % 10);
		strOut[5] = ':';
		strOut[6] = '0' + (sec / 10);
		strOut[7] = '0' + (sec % 10);
		strOut[8] = '\0';
		break;
	}
	return strOut;
}

char *Rtc_Pcf8583P::formatDate(byte style)
{
	getDate();

	switch (style) {
	case RTC_DATE_ASIA:
		//do the asian style, yyyy-mm-dd
		if (century == 1) {
			strDate[0] = '1';
			strDate[1] = '9';
		}
		else {
			strDate[0] = '2';
			strDate[1] = '0';
		}
		strDate[2] = '0' + (year / 10);
		strDate[3] = '0' + (year % 10);
		strDate[4] = '-';
		strDate[5] = '0' + (month / 10);
		strDate[6] = '0' + (month % 10);
		strDate[7] = '-';
		strDate[8] = '0' + (day / 10);
		strDate[9] = '0' + (day % 10);
		strDate[10] = '\0';
		break;
	case RTC_DATE_US:
		//the pitiful US style, mm/dd/yyyy
		strDate[0] = '0' + (month / 10);
		strDate[1] = '0' + (month % 10);
		strDate[2] = '/';
		strDate[3] = '0' + (day / 10);
		strDate[4] = '0' + (day % 10);
		strDate[5] = '/';
		if (century == 1) {
			strDate[6] = '1';
			strDate[7] = '9';
		}
		else {
			strDate[6] = '2';
			strDate[7] = '0';
		}
		strDate[8] = '0' + (year / 10);
		strDate[9] = '0' + (year % 10);
		strDate[10] = '\0';
		break;
	case RTC_DATE_WORLD:
	default:
		//do the world style, dd-mm-yyyy
		strDate[0] = '0' + (day / 10);
		strDate[1] = '0' + (day % 10);
		strDate[2] = '-';
		strDate[3] = '0' + (month / 10);
		strDate[4] = '0' + (month % 10);
		strDate[5] = '-';

		if (century == 1) {
			strDate[6] = '1';
			strDate[7] = '9';
		}
		else {
			strDate[6] = '2';
			strDate[7] = '0';
		}
		strDate[8] = '0' + (year / 10);
		strDate[9] = '0' + (year % 10);
		strDate[10] = '\0';
		break;
	}
	return strDate;
}

byte Rtc_Pcf8583P::getStatus1()
{
	return status1;
}

//get sec
byte Rtc_Pcf8583P::getSecond()
{
	getTime();
	return sec;
}

//get minute
byte Rtc_Pcf8583P::getMinute()
{
	getTime();
	return minute;
}
//get hour
byte Rtc_Pcf8583P::getHour()
{
	getTime();
	return hour;
}
//get day
byte Rtc_Pcf8583P::getDay()
{
	getDate();
	return day;
}

//get month
byte Rtc_Pcf8583P::getMonth()
{
	getDate();
	return month;
}

//get year
byte Rtc_Pcf8583P::getYear()
{
	getDate();
	return year;
}
//get weekday
byte Rtc_Pcf8583P::getWeekday()
{
	getDate();
	return weekday;
}

//************Get alarm date & time
//get Alarm Sec
byte Rtc_Pcf8583P::getAlarmSecond()
{
	getAlarmTime();
	return alarm_sec;
}
//get Alarm minute
byte Rtc_Pcf8583P::getAlarmMinute()
{
	getAlarmTime();
	return alarm_minute;
}
//get Alarm hour
byte Rtc_Pcf8583P::getAlarmHour()
{
	getAlarmTime();
	return alarm_hour;
}

//get Alarm day
byte Rtc_Pcf8583P::getAlarmDay()
{
	getAlarmTime();
	return alarm_day;
}
//get Alarm month
byte Rtc_Pcf8583P::getAlarmMonth()
{
	getAlarmTime();
	return alarm_month;
}
