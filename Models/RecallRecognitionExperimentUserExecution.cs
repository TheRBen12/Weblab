using System.ComponentModel.DataAnnotations;

namespace WebLab.Models;

public class RecallRecognitionExperimentUserExecution
{
    [Key] private int Id { get; set; }
    [Required] private User user { get; set;  }
    [Required] private ExperimenTest ExperimentTest { get; set; }
    private bool taskSucess { get; set; }
}