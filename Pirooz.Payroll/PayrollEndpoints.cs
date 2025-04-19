using FastEndpoints;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;

namespace Pirooz.Payroll;

public static class PayrollEndpoints
{
    public static void MapPayrollEndpoints(this WebApplication app)
    {
        app.MapGet("/payroll/invoices", ([FromServices] IInvoiceService invoiceService) =>
        {
            return invoiceService.ListInvoices();
        });
    }
}

