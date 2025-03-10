using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Enter the file path (include .txt at the end): ");
        string filePath = Console.ReadLine().Trim(); // Trim to remove accidental spaces

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

            // Count words (splitting by spaces, newlines, tabs)
            int wordCount = content.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries).Length;

            Console.WriteLine($"Number of words: {wordCount}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading the file: {ex.Message}");
        }
    }
}

