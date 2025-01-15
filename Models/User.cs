using System.ComponentModel.DataAnnotations;

namespace cyclefriends.Models;

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

    public int CurrentExperimentPosition { get; set; } = 0;
}