using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
namespace Pirooz.HR;
public static class HREndpoints
    {
        public static void MapHREndpoints(this WebApplication app)
        {
            app.MapGet("/hr/employees", ([FromServices] IEmployeeService employeeService) =>
            {
                return employeeService.ListEmployees();
            });
        }
    }

