using System.ComponentModel.DataAnnotations;

namespace WebLab.Models;

public class ProductType
{
    [Key] public int Id { get; set; }
    [Required] public string Name { get; set; }

    public ProductType ParentType { get; set; }

    public int? ParentTypeId { get; set; } // Nullable für Top-Level-Kategorien
    
    public ICollection<ProductType> SubTypes { get; set; }

}