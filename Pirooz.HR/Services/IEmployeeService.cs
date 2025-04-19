using Pirooz.HR.Entities;

namespace Pirooz.HR.Services
{
    public interface IEmployeeService
    {
        Task<List<EmployeeDto>> ListEmployeesAsync();
        Task<EmployeeDto> GetEmployeeByIdAsync(int id);
    }
}