using Microsoft.EntityFrameworkCore;
using Restaurant.API.DbContexts;
using Restaurant.API.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<SnackDbContext>(o => o.UseSqlite(builder.Configuration["ConnectionStrings:ConnStringSnack"]));

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddProblemDetails();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler();
}
else
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.RegisterSnacksEndpoints();
app.RegisterIngredientsEndpoints();

app.Run();
