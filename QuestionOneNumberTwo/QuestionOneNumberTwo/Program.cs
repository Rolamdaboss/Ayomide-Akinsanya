using System;

class Program
{
    static void Main()
    {
        // Prompt user to enter the first number
        Console.Write("Enter the first number: ");
        int num1 = int.Parse(Console.ReadLine());

        // Prompt user to enter the second number
        Console.Write("Enter the second number: ");
        int num2 = int.Parse(Console.ReadLine());

        int max; // Variable to store the maximum number

        // Compare the two numbers and assign the larger one to max
        if (num1 > num2)
        {
            max = num1;
        }
        else
        {
            max = num2;
        }

        // Display the maximum number
        Console.WriteLine("The maximum number is: " + max);
    }
}

