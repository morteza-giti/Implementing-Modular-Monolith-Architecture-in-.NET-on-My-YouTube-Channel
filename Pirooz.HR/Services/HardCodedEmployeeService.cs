
using Pirooz.HR.Entities;

namespace Pirooz.HR.Services;

internal class HardCodedEmployeeService : IEmployeeService
{
    private readonly List<Employee> _employees = new()
    {
        new Employee(1, "Alice", "Johnson", new DateTime(2020, 5, 10), "Developer", "IT", 45.5m),
        new Employee(2, "Bob", "Smith", new DateTime(2019, 3, 22), "Manager", "HR", 55.0m),
        new Employee(3, "Charlie", "Brown", new DateTime(2021, 8, 15), "Analyst", "Finance", 40.0m)
    };
    public Task<EmployeeDto> GetEmployeeByIdAsync(int id)
    {
        var employee = _employees.FirstOrDefault(e => e.EmployeeId == id);

        if (employee == null)
            return Task.FromResult<EmployeeDto>(null);

        var dto = MapToDto(employee);
        return Task.FromResult(dto);
    }

    public Task<List<EmployeeDto>> ListEmployeesAsync()
    {
        var dtoList = _employees.Select(MapToDto).ToList();
        return Task.FromResult(dtoList);
    }
    private EmployeeDto MapToDto(Employee employee)
    {
        return new EmployeeDto(
            employee.EmployeeId,
            $"{employee.FirstName} {employee.LastName}",
            employee.DateOfHire,
            employee.Position,
            employee.DepartmentName
        );
    }
}

