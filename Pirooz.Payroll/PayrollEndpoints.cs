using FastEndpoints;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pirooz.Payroll.Services;

namespace Pirooz.Payroll;

public static class PayrollEndpoints
{
    public static void MapPayrollEndpoints(this WebApplication app)
    {
        app.MapGet("/payroll/invoices", async ([FromServices] IInvoiceService invoiceService) =>
        {
            var invoices = await invoiceService.ListInvoicesAsync();
            return Results.Ok(invoices);
        });
    }
}

