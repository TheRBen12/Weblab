namespace WebLab.DTO;

public class FittsLawExperimentExecutionDto
{
    public int ExperimentTestExecutionId { get; set; }
    public string ClickReactionTimes { get; set; } = string.Empty;
    public int NumberFailedClicks { get; set; }
    public int ExecutionTime { get; set; }
    public string Tasks { get; set; } = string.Empty;
    public bool TaskSuccess { get; set; }
    public DateTimeOffset FinishedExecutionAt { get; set; }
}