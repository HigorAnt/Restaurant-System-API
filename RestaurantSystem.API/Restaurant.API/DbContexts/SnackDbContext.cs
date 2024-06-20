using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Restaurant.API.Entities;

namespace Restaurant.API.DbContexts;

public class SnackDbContext(DbContextOptions<SnackDbContext> options) : IdentityDbContext(options)
{
    public DbSet<Snack> Snacks { get; set; } = null!;
    public DbSet<Ingredients> Ingredientes { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        _ = modelBuilder.Entity<Ingredients>().HasData(
       new { Id = 1, Name = "Carne de Vaca" },
       new { Id = 2, Name = "Cebola" },
       new { Id = 3, Name = "Cerveja Escura" },
       new { Id = 4, Name = "Fatia de Pão Integral" },
       new { Id = 5, Name = "Mostarda" },
       new { Id = 6, Name = "Chicória" },
       new { Id = 7, Name = "Maionese" },
       new { Id = 8, Name = "Vários Temperos" },
       new { Id = 9, Name = "Mexilhões" },
       new { Id = 10, Name = "Aipo" },
       new { Id = 11, Name = "Batatas Fritas" },
       new { Id = 12, Name = "Tomate" },
       new { Id = 13, Name = "Extrato de Tomate" },
       new { Id = 14, Name = "Folha de Louro" },
       new { Id = 15, Name = "Cenoura" },
       new { Id = 16, Name = "Alho" },
       new { Id = 17, Name = "Vinho Tinto" },
       new { Id = 18, Name = "Leite de Coco" },
       new { Id = 19, Name = "Gengibre" },
       new { Id = 20, Name = "Pimenta Malagueta" },
       new { Id = 21, Name = "Tamarindo" },
       new { Id = 22, Name = "Peixe Firme" },
       new { Id = 23, Name = "Pasta de Gengibre e Alho" },
       new { Id = 24, Name = "Garam Masala" });

        _ = modelBuilder.Entity<Snack>().HasData(
            new { Id = 1, Name = "Ensopado Flamengo de Carne de Vaca com Chicória" },
            new { Id = 2, Name = "Mexilhões com Batatas Fritas" },
            new { Id = 3, Name = "Ragu alla Bolognese" },
            new { Id = 4, Name = "Rendang" },
            new { Id = 5, Name = "Masala de Peixe" });

        _ = modelBuilder
            .Entity<Snack>()
            .HasMany(d => d.Ingredientes)
            .WithMany(i => i.Snacks)
            .UsingEntity(e => e.HasData(
                new { SnacksId = 1, IngredientesId = 1 },
                new { SnacksId = 1, IngredientesId = 2 },
                new { SnacksId = 1, IngredientesId = 3 },
                new { SnacksId = 1, IngredientesId = 4 },
                new { SnacksId = 1, IngredientesId = 5 },
                new { SnacksId = 1, IngredientesId = 6 },
                new { SnacksId = 1, IngredientesId = 7 },
                new { SnacksId = 1, IngredientesId = 8 },
                new { SnacksId = 1, IngredientesId = 14 },
                new { SnacksId = 2, IngredientesId = 9 },
                new { SnacksId = 2, IngredientesId = 19 },
                new { SnacksId = 2, IngredientesId = 11 },
                new { SnacksId = 2, IngredientesId = 12 },
                new { SnacksId = 2, IngredientesId = 13 },
                new { SnacksId = 2, IngredientesId = 2 },
                new { SnacksId = 2, IngredientesId = 21 },
                new { SnacksId = 2, IngredientesId = 8 },
                new { SnacksId = 3, IngredientesId = 1 },
                new { SnacksId = 3, IngredientesId = 12 },
                new { SnacksId = 3, IngredientesId = 17 },
                new { SnacksId = 3, IngredientesId = 14 },
                new { SnacksId = 3, IngredientesId = 2 },
                new { SnacksId = 3, IngredientesId = 16 },
                new { SnacksId = 3, IngredientesId = 23 },
                new { SnacksId = 3, IngredientesId = 8 },
                new { SnacksId = 4, IngredientesId = 1 },
                new { SnacksId = 4, IngredientesId = 18 },
                new { SnacksId = 4, IngredientesId = 16 },
                new { SnacksId = 4, IngredientesId = 20 },
                new { SnacksId = 4, IngredientesId = 22 },
                new { SnacksId = 4, IngredientesId = 2 },
                new { SnacksId = 4, IngredientesId = 21 },
                new { SnacksId = 4, IngredientesId = 8 },
                new { SnacksId = 5, IngredientesId = 24 },
                new { SnacksId = 5, IngredientesId = 10 },
                new { SnacksId = 5, IngredientesId = 23 },
                new { SnacksId = 5, IngredientesId = 2 },
                new { SnacksId = 5, IngredientesId = 12 },
                new { SnacksId = 5, IngredientesId = 18 },
                new { SnacksId = 5, IngredientesId = 14 },
                new { SnacksId = 5, IngredientesId = 20 },
                new { SnacksId = 5, IngredientesId = 13 }
            ));
        base.OnModelCreating(modelBuilder);
    }
}
