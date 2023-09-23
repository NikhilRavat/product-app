using Microsoft.EntityFrameworkCore;
using ProductApi.Models.Data;

namespace ProductApi.Models
{
    public class NikhilDBContext : DbContext
    {
        public NikhilDBContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Products> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Products>().HasData(new List<Products>()
            {
                new Products{ProductId = 1, ProductName = "Dotnet Core Book",Price = 100,Author="Nikhil Ravat"},
                new Products{ProductId = 2, ProductName = "Angular Book",Price = 200,Author="Shamal Gabu"}
            });
        }
    }
}
