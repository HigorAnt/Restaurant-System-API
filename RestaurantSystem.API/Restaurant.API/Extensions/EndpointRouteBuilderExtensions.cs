using Microsoft.AspNetCore.Http;
using Restaurant.API.EndpointFilters;
using Restaurant.API.EndpointHandlers;

namespace Restaurant.API.Extensions;
public static class EndpointRouteBuilderExtensions
{
    public static void RegisterSnacksEndpoints(this IEndpointRouteBuilder endpointRouteBuilder)
    { 
        var snacksEndpoints = endpointRouteBuilder.MapGroup("/snacks");
        var snacksForIdEndpoints = snacksEndpoints.MapGroup("/{snacksId:int}");

        var snackWithIdAndLockFilterEndpoints = endpointRouteBuilder.MapGroup("/snacks/{snackId:int}")
            .AddEndpointFilter(new SnackIsLockedFilter(1)).AddEndpointFilter(new SnackIsLockedFilter(2));

        snacksEndpoints.MapGet("", SnackHandlers.GetSnackAsync);
        snacksForIdEndpoints.MapGet("", SnackHandlers.GetSnackById).WithName("GetSnack");

        //snacksEndpoints.MapPost("", SnackHandlers.CreateSnackAsync);
        snacksEndpoints.MapPost("", SnackHandlers.CreateSnackAsync).AddEndpointFilter<ValidateAnnotationFilter>();

        snacksForIdEndpoints.MapPut("", SnackHandlers.UpdateSnackAsync);
        snackWithIdAndLockFilterEndpoints.MapPut("", SnackHandlers.UpdateSnackAsync);

        snacksForIdEndpoints.MapDelete("", SnackHandlers.DeleteSnackAsync);
        snackWithIdAndLockFilterEndpoints.MapDelete("", SnackHandlers.DeleteSnackAsync)
            .AddEndpointFilter<LogNotFoundResponseFilter>();
    }

    public static void RegisterIngredientsEndpoints(this IEndpointRouteBuilder endpointRouteBuilder)
    {
        var ingredientsEndpoints = endpointRouteBuilder.MapGroup("/snacks/{snackId:int}/ingredients");

        ingredientsEndpoints.MapGet("", IngredientsHandlers.GetIngredientesAsync);
        ingredientsEndpoints.MapPost("", () =>
        {
            throw new NotImplementedException();
        });
    }
}