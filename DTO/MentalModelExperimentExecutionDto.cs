namespace WebLab.DTO;

public class MentalModelExperimentExecutionDto
{
    
    public int ExperimentTestExecutionId { get; set; }

    public DateTimeOffset FinishedExecutionAt { get; set; }

    public string? ClickedRoutes { get; set; }

    public int FailedClicks { get; set; }

    public bool ClickedOnSearchBar { get; set; } = false;
    
    public string? UsedFilters { get; set; }

    public string FirstClick { get; set; } = string.Empty;
    
    public string? Clicks { get; set; } = string.Empty;
    
    public string? SearchParameters { get; set; } = string.Empty;

    
    public bool UsedFilter { get; set; }
    
    public bool UsedBreadcrumbs { get; set; }

    
    public double? ExecutionTime { get; set; }

    public int? NumberClicks { get; set; }
    
    public int? NumberUsedSearchBar { get; set; }
    
    public int? TimeToClickFirstCategory { get; set; }
    
    public int? TimeToClickSearchBar { get; set; }
    
    public int? TimeToClickShoppingCart { get; set; }
    
    public int? NumberToggledMenu { get; set; }

    public int TimeToFirstClick { get; set; }

    



}