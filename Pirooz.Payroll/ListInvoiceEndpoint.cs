using FastEndpoints;
using Pirooz.Payroll.Entities;
using Pirooz.Payroll.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirooz.Payroll
{
    public class ListInvoiceEndpoint : EndpointWithoutRequest<List<InvoiceDto>>
    {
        private readonly IInvoiceService invoiceService;

        public ListInvoiceEndpoint(IInvoiceService invoiceService)
        {
            this.invoiceService = invoiceService;
        }
        public override void Configure()
        {
            Get("/api/payroll/invoices");
            AllowAnonymous();
        }
        public override async Task HandleAsync(CancellationToken ct)
        {
            var invoiceList = await invoiceService.ListInvoicesAsync();
            await SendAsync(invoiceList);
        }
    }
}
