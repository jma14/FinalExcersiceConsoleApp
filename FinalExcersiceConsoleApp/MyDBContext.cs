using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExcersiceConsoleApp
{
    public class MyDBContext : DbContext
    {
        public MyDBContext() : base("MyDBContext") { }
        public virtual DbSet<Pizza> Pizzas { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
    }
}
