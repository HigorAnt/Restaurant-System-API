using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Restaurant.API.DbContexts;
using Restaurant.API.Models;

namespace Restaurant.API.EndpointHandlers;
public static class IngredientsHandlers
{
    public static async Task<Results<NotFound, Ok<IEnumerable<IngredientsDTO>>>> GetIngredientesAsync(
        SnackDbContext snackDbContext,
        IMapper mapper,
        int rangoId)
    {
        var snackEntity = await snackDbContext.Snacks.FirstOrDefaultAsync(x => x.Id == rangoId);
        if (snackEntity == null)
            return TypedResults.NotFound();

        return TypedResults.Ok(mapper.Map<IEnumerable<IngredientsDTO>>((await snackDbContext.Snacks
            .Include(snack => snack.Ingredientes)
            .FirstOrDefaultAsync(rango => rango.Id == rangoId))?.Ingredientes));
    }
}
