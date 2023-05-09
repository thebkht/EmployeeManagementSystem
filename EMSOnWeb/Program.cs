var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

var app = builder.Build();

app.MapRazorPages();
app.MapGet("/", () => "Hello World!");

app.Run();