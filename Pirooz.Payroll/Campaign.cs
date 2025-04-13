namespace Pirooz.Payroll;

public class Campaign
{
    public int CampaignId { get; set; }
    public string Title { get; set; }
    public DateTime StartDate { get; set; }
    public decimal Budget { get; set; }
    public string TargetAudience { get; set; }
}
