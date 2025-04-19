using Pirooz.Marketing.Entities;

namespace Pirooz.Marketing.Services;

internal class HardCodedCampaignService : ICampaignService
{
    private readonly List<Campaign> _campaigns = new()
    {
        new Campaign(1, "Emails", new DateTime(2024, 12, 1), 15m, "Active Users"),
        new Campaign(2, "Messages", new DateTime(2024, 12, 2), 14m, "Active Users"),
        new Campaign(3, "Promotions", new DateTime(2024, 12, 3), 13m, "Active Users")
    };

    public Task<CampaignDto> GetCampaignByIdAsync(int id)
    {
        var campaign = _campaigns.FirstOrDefault(c => c.CampaignId == id);

        if (campaign == null)
            return Task.FromResult<CampaignDto>(null);

        var dto = MapToDto(campaign);
        return Task.FromResult(dto);
    }

    public Task<List<CampaignDto>> ListCampaignsAsync()
    {
        var dtoList = _campaigns.Select(MapToDto).ToList();
        return Task.FromResult(dtoList);
    }

    private CampaignDto MapToDto(Campaign campaign)
    {
        return new CampaignDto(
            campaign.CampaignId,
            campaign.Title,
            campaign.StartDate,
            campaign.Budget,
            campaign.TargetAudience
        );
    }
}