using FastEndpoints;
using Pirooz.HR;
using Pirooz.Marketing;
using Pirooz.Payroll;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddFastEndpoints();

builder.Services.AddHRServices();
builder.Services.AddMarketingServices();
builder.Services.AddPayrollServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseFastEndpoints();
app.UseHttpsRedirection();

// Map the endpoints of each module
app.MapHREndpoints();
app.MapMarketingEndpoints();
app.MapPayrollEndpoints();

app.Run();
