using Microsoft.EntityFrameworkCore;
using PasswordManager_API.Context;
using PasswordManager_API.Interfaces;
using PasswordManager_API.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<PasswordManagerDbContext>(opt => opt.UseSqlServer("Data Source=DESKTOP-E4L6533\\SQLEXPRESS;Initial Catalog=PasswordManagerDb;Integrated Security=True;Encrypt=True;Trust Server Certificate=True"));
builder.Services.AddScoped<ILookupInterface, LookupAppService>();//configure for my own servcie
builder.Services.AddScoped<IUserAuthanticationInterface, AuthnticationAppService>();
builder.Services.AddScoped<IUserProfileInterface, UserProfileAppService>();
builder.Services.AddScoped<IProviderInterface, ProviderAppService>();
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
