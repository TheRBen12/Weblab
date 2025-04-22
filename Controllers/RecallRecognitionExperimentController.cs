using Microsoft.AspNetCore.Mvc;
using WebLab.Data;
using WebLab.DTO;
using WebLab.Interfaces;
using WebLab.Models;

namespace WebLab.Controllers;

public class RecallRecognitionExperimentController(ApplicationDbContext context)
    : BaseController
{
    public readonly ApplicationDbContext _context = context;


    [HttpPost("new")]
    public async Task<ActionResult<RecallRecognitionExperimentExecution>> SaveExecution(
        [FromBody] RecallRecognitionExperimentExecutionDto executionDto)
    {
        var experimentTestExecution =
            await context.ExperimentTestExecutions.FindAsync(executionDto.ExperimentTestExecutionId);

        if (experimentTestExecution != null)
        {
            experimentTestExecution.FinishedExecutionAt = executionDto.FinishedExecutionAt;
            experimentTestExecution.State = "FINISHED";

            TimeSpan difference = experimentTestExecution.FinishedExecutionAt.Value.UtcDateTime -
                                 experimentTestExecution.StartedExecutionAt.UtcDateTime;
            double seconds = difference.TotalSeconds;
            experimentTestExecution.ExecutionTime = seconds;
            experimentTestExecution = context.ExperimentTestExecutions.Update(experimentTestExecution).Entity;
            await context.SaveChangesAsync();
        }
        else
        {
            throw new Exception("Die ID darf nicht null sein");
        }


        var recallRecognitionExecution = new RecallRecognitionExperimentExecution()
        {
            CategoryLinkClickDates = executionDto.CategoryLinkClickDates,
            FailedClicks = executionDto.FailedClicks,
            ClickedOnSearchBar = executionDto.ClickedOnSearchBar,
            ExperimentTestExecution = experimentTestExecution,
            ExecutionTime = experimentTestExecution.ExecutionTime,
            NumberClicks = executionDto.NumberClicks,
            NumberUsedSearchBar = executionDto.NumberUsedSearchBar,
            TimeToClickFirstCategoryLink = executionDto.TimeToClickFirstCategoryLink,
            UsedBreadcrumbs = executionDto.UsedBreadcrumbs,
            SearchParameters = executionDto.SearchParameters,
            TimeToClickSearchBar = executionDto.TimeToClickSearchBar,
            FirstClick = executionDto.FirstClick,
            UsedFilter = executionDto.UsedFilter,
            TimeToClickShoppingCart = executionDto.TimeToClickShoppingCart,
        };
        var result = context.RecallRecognitionExperimentExecutions.Add(recallRecognitionExecution);
        await context.SaveChangesAsync();
        return result.Entity;
    }
}