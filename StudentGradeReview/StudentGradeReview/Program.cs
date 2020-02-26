//Ed Louie
using System;

namespace StudentGradeReview
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            int studId;

            double hwPer = 0.25;
            double midPer = 0.25;
            double partPer = 0.1;
            double finalPer = 0.3;
            double quizPer = 0.1;

            double hw;
            double mid;
            double part;
            double final;
            double quiz;

            double hwGrade;
            double midGrade;
            double partGrade;
            double finalGrade;
            double quizGrade;
            double overallGrade;

            Console.WriteLine("What is your first name?");
            firstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            lastName = Console.ReadLine();

            Console.WriteLine("What is your student ID?");
            studId = Convert.ToInt32(Console.ReadLine());            

            Console.WriteLine("What is your overall percentage grade for homeworks?");
            hw = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for participations?");
            part = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for quizzes?");
            quiz = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for the midterm?");
            mid = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for the final?");
            final = Convert.ToDouble(Console.ReadLine());

            hwGrade = hw * hwPer;
            partGrade = part * partPer;
            quizGrade = quiz * quizPer;
            midGrade = mid * midPer;
            finalGrade = final * finalPer;
            overallGrade = hwGrade + partGrade + quizGrade + midGrade + finalGrade;
                                 
            Console.WriteLine($"{firstName} {lastName} ({studId}), your final grade is {overallGrade}.");

            Console.ReadKey();
        }
    }
}
