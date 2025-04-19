using Pirooz.Payroll.Entities;

namespace Pirooz.Payroll.Services
{
    public interface IInvoiceService
    {
        Task<List<InvoiceDto>> ListInvoicesAsync();
        Task<InvoiceDto> GetInvoiceByIdAsync(int id);
    }
}