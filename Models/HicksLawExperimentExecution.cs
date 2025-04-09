using System.ComponentModel.DataAnnotations;

namespace WebLab.Models;

public class HicksLawExperimentExecution
{
    
    
    [Key] public int Id { get; set; }

    [Required] public ExperimentTestExecution ExperimentTestExecution { get; set; }
    
    public string? CategoryLinkClickDates { get; set; }

    public int FailedClicks { get; set; }
    
    public double? ExecutionTime { get; set; }

    public int? NumberClicks { get; set; }
    
    public int? NumberUsedSearchBar { get; set; }

    public int ProductLimit { get; set; }

    public int CategoryLimit { get; set; }
    
    public int TimeToClickFirstCategoryLink { get; set; }

    public bool ClickedOnFilters { get; set; }

    public DateTimeOffset FirstChoiceAt { get; set; }

    public DateTimeOffset SecondChoiceAt { get; set; }
    
    public DateTimeOffset ThirdChoiceAt { get; set; }

    public string FirstClick { get; set; }
    
    public string UsedFilters { get; set; } = String.Empty;







}