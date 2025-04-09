using System.ComponentModel.DataAnnotations;

namespace WebLab.Models;

public class FormAndFeedbackExperimentExecution
{
    [Key] public int Id { get; set; }

    [Required] public ExperimentTestExecution ExperimentTestExecution { get; set; }

    [Required] public int NumberClicks { get; set; }
    
    [Required] public int ExecutionTime { get; set; }

    [Required] public int NumberFormValidations { get; set; }
    
    
    [Required] public int NumberErrors { get; set; }

    
}