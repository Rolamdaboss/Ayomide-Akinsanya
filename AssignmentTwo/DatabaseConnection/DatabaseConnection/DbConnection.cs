using System;

// Abstract base class representing a database connection
abstract class DbConnection
{
    public string ConnectionString { get; }
    public TimeSpan Timeout { get; set; }

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
