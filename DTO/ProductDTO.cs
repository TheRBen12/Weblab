using WebLab.Models;

namespace WebLab.DTO;

public class ProductDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Type { get; set; } // Statt der ganzen `Type`-Entity nur den Namen
    public List<ProductSpecificationDTO> Specifications { get; set; }
    
    public float Price { get; set; }
    public string Trademark { get; set; }
}