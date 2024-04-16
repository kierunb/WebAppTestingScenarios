using Moq;
using SimpleWebApplication.DataTests.Models;
using SimpleWebApplication.DataTests.Services;
using FluentAssertions;
using AutoFixture;
using AutoFixture.Xunit2;

namespace SimpleWebApplication.DataTests;

// Docs: https://autofixture.github.io/docs/quick-start/#
// https://fluentassertions.com/introduction

public class AutoFixtureTests
{
    [Fact]
    public void BeforeAutoFixture()
    {
        // Arrange
        var someModel = new SomeModel
        {
            Id = 1,
            Name = "Some Name",
            Description = "Some Description",
            Created = DateTime.Now,
            IsDeleted = false
        };

        // mock the repo dependency
        var someRepositoryMock = new Mock<ISomeRepository>();

        // AddSomeModel function parameter should be of type SomeModel and return void (and be called once)
        someRepositoryMock.Setup(x => x.AddSomeModel(It.IsAny<SomeModel>())).Verifiable();

        var sut = new SomeService(someRepositoryMock.Object);

        // Act
        var newId = sut.AddSomeModel(someModel);

        // Assert (classic version)
        //Assert.Equal(expected: someModel.Id, actual: newId);

        // Fluent Assertions version
        newId.Should().Be(someModel.Id);
    }


    [Fact]
    public void AfterAutoFixture()
    {
        // Arrange
        var fixture = new Fixture();

        var someModel = fixture.Create<SomeModel>();

        // mock the repo dependency
        var someRepositoryMock = new Mock<ISomeRepository>();

        // AddSomeModel function parameter should be of type SomeModel and return void (and be called once)
        someRepositoryMock.Setup(x => x.AddSomeModel(It.IsAny<SomeModel>())).Verifiable();

        var sut = new SomeService(someRepositoryMock.Object);

        // Act
        var newId = sut.AddSomeModel(someModel);

        // Assert
        newId.Should().Be(someModel.Id);
    }

    [Fact]
    public void AutoFixtureWorks()
    {
        var fixture = new Fixture();

        var message = fixture.Create<string>();

        var model = fixture.Create<SomeModel>();

        message.Should().NotBeNullOrEmpty();

        model.Id.Should().BeGreaterThanOrEqualTo(0);
        model.Name.Should().NotBeNullOrEmpty();
    }

    [Theory]
    [AutoData]
    public void MathService_AddTwoNumbers_ReturnsSum(MathService sut, int a, int b)
    {
        // Act
        var result = sut.Add(a, b);

        // Assert
        result.Should().Be(a + b);
    }



    //[Theory]
    //[AutoData]
    //public void AfterAutoFixtureWithMoqIntegration(SomeRepository mockRepository, SomeService sut, SomeModel someModel)
    //{
    //    // Act
    //    var newId = sut.AddSomeModel(someModel);

    //    // Assert
    //    newId.Should().Be(someModel.Id);
    //}
}