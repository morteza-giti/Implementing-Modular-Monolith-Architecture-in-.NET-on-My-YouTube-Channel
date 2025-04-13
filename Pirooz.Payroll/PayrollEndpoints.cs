using Microsoft.AspNetCore.Builder;

namespace Pirooz.Payroll;

internal static class PayrollEndpoints
{
    public static void MapPayrollEndpoints(this WebApplication app)
    {
        app.MapGet("/payroll/invoices", (InvoiceService invoiceService) =>
        {
            return invoiceService.ListInvoices();
        });
    }
}