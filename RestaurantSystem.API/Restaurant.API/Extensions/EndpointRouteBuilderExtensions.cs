using Restaurant.API.EndpointHandlers;

namespace Restaurant.API.Extensions;
public static class EndpointRouteBuilderExtensions
{
    public static void RegisterSnacksEndpoints(this IEndpointRouteBuilder endpointRouteBuilder)
    {
        var snacksEndpoints = endpointRouteBuilder.MapGroup("/snacks");
        var snacksForIdEndpoints = snacksEndpoints.MapGroup("/{snacksId:int}");

        snacksEndpoints.MapGet("", SnackHandlers.GetSnackAsync);
        snacksForIdEndpoints.MapGet("", SnackHandlers.GetSnackById).WithName("GetSnack");
        snacksEndpoints.MapPost("", SnackHandlers.CreateSnackAsync);
        snacksForIdEndpoints.MapPut("", SnackHandlers.UpdateSnackAsync);
        snacksForIdEndpoints.MapDelete("", SnackHandlers.DeleteSnackAsync);
    }

    public static void RegisterIngredientsEndpoints(this IEndpointRouteBuilder endpointRouteBuilder)
    {
        var ingredientsEndpoints = endpointRouteBuilder.MapGroup("/snacks/{snackId:int}/ingredients");

        ingredientsEndpoints.MapGet("", IngredientsHandlers.GetIngredientesAsync);
    }
}