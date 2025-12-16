using ASP.NET_Core_Web_API.Services;
using ASP.NET_Core_Web_API.Services___Implementations;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddScoped<ICartService, CartService>();
builder.Services.AddScoped<IPaymentService, PaymentService>();
builder.Services.AddScoped<IShipmentService, ShipmentService>();
builder.Services.AddSingleton<IDataProviderService, DataProviderService>();

var app = builder.Build();

app.MapControllers();

app.Run();
