using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Analogue_Clock
{
    static class Utility
    {
        public static int[] getTime(string time)
        {
            try
            {
                int hours = Convert.ToInt32(Regex.Split(time, @"[:]")[0]);
                int minutes = Convert.ToInt32(Regex.Split(time, @"[:]")[1]);
                return new int[] { hours, minutes };
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid format");
                return null;
            }
        }
    }
}
