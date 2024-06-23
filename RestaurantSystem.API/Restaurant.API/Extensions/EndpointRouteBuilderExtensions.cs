using Microsoft.AspNetCore.Identity;
using Restaurant.API.EndpointFilters;
using Restaurant.API.EndpointHandlers;

namespace Restaurant.API.Extensions;
public static class EndpointRouteBuilderExtensions
{
    public static void RegisterSnacksEndpoints(this IEndpointRouteBuilder endpointRouteBuilder)
    {
        endpointRouteBuilder.MapGroup("/identity/").MapIdentityApi<IdentityUser>();

        endpointRouteBuilder.MapGet("/pratos/{pratoid:int}", (int pratoid) => $"O prato {pratoid} é delicioso!")
            .WithOpenApi(operation =>
            {
                operation.Deprecated = true;
                return operation;
            })
            .WithSummary("Este endpoint está deprecated e será descontinuado na versão 2 desta API")
            .WithDescription("Por favor utilize a outra rota desta API sendo ela /snacks/{snackId} para evitar maiores transtornos futuros");

        var snacksEndpoints = endpointRouteBuilder.MapGroup("/snacks").RequireAuthorization();

        var snacksForIdEndpoints = snacksEndpoints.MapGroup("/{snackId:int}");

        var snackWithIdAndLockFilterEndpoints = endpointRouteBuilder.MapGroup("/snacks/{snackId:int}").
            RequireAuthorization("RequireAdminFromBrazil").RequireAuthorization()
            .AddEndpointFilter(new SnackIsLockedFilter(1)).AddEndpointFilter(new SnackIsLockedFilter(2));

        snacksEndpoints.MapGet("", SnackHandlers.GetSnackAsync).WithOpenApi()
            .WithSummary("Esta rota retornará todos as comidas");

        snacksForIdEndpoints.MapGet("", SnackHandlers.GetSnackById).WithName("GetSnack").AllowAnonymous()
            .WithSummary("Essa rota irá retorna uma comida a partir do ID informado");

        //snacksEndpoints.MapPost("", SnackHandlers.CreateSnackAsync);
        snacksEndpoints.MapPost("", SnackHandlers.CreateSnackAsync).AddEndpointFilter<ValidateAnnotationFilter>()
            .WithSummary("Essa rota irá criar uma nova comida");

        snacksForIdEndpoints.MapPut("", SnackHandlers.UpdateSnackAsync).WithSummary("Essa rota irá atualizar uma comida");
        //snackWithIdAndLockFilterEndpoints.MapPut("", SnackHandlers.UpdateSnackAsync);

        snacksForIdEndpoints.MapDelete("", SnackHandlers.DeleteSnackAsync).
            WithOpenApi().WithSummary("Essa rota irá deletar a refeição selecionada");
        //snackWithIdAndLockFilterEndpoints.MapDelete("", SnackHandlers.DeleteSnackAsync)
        //.AddEndpointFilter<LogNotFoundResponseFilter>();
    }

    public static void RegisterIngredientsEndpoints(this IEndpointRouteBuilder endpointRouteBuilder)
    {
        var ingredientsEndpoints = endpointRouteBuilder.MapGroup("/snacks/{snackId:int}/ingredients").RequireAuthorization();

        ingredientsEndpoints.MapGet("", IngredientsHandlers.GetIngredientesAsync);
        ingredientsEndpoints.MapPost("", () =>
        {
            throw new NotImplementedException();
        });
    }
}