using System.ComponentModel.DataAnnotations;

namespace WebLab.Models;

public class Product
{
    [Key]
    public int Id { get; set; }

    [Required]
    public required string Trademark { get; set; }

    [Required]
    public required string Name { get; set; }
    
    [Required]
    public required float Price { get; set; }
    
    [Required]
    public required ProductType Type { get; set; }
    
    public ICollection<ProductSpecification> Specifications { get; set; } // Dynamische Eigenschaften

    
    
    
}