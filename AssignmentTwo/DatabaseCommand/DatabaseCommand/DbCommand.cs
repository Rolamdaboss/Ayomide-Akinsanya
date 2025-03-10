using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseCommand
{       // Class representing a database command
     class DbCommand
    {
        private readonly DbConnection _connection; //Database connection object
        private readonly string _instruction; //SQL or database command

        // Constructor ensuring a valid connection and instruction are provided
        public DbCommand(DbConnection connection, string instruction)
        {
            _connection = connection ?? throw new InvalidOperationException("DbConnection cannot be null.");
            _instruction = string.IsNullOrWhiteSpace(instruction) ? throw new InvalidOperationException("Instruction cannot be null or empty.") : instruction;
        }

        // Execute method to run the command
        public void Execute()
        {
            _connection.Open(); // Open connection
            Console.WriteLine($"Executing instruction: {_instruction}"); // Execute command
            _connection.Close(); // Close connection
        }
    }
}
