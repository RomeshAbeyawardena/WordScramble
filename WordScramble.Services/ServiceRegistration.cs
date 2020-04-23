using AutoMapper;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WordScramble.Contracts;
using WordScramble.Domains;

namespace WordScramble.Services
{
    public class ServiceRegistration : IServiceRegistration
    {
        public void RegisterServices(IServiceCollection services)
        {
            services
                .AddSingleton<ApplicationSettings>()
                .AddSingleton<Random>();

            services.Scan(scan => scan
                .FromAssembliesOf(typeof(ServiceRegistration))
                .AddClasses(classes => classes
                    .Where(type => type.Name.EndsWith("Service") 
                               || type.Name.EndsWith("Generator")))
                .AsMatchingInterface());

            services.AddAutoMapper(Assembly.GetAssembly(typeof(ApplicationSettings)));
            services.AddMediatR(Assembly
                .GetAssembly(typeof(ServiceRegistration)));
        }
    }
}
