//Ed Louie
using System;

namespace FizzBuzzReview
{
    class Program
    {
        static void Main(string[] args)
        {
            string luckyNum;
            Int32 numVal;

            Console.WriteLine("Please input your lucky number.");
            luckyNum = Console.ReadLine();

            if (Int32.TryParse(luckyNum, out numVal))
            {
                if (numVal % 3 == 0 && numVal % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (numVal % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (numVal % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine($"{ numVal}");
                }
            }
            else
            {
                Console.WriteLine($"Sorry, we are unable to run the program because {luckyNum} is not a valid number.");
            }

            
            Console.ReadKey();
        }
    }
}
