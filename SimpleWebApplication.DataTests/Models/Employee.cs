namespace SimpleWebApplication.DataTests.Models;

public record Employee
{
    public int EmployeeId { get; init; }
    public string FirstName { get; init; } = string.Empty;
    public string LastName { get; init; } = string.Empty;
}

