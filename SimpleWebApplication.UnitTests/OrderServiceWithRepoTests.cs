using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;
using Moq;
using SimpleWebApplication.Services;
using AutoFixture.Xunit2;

namespace SimpleWebApplication.UnitTests
{
    public class OrderServiceWithRepoTests
    {
        [Theory, AutoData]
        public void PlaceOrder_CorrectValues_ReturnCorrectStatus(Order order)
        {
            // Arrange
            var mock = new Mock<IOrderRepository>();
            mock.Setup(repo => repo.Save(order)).Returns(true);

            var orderService = new OrderServiceWithRepo(mock.Object);

            // Act
            var result = orderService.PlaceOrder(order);

            // Assert
            mock.Verify(repo => repo.Save(order), Times.Once);

            result.Should().Be(OrderStatus.OrderPlacedCorrectly);
        }
    }
}
