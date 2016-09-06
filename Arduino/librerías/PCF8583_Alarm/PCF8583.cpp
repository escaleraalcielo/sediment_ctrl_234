/*
  Implements a simple interface to the time function of the PCF8583 RTC chip

  Works around the device's limited year storage by keeping the year in the
  first two bytes of user accessible storage

  Assumes device is attached in the standard location - Analog pins 4 and 5
  Device address is the 8 bit address (as in the device datasheet - normally A0)

  Copyright (c) 2009, Erik DeBill


  This library is free software; you can redistribute it and/or
  modify it under the terms of the GNU Lesser General Public
  License as published by the Free Software Foundation; either
  version 2.1 of the License, or (at your option) any later version.

  This library is distributed in the hope that it will be useful,
  but WITHOUT ANY WARRANTY; without even the implied warranty of
  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
  Lesser General Public License for more details.

  You should have received a copy of the GNU Lesser General Public
  License along with this library; if not, write to the Free Software
  Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA  02110-1301  USA
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
#include "PCF8583.h"

// provide device address as a full 8 bit address (like the datasheet)
PCF8583::PCF8583(int device_address) {
  address = device_address >> 1;  // convert to 7 bit so Wire doesn't choke
  Wire.begin();
}

// initialization 

void PCF8583::init()
{

Wire.beginTransmission(address);
Wire.write(0x00);
Wire.write(0x04);   // Set alarm on int\ will turn to vcc
Wire.endTransmission();

}



void PCF8583::get_time(){


  Wire.beginTransmission(address);
  Wire.write(0x02);
  Wire.endTransmission();
  Wire.requestFrom(address, 5);

  second = bcd_to_byte(Wire.read());
  minute = bcd_to_byte(Wire.read());
  hour   = bcd_to_byte(Wire.read());
  byte incoming = Wire.read(); // year/date counter
  day    = bcd_to_byte(incoming & 0x3f);
  year   = (int)((incoming >> 6) & 0x03);      // it will only hold 4 years...
  month  = bcd_to_byte(Wire.read() & 0x1f);  // 0 out the weekdays part

  //  but that's not all - we need to find out what the base year is
  //  so we can add the 2 bits we got above and find the real year
  Wire.beginTransmission(address);
  Wire.write(0x10);
  Wire.endTransmission();
  Wire.requestFrom(address, 2);
  year_base = 0;
  year_base = Wire.read();
  year_base = year_base << 8;
  year_base = year_base | Wire.read();
  year = year + year_base;
}


void PCF8583::set_time()
 {

  Wire.beginTransmission(address);
  Wire.write(0xC0);   // stop counting, don't mask
  Wire.endTransmission();

  Wire.beginTransmission(address);
  Wire.write(0x02);
  Wire.write(int_to_bcd(second));	//0x02
  Wire.write(int_to_bcd(minute));	//0x03				
  Wire.write(int_to_bcd(hour));		//0x04
  Wire.write(((byte)(year % 4) << 6) | int_to_bcd(day));//0x05
  Wire.write(int_to_bcd(month));	//0x06
  Wire.endTransmission();

  Wire.beginTransmission(address);
  Wire.write(0x10);
  year_base = year - year % 4;
  Wire.write(year_base >> 8);
  Wire.write(year_base & 0x00ff);
  Wire.endTransmission();
  
  init(); // re set the control/status register to 0x04

  }

//Get the alarm at 0x09 adress

void PCF8583::get_alarm()
{

Wire.beginTransmission(address);
Wire.write(0x0A); // Set the register pointer to (0x0A) 
Wire.endTransmission();

Wire.requestFrom(address, 4); // Read 4 values 

second_A = bcd_to_byte(Wire.read());
minute_A = bcd_to_byte(Wire.read());
hour_A   = bcd_to_byte(Wire.read());

Wire.beginTransmission(address);
Wire.write(0x0E); 
Wire.endTransmission();

Wire.requestFrom(address, 1); // Read weekday value 

day_A= bcd_to_byte(Wire.read());

}


//Set a daily alarm

void PCF8583::set_daily_alarm()
{

Wire.beginTransmission(address);
Wire.write(0x08); 
Wire.write(0x90);  // daily alarm set 
Wire.endTransmission();

Wire.beginTransmission(address);
Wire.write(0x09); // Set the register pointer to (0x09)
Wire.write(0x00); // Set 00 at milisec 
Wire.write(int_to_bcd(second_A));
Wire.write(int_to_bcd(minute_A));
Wire.write(int_to_bcd(hour_A));
Wire.write(0x00); // Set 00 at day 
Wire.endTransmission();

}



int PCF8583::bcd_to_byte(byte bcd){
  return ((bcd >> 4) * 10) + (bcd & 0x0f);
}

byte PCF8583::int_to_bcd(int in){
  return ((in / 10) << 4) + (in % 10);
}

