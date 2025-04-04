using Microsoft.AspNetCore.Mvc;
using WebLab.Data;
using WebLab.DTO;
using WebLab.Interfaces;
using WebLab.Models;

namespace WebLab.Controllers;

public class FittsLawExperimentController(ApplicationDbContext context, IExperimentService experimentService): BaseController
{
    private readonly ApplicationDbContext _context = context;
    private readonly IExperimentService _experimentService = experimentService;
    
    [HttpPost]
    public async Task<bool> Save([FromBody] FittsLawExperimentExecutionDto executionDto)
    {
        
        
        var experimentTestExecution =
            await experimentService.FindExecutionById(executionDto.ExperimentTestExecutionId);

        if (experimentTestExecution != null)
        {
            experimentTestExecution.FinishedExecutionAt = executionDto.FinishedExecutionAt;
            experimentTestExecution = await experimentService.SaveExperimentExecution(experimentTestExecution);
        }

        var result = new FittsLawExperimentExecution
        {
            ExperimentTestExecution = experimentTestExecution,
            ClickReactionTimes = executionDto.ClickReactionTimes,
            NumberFailedClicks = executionDto.NumberFailedClicks,
            ExecutionTime = executionDto.ExecutionTime,
            Tasks = executionDto.Tasks,
            TaskSuccess = executionDto.TaskSuccess,

        };

        await context.FittsLawExperimentExecutions.AddAsync(result);
        
        return await context.SaveChangesAsync() > 0;
    }
    
}