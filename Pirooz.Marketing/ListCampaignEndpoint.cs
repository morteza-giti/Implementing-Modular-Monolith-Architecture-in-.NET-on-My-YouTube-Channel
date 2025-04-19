using FastEndpoints;
using Pirooz.Marketing.Entities;
using Pirooz.Marketing.Services;

namespace Pirooz.Marketing;

public class ListCampaignEndpoint : EndpointWithoutRequest<List<CampaignDto>>
{
    private readonly ICampaignService campaignService;

    public ListCampaignEndpoint(ICampaignService campaignService)
    {
        this.campaignService = campaignService;
    }
    public override void Configure()
    {
        Get("/api/marketing/campaigns");
        AllowAnonymous();
    }
    public override async Task HandleAsync(CancellationToken ct)
    {
        var campaigns = await campaignService.ListCampaignsAsync();
        await SendAsync(campaigns);
    }
}