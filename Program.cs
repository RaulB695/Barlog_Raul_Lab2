using Microsoft.EntityFrameworkCore;
using Barlog_Raul_Lab2;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("Barlog_Raul_Lab2Context")
    ?? throw new InvalidOperationException("Connection string 'Barlog_Raul_Lab2Context' not found.");

builder.Services.AddDbContext<Barlog_Raul_Lab2Context>(options =>
    options.UseSqlServer(connectionString));

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();