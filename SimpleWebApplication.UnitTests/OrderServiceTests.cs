using AutoFixture;
using AutoFixture.Xunit2;
using FluentAssertions;
using SimpleWebApplication.Services;
using System;
using Xunit;

namespace SimpleWebApplication.UnitTests
{
    public class OrderServiceTests
    {
        [Fact]
        public void PlaceOrder_CorrectValues_ReturnCorrectStatus()
        {
            
            
            
            
            
            // Arrange
            var orderService = new OrderService();
            var fixture = new Fixture();
            var order = fixture.Create<Order>();

            // Act
            var result = orderService.PlaceOrder(order);

            // Assert
            Assert.Equal(OrderStatus.OrderPlacedCorrectly, result);

        }
        [Theory, AutoData]
        public void PlaceOrder_CorrectValues_ReturnCorrectStatus_v2(Order order)
        {
            // Arrange
            var orderService = new OrderService();

            // Act
            OrderStatus result = orderService.PlaceOrder(order);

            // Assert
            result.Should().Be(OrderStatus.OrderPlacedCorrectly);

        }

        [Fact]
        public void PlaceOrder_NullValue_ThrowsException()
        {
            // Arrange
            var orderService = new OrderService();
            Order order = null;

            // Act && Assert

            Assert.Throws<ArgumentNullException>(() => orderService.PlaceOrder(order));

        }

        [Fact]
        public void PlaceOrder_NullValue_ThrowsException_v2()
        {
            // Arrange
            var orderService = new OrderService();
            Order order = null;

            // Act
            Action act = () => orderService.PlaceOrder(order);


            // Assert
            act.Should().Throw<ArgumentNullException>();
                //.WithInnerException<ArgumentException>()
                //.WithMessage(nameof(order));

        }
    }
}
