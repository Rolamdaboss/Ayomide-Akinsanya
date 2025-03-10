using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // HashSet to store unique numbers entered by the user
        HashSet<int> uniqueNumbers = new HashSet<int>();

        while (true)
        {
            // Prompt the user for input
            Console.Write("Enter a number (or type 'Quit' to exit): ");
            string input = Console.ReadLine();

            // Check if the user wants to quit (makes it case insensitive)
            if (input.Equals("Quit", StringComparison.OrdinalIgnoreCase))
                break;

            // Try to convert input to an integer
            if (int.TryParse(input, out int number))
            {
                // Add the number to the HashSet (only unique values are stored)
                uniqueNumbers.Add(number);
            }
            else
            {
                // Notify the user of invalid input
                Console.WriteLine("Invalid input. Please enter a valid number or 'Quit' to exit.");
            }
        }

        // Display the unique numbers entered by the user
        Console.WriteLine("\nUnique numbers entered:");

        // Iterate through HashSet and print each unique number
        foreach (int num in uniqueNumbers)
        {
            Console.WriteLine(num); // Print each unique number
        }
    }
}

