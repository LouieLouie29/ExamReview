//Ed Louie
using System;

namespace TuitionIncreaseReview
{
    class Program
    {
        static void Main(string[] args)
        {
              double tuition = 12000;
              double tuitionInc = 0;
              double increase = 0.05;
              string msg;

              for (int years = 1; years <= 7; years++)
              {
                  if (years >= 1)
                  {
                      tuitionInc = tuition * increase;
                  }

                  tuition = tuitionInc + tuition;

                msg = ($"Your tuition after {years.ToString()} will be {tuition.ToString("C2")}.");
                Console.WriteLine(msg);
              }
              

           

            Console.ReadKey();
        }
    }
}
