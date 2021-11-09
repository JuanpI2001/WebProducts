﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebProducts.Models;
using System.Data.Entity;
namespace WebProducts.Data
{
    public class ProductDbContext:DbContext
    {
        public ProductDbContext() : base("KeyDB") { }
        public DbSet<Product> Products { get; set; }
    }
}