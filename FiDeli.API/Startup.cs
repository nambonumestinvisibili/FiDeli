using FiDeli.Infrastructure;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using AutoMapper;
using FiDeli.Domain.EventBus.Interfaces.Validators;
using FluentValidation;
using FluentValidation.AspNetCore;

namespace FiDeli.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //assemblies
            var InfraAssembly = Assembly.GetAssembly(typeof(FiDeli.Infrastructure.ServiceCollectionExtensions));
            var DomainAssembly = Assembly.GetAssembly(typeof(FiDeli.Domain.Person));
            var ApplicationAssembly = Assembly.GetAssembly(typeof(FiDeli.Application.Services.Interfaces.RepositoryInterfaces.ICommissionRepo));


            services.AddControllers()
                .AddFluentValidation(fv => {
                    fv.RegisterValidatorsFromAssemblyContaining(typeof(Startup));
                    fv.RegisterValidatorsFromAssembly(ApplicationAssembly);

                });
            
            //data
            services.RegisterDataService(Configuration);

            
            //communication
            //todo: make it cleaner -=> what if classess change?
            services.AddMediatR(typeof(Startup).Assembly);
            services.AddMediatR(InfraAssembly);
            services.AddMediatR(DomainAssembly);
            services.AddMediatR(ApplicationAssembly);

            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));
          
            //mapping
            services.AddAutoMapper(typeof(Startup).Assembly, ApplicationAssembly);


            //swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "FiDeli.API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "FiDeli.API v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
