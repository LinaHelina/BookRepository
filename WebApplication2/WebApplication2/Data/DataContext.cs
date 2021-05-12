using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        private const string Connection =
            "Data Source=(local);Initial Catalog=DatabaseAAA;Integrated Security=True";

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<ProductDetails> ProductDetails { get; set; }
        public DbSet<CustomerShippingAddresses> CustomerShippingAddresses { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Cart> Cart { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Connection);

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.SeedProducts();
            //modelBuilder.SeedProductDetails();
        }

    }
}