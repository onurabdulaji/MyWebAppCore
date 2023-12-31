﻿using Microsoft.Extensions.DependencyInjection;
using Project.BusinessLayer.ManagerServices.Abstracts;
using Project.BusinessLayer.ManagerServices.Concretes;
using Project.DataAccessLayer.Repositories.Abstracts;
using Project.DataAccessLayer.Repositories.Concretes;

namespace Project.BusinessLayer.Resolvers.Services.Repositories
{
    public static class RepositoriesDependencies
    {
        public static IServiceCollection RepositoryResolver(this IServiceCollection services)
        {
            // Bases

            services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            services.AddScoped(typeof(IManager<>), typeof(BaseManager<>));

            //  Dependencies 

            services.AddScoped<IAppUserManager, AppUserManager>();
            services.AddScoped<IAppUserRepository, AppUserRepository>();

            services.AddScoped<IAppRoleManager, AppRoleManager>();
            services.AddScoped<IAppRoleRepository, AppRoleRepository>();

            services.AddScoped<IAboutManager, AboutManager>();
            services.AddScoped<IAboutRepository, AboutRepository>();

            services.AddScoped<IContactManager, ContactManager>();
            services.AddScoped<IContactRepository, ContactRepository>();

            services.AddScoped<IMyClientManager, MyClientManager>();
            services.AddScoped<IMyClientRepository, MyClientRepository>();

            services.AddScoped<IServiceManager, ServiceManager>();
            services.AddScoped<IServiceRepository, ServiceRepository>();

            services.AddScoped<ITestimonialManager, TestimonialManager>();
            services.AddScoped<ITestimonialRepository, TestimonialRepository>();

            services.AddScoped<IWorkManager, WorkManager>();
            services.AddScoped<IWorkRepository, WorkRepository>();



            return services;
        }
    }
}
