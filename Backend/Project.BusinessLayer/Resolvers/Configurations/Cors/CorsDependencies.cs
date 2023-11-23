using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BusinessLayer.Resolvers.Configurations.Cors
{
    public static class CorsDependencies
    {
        public static IConfiguration CorsResolver(this IConfiguration configuration)
        {
            return configuration;
        }
    }
}
