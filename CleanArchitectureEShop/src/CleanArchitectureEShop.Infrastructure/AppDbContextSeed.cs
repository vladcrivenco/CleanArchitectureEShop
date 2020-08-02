using CleanArchitectureEShop.Core.Entities.CatalogAggregate;
using CleanArchitectureEShop.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureEShop.Infrastructure
{
    public class AppDbContextSeed
    {
        public static async Task SeedAsync(AppDbContext appContext)
        {
            // context.Database.Migrate();
            if (!await appContext.CatalogItems.AnyAsync())
            {
                await appContext.CatalogItems.AddRangeAsync(
                    GetPreconfiguredItems());

                await appContext.SaveChangesAsync();
            }
        }

        static IEnumerable<CatalogItem> GetPreconfiguredItems()
        {
            return new List<CatalogItem>()
            {
                new CatalogItem(".NET Bot Black Sweatshirt", ".NET Bot Black Sweatshirt", 19.5M,  "http://catalogbaseurltobereplaced/images/products/1.png"),
                new CatalogItem(".NET Black & White Mug", ".NET Black & White Mug", 8.50M, "http://catalogbaseurltobereplaced/images/products/2.png"),
                new CatalogItem("Prism White T-Shirt", "Prism White T-Shirt", 12,  "http://catalogbaseurltobereplaced/images/products/3.png"),

            };
        }
    }
}
