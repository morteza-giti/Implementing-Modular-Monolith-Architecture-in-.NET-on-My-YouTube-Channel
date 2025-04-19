using Ardalis.GuardClauses;
using System.Reflection.Metadata;
using System.Xml.Linq;

namespace Pirooz.HR;

public class Employee
{
    public int EmployeeId { get; private set; }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public DateTime DateOfHire { get; private set; }
    public string Position { get; private set; }
    public string DepartmentName { get; private set; }
    public decimal HourlyWage { get; private set; }

    public Employee(int employeeId, string firstName, string lastName, DateTime dateOfHire, string position, string departmentName, decimal hourlyWage)
    {
        EmployeeId = Guard.Against.NegativeOrZero(employeeId, nameof(employeeId));
        FirstName = Guard.Against.NullOrWhiteSpace(firstName, nameof(firstName));
        LastName = Guard.Against.NullOrWhiteSpace(lastName, nameof(lastName));
        DateOfHire = Guard.Against.OutOfSQLDateRange(dateOfHire, nameof(dateOfHire));
        Position = Guard.Against.NullOrWhiteSpace(position, nameof(position));
        DepartmentName = Guard.Against.NullOrWhiteSpace(departmentName, nameof(departmentName));
        HourlyWage = Guard.Against.OutOfRange(hourlyWage, nameof(hourlyWage), 10, 100);
    }
    public void UpdateHourlyWage(decimal newHourlyWage)
    {
        HourlyWage = Guard.Against.OutOfRange<decimal>(newHourlyWage, nameof(newHourlyWage), 10, 100);
    }
}
