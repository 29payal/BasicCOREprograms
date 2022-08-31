using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COREPrograms
{
    internal class HarmonicNo
    {
        public static void HarmonicNum()
        {
            int n, i;
            double result = 0.0;
            Console.WriteLine("Enter the vaule for harmonic ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                result+=1/(float)i;
                Console.WriteLine("1/{0} +", i);
            }
            Console.WriteLine($"={result}");
        }
    }
}
