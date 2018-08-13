using System;
using static System.Console;

namespace Exercise1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Factorial();
            Write("Please enter a quantity of items: ");
            string input = ReadLine();
            try
            {
                WriteLine($"You're discount is {CalculateDiscount(Convert.ToInt32(input))}%");

            }
            catch (Exception)
            {
                Console.WriteLine("You did not input a valid number");
            }
        }

        private static void Factorial()
        {
            WriteLine("Please enter a number to find the factorial: ");
            string input = ReadLine();

            if (input != null)
            {
                if (int.TryParse(input, out int n))
                {
                    WriteLine($"You entered {n}");
                }
            }
            else
            {
                WriteLine("Please enter a valid number!");
                Factorial();
            }
            
        }



        private static int CalculateDiscount(int n)
        {
            if (n < 10)
            {
                return 5;
            }
            else if (n < 50)
            {
                return 10;
            }
            else if (n < 100)
            {
                return 15;
            }
            else
            {
                return 20;
            }
        }
    }
}
