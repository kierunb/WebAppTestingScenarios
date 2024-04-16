using SimpleWebApplication.DataTests.Models;

namespace SimpleWebApplication.DataTests.Services;

public interface ISomeRepository
{
    void AddSomeModel(SomeModel model);
    SomeModel GetSomeModel(int id);
}