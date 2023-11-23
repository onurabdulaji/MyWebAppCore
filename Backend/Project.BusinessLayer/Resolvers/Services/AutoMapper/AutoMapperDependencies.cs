using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BusinessLayer.Resolvers.Services.AutoMapper
{
    public static class AutoMapperDependencies
    {
        public static IServiceCollection MapperResolver(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AutoMapperDependencies));
            return services;
        }
    }
}
