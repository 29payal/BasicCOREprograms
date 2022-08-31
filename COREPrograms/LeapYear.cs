using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COREPrograms
{
    internal class LeapYear
    {
        public static void CheckLeapYear()
        {
            int year;
            Console.WriteLine("Enter the year ");
            year = Convert.ToInt32(Console.ReadLine());

            if ((year % 4 == 0 && year % 100 != 0 || year % 400 == 0))
            {
                Console.WriteLine(year + "is a leap yaer");
            }
            else
            {
                Console.WriteLine(year + " is not a leap year");
            }
        }
    }
}
   