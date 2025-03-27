using System.ComponentModel.DataAnnotations;

namespace WebLab.Models;

public class ExperimentTestExecution
{
    [Key] public int Id { get; set; }

    [Required] public ExperimentTest ExperimentTest{ get; set; }
    
    public DateTimeOffset? FinishedExecutionAt { get; set; }
    
    [Required] public DateTimeOffset StartedExecutionAt { get; set; }

    public double? ExecutionTime { get; set; }
    
    [Required] public User User { get; set; }

    [Required] public string State { get; set; } = "INPROCESS";
    
    [Required]
    public int TimeReadingDescription { get; set; }

    [Required]
    public DateTimeOffset OpenedDescAt { get; set; }

}