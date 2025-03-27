namespace WebLab.DTO;

public class ExperimentTestExecutionDto
{
     public int Id { get; set; }

    public int ExperimentTestId{ get; set; }
    
    public DateTimeOffset? FinishedExecutionAt { get; set; }
    
    public DateTimeOffset StartedExecutionAt { get; set; }

    public int? ExecutionTime { get; set; }
    
    public int UserId { get; set; }

    public string State { get; set; }

    public int TimeReadingDescription { get; set; }

    public DateTimeOffset OpenedDescAt { get; set; }
}