using Microsoft.EntityFrameworkCore;
using NguyenHuuTuan_2310900112.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<NguyenHuuTuan2310900112Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllersWithViews();


var connectionString = builder.Configuration.GetConnectionString("NhtDbConnect");
builder.Services.AddDbContext<NguyenHuuTuan2310900112Context>(x => x.UseSqlServer(connectionString));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/NhtHome/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=NhtHome}/{action=NhtIndex}/{nhtid?}");

app.Run();
