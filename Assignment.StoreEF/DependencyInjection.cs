using Assignment.Domain.Interfaces;
using Assignment.StoreEF.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.StoreEF
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureEF(this IServiceCollection services, IConfiguration configuration)
        {
            var defaultConnectionString = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<DbContextStore>(options =>
               options.UseSqlServer(defaultConnectionString));

            services.AddAutoMapper(Assembly.GetExecutingAssembly());           
            services.AddScoped<IProductRepository, ProductRepository>();

            return services;
        }
    }
}
