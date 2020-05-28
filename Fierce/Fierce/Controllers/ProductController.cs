﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Fierce.Models;

namespace Fierce.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repository;
        public ProductController(IProductRepository repo)
        {
            repository = repo;
        }
        public ViewResult List(int productPage = 1)
    => View(repository.Products.OrderBy(p => p.ProductID)
     .Skip((productPage - 1) * PageSize)
    .Take(PageSize));
    }
}