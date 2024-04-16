using SimpleWebApplication.DataTests.Models;

namespace SimpleWebApplication.DataTests.Services;

public class SomeRepository : ISomeRepository
{
    public void AddSomeModel(SomeModel model)
    {
        // Add model to database
    }

    public SomeModel GetSomeModel(int id)
    {
        // Get model from database
        return new SomeModel();
    }
}
