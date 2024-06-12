using Microsoft.EntityFrameworkCore;
using Restaurant.API.DbContexts;
using Restaurant.API.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<SnackDbContext>(o => o.UseSqlite(builder.Configuration["ConnectionStrings:ConnStringSnack"]));

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.RegisterSnacksEndpoints();
app.RegisterIngredientsEndpoints();

app.Run();
