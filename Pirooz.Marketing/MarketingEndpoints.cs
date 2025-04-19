using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pirooz.Marketing.Services;

namespace Pirooz.Marketing;

public static class MarketingEndpoints
{
    public static void MapMarketingEndpoints(this WebApplication app)
    {
        app.MapGet("/marketing/campaigns", async ([FromServices] ICampaignService campaignService) =>
        {
            var campaigns = await campaignService.ListCampaignsAsync();
            return Results.Ok(campaigns);
        });
    }
}
