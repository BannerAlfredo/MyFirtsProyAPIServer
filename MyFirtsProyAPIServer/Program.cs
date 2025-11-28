using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MyFirtsProyAPIServer.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder .Services.AddEndpointsApiExplorer();
builder .Services.AddSwaggerGen();

builder.Services.AddDbContext<MyAppContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaulConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();

    app.MapSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
