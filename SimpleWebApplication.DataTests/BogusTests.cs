using Bogus;
using FluentAssertions;
using SimpleWebApplication.DataTests.Models;

namespace SimpleWebApplication.DataTests;

// Docs: https://github.com/bchavez/Bogus

public class BogusTests
{
    [Fact]
    public void BogusTest1()
    {
        //Set the randomizer seed if you wish to generate repeatable data sets.
        Randomizer.Seed = new Random(666);

        var testUserFaker = new Faker<SomeModel>()
            .RuleFor(u => u.Id, f => f.IndexFaker)
            .RuleFor(u => u.Name, f => f.Name.FullName())
            .RuleFor(u => u.Description, f => f.Lorem.Sentence())
            .RuleFor(u => u.Created, f => f.Date.Past())
            .RuleFor(u => u.IsDeleted, f => f.Random.Bool());

        var someModel = testUserFaker.Generate();

        someModel.Should().NotBeNull();
        someModel.Id.Should().BeGreaterThanOrEqualTo(0);
    }
}
