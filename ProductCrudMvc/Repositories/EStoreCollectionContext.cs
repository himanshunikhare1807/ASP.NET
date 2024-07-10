using Microsoft.EntityFrameworkCore;
using ProductCrudMvc.Models;

namespace ProductCrudMvc.Repositories
{
    public class EStoreCollectionContext : DbContext
    {
        public DbSet<Product> products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string ConnectionString = @"server=localhost;port=3306;username=root;password=root123;database=db";

            optionsBuilder.UseMySQL(ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Title).IsRequired();
                entity.Property(e => e.Description).IsRequired();
                entity.Property(e => e.UnitePrice).IsRequired();
                entity.Property(e => e.ImageUrl).IsRequired();
                entity.Property(e => e.Quantity).IsRequired();
            });
            modelBuilder.Entity<Product>().ToTable("product");
        }
    }
}
