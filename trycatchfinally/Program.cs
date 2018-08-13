using System;
using System.IO;

namespace trycatchfinally
{
    class Program
    {
        static void Main(string[] args)
        {
            TryCatchFinallyTest();
            WhileTest();
            Console.WriteLine(sizeof(byte));
            Console.WriteLine(byte.MaxValue);
        }

        private static void WhileTest()
        {
            int i = 1;
            while (i < 5)
            {
                Console.WriteLine("The value of i = {0}", i);
                i++;
            }
        }

        private static void TryCatchFinallyTest()
        {
            StreamReader sr = null;
            try
            {
                sr = File.OpenText(@"C:\data.txt");
                Console.WriteLine(sr.ReadToEnd());
            }
            catch (FileNotFoundException fnfe)
            {
                Console.WriteLine(fnfe.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (sr !=null)
                {
                    sr.Close();
                }
            }
        }
    }
}
