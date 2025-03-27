using System.ComponentModel.DataAnnotations;

namespace WebLab.Models;

public class NavigationSelection
{
    [Key] public int Id { get; set; }

    [Required] public bool SideNavigationSearchBarTop { get; set; }
    
    [Required] public bool SideNavigationSearchbarBottom { get; set; }

    [Required] public bool HorizontalNavigation { get; set; }

    [Required] public bool SideNavigationUserInformationTop { get; set; }

    [Required] public int UserId { get; set; }
}