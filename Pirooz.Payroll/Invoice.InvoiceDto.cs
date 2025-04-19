namespace Pirooz.Payroll;

public record InvoiceDto(int InvoiceId, decimal Amount, DateTime DateIssued, string Status);
