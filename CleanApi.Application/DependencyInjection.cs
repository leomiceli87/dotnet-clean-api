using CleanApi.Application.Interfaces;
using CleanApi.Application.UseCases;
using CleanApi.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace CleanApi.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IUseCase<IEnumerable<Product>>, GetAllProductsUseCase>();
        return services;
    }
}
