using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fierce.Models
{
    interface IProductRepository
    {
        IQueryable<Product> Products { get; }
    }
}
