using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Demo4.Models
{
    public class AppDbContext : DbContext
    {
        protected AppDbContext() : base("name=myConnection")
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
    }
}