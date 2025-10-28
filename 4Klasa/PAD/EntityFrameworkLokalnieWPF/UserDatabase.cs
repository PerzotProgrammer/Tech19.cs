using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkLokalnieWPF;

public class UserDatabase : DbContext
{
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Server=localhost; Database=UsersDatabase; User Id=sa; Password=zaq1@WSX; Trusted_Connection=false; MultipleActiveResultSets=true;TrustServerCertificate=true");
    }
}

public class User
{
    public int? Id { get; init; }
    public required string FirstName { get; init; }
    public required string SecondName { get; init; }
}