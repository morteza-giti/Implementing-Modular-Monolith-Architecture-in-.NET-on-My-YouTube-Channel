namespace Pirooz.HR;

internal class EmployeeService : IEmployeeService
{
    public List<EmployeeDto> ListEmployees()
    {
        return new List<EmployeeDto>()
            {
                new EmployeeDto(1, "Morteza Giti", DateTime.Now ,"Web Developer","AppDev" ),
                new EmployeeDto(1, "John Smith", DateTime.Now ,"Web Developer","AppDev" ),
                new EmployeeDto(1, "Alex Wendy", DateTime.Now ,"Web Developer","AppDev" )
            };
    }
}

