using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Prompt user to enter numbers separated by a hyphen
        Console.Write("Enter a few numbers separated by a hyphen (e.g. 5-6-7-8-9): ");
        string input = Console.ReadLine();

        // Convert input string to a list of integers
        List<int> numbers = input.Split('-')
                                 .Select(i => i.Trim())
                                 .Where(i => int.TryParse(i, out _))
                                 .Select(int.Parse)
                                 .ToList();

        // Ensure we have at least two numbers to check for consecutiveness
        if (numbers.Count < 2)
        {
            Console.WriteLine("Not Consecutive (insufficient numbers)");
            return;
        }

        // Check if numbers are consecutive (either ascending or descending)
        bool isAscending = true;
        bool isDescending = true;

        for (int i = 1; i < numbers.Count; i++)
        {
            if (numbers[i] != numbers[i - 1] + 1)
                isAscending = false;
            if (numbers[i] != numbers[i - 1] - 1)
                isDescending = false;
        }

        // Display result based on the check
        if (isAscending || isDescending)
            Console.WriteLine("Consecutive");
        else
            Console.WriteLine("Not Consecutive");
    }
}

