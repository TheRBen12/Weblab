using System.ComponentModel.DataAnnotations;

namespace WebLab.Models;

public class RecallRecognitionExperimentExecution
{
    [Key] public int Id { get; set; }

    [Required] public ExperimentTestExecution ExperimentTestExecution { get; set; }
    
    public string? CategoryLinkClickDates { get; set; }

    public int FailedClicks { get; set; }

    public bool ClickedOnSearchBar { get; set; } = false;
    
    public double? ExecutionTime { get; set; }

    public int? NumberClicks { get; set; }
    
    public int? NumberUsedSearchBar { get; set; }

    public int? TimeToClickSearchBar { get; set; }
    
    public bool UsedBreadcrumbs { get; set; } = false;

    public int? TimeToClickFirstCategoryLink { get; set; }

    public string? SearchParameters { get; set; } = string.Empty;

}