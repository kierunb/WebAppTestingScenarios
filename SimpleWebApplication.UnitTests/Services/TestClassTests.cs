using Xunit;
using SimpleWebApplication.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoFixture;
using Moq;

namespace SimpleWebApplication.Services.Tests
{
    public class TestClassTests
    {
        private readonly Fixture _fixture;
        private readonly Mock<TestClass> _mockTestClass;

        public TestClassTests()
        {
            _fixture = new Fixture();
            _mockTestClass = new Mock<TestClass>();
        }

        [Fact]
        public void GetLengthTest()
        {
            // Arrange
            string str = _fixture.Create<string>();
            int expectedLength = str.Length;
            _mockTestClass.Setup(tc => tc.GetLength(str)).Returns(expectedLength);

            // Act
            int result = _mockTestClass.Object.GetLength(str);

            // Assert
            Assert.Equal(expectedLength, result);
        }
    }
}