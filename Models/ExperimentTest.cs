using System.ComponentModel.DataAnnotations;

namespace WebLab.Models;

public class ExperimentTest
{
    [Key] public int Id { get; set; }

    [Required] public string Name { get; set; }

    [Required] public string State { get; set; }

    [Required] public int Position { get; set; }

    [Required] public int EstimatedExecutionTime { get; set; }

    [Required] public string Description { get; set; }

    [Required] public Experiment Experiment { get; set; }
}