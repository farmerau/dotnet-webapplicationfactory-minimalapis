using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Farmer.Codes.MinimalApis.WebApplicationFactoryDemo.InternalsVisibleToTests;

public class HelloWorldTests
{
    [Test]
    public async Task BaseRoute_WhenInvoked_ReturnsHelloWorldResponse()
    {
        // Arrange
        TestApplication app = new TestApplication();
        HttpClient client = app.CreateDefaultClient();

        // Act
        HttpResponseMessage response = await client.GetAsync("/");
        string stringResponse = await response.Content.ReadAsStringAsync();

        // Assert
        Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        Assert.AreEqual(Constants.HelloWorldResponse, stringResponse);
    }
}