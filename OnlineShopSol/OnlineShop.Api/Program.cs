using Microsoft.EntityFrameworkCore;
using OnlineShop.BL.Contract;
using OnlineShop.BL.Services;
using OnlineShop.DAL.Context;
using OnlineShop.DAL.Interfaces;
using OnlineShop.DAL.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


//Context
builder.Services.AddDbContext<ShopContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ShopContext")));

//Repositories
builder.Services.AddControllers();
builder.Services.AddScoped<ISuppliersRepository, SuppliersRepository>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

//App Service
builder.Services.AddTransient<ISupplierService, SuppliersService>();




builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
