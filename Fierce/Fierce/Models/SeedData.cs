using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;

namespace Fierce.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Products.Any())
            {
                context.Products.AddRange(
        new Product { Name = "Fierce & Favored", Price = 28, Category = "Shirt" },
        new Product { Name = "Fierce Woman Entrepreneur", Price = 28, Category = "Shirt" },
        new Product { Name = "Fierce Definition", Price = 28, Category = "Shirt" },
        new Product { Name = "Fierce Woman of Faith", Price = 28, Category = "Shirt" },
        new Product { Name = "Fierce & Favored Sweatshirt", Price = 40, Category = "Sweatshirt" },
        new Product { Name = "Fierce Woman Entrepreneur Sweatshirt", Price = 40, Category = "Sweatshirt" },
        new Product { Name = "Fierce Definition Sweatshirt", Price = 40, Category = "Sweatshirt" },
        new Product { Name = "Fierce Woman of Faith Sweatshirt", Price = 40, Category = "Sweatshirt" },
        new Product { Name = "Fierce & Favored Hoodie", Price = 45, Category = "Hoodie" },
        new Product { Name = "Fierce Woman Entrepreneur Hoodie", Price = 45, Category = "Hoodie" },
        new Product { Name = "Fierce Definition Hoodie", Price = 45, Category = "Hoodie" },
        new Product { Name = "Fierce Woman of Faith Hoodie", Price = 45, Category = "Hoodie" }
                    );
                context.SaveChanges();
            }
        }
    }
}
