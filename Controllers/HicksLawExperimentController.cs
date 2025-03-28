using Microsoft.AspNetCore.Mvc;
using WebLab.Data;
using WebLab.DTO;
using WebLab.Models;

namespace WebLab.Controllers;

public class HicksLawExperimentController(ApplicationDbContext context) : BaseController
{
    [HttpPost("new")]
    public async Task<ActionResult<HicksLawExperimentExecution>> SaveExecution(
        [FromBody] HicksLawExperimentExecutionDto executionDto)
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


        var hicksLawExperimentExecution = new HicksLawExperimentExecution
        {
            ExperimentTestExecution = experimentTestExecution,
            ExecutionTime = experimentTestExecution.ExecutionTime,
            NumberClicks = executionDto.NumberClicks,
            ClickedOnFilters = false,
            CategoryLimit = executionDto.CategoryLimit,
            ProductLimit = executionDto.ProductLimit,
            FirstChoiceAt = executionDto.FirstChoiceAt,
            SecondChoiceAt = executionDto.SecondChoiceAt,
            ThirdChoiceAt = executionDto.ThirdChoiceAt,
            FirstClick = executionDto.FirstClick,
            CategoryLinkClickDates = executionDto.CategoryLinkClickDates,
            NumberUsedSearchBar = executionDto.NumberClickedSearchBar,
            TimeToClickFirstCategoryLink = executionDto.TimeToClickFirstCategoryLink,

        };
        var result = context.HicksLawExperimentExecutions.Add(hicksLawExperimentExecution);
        await context.SaveChangesAsync();
        return result.Entity;
    }
}