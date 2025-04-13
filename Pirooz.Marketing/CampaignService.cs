namespace Pirooz.Marketing;

internal class CampaignService : ICampaignService
{
    public List<CampaignDto> ListCampaigns()
    {
        return new List<CampaignDto>()
         {
             new CampaignDto(1, "Emails" , DateTime.Now ,15,"Active Users" ),
             new CampaignDto(1,"Messages" , DateTime.Now ,14,"Active Users"),
             new CampaignDto(1, "Promotions", DateTime.Now ,13,"Active Users")
         };
    }
}
