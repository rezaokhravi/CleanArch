using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArch.Data.Repositories;
using CleanArch.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArch.IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection  RegisterService(this IServiceCollection  services)
        {
           #region Application Layer
            
           #endregion

           #region Persistence Layer
             services.AddScoped<IUserRepository,UserRepository>();
           #endregion

            return services;
        }
    }
}