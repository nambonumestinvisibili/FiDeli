using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiDeli.Infrastructure
{
    public static class MediatrServiceCollectionExtension
    {
        public static IServiceCollection RegisterHandlers(this IServiceCollection services)
        {



            services.AddMediatR(typeof(Handler1).Assembly);
            return services;
        }
    }
}
