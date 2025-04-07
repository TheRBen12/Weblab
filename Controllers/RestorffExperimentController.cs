using Microsoft.AspNetCore.Mvc;
using WebLab.Data;
using WebLab.DTO;
using WebLab.Interfaces;
using WebLab.Models;

namespace WebLab.Controllers;

public class RestorffExperimentController(ApplicationDbContext context, IExperimentService experimentService): BaseController
{
    private readonly ApplicationDbContext _context = context;
    private readonly IExperimentService _experimentService = experimentService;
    
    [HttpPost("new")]
    public async Task<bool> Save([FromBody] RestorffExperimentExecutionDto executionDto)
    {
        
        
        var experimentTestExecution =
            await experimentService.FindExecutionById(executionDto.ExperimentTestExecutionId);

        if (experimentTestExecution != null)
        {
            experimentTestExecution.FinishedExecutionAt = executionDto.FinishedExecutionAt;
            experimentTestExecution = await experimentService.SaveExperimentExecution(experimentTestExecution);
        }

        var result = new RestorffExperimentExecution
        {
            ExperimentTestExecution = experimentTestExecution,
            ReactionTimes = executionDto.ReactionTimes,
            NumberFailedClicks = executionDto.NumberFailedClicks,
            NumberClicks = executionDto.NumberClicks,
            ExecutionTime = executionDto.ExecutionTime,
            Tasks = executionDto.Tasks,
            NumberDeletedMails = executionDto.NumberDeletedMails,
        };

        await context.RestorffExperimentExecutions.AddAsync(result);
        
        return await context.SaveChangesAsync() > 0;
    }
}