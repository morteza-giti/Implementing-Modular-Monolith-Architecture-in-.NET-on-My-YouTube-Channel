using Ardalis.GuardClauses;
using System;

namespace Pirooz.Payroll;

public class Invoice
{
    public int InvoiceId { get; private set; }
    public decimal Amount { get; private set; }
    public DateTime DateIssued { get; private set; }
    public string Status { get; private set; }

    public Invoice(int invoiceId, decimal amount, DateTime dateIssued, string status)
    {
        InvoiceId = Guard.Against.NegativeOrZero(invoiceId, nameof(invoiceId));
        Amount = Guard.Against.NegativeOrZero(amount, nameof(amount));
        DateIssued = Guard.Against.OutOfSQLDateRange(dateIssued, nameof(dateIssued));
        Status = Guard.Against.NullOrWhiteSpace(status, nameof(status));
    }
}
