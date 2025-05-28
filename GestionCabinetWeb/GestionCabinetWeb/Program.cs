using GestionCabinetWeb.Models; // Ajoute ceci
using Microsoft.EntityFrameworkCore; // Et ceci

var builder = WebApplication.CreateBuilder(args);

// ✅ Ajoute ici la configuration de ton DbContext avec MySQL
builder.Services.AddDbContext<CabinetMedicalContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("CabinetMedicalDb"),
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("CabinetMedicalDb"))
    ));

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
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
