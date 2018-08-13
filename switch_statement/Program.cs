using System;

namespace switch_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            TestSwitch(10, 20, '+');
            TestSwitchFallThrough();
        }

        private static void TestSwitch(int op1, int op2, char opr)
        {
            int result;
            switch (opr)
            {
                case '+':
                    result = op1 + op2;
                    break;
                case '-':
                    result = op1 - op2;
                    break;
                case '*':
                    result = op1 * op2;
                    break;
                case '/':
                    result = op1 / op2;
                    break;
                default:
                    Console.WriteLine("Unknown operator");
                    result = 0;
                    break;
            }
            Console.WriteLine("Result: {0}", result);
        }

        private static void TestSwitchFallThrough()
        {
            DateTime dt = DateTime.Today;
            switch (dt.DayOfWeek)
            {
                case DayOfWeek.Monday:
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                case DayOfWeek.Friday:
                    Console.WriteLine("Today is a week day");
                    break;
                default:
                    Console.WriteLine("Today is a weekend day");
                    break;
            }
        }
    }
}
