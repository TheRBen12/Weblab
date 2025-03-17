using System.ComponentModel.DataAnnotations;

namespace WebLab.Models;

public class RecallRecognitionExperimentExecution
{
    [Key] public int Id;
    [Required] public ExperimentTest ExperimentTest { get; set; }
    [Required] public DateTimeOffset StartedExperimentAt { get; set; }


}