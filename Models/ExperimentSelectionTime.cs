using System.ComponentModel.DataAnnotations;

namespace WebLab.Models;

public class ExperimentSelectionTime
{
    [Key] public int Id { get; set; }
    [Required] public int Time { get; set; }
    [Required] public Experiment Experiment { get; set; }
    [Required] public User User { get; set; }
    public UserSetting? Setting { get; set; }
}