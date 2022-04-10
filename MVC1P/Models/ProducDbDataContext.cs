using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MVC1P.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC1P.Models
{
    public class ProducDbDataContext : DbContext
    {
        public ProducDbDataContext(DbContextOptions options) : base(options){}
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderLine> OrderLine { get; set; }

    }
}
