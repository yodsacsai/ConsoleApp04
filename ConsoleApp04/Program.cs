using System;

namespace ConsoleApp04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 10, 20, 30 };
            try
            {
                Console.WriteLine(x[99]);
            }
            catch
            {
                Console.WriteLine("please contact admin");
            }
            finally
            {
                Console.WriteLine("wow wow wow");
            }
        }
    }
}
