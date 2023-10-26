using Microsoft.AspNetCore.WebSockets;
using ReadingIsGood.Entities;
using ReadingIsGood.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var builderServices = builder.Services;

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


#region Services

var serviceProvider = builder.Services.BuildServiceProvider();
var logger = serviceProvider.GetService<ILogger<BaseEntity>>();
builder.Services.AddSingleton(typeof(ILogger), logger);

builderServices.AddScoped<IBookService, BookService>();
builderServices.AddScoped<ICustomerService, CustomerService>();
builderServices.AddScoped<IOrderService, OrderService>();

#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
