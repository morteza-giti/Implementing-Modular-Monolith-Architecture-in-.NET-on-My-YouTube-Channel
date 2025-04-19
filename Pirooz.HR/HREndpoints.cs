using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pirooz.HR.Services;
namespace Pirooz.HR;
public static class HREndpoints
{
    public static void MapHREndpoints(this WebApplication app)
    {
        app.MapGet("/hr/employees", async ([FromServices] IEmployeeService employeeService) =>
        {
            var employees = await employeeService.ListEmployeesAsync();
            return Results.Ok(employees);
        });
    }
}

