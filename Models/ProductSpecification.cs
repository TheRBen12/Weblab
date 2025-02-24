using System.ComponentModel.DataAnnotations;

namespace WebLab.Models;

public class ProductSpecification
{
    [Key]
    public int Id { get; set; }
    public Product Product { get; set; }
    public ProductProperty ProductProperty { get; set; }
    public string Value { get; set; }
}