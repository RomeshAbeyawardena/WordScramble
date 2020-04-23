using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using WordScramble.Contracts;

namespace WordScramble.Broker
{
    public sealed class AppServiceBroker : ServiceBroker
    {
        private AppServiceBroker()
        {
            Assemblies = new [] { Assembly.GetAssembly(typeof(AppServiceBroker)) };
        }

    }

    public abstract class ServiceBroker
    {
        public IEnumerable<Assembly> Assemblies { get; protected set; }

        public static void RegisterServices<TServiceBroker>(IServiceCollection services)
            where TServiceBroker : ServiceBroker
        {
            Activator
                .CreateInstance<TServiceBroker>()
                .RegisterServices(services);
        }

        public void RegisterServices(IServiceCollection services)
        {
            foreach (var assembly in Assemblies)
            {
                var types = assembly.GetTypes();
                var serviceRegistrationTypes = types.Where(type => type
                    .GetInterface(nameof(IServiceRegistration), false) != null);

                foreach(var serviceRegistrationType in serviceRegistrationTypes)
                {
                    var serviceRegistration = Activator.CreateInstance(serviceRegistrationType) as IServiceRegistration;
                    serviceRegistration.RegisterServices(services);
                }
            }
        }
    }
}
