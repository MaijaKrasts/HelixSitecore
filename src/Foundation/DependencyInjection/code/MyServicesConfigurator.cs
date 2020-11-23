using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.Foundation.DependencyInjection
{
    public class MyServicesConfigurator : IServicesConfigurator
    {
        // You use the IServicesConfigurator interface to configure services from code.

        public void Configure(IServiceCollection serviceCollection)
        {
            //default example:
            //serviceCollection.AddScoped(typeof(IMyService), typeof(MyServiceImplementation));
            //serviceCollection.AddTransient(typeof(MyServiceBase), typeof(MyServiceBaseImplementation));
        }
    }
}