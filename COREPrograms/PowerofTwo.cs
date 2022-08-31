using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COREPrograms
{
    internal class PowerofTwo
    {
        public static void TableofTwo()
        {
            int j, n;
            Console.WriteLine("Input the number");
            n= Convert.ToInt32(Console.ReadLine());
            for (j = 1; j <= 10; j++) 
            {
                Console.WriteLine( "{0} * {1} = {2}", n,j,n*j);
            }
        }
    }
}
