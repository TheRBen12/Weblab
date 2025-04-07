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
    public async Task<ActionResult<MentalModelExperimentExecution>> SaveExperimentExecution([FromBody] MentalModelExperimentExecutionDto executionDto)
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
            
        };
            
        var result = context.MentalModelExperimentExecutions.Add(mentalModelExecution);
        await context.SaveChangesAsync();
        return result.Entity;
    }
    
    
   //[HttpPost("feedback/new")]
    
    

    
}