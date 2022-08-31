using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COREPrograms
{
    internal class LargestNumber
    {
        public static void LargestNo()
        {
            int num1, num2, num3;
            Console.WriteLine("Enter the first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number: ");
            num3 = Convert.ToInt32(Console.ReadLine());
            
            
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine( num1+ " is a largest number ");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine( num2+ " is a largest number ");
            }
            else
            {
                Console.WriteLine( num3+  " is a largest number ");
            }
        }
    }
}
