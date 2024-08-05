using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Mega.Areas.Identity.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DbMegaContextConnection") ?? throw new InvalidOperationException("Connection string 'DbMegaContextConnection' not found.");

builder.Services.AddDbContext<DbMegaContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<MegaUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<DbMegaContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();
app.Run();
