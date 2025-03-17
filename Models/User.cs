using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace WebLab.Models;

public class User
{
    [Key]
    public int Id { get; set; }

    [Required]
    [EmailAddress(ErrorMessage = "Das ist keine gültige E-Mail Adresse")]
    public required string Email { get; set; }

    [Required]
    public required string Name { get; set; }

    [Required]
    public required string Prename { get; set; }

    [Required]
    public required string Group { get; set; }
    
    [Required]
    public int CurrentExperimentPosition { get; set; }
    
    public  DateTimeOffset? StartedUserExperienceAt { get; set; }
    
    public  DateTimeOffset? FinishedUserExperienceAt { get; set; }

}