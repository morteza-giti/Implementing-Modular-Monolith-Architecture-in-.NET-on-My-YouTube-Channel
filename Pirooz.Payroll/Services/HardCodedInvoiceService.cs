using Pirooz.Payroll.Services;
using Pirooz.Payroll.Entities;

namespace Pirooz.HR.Services;

internal class HardCodedInvoiceService : IInvoiceService
{
    private readonly List<Invoice> _invoices = new()
    {
        new Invoice(1, 12m, new DateTime(2024, 12, 1), "Pending"),
        new Invoice(2, 13m, new DateTime(2024, 12, 2), "Complete"),
        new Invoice(3, 14m, new DateTime(2024, 12, 3), "Pending")
    };

    public Task<InvoiceDto> GetInvoiceByIdAsync(int id)
    {
        var invoice = _invoices.FirstOrDefault(i => i.InvoiceId == id);

        if (invoice == null)
            return Task.FromResult<InvoiceDto>(null);

        var dto = MapToDto(invoice);
        return Task.FromResult(dto);
    }

    public Task<List<InvoiceDto>> ListInvoicesAsync()
    {
        var dtoList = _invoices.Select(MapToDto).ToList();
        return Task.FromResult(dtoList);
    }

    private InvoiceDto MapToDto(Invoice invoice)
    {
        return new InvoiceDto(
            invoice.InvoiceId,
            invoice.Amount,
            invoice.DateIssued,
            invoice.Status
        );
    }
}