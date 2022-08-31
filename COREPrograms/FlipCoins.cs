using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COREPrograms
{
    internal class FlipCoins
    {
        public static void CalculatePercentage()
        {
            int HeadCount = 0, TailCount = 0;
            double HeadPercentage;
            double TailPercentage;
            Console.WriteLine("Please enter value for number");
            int flipcoin = Convert.ToInt32(Console.ReadLine());

            if (flipcoin > 0)
            {
                for (int i = 0; i < flipcoin; i++)
                {
                    Random random = new Random();
                    int number = random.Next(2);//0,1
                    if (number ==1)
                    {
                        Console.WriteLine("Head");
                        HeadCount++;
                    }
                    else
                    {
                        Console.WriteLine("Tail");
                        TailCount++;    
                    }
                }
                HeadPercentage = HeadCount*100/ flipcoin;
                TailPercentage = TailCount*100/ flipcoin;
                Console.WriteLine("Head percentage: " + HeadPercentage+" "+"Tail percentage:" +TailPercentage);
            }
            else
            {
                Console.WriteLine("Enter positive number");
            }
        }
    }
}
