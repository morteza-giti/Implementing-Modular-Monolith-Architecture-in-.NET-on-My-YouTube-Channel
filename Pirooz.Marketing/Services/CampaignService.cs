using Pirooz.Marketing.Entities;
using Pirooz.Marketing.Repositories;

namespace Pirooz.Marketing.Services;

internal class CampaignService : ICampaignService
{
    private readonly ICampaignRepository campaignRepository;

    public CampaignService(ICampaignRepository campaignRepository)
    {
        this.campaignRepository = campaignRepository;
    }

    public async Task<CampaignDto> GetCampaignByIdAsync(int id)
    {
        var campaign = await campaignRepository.GetByIdAsync(id);
        if (campaign == null)
        {
            return null;
        }

        return new CampaignDto(
            campaign.CampaignId,
            campaign.Title,
            campaign.StartDate,
            campaign.Budget,
            campaign.TargetAudience
        );
    }
    public async Task<List<CampaignDto>> ListCampaignsAsync()
    {
        var campaigns = await campaignRepository.ListAllAsync();

        var campaignDtos = campaigns.Select(c => new CampaignDto(
            c.CampaignId,
            c.Title,
            c.StartDate,
            c.Budget,
            c.TargetAudience
        )).ToList();

        return campaignDtos;
    }
}