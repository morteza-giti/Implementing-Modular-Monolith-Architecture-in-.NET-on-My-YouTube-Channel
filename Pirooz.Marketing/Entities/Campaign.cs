using Ardalis.GuardClauses;
using System;

namespace Pirooz.Marketing.Entities;

public class Campaign
{
    public int CampaignId { get; private set; }
    public string Title { get; private set; }
    public DateTime StartDate { get; private set; }
    public decimal Budget { get; private set; }
    public string TargetAudience { get; private set; }

    public Campaign(int campaignId, string title, DateTime startDate, decimal budget, string targetAudience)
    {

        CampaignId = Guard.Against.NegativeOrZero(campaignId, nameof(campaignId));
        Title = Guard.Against.NullOrWhiteSpace(title, nameof(title));
        StartDate = Guard.Against.OutOfSQLDateRange(startDate, nameof(startDate));
        Budget = Guard.Against.NegativeOrZero(budget, nameof(budget));
        TargetAudience = Guard.Against.NullOrWhiteSpace(targetAudience, nameof(targetAudience));
    }
}


