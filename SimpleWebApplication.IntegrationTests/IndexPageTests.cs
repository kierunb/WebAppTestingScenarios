using AngleSharp.Io;
using Microsoft.AspNetCore.Mvc;
using SimpleWebApplication.IntegrationTests.Helpers;
using SimpleWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SimpleWebApplication.IntegrationTests
{
    
    public class IndexPageTests
    {
        private readonly SimpleWebApplicationFactory _factory;

        public IndexPageTests()
        {
            _factory = new SimpleWebApplicationFactory();
        }

        [Theory]
        [InlineData("/")]
        [InlineData("/home/index")]
        [InlineData("/home/privacy")]
        public async Task Get_EndpointsReturnSuccessAndCorrectContentType(string url)
        {
            var client = _factory.CreateClient();

            var response = await client.GetAsync(url);

            response.EnsureSuccessStatusCode();
            Assert.Equal("text/html; charset=utf-8",
                response?.Content?.Headers?.ContentType?.ToString());
            
        }

        [Fact]
        public async Task IndexPage_Contains_WelcomeText()
        {
            var client = _factory.CreateClient();

            var response = await client.GetAsync("/");
            var content = await HtmlHelpers.GetDocumentAsync(response);

            response.EnsureSuccessStatusCode();

            var welcomeElement = content.QuerySelector("body > div.container > main > div > h1");

            Assert.Equal(expected: "Welcome", actual: welcomeElement?.TextContent);
        }

        [Fact]
        public async Task DataModel_ReturnsAndDeserialize_Json()
        {
            var client = _factory.CreateClient();

            var response = await client.GetFromJsonAsync<SimpleDataModel>("/home/datamodel");

            Assert.IsType<SimpleDataModel>(response);
        }
    }
}
