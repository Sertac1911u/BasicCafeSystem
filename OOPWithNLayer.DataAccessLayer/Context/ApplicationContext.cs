using OOPWithNLayer.Entity.Concrete;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees;

namespace OOPWithNLayer.DataAccessLayer.Context
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}
