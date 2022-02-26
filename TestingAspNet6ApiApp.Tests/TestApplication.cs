using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingAspNet6ApiApp.Services;

namespace TestingAspNet6ApiApp.Tests
{
    internal class TestApplication : WebApplicationFactory<Program>
    {
        public string Message { get; set; }

        protected override IHost CreateHost(IHostBuilder builder)
        {
            builder.ConfigureServices(sp => {
                sp.AddScoped<IMessageService, FakeMessageService>(
                    _ => new FakeMessageService
                    {
                        Message = Message
                    });
            });
            return base.CreateHost(builder);
        }
    }
}
