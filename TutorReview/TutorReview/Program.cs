//Ed Louie
using System;

namespace TutorReview
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randNum1 = new Random();
            Random randNum2 = new Random();
            int randomNumber1;
            int randomNumber2;
            randomNumber1 = randNum1.Next(0,50);
            randomNumber2 = randNum2.Next(0, 50);
            int correctAnswer;
            correctAnswer = randomNumber1 + randomNumber2;
            int answer;

            Console.WriteLine($"{randomNumber1} + {randomNumber2} = ?");
            answer = Convert.ToInt32(Console.ReadLine());

            do
            {            
            if (answer != correctAnswer)
            {
                    Console.WriteLine($"Sorry, your answer of {answer} was not correct. PLease try again.");
                    answer = Convert.ToInt32(Console.ReadLine());
                }
            } while (answer != correctAnswer);           

            Console.WriteLine($"Congrats, your answer of {answer} was correct!");

            Console.ReadKey();
        }
    }
}
