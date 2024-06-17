using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Home Sales!");
        Dictionary<char, decimal> salesTotals = new Dictionary<char, decimal>();
       
        decimal grandTotal = 0;

        while (true)
        {
            Console.Write("Enter salesperson initial (D, E, F) or Z to finish: ");
            string input = Console.ReadLine().ToUpper();

            if (input == "Z")
            {
                break; 
            }

               if (!char.IsLetter(input[0]) ||  !("DEF".IndexOf(input[0]) >= 0))
            {
                Console.WriteLine("Invalid initial Please enter D, E, or F.");
                continue;
            }

            if (!salesTotals.ContainsKey(input[0]))
            {
                salesTotals[input[0]] = 0m;
            }

            Console.Write($"Enter sale amount for {input}: ");
            decimal saleAmount = Convert.ToDecimal(Console.ReadLine());

            salesTotals[input[0]] += saleAmount;
            grandTotal += saleAmount;

            Console.WriteLine($"Sale added for {input} totaling {salesTotals[input[0]]}");
        }

        Console.WriteLine("\nSales Totals:");
        foreach (var entry in salesTotals)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }
        Console.WriteLine($"Grand Total: {grandTotal}");

      
        char highestTotalSalesperson = ' ';
        decimal highestTotal = 0;
        foreach (var entry in salesTotals)
        {
            if (entry.Value > highestTotal)
            {
                highestTotal = entry.Value;
                highestTotalSalesperson = entry.Key;
            }
        }

        Console.WriteLine($"\nThe salesperson with the highest total is {highestTotalSalesperson} with a total of {highestTotal}.");
    }
}
