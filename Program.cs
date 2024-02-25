using Microsoft.EntityFrameworkCore;
using Asp_mvc.Data;
using Microsoft.AspNetCore.Identity;
using Asp_mvc.Config;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
//Identity
builder.Services.IdentityDbContextConfig(builder.Configuration);
builder.Services.IdentityConfigs();

//Entity Core
builder.Services.EntityDbContextConfig(builder.Configuration);

builder.Services.ResolveDependencies();
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
  
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();


app.MapControllerRoute(
    name: "MyArea", pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    "default", pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
