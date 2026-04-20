namespace SupesScrapbook.Application;
using Microsoft.Extensions.DependencyInjection;
using SupesScrapbook.Application.Services;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<ISupeService, SupeService>();
        return services;
    }
}