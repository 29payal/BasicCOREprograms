namespace COREPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to BASIC CORE PROGRAMS!");
            Console.WriteLine("Choose option\n  1. Flip coin\t  2. Leap year\t 3. Poweroftwo");
            int option = Convert.ToInt32(Console.ReadLine());  
            switch (option)
            {
                case 1:
                    FlipCoins.CalculatePercentage();
                    break;
                    case 2: 
                        LeapYear.CheckLeapYear();
                    break;
                case 3:
                    PowerofTwo.TableofTwo();
                    break;
                default:        
                    Console.WriteLine("Wrong Choice ");
                    break;

            }
        }
    }
}