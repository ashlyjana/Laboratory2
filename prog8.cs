using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // create a list to store transaction amounts
        List<decimal> transactions = new List<decimal>();

        Console.WriteLine("Enter transaction amounts: ");

        //will ask user until 5 transactions are entered
        while (transactions.Count < 5)
        {
            Console.Write($"Transaction {transactions.Count + 1}: ");
            string input = Console.ReadLine();

            // convert innput to decimal
            if (decimal.TryParse(input, out decimal amount))
            {
                // if connversion is successful this will add it to the list    
                transactions.Add(amount);
            }
            else
            {
                // if input is invalid it prints a message saying an error occurred
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        // list to store transactions greater than 10,000
        List<decimal> aboveTenThousand = new List<decimal>();

        // variable to store total of transactions above 10,000
        decimal total = 0;

        // filters transactions greater than 10,000
        foreach (decimal amount in transactions)
        {
            if (amount > 10000)
            {
                //add to filtered list
                aboveTenThousand.Add(amount);

                // add to total
                total += amount;
            }
        }

        // display the filtered transactions
        Console.WriteLine("\nTransactions above 10,000:");
        foreach (decimal t in aboveTenThousand)
        {
            // formatting the output to 2 decimal places
            Console.WriteLine(t.ToString("F2"));
        }

        //display the total of those transactions
        Console.WriteLine($"\nTotal of those transactions: {total.ToString("F2")}");
    }
}
