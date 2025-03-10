using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseCommand
{       // Abstract class representing a generic database connection
     abstract class DbConnection
    {
        public string ConnectionString { get; } // Connection string for the database
        public TimeSpan Timeout { get; set; } // Timeout duration for connection

        // Constructor to ensure a valid connection string is provided
        protected DbConnection(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new InvalidOperationException("Connection string cannot be null or empty.");

            ConnectionString = connectionString;
            Timeout = TimeSpan.FromSeconds(30); // Default timeout
        }

        // Abstract methods for opening and closing the connection
        public abstract void Open();
        public abstract void Close();
    }
}
