namespace Pirooz.Payroll.Entities;

public record InvoiceDto(int InvoiceId, decimal Amount, DateTime DateIssued, string Status);
