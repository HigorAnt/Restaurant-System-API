using System.ComponentModel.DataAnnotations;

namespace Restaurant.API.Models;
public class SnackForCreateDTO
{
    [Required]
    [StringLength(100, MinimumLength = 3)]
    public required string Name { get; set; }
}
