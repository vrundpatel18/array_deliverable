// Vrund Patel
// 2/5
// array deliverable assignment

using System;


namespace array_deliverable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci Series:");

            int a = 0, b = 1, c = 0;
            Console.WriteLine("{0}\n{1}", a, b);

            for (int i = 2; i < 25; i++)
            {
                c = a + b;
                Console.WriteLine("{0}", c);
                a = b;
                b = c;

            }

                       

        }
    }
}