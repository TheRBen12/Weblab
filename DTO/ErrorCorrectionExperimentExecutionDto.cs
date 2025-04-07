namespace WebLab.DTO;

public class ErrorCorrectionExperimentExecutionDto
{
    public int ExperimentTestExecutionId { get; set; }

    public int FailedClicks { get; set; }
    

    public int? NumberClicks { get; set; }

    public string? FirstClick { get; set; }

    public int? TimeToClickOnUndo { get; set; }

    public bool ClickedOnUndo { get; set; }

    public bool TaskSuccess { get; set; }

    public bool ClickedOnDeletedItems { get; set; }

    public string UndoSnackBarPosition { get; set; }

    public bool CorrectInput { get; set; }
    
    public DateTimeOffset FinishedExecutionAt { get; set; }

    public int? TimeToClickOnDeletedItems { get; set; }

}