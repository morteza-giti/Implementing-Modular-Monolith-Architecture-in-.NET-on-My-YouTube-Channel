using Pirooz.HR.Entities;
using Pirooz.HR.Repositories;

namespace Pirooz.HR.Services;

internal class EmployeeService : IEmployeeService
{
    private readonly IEmployeeRepository employeeRepository;

    public EmployeeService(IEmployeeRepository employeeRepository)
    {
        this.employeeRepository = employeeRepository;
    }

    public async Task<EmployeeDto> GetEmployeeByIdAsync(int id)
    {
        var employee = await employeeRepository.GetByIdAsync(id);
        if (employee == null)
        {
            return null;
        }

        return new EmployeeDto(employee.EmployeeId, $"{employee.FirstName} {employee.LastName}", employee.DateOfHire, employee.Position, employee.DepartmentName);
    }

    public async Task<List<EmployeeDto>> ListEmployeesAsync()
    {
        //TODO: implement this
        return new List<EmployeeDto>();
    }
}

