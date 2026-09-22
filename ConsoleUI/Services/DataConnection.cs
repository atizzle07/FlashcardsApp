using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
namespace ConsoleUI.Services;

public class DataConnection
{
    private static IConfiguration _config = new ConfigurationBuilder()
        .AddJsonFile("appsettings.json", false, true)
        .Build();

    public static SqlConnection GetConnection()
    {
        string connectionString = _config.GetConnectionString("Default")
                                  ?? throw new InvalidOperationException("Connection string not found");

        return new SqlConnection(connectionString);
    }

    private static void CreateDatabase()
    {
        throw new NotImplementedException();
        
        // Create database
        
        // Create card table
        
        // Create stack table
    }

    private static void CreateDbTables()
    {
        throw new NotImplementedException();
    }
}