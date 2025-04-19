﻿using FastEndpoints;
namespace Pirooz.HR;

public class ListEmployeeEndpoint : EndpointWithoutRequest<List<EmployeeDto>>
{
    private readonly IEmployeeService employeeService;

    public ListEmployeeEndpoint(IEmployeeService employeeService)
    {
        this.employeeService = employeeService;
    }
    public override void Configure()
    {
        Get("/api/hr/employees");
        AllowAnonymous();
    }
    public override async Task HandleAsync(CancellationToken ct)
    {
        var employees = employeeService.ListEmployees();
        await SendAsync(employees.ToList());
    }
}

