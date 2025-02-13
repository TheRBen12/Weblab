using System.ComponentModel.DataAnnotations;

namespace WebLab.DTO;

public class ExperimentDTO
{
    [Required]
    public string Name { get; set;  }

    [Required] 
    public string State { get; set; }
    
    [Required] public int Position { get; set; }
}