using TestingAspNet6ApiApp.Services;

namespace TestingAspNet6ApiApp.Tests
{
    public class FakeMessageService : IMessageService
    {
        public string Message { get; set; } = "Hello";

        public string SayHello() => Message;
    }
}
