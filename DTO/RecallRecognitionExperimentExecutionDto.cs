namespace WebLab.DTO;

public class RecallRecognitionExperimentExecutionDto
{
    public int Id;
    
    public int ExperimentTestExecutionId { get; set; }
    
    public string? CategoryLinkClickDates { get; set; }

    public int FailedClicks { get; set; }

    public bool ClickedOnSearchBar { get; set; } = false;
    
    public DateTimeOffset? FinishedExecutionAt { get; set; }
    
    public int? ExecutionTime { get; set; }

    public int? NumberClicks { get; set; }
    
    public int? NumberUsedSearchBar { get; set; }
    
    public int? TimeToClickSearchBar { get; set; }

    public int? TimeToClickFirstCategoryLink { get; set; }
    
    public bool UsedBreadcrumbs { get; set; }
    
    public string? SearchParameters { get; set; } = string.Empty;

    public string? FirstClick { get; set; } = string.Empty;


    

}