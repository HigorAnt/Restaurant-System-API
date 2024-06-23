using MiniValidation;
using Restaurant.API.Models;

namespace Restaurant.API.EndpointFilters;

public class ValidateAnnotationFilter : IEndpointFilter
{
    public async ValueTask<object?> InvokeAsync(EndpointFilterInvocationContext context, EndpointFilterDelegate next)
    {
        var snackForCreateDTO = context.GetArgument<SnackForCreateDTO>(2);

        if (!MiniValidator.TryValidate(snackForCreateDTO, out var validationErrors))
        {
            return TypedResults.ValidationProblem(validationErrors);
        }

        return await next(context);
    }
}
