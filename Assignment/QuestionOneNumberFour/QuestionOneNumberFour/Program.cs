using System;

class Program
{
    static void Main()
    {
        // Prompt the user to enter the speed limit
        Console.Write("Enter the Speed limit: ");
        int speedLimit = int.Parse(Console.ReadLine());

        // Prompt the user to enter the speed of the car
        Console.Write("Enter the Speed of Car: ");
        int carSpeed = int.Parse(Console.ReadLine());

        // Calculate the difference between car speed and speed limit
        int diff = (carSpeed - speedLimit);

        // Calculate demerit points (1 point for every 5 km over the limit)
        int demeritPoint = (diff / 5);

        // If the car speed is within the limit, print "OK"
        if (carSpeed < speedLimit)
        {
            Console.WriteLine("OK");
        }
        else
        {
            // Display the calculated demerit points
            Console.WriteLine($"Demerit points: {demeritPoint} ");

            // If demerit points exceed 12, suspend the license
            if (demeritPoint > 12)
            {
                Console.WriteLine("License Suspended");
            }
        }
    }
}

