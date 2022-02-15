using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using SimpleWebApplication.Controllers;
using SimpleWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SimpleWebApplication.UnitTests
{

    /// <summary>
    /// https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/testing?view=aspnetcore-6.0
    /// https://github.com/ivaylokenov/MyTested.AspNetCore.Mvc
    /// </summary>

    public class HomeControllerTests
    {
        [Fact]
        public void Index_ReturnsAViewResult()
        {
            // Arrange
            var mockLogger = new Mock<ILogger<HomeController>>();

            var controller = new HomeController(mockLogger.Object);

            // Act
            var result = controller.Index();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);

        }

        [Fact]
        public void WithModel_ReturnsAViewResult_WithCorrectViewModel()
        {
            // Arrange
            var mockLogger = new Mock<ILogger<HomeController>>();

            var controller = new HomeController(mockLogger.Object);

            // Act
            var result = controller.WithModel();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<SimpleViewModel>(viewResult.ViewData.Model);

        }

        /// <summary>
        /// Testing web api controller
        /// </summary>
        [Fact]
        public void DataModel_ReturnsAViewResult()
        {
            // Arrange
            var mockLogger = new Mock<ILogger<HomeController>>();

            var controller = new HomeController(mockLogger.Object);

            // Act
            var result = controller.DataModel();

            // Assert
            var viewResult = Assert.IsType<OkObjectResult>(result);

            Assert.IsType<SimpleDataModel>(viewResult.Value);

        }
    }
}
