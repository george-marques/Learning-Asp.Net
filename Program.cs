using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Asp_mvc.Data;
using Microsoft.AspNetCore.Identity;
var builder = WebApplication.CreateBuilder(args);

//Configura��o do dbContext banco - EF
builder.Services.AddDbContext<AspContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AspContext") ?? throw new InvalidOperationException("Connection string 'AspContext' not found.")));

builder.Services.AddDbContext<ContextIdentity>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ContextIdentityConnection") ?? throw new InvalidOperationException("Connection string 'ContextIdentity' not found.")));

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true).AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ContextIdentity>();

// Add services to the container.
// Inje��o de depend�ncia
builder.Services.AddTransient<IFilmeRepository, FilmeRepository>();

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();


app.MapControllerRoute(
    name: "MyArea",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
