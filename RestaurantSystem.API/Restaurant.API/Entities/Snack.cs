using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Restaurant.API.Entities;
public class Snack
{
    [Key]
    public int Id { get; set; }
    [Required]
    [MaxLength(200)]
    public string Name { get; set; }
    public ICollection<Ingredients> Ingredientes { get; set; } = new List<Ingredients>();
    public Snack() {}
    [SetsRequiredMembers]
    public Snack(int id, string name)
    {
        Id = id;
        Name = name;
    }
}
