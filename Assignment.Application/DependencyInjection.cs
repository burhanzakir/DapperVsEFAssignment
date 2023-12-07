namespace Assignment.Application
{
    using Assignment.Application.Interfaces;
    using Assignment.Application.Services;
    using Microsoft.Extensions.DependencyInjection;
    using System.Reflection;
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();

            return services;
        }
    }
}
