using Acceso_Datos;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<Prueba_json>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Conexion_BD") ?? throw new InvalidOperationException("Connection string 'Act1Context' not found.")));

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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();





//https://learn.microsoft.com/es-es/aspnet/core/data/ef-rp/intro?view=aspnetcore-7.0&tabs=visual-studio
//https://learn.microsoft.com/es-es/aspnet/core/data/ef-mvc/intro?view=aspnetcore-7.0--!!
//https://github.com/dotnet/AspNetCore.Docs/tree/main/aspnetcore/data/ef-mvc/intro/samples/cu-final