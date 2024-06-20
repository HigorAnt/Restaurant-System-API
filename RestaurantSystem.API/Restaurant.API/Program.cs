using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Restaurant.API.DbContexts;
using Restaurant.API.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<SnackDbContext>(o => o.UseSqlite(builder.Configuration["ConnectionStrings:ConnStringSnack"]));

builder.Services.AddIdentityApiEndpoints<IdentityUser>().AddEntityFrameworkStores<SnackDbContext>();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddProblemDetails();

builder.Services.AddAuthentication().AddJwtBearer();
builder.Services.AddAuthorization();

builder.Services.AddAuthorizationBuilder().AddPolicy("RequireAdminFromBrazil", policy =>
        policy.RequireRole("admin").RequireClaim("country", "Brazil"));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.AddSecurityDefinition("TokenAuthRango",
        new()
        {
            Name = "Authorization",
            Description = "Token baseado em Autentica��o e Autoriza��o",
            Type = SecuritySchemeType.Http,
            Scheme = "Bearer",
            In = ParameterLocation.Header
        }
    );
    options.AddSecurityRequirement(new()
        {
            {
                new ()
                {
                    Reference = new OpenApiReference {
                        Type = ReferenceType.SecurityScheme,
                        Id = "TokenAuthRango"
                    }
                },
                new List<string>()
            }
        }
    );
});

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

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.RegisterSnacksEndpoints();
app.RegisterIngredientsEndpoints();

app.Run();
