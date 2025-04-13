using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirooz.Marketing
{
    public static class MarketingServicesExtensions
    {
        public static IServiceCollection AddMarketingServices(this IServiceCollection services)
        {
            services.AddScoped<ICampaignService, CampaignService>();
            return services;
        }
    }
}
