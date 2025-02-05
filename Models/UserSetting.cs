using System.ComponentModel.DataAnnotations;

namespace WebLab.Models;

public class UserSetting
{
    [Key] public int Id { get; set; }

    [Required] public User User { get; set; }

    [Required] public bool ProgressiveVisualizationExperiment { get; set; }

    [Required] public bool ProgressiveVisualizationExperimentTest { get; set; }

    [Required] public bool AutoStartNextExperiment { get; set; }
    
    [Required] public DateTime Created { get; set; }
    
    
    
}