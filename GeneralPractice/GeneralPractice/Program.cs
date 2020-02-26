//Ed Louie
using System;

namespace GeneralPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Favorite Number practice
            /*

             Console.WriteLine("Please input your favorite number.");
             string favNumAsString = Console.ReadLine();
             int favNum = Convert.ToInt32(favNumAsString);

             Console.WriteLine(favNum); //Testing Purposes

             if (favNum == 7)
             {
                 Console.WriteLine("Wow, how original are you?");
             }
             else if (favNum == 13)
             {
                 Console.WriteLine("Yikes, that's an unlucky number!");
             }
             else
             {
                 int newNum = favNum * 10;
                 Console.WriteLine($"Your favorite number times 10 is {newNum}.");
             }
             //Console.ReadKey();

             */
            /*
           //Word Replace
           string message = "This is the best message in the world.";
           Console.WriteLine(message);


           Console.WriteLine("What word would you like to lookup?");
           string lookWord = Console.ReadLine();

           Console.WriteLine("What would you like to replace that word with?");
           string replaceWord = Console.ReadLine();

           bool isValidWord = message.Contains(lookWord);


           if (isValidWord == true)
           {
               string alteredMsg = message.Replace(lookWord, replaceWord);
               Console.WriteLine(alteredMsg);
           }            
           else
           {
               Console.WriteLine($"Sorry, the word {lookWord} is not in this sentence.");
           }           

           Console.ReadKey();
           */
            //DaysInTheMonth
            //Jan, March, May, July, Aug, Oct, Dec - 31
            //April, June, Sept, Nov - 30
            //February - 28, 29
            /*

            Console.WriteLine("Please input a month.");
            string input = Console.ReadLine();
            string month = input.ToUpper();

            if (month == "JANUARY")
            {
                Console.WriteLine("There are 31 days in January.");
            }
            else if (month == "FEBRUARY")
            {                
                Console.WriteLine("Is this a leap year?");
                string leap = Console.ReadLine();
                string response = leap.ToUpper();
                if (response == "YES")
                {
                    Console.WriteLine("There are 29 days in February.");
                }
                else
                {
                    Console.WriteLine("There are 28 days in February.");
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
            */
            //How much will I save after X years?
            double saving = 0;
            double percent = 0;
            int years = 1;
            int month;
            double totalSaved = 0;

            Console.WriteLine("How much money do you want to save a week?");
            saving = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is the interest percent? e.g. 5% as 5.");
            percent = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("How many years do you planning on saving?");
            years = Convert.ToInt32(Console.ReadLine());

            for (month = 0; month <= years * 12; month++) //12 months in a year
            {
                totalSaved += saving * 4; //4 weeks in a month
                totalSaved += totalSaved * percent;
            }


            Console.WriteLine(totalSaved);

            Console.ReadKey();
            

        }
    }
}
