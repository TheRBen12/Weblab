using System.ComponentModel.DataAnnotations;

namespace WebLab.Models;

public class FittsLawExperimentExecution
{
    [Key] public int Id { get; set; }

    [Required] public ExperimentTestExecution ExperimentTestExecution { get; set; }
    [Required] public string ClickReactionTimes { get; set; } = string.Empty;
    [Required] public int NumberFailedClicks { get; set; }
    [Required] public int ExecutionTime { get; set; }
    [Required] public string Tasks { get; set; } = string.Empty;
    [Required] public bool TaskSuccess { get; set; }
}