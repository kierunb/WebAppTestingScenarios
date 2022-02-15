using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace SimpleWebApplication.UnitTests
{
    public class XUnitTestsSamples : IDisposable
    {

        public XUnitTestsSamples()
        {
            Console.WriteLine("Initializing tests");
        }
        public void Dispose()
        {
            Console.WriteLine("Cleaning after tests");
        }

        [Fact]
        public void SimpleTest()
        {
            Assert.True(true, "This simple test should pass");
        }

        [Fact(DisplayName = "Super simple test")]
        public void SimpleTestNamed()
        {
            Assert.True(true, "This simple test should pass");
        }

        [Fact]
        public void SimpleTestWithException()
        {
            Assert.Throws<OverflowException>(
                () =>
                {
                    checked
                    {
                        int x = 123;
                        int y = int.MaxValue;
                        int res = x + y;
                    }
                });
        }

        [Fact(Timeout = 100)]
        public async Task SimpleAsyncTestWithTimeout()
        {
            await Task.Delay(5);
            Assert.True(true, "This simple test should pass");
        }

        [Trait("Category", "ComplexTest")]
        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        public void SimpleAsyncTestWithFewCases(int x, int y)
        {
            Assert.True(x == y, "This simple test should pass");
        }

        [Theory, MemberData(nameof(DynamicDataAsProperty))]
        public void TestAddDynamicDataMethod(int a, int b, int expected)
        {
            Assert.True(true, "This simple test should pass");
        }

        public static IEnumerable<object[]> DynamicDataAsProperty
        {
            get
            {
                return new[]
                {
                     new object[] { 1, 1, 2 },
                     new object[] { 12, 30, 42 },
                     new object[] { 14, 1, 15 }
                };
            }
        }

        [Theory, ClassData(typeof(IndexOfData))]
        public void TestAddDynamicDataMethod2(int a, int b, int expected)
        {

        }
    }

    public class IndexOfData : IEnumerable<object[]>
    {
        private readonly List<object[]> _data = new List<object[]>
        {
            new object[] { 1, 1, 2 },
            new object[] { 12, 30, 42 },
            new object[] { 14, 1, 15 }
        };

        public IEnumerator<object[]> GetEnumerator()
        { return _data.GetEnumerator(); }

        IEnumerator IEnumerable.GetEnumerator()
        { return GetEnumerator(); }
    }
}
