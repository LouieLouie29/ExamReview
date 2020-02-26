//Ed Louie
using System;

namespace Accumulators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add all numbers from 1 - 100 and multiply all numbers from 1 - 100

            int counter;
            double multiplication = 1;
            int sum = 0;

            for (counter = 1; counter <= 100; counter++)
            {
                sum += counter;
                multiplication *= counter;
            }

            Console.WriteLine($"Summation value from 1 - 100 is {sum.ToString("N0")}");
            Console.WriteLine($"Multiplication value from 1 - 100 is {multiplication.ToString("N0")}");

            Console.ReadKey();

        }
    }
}
