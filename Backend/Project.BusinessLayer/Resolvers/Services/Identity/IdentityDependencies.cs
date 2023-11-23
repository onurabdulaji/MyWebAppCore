using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Project.DataAccessLayer.Context;
using Project.EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BusinessLayer.Resolvers.Services.Identity
{
    public static class IdentityDependencies
    {
        public static IServiceCollection IdentityResolver(this IServiceCollection services)
        {

            services.AddIdentity<AppUser, AppRole>()
                .AddEntityFrameworkStores<MyContext>()
                .AddTokenProvider<DataProtectorTokenProvider<AppUser>>(TokenOptions.DefaultProvider)
                .AddEntityFrameworkStores<MyContext>();

            services.AddIdentityCore<AppUser>(opt =>
            {
                opt.SignIn.RequireConfirmedEmail = true;
            })
                .AddEntityFrameworkStores<MyContext>();


            return services;
        }
    }
}
