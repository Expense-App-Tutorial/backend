using backend.Database.Interceptors;
using Microsoft.EntityFrameworkCore;

namespace backend.Configurations;

public static class PostgresConfig
{
    public static IServiceCollection AddPostgres(
        this IServiceCollection services,
        IConfiguration configuration
    )
    {
        var connectionString =
            configuration["CONNECTION_STRING"]
            ?? throw new InvalidOperationException("Connection string is missing.");

        services.AddDbContext<AppDbContext>(options => options.UseNpgsql(connectionString));

        return services;
    }
}
