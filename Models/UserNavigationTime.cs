using System.ComponentModel.DataAnnotations;

namespace WebLab.Models;

public class UserNavigationTime
{
    [Key] public int Id { get; set; }
    
    [Required]
    public User User { get; set; }
    
    public ExperimentTest? FromExperiment { get; set; }
    
    [Required] 
    public ExperimentTest ToExperiment { get; set; }

    [Required] public DateTimeOffset FinishedNavigation { get; set; }

    [Required] public DateTimeOffset StartedNavigation { get; set; }

    public UserSetting? UserSetting { get; set; }

    [Required] public int NumberClicks { get; set; } = 0;


}