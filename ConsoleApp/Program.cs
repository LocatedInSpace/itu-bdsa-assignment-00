// See https://aka.ms/new-console-template for more information

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Year to check (if leap): ");
            string input = Console.ReadLine();
            Console.WriteLine(YayOrNay(input));
        }

        public static string YayOrNay(string input)
        {
            int yearToCheck;
            bool isNumeric = int.TryParse(input, out yearToCheck);
            if (IsLeapYear(yearToCheck))
            {
                return "yay";
            }
            else
            {
                return "nay";
            }
        }
        
        public static bool IsLeapYear(int year)
        {
            if (year % 4 == 0)
            {
                if (year % 100 == 0 && year % 400 != 0)
                {
                    return false;
                }
                return true;
            }

            return false;
        }
    }
}