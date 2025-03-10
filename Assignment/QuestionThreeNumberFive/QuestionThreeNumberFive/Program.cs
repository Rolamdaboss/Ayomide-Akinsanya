using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        while (true)
        {
            // Prompt the user to enter a list of comma-separated numbers
            Console.Write("Enter a list of at least 5 comma-separated numbers: ");
            string input = Console.ReadLine();

            // Split the input string by commas and remove any empty entries
            List<string> items = input.Split(',')
                                        .Select(i => i
                                        .Trim())
                                        .ToList();

            // Try converting the list into a list of integers
            List<int> numbers = new List<int>();
            foreach (string item in items)
            {
                if (int.TryParse(item, out int number))
                {
                    numbers.Add(number);
                }
            }

            // Check if the list has at least 5 valid numbers
            if (numbers.Count < 5)
            {
                Console.WriteLine("Invalid List. Please enter at least 5 numbers.");
                continue; // Ask the user to re-enter the list
            }

            // Sort the list in ascending order
            numbers.Sort();

            // Display the three smallest numbers
            Console.WriteLine("The three smallest numbers are: " + string.Join(", ", numbers.Take(3)));
            break; // Exit the loop after valid input
        }
    }
}
