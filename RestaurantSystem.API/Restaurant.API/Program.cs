using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Restaurant.API.DbContexts;
using Restaurant.API.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<SnackDbContext>(o => o.UseSqlite(builder.Configuration["ConnectionStrings:ConnStringSnack"]));

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/snack", async Task<Results<NoContent, Ok<IEnumerable<SnackDTO>>>>(
    SnackDbContext snackDbContext,
    IMapper mapper,
    [FromQuery(Name = "name")] string? nameSnack) =>
    {
        var snackEntity = await snackDbContext.Snacks.Where(x => nameSnack == null || x.Name.ToLower().Contains(
            nameSnack.ToLower())).ToListAsync();

        if(snackEntity.Count <= 0 || snackEntity == null)
        {
            return TypedResults.NoContent();
        } 
        else
        {
            return TypedResults.Ok(mapper.Map<IEnumerable<SnackDTO>>(snackEntity));
        }
});

app.MapGet("/snack/{snackId:int}/ingredients", async (
    SnackDbContext snackDbContext,
    IMapper mapper,
    int snackId) =>
    {
        return mapper.Map<IEnumerable<IngredientsDTO>>((await snackDbContext.Snacks.Include(
        snack => snack.Ingredientes).FirstOrDefaultAsync(snack => snack.Id == snackId))?.Ingredientes);
});

app.MapGet("/snack/{id:int}", async (
    SnackDbContext snackDbContext,
    IMapper mapper,
    int id) =>
    {
        mapper.Map<SnackDTO>(await snackDbContext.Snacks.FirstOrDefaultAsync(x => x.Id == id));
});

app.Run();
