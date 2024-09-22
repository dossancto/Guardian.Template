using Lug.Modules.Injectors.Database;

namespace Lug.Modules.Injectors.General;

public static class CommumInjector
{
    public static IServiceCollection AddCommumModule(this IServiceCollection services)
      => services
            .AddDatabase()
      ;
}
