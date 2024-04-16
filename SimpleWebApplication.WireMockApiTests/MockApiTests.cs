using Microsoft.AspNetCore.Hosting.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WireMock.RequestBuilders;
using WireMock.ResponseBuilders;
using WireMock.Server;

namespace SimpleWebApplication.WireMockApiTests;

public class MockApiTests : IDisposable
{

    private readonly WireMockServer _server;

    public MockApiTests()
    {
        _server = WireMockServer.Start();
    }


    public void Dispose() => _server.Stop();


    [Fact]
    public async Task Should_respond_to_request()
    {
        _server
            .Given(Request.Create().WithPath("/foo").UsingGet())
            .RespondWith(
              Response.Create()
                .WithStatusCode(200)
                .WithBody(@"{ ""msg"": ""Hello world!"" }")
            );

        // Act (use a HttpClient which connects to the URL where WireMock.Net is running)
        var response = await new HttpClient().GetAsync($"{_server.Urls[0]}/foo");

        Assert.True(response.IsSuccessStatusCode);
    }
}

