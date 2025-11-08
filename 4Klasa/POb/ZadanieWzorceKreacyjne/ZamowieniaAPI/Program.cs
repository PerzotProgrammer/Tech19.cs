using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace ZamowieniaAPI;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddDbContext<OrderContext>();
        builder.Services.AddControllers()
            .AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
                options.JsonSerializerOptions.WriteIndented = true;
                options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
            });
        ;
        var app = builder.Build();
        app.MapControllers();

        app.Run();
    }
}