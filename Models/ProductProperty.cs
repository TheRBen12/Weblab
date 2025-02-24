using System.ComponentModel.DataAnnotations;

namespace WebLab.Models;

public class ProductProperty
{
    [Key] public int Id { get; set; }

    [Required]
    public string Name { get; set; }
    
}