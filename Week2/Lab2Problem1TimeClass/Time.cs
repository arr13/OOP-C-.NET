using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2Problem1TimeClass
{
    public class Time
    {
        private byte hour; //hour of time
        private byte minute; //minute of time
        private int second; //second of time

        public Time()
        {
            hour = 0;
            minute = 0;
            second = 0;
        }

        public Time(byte hour, byte minute, byte second) //constructor with parametres
        {
            Hour = hour; //initialize hour with value
            Minute = minute; //initialize minute with value
            Second = second; //initialize second with value
        }

        public byte Hour
        {
            get
            {
                return hour;
            }
            set
            {
                if (value >= 0 && value <= 24) // validation of hour
                {
                    this.hour = value;
                }
            }
        }

        public byte Minute
        {
            get 
            {
                return minute;
            }
            set
            {
                if (value >= 0 && value <= 60) //validation of minute
                {
                    this.minute = value;
                }
            }
        }

        public int Second
        {
            get
            {
                return second;
            }
            set
            {
                if (value >= 0 && value <= 60)//validation of second
                {
                    this.second = value;
                }
            }
        }

        public void ShowTome()
        {
            Console.WriteLine(Hour + ":" + Minute + ":" + Second);
        }
    }
}
