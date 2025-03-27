using System.ComponentModel.DataAnnotations;

namespace WebLab.Models;

public class ErrorCorrectionExperimentExecution
{
    [Key] public int Id { get; set; }

    [Required] public ExperimentTestExecution ExperimentTestExecution { get; set; }
    
    public int FailedClicks { get; set; }
    
    public double? ExecutionTime { get; set; }

    public int? NumberClicks { get; set; }
    
    public string FirstClick { get; set; }

    public int? TimeToClickOnUndo { get; set; }

    public bool ClickedOnUndo { get; set; }

    public bool TaskSuccess { get; set; }

    public bool ClickedOnDeletedItems { get; set; }

    public string UndoSnackBarPosition { get; set; }

    public bool CorrectInput { get; set; }


}