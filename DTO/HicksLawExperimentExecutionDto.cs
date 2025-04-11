namespace WebLab.DTO;

public class HicksLawExperimentExecutionDto
{
    
    public int ExperimentTestExecutionId { get; set; }

    public string CategoryLinkClickDates { get; set; }

    public int? NumberClicks { get; set; }
    
    public int? NumberClickedSearchBar { get; set; }

    public int CategoryLimit { get; set; }

    public int ProductLimit { get; set; }
    
    public DateTimeOffset FirstChoiceAt { get; set; }

    public DateTimeOffset SecondChoiceAt { get; set; }
    
    public DateTimeOffset ThirdChoiceAt { get; set; }

    public DateTimeOffset FinishedExecutionAt { get; set; }

    public string? FirstClick { get; set; }

    public string UsedFilters { get; set; } = string.Empty;

    
    public int TimeToClickFirstCategoryLink { get; set; }
    
    public int TimeToFirstClick { get; set; }




}