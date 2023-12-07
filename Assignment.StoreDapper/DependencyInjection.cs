using Assignment.Domain.Interfaces;
using Assignment.StoreDapper.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.StoreDapper
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureDapper(this IServiceCollection services, IConfiguration configuration)
        {
            var defaultConnectionString = configuration.GetConnectionString("DefaultConnection");
            services.AddSingleton(new DbContextStore(defaultConnectionString));

            services.AddScoped<IProductRepository, ProductRepository>();

            return services;
        }
    }
}
