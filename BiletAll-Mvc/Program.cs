using BiletAll.Entity.Context;
using BiletAll.WebService.Abstract;
using BiletAll.WebService.AutoMapper.Profiles;
using BiletAll.WebService.Concrete;
using BiletAll_Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

IConfiguration Configuration = builder.Configuration;
builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddAutoMapper(typeof(SeferlerProfile));
builder.Services.AddScoped<IBiletAllService, BiletAllService>();

builder.Services.AddMemoryCache();
var app = builder.Build();
DbSeeder.Seed(app);
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment()) {
  app.UseExceptionHandler("/Home/Error");
 
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=AnaSayfa}/{id?}");

app.Run();
