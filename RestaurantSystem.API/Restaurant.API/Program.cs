using Microsoft.EntityFrameworkCore;
using Restaurant.API.DbContexts;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<SnackDbContext>(
    o => o.UseSqlite(builder.Configuration["ConnectionStrings:ConnStringSnack"])    
);

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
