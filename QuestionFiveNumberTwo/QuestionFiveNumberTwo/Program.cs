using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        // Prompt user to enter the file path
        Console.Write("Enter the file path (include .txt at the end): ");
        string filePath = Console.ReadLine().Trim();

        // Convert relative paths to absolute paths
        filePath = Path.GetFullPath(filePath);

        // Check if the file exists
        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found. Please check the path and try again.");
            return;
        }

        try
        {
            // Read file content
            string content = File.ReadAllText(filePath);

            // Use Regex to extract words and find the longest one
            string longestWord = Regex.Matches(content, @"\b\w+\b") // Use @"" for correct regex
                                      .Select(match => match.Value)
                                      .OrderByDescending(word => word.Length)
                                      .FirstOrDefault();

            // Display the longest word
            Console.WriteLine($"Longest word: {longestWord}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading the file: {ex.Message}");
        }
    }
}

