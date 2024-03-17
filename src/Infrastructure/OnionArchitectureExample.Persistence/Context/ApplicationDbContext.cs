using Microsoft.EntityFrameworkCore;
using OnionArchitectureExample.Domain.Entities;

namespace OnionArchitectureExample.Persistence.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = Guid.Parse("6f128010-5d73-49ec-9c71-9aa28bbd13bb"), Name = "Product 1", Value = 10, Quantity = 100 },
                new Product { Id = Guid.NewGuid(), Name = "Product 2", Value = 120, Quantity = 100 },
                new Product { Id = Guid.NewGuid(), Name = "Product 3", Value = 1, Quantity = 100 });
            base.OnModelCreating(modelBuilder);
        }
    }
}
