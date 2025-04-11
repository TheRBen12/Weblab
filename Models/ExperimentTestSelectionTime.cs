using System.ComponentModel.DataAnnotations;

namespace WebLab.Models;

public class ExperimentTestSelectionTime
{
    [Key] public int Id { get; set; }
    [Required] public int Time { get; set; }
    [Required] public ExperimentTest ExperimentTest { get; set; }
    [Required] public User User { get; set; }
    public UserSetting? Setting { get; set; }
}