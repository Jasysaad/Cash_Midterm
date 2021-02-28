using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Cash_Midterm
{
    class Program
    {
        static void Cash(decimal cartTotal)
        {
            decimal tendered = 0;
            do
            {

                Console.WriteLine("Your total is $" + cartTotal + ". How much cash is tendered?");
                decimal.TryParse(Console.ReadLine(), out tendered);
                if (tendered < cartTotal)
                {
                    Console.WriteLine("Inadequate funds, try again.");
                }

            }
            while (tendered < cartTotal);


            decimal change = tendered - cartTotal;
            Console.WriteLine("Your change back is: $" + change);
            Console.ForegroundColor = ConsoleColor.White;
        }
        static void Main(string[] args)
        {
            Cash((decimal)23.4);
        }
    }
}
