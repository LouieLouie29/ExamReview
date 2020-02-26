//Ed Louie
using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string word;
            string upperWord;
            string reverseWord = "";
            int wordLength;

            Console.WriteLine("Input a word or phrase.");
            word = Console.ReadLine();
            upperWord = word.ToUpper();
            wordLength = upperWord.Length - 1;

            while (wordLength >= 0)
            {
                reverseWord += upperWord[wordLength];

                wordLength--;
            }

            //Console.WriteLine(reverseWord); //Testing Purposes

            if (reverseWord == upperWord)
            {
                Console.WriteLine($"{upperWord} is a palindrome.");
            }
            else
            {
                Console.WriteLine($"{upperWord} is not a palindrome.");
            }

            Console.ReadKey();
        }
    }
}
