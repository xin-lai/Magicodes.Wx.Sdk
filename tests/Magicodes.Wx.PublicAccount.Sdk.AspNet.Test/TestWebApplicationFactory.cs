using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.IO;
using Xunit.Abstractions;

namespace Magicodes.Wx.PublicAccount.Sdk.Test
{
    public class TestWebApplicationFactory : WebApplicationFactory<TestStartup>
    {
        public ITestOutputHelper Output { get; set; }

        protected override IHostBuilder CreateHostBuilder()
        {
            var builder = Host.CreateDefaultBuilder()
                              .ConfigureLogging((context, logging) =>
                              {
                                  logging.ClearProviders();
                                  logging.AddXunit(Output);
                              })
                              .ConfigureWebHostDefaults(x =>
                              {
                                  x.UseStartup<TestStartup>().UseTestServer();
                              }).ConfigureAppConfiguration((context, config) =>
                              {
                                  config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: false);
                              });
            return builder;
        }

        protected override IHost CreateHost(IHostBuilder builder)
        {
            builder.UseContentRoot(Directory.GetCurrentDirectory());
            return base.CreateHost(builder);
        }

        //protected override void ConfigureWebHost(IWebHostBuilder builder)
        //{
        //    builder.ConfigureServices(services =>
        //    {

        //    });
        //}
    }
}
