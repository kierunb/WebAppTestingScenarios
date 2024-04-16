using SimpleWebApplication.DataTests.Models;

namespace SimpleWebApplication.DataTests.Services;

public class SomeService
{
    private readonly ISomeRepository _someRepository;

    public SomeService(ISomeRepository someRepository)
    {
        _someRepository = someRepository;
    }

    public int AddSomeModel(SomeModel model)
    {
        _someRepository.AddSomeModel(model);
        return model.Id;
    }

    public SomeModel GetSomeModel(int id)
    {
        return _someRepository.GetSomeModel(id);
    }
}
