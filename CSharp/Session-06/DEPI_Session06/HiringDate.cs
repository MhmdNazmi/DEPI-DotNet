using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPI_Session06
{
    internal class HiringDate
    {
        int _day;
        int _month;
        int _year;
        int currentYear = DateTime.Now.Year;

        public int Day
        {  
            get { return _day; }
            set 
            {
                if (value < 1 || value > 31 )
                    throw new ArgumentOutOfRangeException(nameof(value), "Day must be between 1 & 31");
                _day = value;
            } 
        }

        public int Month 
        {
            get { return _month; }
            set 
            {
                if (value < 1 || value > 12)
                    throw new ArgumentOutOfRangeException(nameof(value), "Month must be bewteen 1 & 12");
                _month = value;
            }
        }

        public int Year 
        {
            get { return _year; }
            set 
            {
                
                if (value < 1920 || (value - 20) > currentYear)
                    throw new ArgumentOutOfRangeException(nameof(value), "Invalid year");
                _year = value;
            } 
        }

        public HiringDate()
        {
            Day = 1;
            Month = 1;
            Year = currentYear;
        }

        public HiringDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public override string ToString()
        {
            return $"{Day}/{Month}/{Year}";
        }
    }
}
