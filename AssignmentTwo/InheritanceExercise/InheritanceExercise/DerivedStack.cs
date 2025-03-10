using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExercise
{
    public class DerivedStack :MainStack
    {
        // Display stack contents for debugging
        public void PrintStack()
        {
            Console.WriteLine("Stack contents:");
            for (int i = _stack.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(_stack[i]); // Print each item from top to bottom
            }
        }
    }
}
