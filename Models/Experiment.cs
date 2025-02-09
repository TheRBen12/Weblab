using System.ComponentModel.DataAnnotations;

namespace WebLab.Models;

public class Experiment
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Name { get; set;  }

    [Required] 
    public string State { get; set; }

    [Required] public int Position { get; set; }

}