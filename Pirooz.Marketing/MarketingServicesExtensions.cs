using Microsoft.Extensions.DependencyInjection;
using Pirooz.Marketing.Repositories;
using Pirooz.Marketing.Services;
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
            //services.AddScoped<ICampaignRepository, CampaignRepository>();
            return services;
        }
    }
}
