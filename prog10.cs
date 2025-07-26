using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store the scores
        List<int> scores = new List<int>();

        Console.WriteLine("Enter 5 player scores:");

        // Keep asking the user until we have 5 valid scores
        while (scores.Count < 5)
        {
            Console.Write($"Score {scores.Count + 1}: ");
            string input = Console.ReadLine();

            // Try to convert the input to an integer
            if (int.TryParse(input, out int score))
            {
                scores.Add(score); // Add the score to the list
            }
            else
            {
                Console.WriteLine("That's not a valid number. Please try again.");
            }
        }

        // Sort the scores from highest to lowest
        scores.Sort();
        scores.Reverse();

        // Show the leaderboard before adding the new score
        Console.WriteLine("\n🏆 Current Leaderboard:");
        DisplayLeaderboard(scores);

        // Ask the user to enter a new score to add
        Console.Write("\nEnter new player's score: ");
        int newScore;

        // Make sure the new input is a valid number
        while (!int.TryParse(Console.ReadLine(), out newScore))
        {
            Console.WriteLine("Please enter a valid number:");
        }

        // Find the right spot to insert the new score to keep the list sorted
        int position = scores.FindIndex(s => newScore >= s);

        if (position == -1)
        {
            // If the new score is the lowest, just add it to the end
            scores.Add(newScore);
        }
        else
        {
            // Otherwise, insert it in the correct position
            scores.Insert(position, newScore);
        }

        // Show the updated leaderboard
        Console.WriteLine("\n📈 Updated Leaderboard:");
        DisplayLeaderboard(scores);
    }

    // This method prints the leaderboard nicely with ranks
    static void DisplayLeaderboard(List<int> scores)
    {
        for (int i = 0; i < scores.Count; i++)
        {
            Console.WriteLine($"Rank {i + 1}: {scores[i]}");
        }
    }
}
