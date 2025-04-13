namespace Pirooz.Marketing;

public class Invoice
{
    public int InvoiceId { get; set; }
    public decimal Amount { get; set; }
    public DateTime DateIssued { get; set; }
    public string Status { get; set; }
}
