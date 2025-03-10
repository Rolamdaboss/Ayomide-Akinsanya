using System;

class Program
{
    static void Main()
    {
        // Prompt user to enter a time in 24-hour format
        Console.Write("Enter a time in 24-hour format (e.g. 19:00): ");
        string input = Console.ReadLine();

        // Check if input is empty or null
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Invalid Time");
            return;
        }

        // Validate the time format and range
        if (TimeSpan.TryParse(input, out TimeSpan time) && time.TotalMinutes >= 0 && time.TotalMinutes < 1440)
        {
            Console.WriteLine("Ok");
        }
        else
        {
            Console.WriteLine("Invalid Time");
        }
    }
}

