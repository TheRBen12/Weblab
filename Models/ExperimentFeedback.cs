using System.ComponentModel.DataAnnotations;

namespace WebLab.Models;

public class ExperimentFeedback
{
    [Key] public int Id { get; set; }
    [Required] public User User { get; set; }
    [Required] public string Text { get; set; }
    [Required] public int Consistency { get; set; }
    [Required] public int CognitiveStress { get; set; }
    [Required] public int Learnability { get; set; }
    [Required] public int MentalModel { get; set; }
    
    [Required] public int Understandable { get; set; }
    
    [Required] public ExperimentTest ExperimentTest { get; set; }

}