using System;

class Program
{
    static void Main()
    {
        int sum = 0; // Variable to store the sum of entered numbers
        string input; // Variable to store user input

        Console.WriteLine("Enter a number (or type 'ok' to exit):");

        while (true)
        {
            input = Console.ReadLine(); // Read user input

            // Check if user wants to exit
            if (input.ToLower() == "ok")
                break;

            // Validate numeric input and add to sum
            if (int.TryParse(input, out int number))
            {
                sum += number; // Add valid number to sum
            }
            else
            {
                // Notify the user of invalid input
                Console.WriteLine("Invalid input. Please enter a valid number or 'ok' to exit.");
            }
        }

        // Display the total sum of entered numbers
        Console.WriteLine("Total sum of entered numbers: " + sum);
    }
}

