using System;

class Program
{
    static void Main()
    {
        // Prompt the user to enter a series of numbers separated by commas
        Console.Write("Enter a series of numbers separated by commas: ");
        string input = Console.ReadLine();

        // Split the input string into an array using commas as separators
        string[] numberStrings = input.Split(',');

        // Initialize maxNumber with the smallest possible integer value
        int maxNumber = int.MinValue;

        // Iterate through each element in the array
        foreach (string a in numberStrings)
        {
            // Trim spaces and attempt to parse each element as an integer
            if (int.TryParse(a.Trim(), out int number))
            {
                // Update maxNumber if the current number is greater
                if (number > maxNumber)
                    maxNumber = number;
            }
            else
            {
                // Display an error message and exit if input is invalid
                Console.WriteLine("Invalid input. Please enter numbers separated by commas.");
                return;
            }
        }

        // Display the maximum number found
        Console.WriteLine($"The maximum number is: {maxNumber}");
    }
}

