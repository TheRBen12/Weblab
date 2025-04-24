using System.ComponentModel.DataAnnotations;

namespace WebLab.Models;

public class NavigationClickTime
{
    [Key] public int Id { get; set; }
    [Required] public int UserId { get; set; }
    [Required] public string SourceUrl { get; set; }
    [Required] public string TargetUrl { get; set; }
    [Required] public int Time { get; set; }

}