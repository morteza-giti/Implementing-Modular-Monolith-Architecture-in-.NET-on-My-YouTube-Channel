using Pirooz.Payroll.Entities;
using Pirooz.Payroll.Repositories;

namespace Pirooz.Payroll.Services
{
    internal class InvoiceService : IInvoiceService
    {
        private readonly IInvoiceRepository invoiceRepository;

        public InvoiceService(IInvoiceRepository invoiceRepository)
        {
            this.invoiceRepository = invoiceRepository;
        }

        public async Task<InvoiceDto> GetInvoiceByIdAsync(int id)
        {
            var invoice = await invoiceRepository.GetByIdAsync(id);
            if (invoice == null)
            {
                return null;
            }

            return new InvoiceDto(
                invoice.InvoiceId,
                invoice.Amount,
                invoice.DateIssued,
                invoice.Status
            );
        }

        public async Task<List<InvoiceDto>> ListInvoicesAsync()
        {
            var invoices = await invoiceRepository.ListAllAsync();
            return invoices.Select(i => new InvoiceDto(
                i.InvoiceId,
                i.Amount,
                i.DateIssued,
                i.Status
            )).ToList();
        }
    }
}