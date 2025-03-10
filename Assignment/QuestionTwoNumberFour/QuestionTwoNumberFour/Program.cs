using System;

class Program
{
    static void Main()
    {
        Random random = new Random(); // Create an instance of Random class
        int secretNumber = random.Next(1, 11); // Generates a random number between 1 and 10
        int attempts = 4; // Maximum number of attempts allowed

        // Console.WriteLine($"(Secret Number: {secretNumber})"); // for debugging purpose
        Console.WriteLine("Guess the number between 1 and 10. You have 4 attempts.");

        // Loop through the allowed number of attempts
        for (int i = 0; i < attempts; i++)
        {
            Console.Write("Enter your guess: ");

            // Validate user input and ensure it's within the correct range
            if (int.TryParse(Console.ReadLine(), out int guess) && guess >= 1 && guess <= 10)
            {
                // Check if the guessed number matches the secret number
                if (guess == secretNumber)
                {
                    Console.WriteLine("You won!");
                    return; // Exit program if guessed correctly
                }
                else
                {
                    Console.WriteLine("Wrong guess. Try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 10.");
            }
        }

        // Display the correct number if the user fails all attempts
        Console.WriteLine($"You lost! The correct number was {secretNumber}.");
    }
}

