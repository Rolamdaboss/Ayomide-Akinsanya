using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Prompt user to enter a word
        Console.Write("Enter an English word: ");
        string input = Console.ReadLine();

        // Check if input is empty or null
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Invalid input");
            return;
        }

        // Define the set of vowels
        char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

        // Count the number of vowels in the input (case insensitive)
        int vowelCount = input.ToLower().Count(all => vowels.Contains(all));

        // Display the vowel count
        Console.WriteLine($"Number of vowels: {vowelCount}");
    }
}

