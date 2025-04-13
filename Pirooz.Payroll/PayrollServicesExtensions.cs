using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirooz.Payroll
{
    public static class PayrollServicesExtensions
    {
        public static IServiceCollection AddPayrollServices(this IServiceCollection services)
        {
            services.AddScoped<IInvoiceService, InvoiceService>();
            return services;
        }
    }
}
