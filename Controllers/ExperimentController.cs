using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebLab.Data;
using WebLab.DTO;
using WebLab.Interfaces;
using WebLab.Models;

namespace WebLab.Controllers;

public class ExperimentController(ApplicationDbContext context, IExperimentService experimentService) : BaseController
{
    private readonly ApplicationDbContext context = context;
    public readonly IExperimentService ExperimentService = experimentService;


    [HttpGet]
    public async Task<ActionResult<List<Experiment>>> GetExperiments()
    {
        var experiments = await context.Experiments.ToListAsync();
        return experiments;
    }

    [HttpGet("{experimentId}")]
    public async Task<ActionResult<Experiment>> FindExperiment(int experimentId)
    {
        var experiment = await context.Experiments.FindAsync(experimentId);
        if (experiment != null)
        {
            return experiment;
        }

        {
            return NotFound("Das Experiment mit der Id " + experimentId + " wurde nicht gefunden");
        }
    }


    [HttpPost("mental-model/new")]
    public async Task<ActionResult<MentalModelExperimentExecution>> SaveExperimentExecution(
        [FromBody] MentalModelExperimentExecutionDto executionDto)
    {
        var experimentTestExecution =
            await experimentService.FindExecutionById(executionDto.ExperimentTestExecutionId);

        if (experimentTestExecution != null)
        {
            experimentTestExecution.FinishedExecutionAt = executionDto.FinishedExecutionAt;
            experimentTestExecution = await experimentService.SaveExperimentExecution(experimentTestExecution);
        }
        else
        {
            return NotFound("Die execution ID darf nicht null sein");
        }

        experimentTestExecution.FinishedExecutionAt = executionDto.FinishedExecutionAt;

        var mentalModelExecution = new MentalModelExperimentExecution
        {
            ExperimentTestExecution = experimentTestExecution,
            ClickedRoutes = executionDto.ClickedRoutes,
            FailedClicks = executionDto.FailedClicks,
            ClickedOnSearchBar = executionDto.ClickedOnSearchBar,
            UsedFilters = executionDto.UsedFilters,
            UsedFilter = executionDto.UsedFilter,
            NumberClicks = executionDto.NumberClicks,
            NumberUsedSearchBar = executionDto.NumberUsedSearchBar,
            TimeToClickFirstCategory = executionDto.TimeToClickFirstCategory,
            FirstClick = executionDto.FirstClick,
            TimeToClickSearchBar = executionDto.TimeToClickSearchBar,
            TimeToClickShoppingCart = executionDto.TimeToClickShoppingCart,
            UsedBreadcrumbs = executionDto.UsedBreadcrumbs,
            NumberToggledMenu = executionDto.NumberToggledMenu,
            TimeToFirstClick = executionDto.TimeToFirstClick,
            Clicks = executionDto.Clicks,
            SearchParameters = executionDto.SearchParameters,
        };

        var result = context.MentalModelExperimentExecutions.Add(mentalModelExecution);
        await context.SaveChangesAsync();
        return result.Entity;
    }


    [HttpPost("feedback/new")]
    public async Task<IActionResult> SaveFeedback(ExperimentFeedbackDto feedbackDto)
    {
        var user = await context.Users.Where(user => user.Id == feedbackDto.UserId).FirstOrDefaultAsync();
        var test = await context.ExperimentTests.Where(test => test.Id == feedbackDto.ExperimentTestId).FirstOrDefaultAsync();
        if (user == null || test == null )
        {
            return BadRequest("User or Test cannot be null");
        }

        var feedback = new ExperimentFeedback
        {
            User = user,
            Text = feedbackDto.Text,
            Consistency = feedbackDto.Consistency,
            CognitiveStress = feedbackDto.CognitiveStress,
            Learnability = feedbackDto.Learnability,
            MentalModel = feedbackDto.MentalModel,
            ExperimentTest = test,
            Understandable = feedbackDto.Understandable,
        };
        await context.ExperimentFeedbacks.AddAsync(feedback);
        await context.SaveChangesAsync();
        return Ok();
    }
    
    
    [HttpPost("selection-time/new")]
    public async Task<ActionResult<ExperimentSelectionTimeDto>> SaveExperimentSelectionTime(ExperimentSelectionTimeDto experimentSelectionTimeDto)
    {
        var user = await context.Users.Where(user => user.Id == experimentSelectionTimeDto.UserId).FirstOrDefaultAsync();
        var experiment = await context.Experiments.Where(exp => exp.Id == experimentSelectionTimeDto.ExperimentId).FirstOrDefaultAsync();
        var setting = await context.UserSettings.Where(setting => setting.Id == experimentSelectionTimeDto.SettingId).FirstOrDefaultAsync();
        if (user == null || experiment == null)
        {
            return BadRequest("User or Experiment cannot be null");
        }

        var experimentSelectionTime = new ExperimentSelectionTime
        {
            Time = experimentSelectionTimeDto.Time,
            Experiment = experiment,
            User = user,
            Setting = setting,

        };
        await context.ExperimentSelectionTimes.AddAsync(experimentSelectionTime);
        await context.SaveChangesAsync();
        return Ok(experimentSelectionTimeDto);
    }
}