using System.ComponentModel.DataAnnotations;

namespace WebLab.Models;

public class Mixer
{
    [Key] public int Id { get; set; }

    [Required] public int Volume { get; set; }

    [Required] public String Function { get; set; }

    [Required] public string Lenght { get; set; }

    [Required] public string Colr { get; set; }

    [Required] public int Power { get; set; }

    [Required] public string Material { get; set; }

    public string OriginCountry { get; set; }

    [Required] public Product Product { get; set; }

    [Required] public ProductType Type { get; set; }
    
    
}