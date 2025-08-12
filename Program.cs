using CalculatorAPI.Api;
using CalculatorAPI.Converter;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<NumberSystemConverter>(
    _ => new SimpleConverter()
);

builder.Services.AddControllers();
builder.Services.AddRazorPages();

var app = builder.Build();

app.MapControllers();

app.MapRazorPages();

app.Run();
