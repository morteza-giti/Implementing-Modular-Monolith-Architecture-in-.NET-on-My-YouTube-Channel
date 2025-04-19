using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirooz.Marketing.Repositories
{
    public interface ICampaignRepository
    {
        Task<Campaign> GetByIdAsync(int id);
        Task<Campaign> ListAllAsync();
        Task AddAsync(Campaign campaign);
        Task UpdateAsync(Campaign campaign);
        Task DeleteAsync(Campaign campaign);
        Task<int> SaveChangesAsync();
    }
}
