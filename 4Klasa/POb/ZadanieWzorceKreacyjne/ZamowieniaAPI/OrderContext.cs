using Microsoft.EntityFrameworkCore;

namespace ZamowieniaAPI;

public class OrderContext : DbContext
{
    public DbSet<Order> Orders { get; private set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=database.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Order>()
            .HasMany(e => e.Burgers)
            .WithOne(e => e.Order)
            .HasForeignKey(e => e.OrderId)
            .IsRequired();

        modelBuilder.Entity<Order>()
            .HasMany(e => e.Drinks)
            .WithOne(e => e.Order)
            .HasForeignKey(e => e.OrderId)
            .IsRequired();

        modelBuilder.Entity<Order>()
            .HasMany(e => e.Fries)
            .WithOne(e => e.Order)
            .HasForeignKey(e => e.OrderId)
            .IsRequired();
    }
}