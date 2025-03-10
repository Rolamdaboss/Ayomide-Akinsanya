using InheritanceExercise;

class Program
{
    static void Main()
    {
        // Creating an instance of the CustomStack
        DerivedStack myStack = new DerivedStack();

        // Pushing different data types onto the stack
        myStack.Push(1);
        myStack.Push(2);
        myStack.Push(3);
        myStack.Push("Hello");

        // Displaying stack contents
        myStack.PrintStack();

        // Popping elements and displaying them (LIFO order)
        Console.WriteLine(myStack.Pop()); // Should remove and return "Hello"
        Console.WriteLine(myStack.Pop()); // Should remove and return 3
        Console.WriteLine(myStack.Pop()); // Should remove and return 2
        Console.WriteLine(myStack.Pop()); // Should remove and return 1

        // Check behavior when trying to pop from an empty stack
        try
        {
            myStack.Pop(); // Should throw an exception
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine("Exception: " + ex.Message);
        }

        // Clearing the stack
        myStack.Clear();
        Console.WriteLine("Stack cleared.");
    }
}