var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages(options =>
{
    // Custom route
    options.Conventions.AddPageRoute(
        "/Products/Details",
        "Products/{id:int}");
});

var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

app.MapRazorPages();

app.Run();