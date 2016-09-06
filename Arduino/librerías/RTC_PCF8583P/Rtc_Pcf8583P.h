/*
 * Rtc_Pcf8583P.h
 *  NAME
 *    External Real Time Clock support routines
 *    AUTHOR: Joe Robertson, orbitalair@bellsouth.net
 * 	  Ported to PCF8583P by Daniel Martinez Cruz
 * 		fi.danielmartinez@gmail.com
 *
 * Modification date: 04.08.2016
 * 2016 Daniel <Daniel@DANIEL-PC>
 *
 */

#ifndef Rtc_Pcf8583P_H
#define Rtc_Pcf8583P_H

#include "Arduino.h"
#include "Wire.h"

#define RTC_VERSION  "Pcf8583P v1.0"

 /* these are adjusted for arduino */
#define RTC_R 	0xa3	//de datasheet
#define RTC_W 	0xa2


#define DIR_SEC 	1
#define DIR_MIN 	2
#define DIR_HR 		3
#define DIR_DAY 	4
#define DIR_WEEKDAY	5
#define DIR_MONTH 	6
#define DIR_YEAR 	7

/* register addresses in the rtc */
#define STATUS				0x00
#define DIR_1_100			0x01
#define DIR_SEC				0x02
#define DIR_MIN				0x03

#define DIR_HR				0x04
#define DIR_YEAR_DATE		0x05
#define DIR_MONTH_WEEKDAY	0x06
#define DIR_TIMER			0x07

#define DIR_ALARM			0x08
#define DIR_ALARM_1_100		0x09
#define DIR_ALRM_SEC		0x0A
#define DIR_ALRM_MIN		0x0B

#define DIR_ALRM_HR			0x0C
#define DIR_ALRM_DATE		0x0D
#define DIR_ALRM_MONTH		0x0E
#define DIR_ALRM_TIMER		0x0F

#define no_alarm			0x00
#define alarm_enable_bit	0x04
#define RTC_ALARM			0xB0
//#define RTC_ALARM_AIE 	0x04
#define RTC_ALARM_AF 		0x02
/* optional val for no alarm setting */
#define RTC_NO_ALARM		99

//#define RTC_CENTURY_MASK 	0x80

/* date format flags */
#define RTC_DATE_WORLD		0x01
#define RTC_DATE_ASIA		0x02
#define RTC_DATE_US			0x04
/* time format flags */
#define RTC_TIME_HMS		0x01
#define RTC_TIME_HM			0x02

/* square wave constants */
#define SQW_DISABLE     B00000000
#define SQW_32KHZ       B10000000
#define SQW_1024HZ      B10000001
#define SQW_32HZ        B10000010
#define SQW_1HZ         B10000011

/* arduino class */
class Rtc_Pcf8583P {
public:
	Rtc_Pcf8583P();

	//Config
	void initClock();		/* zero out all values, disable all alarms */
	void clearStatus();		/* set both status bytes to zero */

	//Date
	void getDate();			/* get date vals to local vars */
	void setDate(byte day, byte weekday, byte month, byte century, byte year);

	//Time
	void getTime();
	void setTime(byte sec, byte minute, byte hour);

	//Alarm
	void getAlarm();
	void getAlarmTime();
	void getAlarmDate();
	void setAlarmTime(byte alarm_month, byte alarm_day, byte alarm_hour, byte alarm_minute, byte alarm_sec);
	
	void enableAlarm(); /* activate alarm flag and interrupt */
	void clearAlarm();	/* clear alarm flag and interrupt */
	void resetAlarm();  /* clear alarm flag but leave interrupt unchanged */
	boolean alarmEnabled();
	boolean alarmActive();

	byte readStatus1();
	//byte readStatus2();

	//get time
	byte getSecond();
	byte getMinute();
	byte getHour();

	//get time alarm
	byte getAlarmSecond();
	byte getAlarmMinute();
	byte getAlarmHour();

	//get date
	byte getDay();
	byte getMonth();
	byte getYear();
	byte getWeekday();

	//get date alarm
	byte getAlarmDay();
	byte getAlarmMonth();
	byte getAlarmYear();
	byte getAlarmWeekday();

	//get status
	byte getStatus1();
	byte getReg05();
	//byte getStatus2();

	//Square wave (unused)
	void setSquareWave(byte frequency);
	void clearSquareWave();

	/*get a output string, these call getTime/getDate for latest vals */
	char *formatTime(byte style = RTC_TIME_HMS);
	/* date supports 3 styles as listed in the wikipedia page about world date/time. */
	char *formatDate(byte style = RTC_DATE_US);
	char *version();
private:
	/* methods */
	byte decToBcd(byte value);
	byte bcdToDec(byte value);
	int bcd_to_byte(byte bcd);
	byte int_to_bcd(int in);
	/* time variables */
	byte hour;
	byte minute;
	byte sec;
	byte msec;
	byte day;
	byte weekday;
	byte month;
	byte year;
	byte year_base;
	byte incoming;
	/* time variables BCD */
	byte hourBcd;
	byte minuteBcd;
	byte secBcd;
	byte msecBcd;
	byte dayBcd;
	byte weekdayBcd;
	byte monthBcd;
	byte yearBcd;

	/*registros*/
	byte reg05;
	byte reg06;
	byte reg07;
	byte reg08;

	/* alarm */
	byte alarm_hour;
	byte alarm_minute;
	byte alarm_sec;
	byte alarm_day;
	byte alarm_weekday;	//unused
	byte alarm_month;
	byte alarm_year;	//unused

	/* support */
	byte status1;
	//byte status2;
	byte century;
	char strOut[9];
	char strDate[11];
	int 	RTC_ADDR;
	
};

#endif
