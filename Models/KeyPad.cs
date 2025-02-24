using System.ComponentModel.DataAnnotations;

namespace WebLab.Models;

public class KeyPad
{
    [Key] public int Id { get; set; }

    [Required] public string KeyPadType { get; set; }

    [Required] public int Length { get; set; }
    
    [Required] public int Width { get; set; }
    
    [Required] public int Weight { get; set; }

    [Required] public string ConnectionType { get; set; }

    [Required] public string TouchType { get; set; }

    [Required] public string EnergyType { get; set; }

    [Required] public string KeyPadLayout { get; set; }
    
    [Required] public string SignalTransmission { get; set; }
    
    [Required] public int BatteryTime { get; set; }
    
    [Required] public Product Product { get; set; }
    
    [Required] public ProductType Type { get; set; }







}