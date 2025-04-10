using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace WebLab.Models;

public class MentalModelExperimentExecution
{
    
    [Key] public int Id { get; set; }

    [Required]
    
    public ExperimentTestExecution ExperimentTestExecution { get; set; }

    public string? ClickedRoutes { get; set; } = string.Empty;

    public int FailedClicks { get; set; }

    public bool ClickedOnSearchBar { get; set; } = false;

    [MaxLength(1000)] 
    public string? UsedFilters { get; set; } = string.Empty;

    [MaxLength(255)] 
    public string FirstClick { get; set; } = string.Empty;

    public bool UsedFilter { get; set; }
    
    public bool UsedBreadcrumbs { get; set; }
    
    public double? ExecutionTime { get; set; }

    public int? NumberClicks { get; set; }
    
    public int? NumberUsedSearchBar { get; set; }
    
    public int? TimeToClickFirstCategory { get; set; }
    
    public int? TimeToClickSearchBar { get; set; }
    
    public int? TimeToClickShoppingCart { get; set; }
    
    public int? NumberToggledMenu { get; set; }




    
}