using System.Reflection;
using E_Commerce.Service.Services;
using Microsoft.Extensions.DependencyInjection;
namespace E_Commerce.Service.DependencyInjection;

public static class ApplicationServiceExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<IProductService, ProductService>();
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        return services;
    }
}
