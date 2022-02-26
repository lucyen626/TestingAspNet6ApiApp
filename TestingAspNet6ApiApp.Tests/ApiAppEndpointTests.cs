using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace TestingAspNet6ApiApp.Tests
{
    public class ApiAppEndpointTests
    {
        private readonly ITestOutputHelper output;
        private readonly TestApplication app;

        public ApiAppEndpointTests(ITestOutputHelper output)
        {
            this.output = output;
            app = new TestApplication();

        }

        [Fact]
        public async Task WhenNavigateToRoot_CanGetMessage()
        {
            app.Message = "test message";

            var client = app.CreateDefaultClient();
            var result = await client.GetStringAsync("/");

            output.WriteLine(result);
            Assert.Equal($"ApiApp says {app.Message}", result);

        }
    }
}
