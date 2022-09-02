// See https://aka.ms/new-console-template for more information

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public bool IsLeapYear(int year)
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