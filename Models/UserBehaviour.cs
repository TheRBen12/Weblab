using System.ComponentModel.DataAnnotations;

namespace WebLab.Models;

public class UserBehaviour
{
    
    [Key]
    public int Id { get; set; }

    public bool? ClickedOnHelp { get; set; } = false;

    public int? NumberClickedOnHelp { get; set; } = 0;

    [Required]
    public User? User { get; set; }

    public bool? ClickedOnSettings { get; set; } = false;

    public int? NumberClickedOnSettings { get; set; } = 0;

    public int? TimeReadingWelcomeModal { get; set; } = 0;

    public bool? ClickedOnHint { get; set; } = false;

    public int? NumberClickedOnHint { get; set; }
    
    public int? WelcomeModalTipIndex { get; set; }


}