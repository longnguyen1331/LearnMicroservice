using Microsoft.EntityFrameworkCore;
using PlatformService.Models;

namespace PlatformService.Data
{
    public static class PrepDb
    {
        public static void PrePopulation(IApplicationBuilder app, bool isProduction)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>(), isProduction);
            }
        }

        private static void SeedData(AppDbContext? context, bool isProduction)
        {
            if (isProduction)
            {
                Console.WriteLine("--> Attemping to apply migraitions...");
                try
                {
                    if (context is not null)
                    {
                        context.Database.Migrate();
                    }
                    else Console.WriteLine($"Could not run migration context is null");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Could not run migration: {ex.Message}");

                }
            }

            if (context is not null)
            {
                if (!context.Platforms.Any())
                {
                    Console.WriteLine("--> Seeding Data");

                    context.Platforms.AddRange(
                        new Platform { Name = "Dot Net", Publisher = "Microsoft", Cost = "Free" },
                        new Platform { Name = "SQL Server Express", Publisher = "Microsoft", Cost = "Free" },
                        new Platform { Name = "Kubernetes", Publisher = "Clound Native Computing Foundation", Cost = "Free" }
                        );
                    context.SaveChanges();

                }
                else Console.WriteLine("--> We already have data");
            }
            else Console.WriteLine("--> No context already");
        }
    }
}