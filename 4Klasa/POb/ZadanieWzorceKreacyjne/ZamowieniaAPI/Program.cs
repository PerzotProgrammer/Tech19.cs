using Microsoft.EntityFrameworkCore;

namespace ZamowieniaAPI;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddDbContext<OrderContext>();
        builder.Services.AddControllers();
        var app = builder.Build();
        app.MapControllers();
        
        app.Run();
    }
}