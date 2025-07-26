using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This program reads 15 names from the user, stores them in an array,
            string[] names = new string[15];

            Console.WriteLine("Enter 15 names:");
            for (int i = 0; i < 15; i++)//for loop to read names
                names[i] = Console.ReadLine().ToLower(); 
            
            var result = names.Distinct().OrderBy(name => name).ToArray();
            
            Console.WriteLine("\nUnique, Sorted Names:");
            for (int i = 0; i < result.Length; i++) //for loop to print each name
                Console.WriteLine(result[i]);

        }
    }
}
