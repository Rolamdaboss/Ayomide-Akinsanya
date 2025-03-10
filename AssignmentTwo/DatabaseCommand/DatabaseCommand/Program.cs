using DatabaseCommand;
// Using Program Class to demonstrate polymorphism
class Program
{
    static void Main()
    {
        try
        {
            // Demonstrating polymorphism with SQL Server Connection
            Console.WriteLine("Using SQL Server Connection:");
            DbCommand sqlCommand = new DbCommand(new SqlConnection("Server=myServer;Database=myDB;"), "SELECT * FROM Users");
            sqlCommand.Execute();

            Console.WriteLine(); // Separator for better readability

            // Demonstrating polymorphism with Oracle Connection
            Console.WriteLine("Using Oracle Connection:");
            DbCommand oracleCommand = new DbCommand(new OracleConnection("Server=myOracleServer;Database=myOracleDB;"), "SELECT * FROM Employees");
            oracleCommand.Execute();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}

