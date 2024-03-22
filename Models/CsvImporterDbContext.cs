using Microsoft.EntityFrameworkCore;

namespace CsvImporter.Models;

public class CsvImporterDbContext : DbContext
{
    public CsvImporterDbContext(DbContextOptions<CsvImporterDbContext> options)
        : base(options)
    {
    }

    public DbSet<OrderDetails> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<OrderDetails>()
            .Property(e => e.OrderDetailsId)
            .HasColumnName("order_details_id");

        modelBuilder.Entity<OrderDetails>()
            .Property(e => e.OrderId)
            .HasColumnName("order_id");

        modelBuilder.Entity<OrderDetails>()
            .Property(e => e.PizzaId)
            .HasColumnName("pizza_id");

        modelBuilder.Entity<OrderDetails>()
            .Property(e => e.Quantity)
            .HasColumnName("quantity");
    }
}