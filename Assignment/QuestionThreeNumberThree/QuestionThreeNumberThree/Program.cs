using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        HashSet<int> numbers = new HashSet<int>(); // Store unique numbers
        int count = 0; // Track the number of valid inputs

        while (count < 5)
        {
            // Prompt the user to enter a number and showing the count of number it needs
            Console.Write($"Enter number {count + 1}: ");
            string input = Console.ReadLine();

            // Check if input is a valid integer
            if (int.TryParse(input, out int number))
            {
                // Ensure the number is unique before adding
                if (!numbers.Contains(number))
                {
                    numbers.Add(number); // Add the number to the set
                    count++; // Increment count of valid numbers
                }
                else
                {
                    Console.WriteLine("Error: Number already entered. Try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        // Convert HashSet to List, sort, and display numbers
        List<int> sortedNumbers = new List<int>(numbers);
        sortedNumbers.Sort(); // Sort numbers in ascending order

        // Display the sorted numbers
        Console.WriteLine("Sorted Numbers: " + string.Join(", ", sortedNumbers));
    }
}
