/*
  Implements a simple interface to the time function of the PCF8583 RTC chip

  Works around the device's limited year storage by keeping the year in the
  first two bytes of user accessible storage

  Assumes device is attached in the standard location - Analog pins 4 and 5
  Device address is the 8 bit address (as in the device datasheet - normally A0)

  Copyright (c) 2009, Erik DeBill

*/


/*

   Usage:
      PCF8583 pcf(0xA2);
      pcf.get_time();

      Serial.print("year: ");
      Serial.println(pcf.year);


      pcf.hour = 14;
      pcf.minute = 30
      pcf.second = 0
      pcf.year = 2009
      pcf.month = 9
      pcf.day = 12
      pcf.set_time();


*/

#ifndef PCF8583_H
#define PCF8583_H

#include <Arduino.h>
#include <Wire.h>

class PCF8583 {
    int address;
  public:
 
    int milisec_A;
    int second_A;
    int minute_A;
    int hour_A;
    int day_A;
    int second;
    int minute;
    int hour;
    int day;
    int month;
    int year;
    int year_base;
    int timmer;

    PCF8583(int device_address);
    void init ();
    
    void get_time();
    void set_time();
    void get_alarm();
    void set_daily_alarm();
    int bcd_to_byte(byte bcd);
    byte int_to_bcd(int in);
};


#endif  //PCF8583_H
