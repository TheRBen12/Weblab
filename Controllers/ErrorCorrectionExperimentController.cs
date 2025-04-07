using Microsoft.AspNetCore.Mvc;
using WebLab.Data;
using WebLab.DTO;
using WebLab.Interfaces;
using WebLab.Models;

namespace WebLab.Controllers;

public class ErrorCorrectionExperimentController(ApplicationDbContext context, IExperimentService experimentService) : BaseController
{
    private readonly IExperimentService _experimentService = experimentService;
    
    [HttpPost("new")]
    public async Task<ActionResult<ErrorCorrectionExperimentExecution>> SaveExecution(
        [FromBody] ErrorCorrectionExperimentExecutionDto executionDto)
    {
        var experimentTestExecution =
            await context.ExperimentTestExecutions.FindAsync(executionDto.ExperimentTestExecutionId);

        if (experimentTestExecution != null)
        {
            experimentTestExecution.FinishedExecutionAt = executionDto.FinishedExecutionAt;
            experimentTestExecution = await experimentService.SaveExperimentExecution(experimentTestExecution);
            experimentTestExecution = context.ExperimentTestExecutions.Update(experimentTestExecution).Entity;
            await context.SaveChangesAsync();
        }
        else
        {
            throw new Exception("Die ID darf nicht null sein");
        }
        
        var execution = new ErrorCorrectionExperimentExecution()
        {
            ClickedOnUndo = executionDto.ClickedOnUndo,
            UndoSnackBarPosition = executionDto.UndoSnackBarPosition,
            ClickedOnDeletedItems = executionDto.ClickedOnDeletedItems,
            FirstClick = executionDto.FirstClick,
            NumberClicks = executionDto.NumberClicks,
            FailedClicks = executionDto.FailedClicks,
            CorrectInput = executionDto.CorrectInput,
            ExecutionTime = experimentTestExecution.ExecutionTime,
            ExperimentTestExecution = experimentTestExecution,
            TaskSuccess = executionDto.TaskSuccess,
            TimeToClickOnDeletedItems = executionDto.TimeToClickOnDeletedItems,
            TimeToClickOnUndo = executionDto.TimeToClickOnUndo,
        };
        var result = context.ErrorCorrectionExperimentExecutions.Add(execution);
        await context.SaveChangesAsync();
        return result.Entity;
    }
}