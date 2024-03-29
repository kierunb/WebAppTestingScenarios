﻿using SimpleWebApplication.Services;
using System;
using Xunit;
using FluentAssertions;
using AutoFixture;

namespace SimpleWebApplication.UnitTests;

public class TestClassTestSuite
{
    // create unit tests from TestClass.cs

    [Fact()]
    public void GetLength_Return()
    {
        // Arrange

        var testClass = new TestClass();
        //string hardCodedTestString = "test test";

        var fixture = new Fixture();
        string autoGeneratedText = fixture.Create<string>();

        int expectedResult = autoGeneratedText.Length;

        // Act

        int actualResult = testClass.GetLength(autoGeneratedText);

        // Assert

        //Assert.Equal(expectedResult, actualResult);
        actualResult.Should().Be(expectedResult);

    }
}
