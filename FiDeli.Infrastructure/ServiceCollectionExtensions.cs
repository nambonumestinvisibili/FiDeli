using FiDeli.Infrastructure.Repos;
using FiDeli.Infrastructure.Repos.Database;
using FiDeli.Infrastructure.Repos.IMRepos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiDeli.Infrastructure
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection RegisterDataService(this IServiceCollection services, IConfiguration configuration)
        {

            //services.AddDbContext<FiDeliContext>(o =>
            //{
            //    o.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            //});

            services.AddScoped<IDelivererRepo, IMDelivererRepo>();
            return services;
        }
    }
}
