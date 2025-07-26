using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // this is the board
        char[,] board = new char[4, 4];
        bool[,] revealed = new bool[4, 4]; // this tracks the matched positions
        List<char> letters = new List<char>();

        // this adds letters A to H twice to the list
        for (char c = 'A'; c <= 'H'; c++)
        {
            letters.Add(c);
            letters.Add(c);
        }

        // this randomize the letters
        Random rand = new Random();
        for (int i = 0; i < letters.Count; i++)
        {
            int j = rand.Next(i, letters.Count);
            char temp = letters[i];
            letters[i] = letters[j];
            letters[j] = temp;
        }

        // fill 4x4 grid with random letters
        int index = 0;
        for (int row = 0; row < 4; row++)
        {
            for (int col = 0; col < 4; col++)
            {
                board[row, col] = letters[index];
                index++;
            }
        }

        int matches = 0;
        while (matches < 8)
        {
            Console.Clear();
            DisplayBoard(board, revealed);

            Console.WriteLine("\nEnter first position (e.g., A1): ");
            (int row1, int col1) = GetPosition(revealed);

            Console.Clear();
            DisplayBoard(board, revealed, row1, col1);

            Console.WriteLine("\nEnter second position (e.g., B2): ");
            (int row2, int col2) = GetPosition(revealed, row1, col1);

            Console.Clear();
            DisplayBoard(board, revealed, row1, col1, row2, col2);

            if (board[row1, col1] == board[row2, col2])
            {
                Console.WriteLine("\nMatch found!");
                revealed[row1, col1] = true;
                revealed[row2, col2] = true;
                matches++;
            }
            else
            {
                Console.WriteLine("\nNot a match.");
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
        }

        Console.Clear();
        DisplayBoard(board, revealed);
        Console.WriteLine("\n🎉 Congratulations! You matched all pairs!");
    }

    // function to display board
    static void DisplayBoard(char[,] board, bool[,] revealed, int? r1 = null, int? c1 = null, int? r2 = null, int? c2 = null)
    {
        Console.WriteLine("   1  2  3  4");
        for (int row = 0; row < 4; row++)
        {
            char rowLabel = (char)('A' + row);
            Console.Write(rowLabel + " ");
            for (int col = 0; col < 4; col++)
            {
                if (revealed[row, col] || (row == r1 && col == c1) || (row == r2 && col == c2))
                    Console.Write(" " + board[row, col] + " ");
                else
                    Console.Write(" * ");
            }
            Console.WriteLine();
        }
    }

    // function to determine if position is valid
    static (int, int) GetPosition(bool[,] revealed, int? prevRow = null, int? prevCol = null)
    {
        while (true)
        {
            string input = Console.ReadLine().ToUpper().Trim();

            if (input.Length == 2 &&
                input[0] >= 'A' && input[0] <= 'D' &&
                input[1] >= '1' && input[1] <= '4')
            {
                int row = input[0] - 'A';
                int col = input[1] - '1';

                // checks if positioon is revealed and if it is the same as previous position
                if (revealed[row, col])
                {
                    Console.WriteLine("That position is already matched. Choose another:");
                }
                else if (row == prevRow && col == prevCol)
                {
                    Console.WriteLine("You already picked that. Choose another:");
                }
                else
                {
                    return (row, col);
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Use format like A1, B3. Try again:");
            }
        }
    }
}
