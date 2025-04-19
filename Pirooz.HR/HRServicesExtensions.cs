using Microsoft.Extensions.DependencyInjection;
using Pirooz.HR.Repositories;
using Pirooz.HR.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirooz.HR
{
    public static class HRServicesExtensions
    {
        public static IServiceCollection AddHRServices(this IServiceCollection services)
        {
            services.AddScoped<IEmployeeService, EmployeeService>();
            //services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            return services;
        }
    }
}
