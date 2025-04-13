namespace Pirooz.Payroll;

internal record InvoiceDto(int InvoiceId, decimal Amount, DateTime DateIssued, string Status);
