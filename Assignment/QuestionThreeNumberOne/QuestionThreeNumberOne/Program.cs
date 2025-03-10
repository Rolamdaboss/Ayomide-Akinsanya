using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a list to store names entered by the user
        List<string> names = new List<string>();

        while (true)
        {
            // Prompt the user to enter a name
            Console.Write("Enter a name (or press Enter to finish): ");
            string input = Console.ReadLine();

            // Stop when the user presses Enter without typing a name
            if (string.IsNullOrWhiteSpace(input))
                break;

            // Add the entered name to the list
            names.Add(input);
        }

        // Display the appropriate message based on the number of names
        if (names.Count == 1)
        {
            Console.WriteLine($"{names[0]} likes your post.");
        }
        else if (names.Count == 2)
        {
            Console.WriteLine($"{names[0]} and {names[1]} like your post.");
        }
        else if (names.Count > 2)
        {
            // Show the first two names and indicate the number of additional people
            Console.WriteLine($"{names[0]}, {names[1]} and {names.Count - 2} others like your post.");
        }
    }
}

