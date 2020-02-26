//Ed Louie
using System;

namespace HW1Review
{
    class Program
    {
        static void Main(string[] args)
        {
            string item;
            int itemAmt;
            double itemPrice;
            const double tax = 0.085;
            double itemSub;
            double salesTax;
            double total;

            Console.WriteLine("What item are you purchasing?");
            item = Console.ReadLine();

            Console.WriteLine($"How many {item}'s do you want to buy?");
            itemAmt = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"What is the price for each {item}?");
            itemPrice = Convert.ToDouble(Console.ReadLine());

            itemSub = itemAmt * itemPrice;
            salesTax = tax * itemSub;
            total = salesTax + itemSub;

            Console.WriteLine($"Your subtotal for your bill is {itemSub.ToString("C2")}.");
            Console.WriteLine($"Your sales tax for your bill is {salesTax.ToString("C2")}.");
            Console.WriteLine($"Your total for your bill is {total.ToString("C2")}.");

            Console.ReadKey();
        }
    }
}
