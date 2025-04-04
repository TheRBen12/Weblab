namespace WebLab.DTO;

public class FormAndFeedbackExperimentExecutionDto
{
    public int Id;

    public int ExperimentTestExecutionId { get; set; }

    public int NumberClicks { get; set; }

    public int ExecutionTime { get; set; }

    public int NumberFormValidations { get; set; }

    public DateTimeOffset FinishedExecutionAt { get; set; }
    
    
}