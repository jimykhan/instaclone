using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using instaclone.Data;
using instaclone.Data.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace instaclone
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IHost host = CreateHostBuilder(args).Build();
            //using (var scope = host.Services.CreateScope())
            //{
            //    var servicesProvider = scope.ServiceProvider;
            //    var loggerFactory = servicesProvider.GetRequiredService<ILoggerFactory>();
            //    try
            //    {
            //        //Seed Default Users
            //        var userManager = servicesProvider.GetRequiredService<UserManager<ApplicationUser>>();
            //        var roleManager = servicesProvider.GetRequiredService<RoleManager<IdentityRole>>();
            //        var context = servicesProvider.GetRequiredService<ApplicationDbContext>();
            //        //await ApplicationDbContextSeed.SeedDataAsync(userManager, roleManager, context);
            //    }
            //    catch (Exception ex)
            //    {
            //        var logger = loggerFactory.CreateLogger<Program>();
            //        logger.LogError(ex, "An error occurred seeding the DB.");
            //    }
            //}

            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
