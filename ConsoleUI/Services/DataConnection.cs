using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
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

    public void CreateDatabase()
    {
        const string sqlCreateDb =
            """
            IF DB_ID('flashcards') IS NULL
            BEGIN
                CREATE DATABASE flashcards;
            END;

            USE flashcards;
            """;

        using var conn = new SqlConnection(_config.GetConnectionString("Default"));
        conn.Execute(sqlCreateDb);
    }

    public int[] CreateTables()
    {
        const string sqlCreateCardTable =
            """
            IF NOT EXISTS (
                SELECT 1
                FROM sys.tables
                WHERE name = 'card'
            )
            BEGIN
                CREATE TABLE card (
                    Id BIGINT IDENTITY(1,1) NOT NULL PRIMARY KEY,
                    Name NVARCHAR(50),
                    Question NVARCHAR(200),
                    Answer NVARCHAR(200)
                );
            END;
            """;
        const string sqlCreateStackTable =
            """
            CREATE TABLE IF NOT EXISTS stack
            (
                Id BIGINT NOT NULL
                    CONSTRAINT PK_stack PRIMARY KEY,
                Name NVARCHAR(50),
                CardID BIGINT
                    CONSTRAINT FK_card_stack
                        REFERENCES card
            );
            """;

        using var conn = new SqlConnection(_config.GetConnectionString("Default"));
        var CardTableCreated = conn.Execute(sqlCreateCardTable);
        var StackTableCreated = conn.Execute(sqlCreateStackTable);

        return [CardTableCreated, StackTableCreated];
    }

    public void CreateStack()
    {
        //TODO - implement CreateStack feature
        throw new NotImplementedException();
    }

    public void UpdateActiveStack()
    {
        //TODO - implement UpdateActiveStack method
        throw new NotImplementedException();
    }

    public void GetStackById(int id)
    {
        //TODO - implement GetStackById method
        throw new NotImplementedException();
    }
}
