using System;
using System.Collections.Generic;

namespace coffeeshopmanager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the discount amount: ");
            int discount = Convert.ToInt32(Console.ReadLine());
            Dictionary<string, int> coffee = new Dictionary<string, int>();
            coffee.Add("Americano", 50);
            coffee.Add("Latte", 70);
            coffee.Add("Flat White", 60);
            coffee.Add("Espresso", 60);
            coffee.Add("Cappuccino", 80);
            coffee.Add("Mocha", 90);
            Console.WriteLine("standard prices:");
            foreach (var pair in coffee)
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            Console.WriteLine();
            Console.WriteLine("discounted prices:");
            foreach (var pair in coffee) Console.
            WriteLine($"{pair.Key}: {Math.Round(pair.Value - (double)pair.Value / 100 * discount, 2)}");
            Console.ReadKey();

        }
    }
}