using FraudWatch.Application.Interfaces;
using FraudWatch.Application.Services;
using FraudWatch.Infraestructure.Data.Repositories;
using FraudWatch_CadastroUsuarios.Infraestructure.Data.AppData;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationContext>(options =>
{
    options.UseOracle(builder.Configuration.GetConnectionString("Oracle"));
});

builder.Services.AddTransient<IDentistaRepository, DentistaRepository>();
builder.Services.AddTransient<IAnalistaRepository, AnalistaRepository>();

builder.Services.AddScoped<IDentistaApplicationService, DentistaApplicationService>();
builder.Services.AddScoped<IAnalistaApplicationService, AnalistaApplicationService>();

// Add services to the container.
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
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
