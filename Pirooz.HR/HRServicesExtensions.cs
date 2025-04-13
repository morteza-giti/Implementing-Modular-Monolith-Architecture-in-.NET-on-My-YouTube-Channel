using Microsoft.Extensions.DependencyInjection;
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
            return services;
        }
    }
}
