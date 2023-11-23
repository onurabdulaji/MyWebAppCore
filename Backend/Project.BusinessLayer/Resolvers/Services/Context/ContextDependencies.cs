using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Project.DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BusinessLayer.Resolvers.Services.Context
{
    public static class ContextDependencies
    {
        public static IServiceCollection ContextResolver(this IServiceCollection services)
        {
            ServiceProvider serviceProvider = services.BuildServiceProvider();
            IConfiguration configuration = serviceProvider.GetService<IConfiguration>();
            services.AddDbContextPool<MyContext>(opt =>
            {
                opt.UseSqlServer(configuration.GetConnectionString("MyConnection"))
                .UseLazyLoadingProxies();
            });

            return services;
        }
    }
}
