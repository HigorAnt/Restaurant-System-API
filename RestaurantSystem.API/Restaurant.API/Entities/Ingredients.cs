using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Restaurant.API.Entities;

public class Ingredients
{
    [Key]
    public int Id { get; set; }
    [Required]
    [MaxLength(200)]
    public string Name { get; set; }
    public ICollection<Snack> Snacks { get; set; } = new List<Snack>();
    public Ingredients()
    {
            
    }
    [SetsRequiredMembers]
    public Ingredients(int id, string name)
    {
        Id = id;
        Name = name;
    }
}

