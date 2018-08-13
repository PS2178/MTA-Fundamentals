using System;

namespace RecursiveFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int factorial = Factorial(5);
            Console.WriteLine(factorial);
        }

        private static int Factorial(int n)
        {
            if (n == 0)
            {
                return 1; // base case
            }
            else
            {
                return n * Factorial(n - 1); // recursive case
            }
        }
    }
}
