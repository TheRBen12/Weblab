namespace WebLab.DTO;

public class RestorffExperimentExecutionDto
{
    public int ExperimentTestExecutionId { get; set; }
    public string ReactionTimes { get; set; } = string.Empty;
    public int NumberFailedClicks { get; set; }
    public int NumberClicks { get; set; }
    public int ExecutionTime { get; set; }
    public string Tasks { get; set; } = string.Empty;

    public DateTimeOffset FinishedExecutionAt { get; set; }

    public int NumberDeletedMails { get; set; }
}