using System;

class Program
{
    static void Main()
    {
        // Prompt the user to enter a number for factorial calculation
        Console.Write("Enter a number to find its factorial: ");

        // Validate input and ensure it's a non-negative integer
        if (int.TryParse(Console.ReadLine(), out int number) && number >= 0)
        {
            long factorial = 1; // Variable to store the factorial result

            // Loop to calculate factorial (number * (number-1) * ... * 1)
            for (int i = number; i > 1; i--)
            {
                factorial *= i;
            }

            // Display the calculated factorial
            Console.WriteLine($"{number}! = {factorial}");
        }
        else
        {
            // Notify user if input is invalid
            Console.WriteLine("Invalid input. Please enter a non-negative integer.");
        }
    }
}

