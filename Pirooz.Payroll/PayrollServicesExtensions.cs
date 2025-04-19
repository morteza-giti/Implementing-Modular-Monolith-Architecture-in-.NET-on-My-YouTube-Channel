using Microsoft.Extensions.DependencyInjection;
using Pirooz.HR.Services;
using Pirooz.Payroll.Repositories;
using Pirooz.Payroll.Services;
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
            services.AddScoped<IInvoiceService, HardCodedInvoiceService>();
            //services.AddScoped<IInvoiceRepository, InvoiceRepository>();
            return services;
        }
    }
}
