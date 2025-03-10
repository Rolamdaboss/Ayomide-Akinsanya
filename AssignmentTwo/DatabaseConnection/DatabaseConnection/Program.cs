using DatabaseConnection;

class Program
{
    static void Main()
    {
        try
        {
            // Example usage of SqlConnection
            DbConnection sqlConnection = new SqlConnection("Server=myServer;Database=myDB;");
            sqlConnection.Open();
            sqlConnection.Close();

            Console.WriteLine(); // Separator for better readability

            // Example usage of OracleConnection
            DbConnection oracleDatabaseConnection = new OracleDatabaseConnection("Server=myOracleServer;Database=myOracleDB;");
            oracleDatabaseConnection.Open();
            oracleDatabaseConnection.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
