using SimpleWebApplication.Services;
using Xunit;
using FluentAssertions;
using Moq;

namespace SimpleWebApplication.UnitTests
{
    public class AdvancedMathServiceTests
    {
        [Fact]
        public void BetterAdd_ValidParameters_CorrectValue()
        {
            var mock = new Mock<IAdvancedMathEngine>();
            mock.Setup(foo => foo.VerifyInput(1)).Returns(true);

            var mathService = new AdvancedMathService(mock.Object);
            var actual = mathService.BetterAdd(2, 2);
            int expected = 4;

            actual.Should().Be(expected);
        }
    }
}
