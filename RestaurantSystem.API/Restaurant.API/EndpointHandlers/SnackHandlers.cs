using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Restaurant.API.DbContexts;
using Restaurant.API.Entities;
using Restaurant.API.Models;

namespace Restaurant.API.EndpointHandlers;
public static class SnackHandlers
{
    public static async Task<Results<NoContent, Ok<IEnumerable<SnackDTO>>>> GetSnackAsync
        (SnackDbContext snackDbContext,
        IMapper mapper,
        [FromQuery(Name = "name")] string? snackNome)
    {

        var snackEntity = await snackDbContext.Snacks
                                   .Where(x => snackNome == null || x.Name.ToLower().Contains(snackNome.ToLower()))
                                   .ToListAsync();
        if (snackEntity.Count <= 0 || snackEntity == null)
            return TypedResults.NoContent();
        else
            return TypedResults.Ok(mapper.Map<IEnumerable<
                SnackDTO>>(snackEntity));
    }
    public static async Task<Results<NotFound, Ok<SnackDTO>>> GetSnackById(
        SnackDbContext snackDbContext,
        IMapper mapper,
        int snackId)
    {
        var snackEntity = await snackDbContext.Snacks.FirstOrDefaultAsync(x => x.Id == snackId);
        if (snackEntity == null)
            return TypedResults.NotFound();

        return TypedResults.Ok(mapper.Map<SnackDTO>(
            await snackDbContext.Snacks.FirstOrDefaultAsync(x => x.Id == snackId))
        );
    }
    public static async Task<CreatedAtRoute<SnackDTO>> CreateSnackAsync(
        SnackDbContext snackDbContext,
        IMapper mapper,
        [FromBody] SnackForCreateDTO snackForCreateDTO)
    {
        var snackEntity = mapper.Map<Snack>(snackForCreateDTO);
        snackDbContext.Add(snackEntity);
        await snackDbContext.SaveChangesAsync();

        var snackToReturn = mapper.Map<SnackDTO>(snackEntity);

        return TypedResults.CreatedAtRoute(
            snackToReturn,
            "GetSnack",
            new { snackId = snackToReturn.Id }
        );
    }
    public static async Task<Results<NotFound, Ok>> UpdateSnackAsync(
        SnackDbContext snackDbContext,
        IMapper mapper,
        int snackId,
        [FromBody] SnackForUpdateDTO snackForUpdateDTO)
    {
        var snackEntity = await snackDbContext.Snacks.FirstOrDefaultAsync(x => x.Id == snackId);
        if (snackEntity == null)
            return TypedResults.NotFound();

        mapper.Map(snackForUpdateDTO, snackEntity);
        await snackDbContext.SaveChangesAsync();

        return TypedResults.Ok();
    }
    public static async Task<Results<NotFound, NoContent>> DeleteSnackAsync(
        SnackDbContext snackDbContext,
        int snackId)
    {
        var snackEntity = await snackDbContext.Snacks.FirstOrDefaultAsync(x => x.Id == snackId);
        if (snackEntity == null)
            return TypedResults.NotFound();

        snackDbContext.Snacks.Remove(snackEntity);
        await snackDbContext.SaveChangesAsync();

        return TypedResults.NoContent();
    }
}
