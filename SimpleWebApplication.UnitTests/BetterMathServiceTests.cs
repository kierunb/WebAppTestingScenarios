using SimpleWebApplication.Services;
using Xunit;
using FluentAssertions;

namespace SimpleWebApplication.UnitTests
{
    public class BetterMathServiceTests
    {
        [Fact]
        public void BetterAdd_ValidParameters_CorrectValue()
        {
            
            // Arrange
            var mathService = new BetterMathService();
            int a = 2;
            int b = 2;
            int expectedValue = 4;

            // Act
            int actualValue = mathService.BetterAdd(a, b);

            // Assert
            Assert.Equal(expectedValue, actualValue);
        }

        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(2, 2, 4)]
        public void BetterAdd_ValidParameters_CorrectValues(int a, int b, int expectedValue)
        {

            var mathService = new BetterMathService();

            int actualValue = mathService.BetterAdd(a, b);

            // 'classic value' vs Fluent Assertion
            // Assert.Equal(expectedValue, actualValue);
            actualValue.Should().Be(expectedValue);
        }

    }
}
