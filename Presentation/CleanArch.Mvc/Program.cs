using CleanArch.Data.Context;
using CleanArch.IoC;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder (args);

// Add services to the container.
builder.Services.AddControllersWithViews ();

#region Connection
builder.Services.AddDbContext<EvaluationDBContext> (options => {
    options.UseSqlServer (builder.Configuration.GetConnectionString ("EvaluationDbConnection"));
});
#endregion

#region DependencyContainer 
builder.Services.RegisterService ();
#endregion

var app = builder.Build ();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment ()) {
    app.UseExceptionHandler ("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts ();
}

app.UseHttpsRedirection ();
app.UseStaticFiles ();

app.UseRouting ();

app.UseAuthorization ();

app.MapControllerRoute (
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run ();