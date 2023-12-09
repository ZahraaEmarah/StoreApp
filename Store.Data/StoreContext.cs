using Microsoft.EntityFrameworkCore;
using Store.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(){}
        public StoreContext(DbContextOptions<StoreContext> options)
            : base(options){}
        public DbSet<User> User { get; set; }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Product> Product { get; set; }
    }
}
