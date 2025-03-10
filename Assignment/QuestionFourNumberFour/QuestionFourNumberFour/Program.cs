using System;
using System.Globalization;
using System.Linq;

class Program
{
    static void Main()
    {
        // Prompt user for input
        Console.Write("Enter a few words separated by spaces: ");
        string input = Console.ReadLine();

        // Check if input is empty
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Invalid input");
            return;
        }

        // Convert input to PascalCase
        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        string pascalCase = string.Join("", input.ToLower()
                                          .Split(' ')
                                          .Where(word => !string.IsNullOrWhiteSpace(word))
                                          .Select(word => textInfo.ToTitleCase(word)));

        // Display the PascalCase result
        Console.WriteLine(pascalCase);
    }
}

