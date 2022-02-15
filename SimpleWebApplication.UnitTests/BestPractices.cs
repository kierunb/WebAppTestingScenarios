using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SimpleWebApplication.UnitTests
{

    /*
    https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-best-practices
    
    BEST PRACTICES:
    - Name your tests properly - Add_SingleNumber_ReturnsSameNumber()
    - Arranging your tests - Act, Arrange, Assert
    - Write minimally passing tests - simple, default values - you're veryfing behavior!
    - Avoid magic strings - Explicitly define constants
    - Avoid logic in tests - no loops, if statements etc.
    - Prefer helper methods to setup and teardown
    - Avoid multpile acts
    - Validate private methods by unit testing public methods
    - Stub static references
    */


    public class BestPractices
    {
        public string ParseLogLine(string input)
        {
            var sanitizedInput = TrimInput(input);
            return sanitizedInput;
        }

        private string TrimInput(string input)
        {
            return input.Trim();
        }


        //public void GetDiscountedPrice_NotTuesday_ReturnsFullPrice()
        //{
        //    var priceCalculator = new PriceCalculator();
        //    var dateTimeProviderStub = new Mock<IDateTimeProvider>();
        //    dateTimeProviderStub.Setup(dtp => dtp.DayOfWeek()).Returns(DayOfWeek.Monday);

        //    var actual = priceCalculator.GetDiscountedPrice(2, dateTimeProviderStub);

        //    Assert.Equals(2, actual);
        //}

        //public void GetDiscountedPrice_OnTuesday_ReturnsHalfPrice()
        //{
        //    var priceCalculator = new PriceCalculator();
        //    var dateTimeProviderStub = new Mock<IDateTimeProvider>();
        //    dateTimeProviderStub.Setup(dtp => dtp.DayOfWeek()).Returns(DayOfWeek.Tuesday);

        //    var actual = priceCalculator.GetDiscountedPrice(2, dateTimeProviderStub);

        //    Assert.Equals(1, actual);
        //}

        public int GetDiscountedPrice(int price, IDateTimeProvider dateTimeProvider)
        {
            if (dateTimeProvider.DayOfWeek() == DayOfWeek.Tuesday)
            {
                return price / 2;
            }
            else
            {
                return price;
            }
        }
    }

    public interface IDateTimeProvider
    {
        DayOfWeek DayOfWeek();
    }

    public class Calculator
    {
        private int accumulator = 0;

        public int Add(int a)
        {
            return accumulator + a;
        }
    }
}
