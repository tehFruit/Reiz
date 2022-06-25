using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analogue_Clock
{
    internal class AnalogueClock
    {
        private const int radius = 1;
        private const double circumference = 6.28;
        private const double lengthPerMinute = circumference / 60;
        private int _hours = 0;
        private int _minutes = 0;

        public AnalogueClock()
        {
        
        }

        public bool setHours(int hours)
        {
            if(hours >= 1 && hours <= 12)
            {
                this._hours = hours;
                return true;
            }
            return false;
        }

        public bool setMinutes(int minutes)
        {
            if(minutes >= 0 && minutes <= 59)
            {
                this._minutes = minutes;
                return true;
            }

            return false;
        }

        public double calculateAngle()
        {
            double partOfHour = (double)1 / 60 * (double)this._minutes;
            int additionalMinutes = (int)Math.Round(partOfHour * 5);
            double hourHandInMinutes = ((double)this._hours / 12 * 60) + additionalMinutes;
            
            int minuteDifference = (int)Math.Abs(hourHandInMinutes - _minutes);

            if(minuteDifference > 30)
            {
                minuteDifference = 60 - minuteDifference;
            }

            double arc = minuteDifference * lengthPerMinute;
            double angle = arc * 360 / circumference;
            return angle;
        }
    }
}
