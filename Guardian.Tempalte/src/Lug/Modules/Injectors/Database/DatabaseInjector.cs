using Lug.Modules.Adapters.Database.Ef.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Lug.Modules.Injectors.Database;

public static class DatabaseInjector
{
    public static IServiceCollection AddDatabase(this IServiceCollection services)
    {
        var connectionString = AppEnv.DATABASE.POSTGRES.CONNECTION_STRING.NotNull();

        services.AddDbContext<ApplicationDbContext>(
            x => x.UseNpgsql(connectionString)
        );

        return services;
    }
}
