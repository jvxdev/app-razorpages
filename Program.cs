var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

builder.Services.AddRazorPages();

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapRazorPages();

app.Run();
