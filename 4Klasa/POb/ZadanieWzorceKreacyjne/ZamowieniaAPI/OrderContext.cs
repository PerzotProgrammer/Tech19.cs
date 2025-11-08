using Microsoft.EntityFrameworkCore;

namespace ZamowieniaAPI;

public class OrderContext : DbContext
{
    public DbSet<OrderDTO> Orders { get; private set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=database.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<OrderDTO>()
            .HasMany(e => e.Burgers);

        modelBuilder.Entity<OrderDTO>()
            .HasMany(e => e.Drinks);

        modelBuilder.Entity<OrderDTO>()
            .HasMany(e => e.Fries);
        
    }
}