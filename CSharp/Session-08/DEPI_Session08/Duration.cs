using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPI_Session08
{
    internal class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public Duration(int totalSeconds)
        {
            Hours = totalSeconds / 3600;
            totalSeconds %= 3600;
            Minutes = totalSeconds / 60;
            Seconds = totalSeconds % 60;
        }

        public Duration() : this(0, 0, 0) { }

        public override string ToString()
        {
            if (Hours > 0)
                return $"Hours: {Hours}, Minutes :{Minutes}, Seconds :{Seconds}";
            if (Minutes > 0)
                return $"Minutes :{Minutes}, Seconds :{Seconds}";
            return $"Seconds :{Seconds}";
        }

        public override bool Equals(object? obj)
        {
            if (obj is Duration d)
                return Hours == d.Hours && Minutes == d.Minutes && Seconds == d.Seconds;
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Hours, Minutes, Seconds);
        }
    }
}
