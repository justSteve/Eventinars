using System;
using System.Threading.Tasks;
using Eventinars.Infrastructure.Contexts;
using Eventinars.Server.Extensions;
using Azure.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Eventinars.Server
{
    public class Program
    {
        public async static Task Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();


            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                try
                {
                    var context = services.GetRequiredService<BlazorHeroContext>();

                    if (context.Database.IsSqlServer())
                    {
                        context.Database.Migrate();
                    }
                }
                catch (Exception ex)
                {
                    var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();

                    logger.LogError(ex, "An error occurred while migrating or seeding the database.");

                    throw;
                }
            }

            await host.RunAsync();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .UseSerilog()
                .ConfigureWebHostDefaults(webBuilder =>

                webBuilder.ConfigureAppConfiguration(config =>
                {
                    var settings = config.Build();
                    //var connection = settings.GetConnectionString("AppConfig");

                    config.AddAzureAppConfiguration(options =>
                    {
                        options.Connect(settings["ConnectionStrings:AppConfig"])
                                .ConfigureKeyVault(kv =>
                                {
                                    //kv.SetCredential(new DefaultAzureCredential());
                                    kv.SetCredential(new VisualStudioCredential(new VisualStudioCredentialOptions { TenantId = "720638a1-589b-4e13-8217-0e11886bf376" }));
                                });
                    });
                })
                .UseStaticWebAssets()
                .UseStartup<Startup>()
                );
    };
}
