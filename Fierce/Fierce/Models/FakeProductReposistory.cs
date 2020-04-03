using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fierce.Models
{
    public class FakeProductReposistory : IProductRepository
    {
        public IQueryable<Product> Products => new List<Product> {
        new Product { Name = "Fierce & Favored", Price = 28 },
        new Product { Name = "Fierce Woman Entrepreneur", Price = 28 },
        new Product { Name = "Fierce Definition", Price = 28 },
        new Product { Name = "Fierce Woman of Faith" , Price = 28}
        }.AsQueryable<Product>();
    }
}
