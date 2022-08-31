namespace COREPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to BASIC CORE PROGRAMS!");
            Console.WriteLine("Choose option\n  1. Flip coin\t  2. Leap year\t 3. Poweroftwo\t  4. Swap two Number\t  5. EverorOdd\t 6.VowelorConsonant\t 7. Largest almost three number\t 8.Quotient and Remainder");
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
                case 4:
                    SwapTwoNumber.SwappingNumber();
                    break;
                case 5:
                    EvenOrOdd.CheckEvenOdd();
                    break;
                case 6:
                    VowelorConsonant.FindVowelCon();
                    break;
                case 7:
                    LargestNumber.LargestNo();
                    break;
                case 8:
                    QuotientRemainder.QuotRemain();
                    break;
                default:        
                    Console.WriteLine("Wrong Choice ");
                    break;

            }
        }
    }
}