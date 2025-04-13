namespace Pirooz.Payroll;

internal class InvoiceService
{
    public List<InvoiceDto> ListInvoices()
    {
        return new List<InvoiceDto>()
         {
             new InvoiceDto(1, 12, DateTime.Now ,"Pending" ),
             new InvoiceDto(1, 13, DateTime.Now ,"Complete"),
             new InvoiceDto(1, 14, DateTime.Now ,"Pending")
         };
    }
}
