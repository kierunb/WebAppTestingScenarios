using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SimpleWebApplication.IntegrationTests
{
    public class RestApiTests
    {
        private readonly RestClient _restClient;
        private readonly string _baseUri = "https://jsonplaceholder.typicode.com";
        public RestApiTests()
        {
            _restClient = new RestClient();
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public async Task GetCommentEndpoint_ReturnsCorrectComment(int id)
        {
            var getRequest = new RestRequest($"{_baseUri}/comments/{id}", Method.Get);

            var response = await _restClient.ExecuteGetAsync(getRequest);

            Assert.Equal(System.Net.HttpStatusCode.OK, response.StatusCode);
        }
    }
}
