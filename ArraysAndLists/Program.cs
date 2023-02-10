using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10

            int[] Array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */

            var evens = new List<int>();
            var odds = new List<int>();

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */

            foreach (var even in evens)
            {
                Console.WriteLine($"{even} even number");
            }
            foreach (var odd in odds) 
            { 
            Console.WriteLine($"{odd} odd number");
            }



            /* Now using foreach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */

            foreach (int i in Array)
            {
                if (i % 2 == 0)
                {
                    evens.Add(i);
                    Console.WriteLine($"{i} is even");
                }
                else
                {
                       odds.Add(i);
                    Console.WriteLine($"{i} is odd");
                }
            }
            foreach (var even in evens)
            {
                Console.WriteLine($"{even} even number");
            }
            foreach (var odd in odds)
            {
                Console.WriteLine($"{odd} odd number");
            }

        }
    }
}
