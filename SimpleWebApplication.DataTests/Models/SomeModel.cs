namespace SimpleWebApplication.DataTests.Models;

public class SomeModel
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime Created { get; set; }
    public bool IsDeleted { get; set; }
}
