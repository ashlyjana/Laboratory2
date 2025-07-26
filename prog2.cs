using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // the program will ask the user to enter 5 event names and their corresponding dates   
            string[] eventNames = new string[5];
            DateTime[] eventDates = new DateTime[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter event name: "); //inputs the user's event name
                eventNames[i] = Console.ReadLine();

                Console.Write("Enter event date (MM/DD/YYYY): "); //inputs the user's event date
                DateTime date;
                while (!DateTime.TryParse(Console.ReadLine(), out date))
                {
                    Console.Write("Invalid format. Enter date (MM/DD/YYYY): "); // prompts the user to re-enter the date if the format is incorrect
                }

                // Check for duplicate dates
                bool duplicate = false;
                for (int j = 0; j < i; j++) // for looping
                {
                    if (eventDates[j].Date == date.Date)
                    {
                        Console.WriteLine("Date already used! Enter a different date."); // ask the user to re-enter the date if it is a duplicate
                        i--; // repeat this index
                        duplicate = true;
                        break;
                    }
                }
                
                if (!duplicate) // if the date is not a duplicate, store it
                    eventDates[i] = date;
            }

            // Sort events by date using simple sorting (bubble sort style)
            for (int i = 0; i < 4; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (eventDates[j] < eventDates[i])
                    {
                        // Swap dates
                        DateTime tempDate = eventDates[i];
                        eventDates[i] = eventDates[j];
                        eventDates[j] = tempDate;

                        // Swap names to match
                        string tempName = eventNames[i];
                        eventNames[i] = eventNames[j];
                        eventNames[j] = tempName;
                    }
                }
            }
            // Display the sorted events
            Console.WriteLine("\nEvents sorted by date:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{eventDates[i]:MM/dd/yyyy} - {eventNames[i]}");
            }
        }
    }
}
