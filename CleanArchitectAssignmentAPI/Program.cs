using Assignment.Application;
using Assignment.Application.Interfaces;
using Assignment.StoreEF;
using Assignment.StoreDapper;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddApplicationServices();
////builder.Services.AddInfrastructureEF(builder.Configuration);
builder.Services.AddInfrastructureDapper(builder.Configuration);


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/GetAllProductWithCategory", (IProductService productService) =>
{
    return productService.GetAllProductsWithCategory();
})
.WithName("GetAllProductWithCategory")
.WithOpenApi();

app.Run();

internal record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
