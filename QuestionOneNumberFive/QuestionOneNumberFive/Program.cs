using System;

class Program
{
    static void Main()
    {
        int count = 0; // Variable to store the count of numbers divisible by 3

        // Loop through numbers from 1 to 99
        for (int i = 1; i < 100; i++)
        {
            // Check if the number is divisible by 3
            if (i % 3 == 0)
            {
                count++; // Increment count if divisible by 3
            }
        }

        // Display the total count of numbers divisible by 3
        Console.WriteLine("Total count of numbers divisible by 3 between 1 and 100 is " + count);
    }
}
