using System;

class Program
{
    static void Main()
    {
        // Prompt the user to enter their name
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        string reversedName = ""; // Variable to store the reversed name

        // Loop through the name in reverse order and construct the reversed string
        for (int i = name.Length - 1; i >= 0; i--)
        {
            reversedName += name[i]; // Append each character in reverse order
        }

        // Display the reversed name
        Console.WriteLine("Reversed Name: " + reversedName);
    }
}

