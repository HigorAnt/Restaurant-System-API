namespace Restaurant.API.EndpointFilters;
public class SnackIsLockedFilter : IEndpointFilter
{
    public readonly int _lockedSnackId;
    public SnackIsLockedFilter(int lockedSnackId)
    {
        _lockedSnackId = lockedSnackId;
    }
    public async ValueTask<object?> InvokeAsync(EndpointFilterInvocationContext context, EndpointFilterDelegate next)
    {
        int snackId;

        if (context.HttpContext.Request.Method == "PUT")
        {
            snackId = context.GetArgument<int>(2);
        }
        else if (context.HttpContext.Request.Method == "DELETE")
        {
            snackId = context.GetArgument<int>(1);
        }
        else
        {
            throw new NotSupportedException("This filter is not supported for this scenario.");
        }

        if (snackId == _lockedSnackId)
        {
            return TypedResults.Problem(new()
            {
                Status = 400,
                Title = "A refeição já é perfeita, você não precisa modificar ou deletar esta receita",
                Detail = "Você não pode modificar ou deletar esta Receita"
            });
        }

        var result = await next.Invoke(context);
        return result;
    }
}
