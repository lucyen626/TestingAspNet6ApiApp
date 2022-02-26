namespace TestingAspNet6ApiApp.Services;

public interface IMessageService
{
    string SayHello();
}

public class MessageService : IMessageService
{
    public string SayHello() => "Hello";
}
