using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace test.Data
{
    public class DutchContent: DbContext
    {
      public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
