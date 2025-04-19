using Pirooz.HR.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirooz.HR.Repositories
{
    public interface IEmployeeRepository
    {
        Task<Employee> GetByIdAsync(int id);
        Task<Employee> ListAllAsync();
        Task AddAsync(Employee employee);
        Task UpdateAsync(Employee employee);
        Task DeleteAsync(Employee employee);
        Task<int> SaveChangesAsync();
    }
}
