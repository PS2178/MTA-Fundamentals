﻿using System;

namespace for_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            ForTest();
        }

        private static void ForTest()
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine($"The value of i = {i}");
            }
        }
    }
}
