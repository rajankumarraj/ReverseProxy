using DataAccess;
using DataAccess.SqlServices;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddSwaggerGen(options => new OpenApiInfo { Title = "User Service", Version = "1.0" });
builder.Services.AddScoped<ISQLDataAccess, SQLDataAccess>();
builder.Services.AddScoped<IUserServices, UserServices>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwaggerUI(option =>
    {
        option.SwaggerEndpoint("/openapi/v1.json", "v1");
    });
     
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
