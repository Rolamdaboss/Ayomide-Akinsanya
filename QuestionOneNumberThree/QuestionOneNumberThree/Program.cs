using System;

class Program
{
    static void Main()
    {
        // Prompt the user to enter the width of the image
        Console.Write("Enter the Width of Image: ");
        int width = int.Parse(Console.ReadLine());

        // Prompt the user to enter the height of the image
        Console.Write("Enter the Height of Image: ");
        int height = int.Parse(Console.ReadLine());

        // Determine the orientation of the image
        if (width > height)
        {
            Console.WriteLine("The Image is Landscape"); // Landscape if width is greater than height
        }
        else if (width == height)
        {
            Console.WriteLine("The Image is a Square"); // Square if width and height are equal
        }
        else
        {
            Console.WriteLine("The Image is Portrait"); // Portrait if height is greater than width
        }
    }
}
