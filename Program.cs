using Microsoft.EntityFrameworkCore;
using Barlog_Raul_Lab2;
using Barlog_Raul_Lab2.Data;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddDbContext<Barlog_Raul_Lab2Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Barlog_Raul_Lab2Context")
    ?? throw new InvalidOperationException("Connection string 'Barlog_Raul_Lab2Context' not found.")));

builder.Services.AddDbContext<LibraryIdentityContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Barlog_Raul_Lab2Context")
    ?? throw new InvalidOperationException("Connection string 'Barlog_Raul_Lab2Context' not found.")));

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<LibraryIdentityContext>();

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
