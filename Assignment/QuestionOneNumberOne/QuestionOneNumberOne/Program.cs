using System;

class Program
{
    static void Main()
    {
        int number;
        while (true)
        {
            // Prompt the user to enter a number
            Console.Write("Enter a number between 1 and 10: ");
            string input = Console.ReadLine();

            // Try to parse the input and check if it's within the valid range
            if (int.TryParse(input, out number) && number >= 1 && number <= 10)
            {
                Console.WriteLine("Valid");
                break; // Exit loop on valid input
            }

            // Notify the user of invalid input and prompt again
            Console.WriteLine("Invalid. Try again.");
        }
    }
}
