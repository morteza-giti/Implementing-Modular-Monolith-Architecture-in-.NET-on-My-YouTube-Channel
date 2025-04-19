using FastEndpoints;

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
        var campaignList = campaignService.ListCampaigns();
        await SendAsync(campaignList.ToList());
    }
}