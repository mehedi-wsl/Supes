namespace Supescrapbook.Application;
using Microsoft.Extensions.DependencyInjection;
using Supescrapbook.Application.Services;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<ISupeService, SupeService>();
        return services;
    }
}