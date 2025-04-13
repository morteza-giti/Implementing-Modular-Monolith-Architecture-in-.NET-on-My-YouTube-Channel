using Microsoft.AspNetCore.Builder;

namespace Pirooz.Marketing;

internal static class MarketingEndpoints
{
    public static void MapMarketingEndpoints(this WebApplication app)
    {
        app.MapGet("/marketing/campaigns", (CampaignService campaignService) =>
        {
            return campaignService.ListCampaigns();
        });
    }
}