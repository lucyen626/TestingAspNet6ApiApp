// internal class Program

using TestingAspNet6ApiApp.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IMessageService, MessageService>();
builder.Services.AddScoped<AppNameService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapGet("/", (IMessageService message, AppNameService appName) => 
    $"{appName.Name} says {message.SayHello()}"
);


app.Run();

