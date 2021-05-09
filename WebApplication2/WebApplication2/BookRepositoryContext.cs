using Microsoft.EntityFrameworkCore;
using WebApplication2.Entities.Configs;
using WebApplication2.Models;

namespace WebApplication2
{
    public class BookRepositoryContext: DbContext
    {

        private const string Connection =
            "Data Source=(local);Initial Catalog=BookRepositoryDB;Integrated Security=True";

        //public DbSet<BookModel> Books { get; set; }
        public DbSet<CategoryModel> CategoryModels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Connection);
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new BookConfig());
            modelBuilder.ApplyConfiguration(new CategoryConfig());
        }

    }
}