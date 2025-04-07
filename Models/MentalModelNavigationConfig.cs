using System.ComponentModel.DataAnnotations;

namespace WebLab.Models;

public class MentalModelNavigationConfig
{
    [Key] public int Id { get; set; }

    [Required] public bool SearchBarTop { get; set; }

    [Required] public bool SearchBarBottom { get; set; }

    [Required] public bool NavBarTop { get; set; }

    [Required] public bool NavBarBottom { get; set; }

    [Required] public bool Filter { get; set; }
    
    [Required] public bool AutoCompleteBottom { get; set; }
    
    [Required] public bool AutoCompleteTop { get; set; }
    
    [Required] public bool ShoppingCartTopLeft { get; set; }
    
    [Required] public bool ShoppingCartTopRight { get; set; }
    
    [Required] public bool ShoppingCartBottomRight { get; set; }
    
    [Required] public bool ShoppingCartBottomRLeft { get; set; }

    [Required] public bool MegaDropDown { get; set; }

    [Required] public bool SideMenuLeft { get; set; }
    
    [Required] public bool SideMenuRight { get; set; }

    [Required] public int UserId { get; set; }
    
    [Required] public bool Breadcrumbs { get; set; }




}