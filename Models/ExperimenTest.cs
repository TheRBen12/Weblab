using System.ComponentModel.DataAnnotations;

namespace WebLab.Models;

public class ExperimenTest
{
    [Key] 
    private int Id { get; set; }

    [Required]
    private string Name { get; set; }
    
    [Required]
    private int position { get; set; }

    [Required]
    private Experiment Experiment { get; set;  }
}