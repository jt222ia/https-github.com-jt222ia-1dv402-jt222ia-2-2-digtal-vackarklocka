using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2_digital_vackarklocka
{
    class AlarmClock
    {
        private int _hour;
        private int _minute;
        private int _alarmHour;
        private int _alarmMinute;

        public AlarmClock()
        {
            throw new System.NotImplementedException();
        }

        public AlarmClock(int hour, int minute)
        {
            

            
        }
        public AlarmClock(int hour, string minute, int alarmHour, int alarmMinute)
        {
            throw new System.NotImplementedException();
        }
        public int AlarmHour 
        {
            get { return _alarmHour; }
            set
            {
                if (value < 0 || value > 23)
                {
                    throw new ArgumentException("Talet är inte i intervallet 0-23");
                }
                _alarmHour = value;
            } 
        }

        public int AlarmMinute
        {
            get { return _alarmMinute; }
            set
            {
                if (value < 0 || value > 59)
                {
                    throw new ArgumentException("Talet är inte i intervallet 0-59");
                }
                _alarmMinute = value;
            }
        }

        public int Hour
        {
            get { return _hour; }
            set
            {
                if (value < 0 || value > 23)
                {
                    throw new ArgumentException("Talet är inte i intervallet 0-23");
                }
                _hour = value;
            }
        }

        public int Minute
        {
            get { return _minute; }
            set
            {
                if (value < 0 || value > 59)
                {
                    throw new ArgumentException("Talet är inte i intervallet 0-59");
                }
                _minute = value;
            }
        }

        public bool TickTock()
        {
            throw new System.NotImplementedException();
        }

        public string ToString()
        {
            throw new System.NotImplementedException();
        }
    }
}
