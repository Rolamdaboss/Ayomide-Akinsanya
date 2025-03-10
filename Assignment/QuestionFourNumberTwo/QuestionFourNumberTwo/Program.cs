using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Prompt user to enter numbers separated by a hyphen
        Console.Write("Enter a few numbers separated by a hyphen: ");
        string input = Console.ReadLine();

        // Exit immediately if the user presses Enter without input
        if (string.IsNullOrWhiteSpace(input))
            return;

        // Convert input string to a list of integers
        List<int> numbers = input.Split('-')
                                 .Select(i => i.Trim())
                                 .Where(i => int.TryParse(i, out _))
                                 .Select(int.Parse)
                                 .ToList();

        // Check for duplicates using a HashSet
        HashSet<int> uniqueNumbers = new HashSet<int>();
        foreach (int number in numbers)
        {
            if (!uniqueNumbers.Add(number))
            {
                Console.WriteLine("Duplicate");
                return;
            }
            else
            {
                Console.WriteLine("No Duplicate");
                return;
            }
        }

    }
}

