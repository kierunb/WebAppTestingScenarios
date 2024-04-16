using Dapper;
using Microsoft.Data.SqlClient;
using Respawn;

namespace SimpleWebApplication.DataTests;

// https://khalidabuhakmeh.com/faster-dotnet-database-integration-tests-with-respawn-and-xunit
// https://medium.com/@kova98/easy-test-database-reset-in-net-with-respawn-d5a59f995e9d


public class DatabaseFixture : IAsyncLifetime
{
    private readonly string _connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

    public async Task<SqlConnection> GetOpenConnectionAsync()
    {
        var sqlConnection = new SqlConnection(_connectionString);
        await sqlConnection.OpenAsync();
        return sqlConnection;
    }

    private Respawner respawn = null!;

    public async Task InitializeAsync()
    {
        await MigrateAsync();

        respawn = await Respawner.CreateAsync(_connectionString,
            new RespawnerOptions
            {
                DbAdapter = DbAdapter.SqlServer
            });
    }

    private async Task MigrateAsync()
    {
        // only doing this for the sample,
        // you'll likely already have the database created somewhere
        //{
        //    try
        //    {
        //        await using var connection = await GetOpenConnectionAsync();
        //        await connection.ExecuteAsync(
        //            // lang=SQL
        //            $"""
        //             IF NOT EXISTS (SELECT [name] FROM sys.databases WHERE [name] = N'{DatabaseName}')
        //                CREATE DATABASE {DatabaseName};
        //             """
        //        );
        //    }
        //    catch (SqlException e)
        //    {
        //        throw new Exception("Create and run the container found in the docker-compose.yml", e);
        //    }
        //}

        //{
        //    await using var connection = await GetOpenConnectionAsync();
        //    await connection.ExecuteAsync(
        //        // lang=SQL
        //        """
        //        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[People]') AND type in (N'U'))
        //          BEGIN
        //              CREATE TABLE People
        //              (
        //                  ID INT PRIMARY KEY IDENTITY,
        //                  FirstName NVARCHAR(50),
        //                  LastName NVARCHAR(50),
        //                  Age INT,
        //                  Email NVARCHAR(255)
        //              );
        //          END;
        //        """);
        //}
        await Task.CompletedTask;
    }

    public Task ResetAsync()
        => respawn.ResetAsync(_connectionString);

    public async Task DisposeAsync()
    {
        await Task.CompletedTask;
    }
}

