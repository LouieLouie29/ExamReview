//Ed Louie
using System;

namespace DaysInMonthReview
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the name of a month.");
            string userInput = Console.ReadLine();

            string month = userInput.ToUpper();

            if (month == "JANUARY")
            {
                Console.WriteLine("There are 31 days in January.");
            }
            else if (month == "FEBRUARY")
            {
                Console.WriteLine("Is this a leap year?");
                string leap = Console.ReadLine();
                string newLeap = leap.ToUpper()[0].ToString();

                if (newLeap == "YES")
                {
                    Console.WriteLine("There are 28 days in February.");
                }
                else
                {
                    Console.WriteLine("There are 29 days in February.");
                }
            }
            else if (month == "MARCH")
            {
                Console.WriteLine("There are 31 days in March.");
            }
            else if (month == "APRIL")
            {
                Console.WriteLine("There are 30 days in April.");
            }
            else if (month == "MAY")
            {
                Console.WriteLine("There are 31 days in May.");
            }
            else if (month == "JUNE")
            {
                Console.WriteLine("There are 30 days in June.");
            }
            else if (month == "JULY")
            {
                Console.WriteLine("There are 31 days in July.");
            }
            else if (month == "AUGUST")
            {
                Console.WriteLine("There are 31 days in August.");
            }
            else if (month == "SEPTEMBER")
            {
                Console.WriteLine("There are 30 days in September.");
            }
            else if (month == "OCTOBER")
            {
                Console.WriteLine("There are 31 days in October.");
            }
            else if (month == "NOVEMBER")
            {
                Console.WriteLine("There are 30 days in November.");
            }
            else
            {
                Console.WriteLine("There are 31 days in December.");
            }
            Console.ReadKey();
        }
    }
}
