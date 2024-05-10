using Microsoft.EntityFrameworkCore;
using System;
using Task.Data;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();


builder.Services.AddDbContext<AppDbContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("FiorelloTask")));

var app = builder.Build();



app.UseHttpsRedirection();
app.UseStaticFiles();



app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
