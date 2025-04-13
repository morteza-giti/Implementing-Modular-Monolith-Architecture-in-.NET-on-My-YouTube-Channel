using Microsoft.AspNetCore.Builder;
namespace Pirooz.HR;
internal static class HREndpoints
    {
        public static void MapHREndpoints(this WebApplication app)
        {
            app.MapGet("/hr/employees", (EmployeeService employeeService) =>
            {
                return employeeService.ListEmployees();
            });
        }
    }

