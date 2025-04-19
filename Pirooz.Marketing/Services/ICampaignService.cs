using Pirooz.Marketing.Entities;

namespace Pirooz.Marketing.Services
{
    public interface ICampaignService
    {
        Task<List<CampaignDto>> ListCampaignsAsync();
        Task<CampaignDto> GetCampaignByIdAsync(int id);
    }
}