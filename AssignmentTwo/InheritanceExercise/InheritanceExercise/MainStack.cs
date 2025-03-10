using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExercise
{
    public class MainStack
    {
        // Protected list to store stack elements (accessible to derived classes)
        protected List<object> _stack = new List<object>();

        // Push method: Adds an object to the stack
        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("Null values cannot be added to the stack.");

            _stack.Add(obj); // Add object to the stack
        }

        // Pop method: Removes and returns the last added object
        public object Pop()
        {
            if (_stack.Count == 0)
                throw new InvalidOperationException("Cannot pop from an empty stack.");

            int lastIndex = _stack.Count - 1; // Get index of last item
            object topItem = _stack[lastIndex]; // Retrieve last item
            _stack.RemoveAt(lastIndex); // Remove last item

            return topItem; // Return the popped item
        }

        // Clear method: Removes all items from the stack
        public void Clear()
        {
            _stack.Clear(); // Empty the stack
        }
    }
}
