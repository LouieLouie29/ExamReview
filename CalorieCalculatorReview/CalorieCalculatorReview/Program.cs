//Ed Louie
using System;

namespace CalorieCalculatorReview
{
    class Program
    {
        static void Main(string[] args)
        {
            double calorieGoal;
            double caloriesBurned = 0;
            double min = 0;

            Console.WriteLine("How many calories do you want to burn?");
            calorieGoal = Convert.ToDouble(Console.ReadLine());

            while (caloriesBurned <= calorieGoal)
            {
                min += 1;
                caloriesBurned += 3.9;

                Console.WriteLine($"After {min} minute(s), you have burned {caloriesBurned.ToString("N2")}.");
            }

            Console.ReadKey();
        }
    }
}
