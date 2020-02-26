//Ed Louie
using System;

namespace SavingsAfterXYears
{
    class Program
    {
        static void Main(string[] args)
        {
            double savings = 0;
            double interest = 0.0;
            int years = 0;
            double totalSaved = 0;
            int numYears = 1;
            int numMonths = 1;

            Console.WriteLine("How much money do you want to save each week?");
            savings = Convert.ToDouble(Console.ReadLine());            

            Console.WriteLine(savings); //Testing Purposes

            Console.WriteLine("What is your current interest rate? (Put whole percent e.g. 5% as 5)");
            interest = Convert.ToDouble(Console.ReadLine()) / 100;            
            
            Console.WriteLine(interest); //Testing Purposes

            Console.WriteLine("How many years would you like to save?");
            years = Convert.ToInt32(Console.ReadLine());            

            Console.WriteLine(years); //Testing Purposes

            for (int month = 1; month <= years * 12; month++) //12 months in every year
            {
                totalSaved += savings * 4; //4 weeks in every month
                totalSaved += totalSaved * interest;

                string monthName = month.ToString("N0");

                if (numMonths == 1)
                {
                    monthName = "January";
                }
                else if (numMonths == 2)
                {
                    monthName = "February";
                }
                else if (numMonths == 3)
                {
                    monthName = "March";
                }
                else if (numMonths == 4)
                {
                    monthName = "April";
                }
                else if (numMonths == 5)
                {
                    monthName = "May";
                }
                else if (numMonths == 6)
                {
                    monthName = "June";
                }
                else if (numMonths == 7)
                {
                    monthName = "July";
                }
                else if (numMonths == 8)
                {
                    monthName = "August";
                }
                else if (numMonths == 9)
                {
                    monthName = "September";
                }
                else if (numMonths == 10)
                {
                    monthName = "October";
                }
                else if (numMonths == 11)
                {
                    monthName = "November";
                }
                else //Represents December
                {
                    monthName = "December";
                }

                Console.WriteLine($"{monthName} @ year {numYears.ToString("N0")} : {totalSaved.ToString("C2")}");

                numMonths++;

                if (month % 12 == 0)
                {
                    numYears++;
                    numMonths = 1;
                }
            }
            totalSaved = totalSaved + interest;

            Console.WriteLine($"You will have saved {totalSaved.ToString("C2")} after {years} year(s).");
            
            Console.ReadKey();
        }
    }
}
