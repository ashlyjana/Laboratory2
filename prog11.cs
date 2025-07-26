using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This program manages a book inventory.
            var names = new List<string>();
            var quantity = new List<int>();

            for (int i = 0; i < 5; i++)//for loop
            {
                //enter book name and quantity
                Console.Write("Book: ");
                names.Add(Console.ReadLine().ToLower());
                Console.Write("Quantity: ");
                quantity.Add(int.Parse(Console.ReadLine()));
            }
            // Display the inventory
            Console.Write("Search book: ");
            string find = Console.ReadLine().ToLower();
            int index = names.IndexOf(find);

            if (index != -1) //if statemebt
            {
                // Display the book and its quantity
                Console.Write("New quantity: ");
                quantity[index] = int.Parse(Console.ReadLine());
            }
            else Console.WriteLine("empty");//else statement
            // Display the inventory
            Console.WriteLine("Inventory:");
            for (int i = 0; i < names.Count; i++)//for loop
                Console.WriteLine($"{names[i]} - {quantity[i]}");
        }
    }
}
