using System.ComponentModel.DataAnnotations;

namespace WebLab.Models;

public class Experiment
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string name { get; set;  }

    [Required] 
    public string state { get; set; }

}