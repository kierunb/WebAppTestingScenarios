using Microsoft.Data.SqlClient;
using Dapper;
using SimpleWebApplication.DataTests.Models;
using Respawn;
using Xunit.Abstractions;


namespace SimpleWebApplication.DataTests;

// Docs:
// https://github.com/DapperLib/Dapper
// https://www.learndapper.com/
// https://github.com/jbogard/Respawn


public class DatabaseTests : IDisposable
{
    private readonly string _connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
    private readonly SqlConnection _connection;
    private readonly ITestOutputHelper _output;


    public DatabaseTests(ITestOutputHelper output)
    {
        _output = output;
        _connection = new SqlConnection(_connectionString);
    }

    [Fact]
    public async Task AddEmployeeTest()
    {
        await _connection.OpenAsync();

        var checkpoint = await Respawner.CreateAsync(_connection, 
            new RespawnerOptions {  });

        var sql = "INSERT INTO Employees (LastName, FirstName) VALUES (@LastName, @FirstName)";

        var rowsAffected = await _connection.ExecuteAsync(sql, new Employee { LastName = "Doe", FirstName = "John" });

        try
        {
            await checkpoint.ResetAsync(_connection);
        }
        catch
        {
            _output.WriteLine(checkpoint.DeleteSql);
            throw;
        }

        Assert.Equal(1, rowsAffected);
    }


    public void Dispose()
    {
       _connection.Dispose();
    }
}
