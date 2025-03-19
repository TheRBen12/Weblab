using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebLab.Data;
using WebLab.DTO;
using WebLab.Models;

namespace WebLab.Controllers;

public class ExperimentTestController(ApplicationDbContext context) : BaseController
{
    public readonly ApplicationDbContext _context = context;

    [HttpGet]
    public async Task<IEnumerable<ExperimentTest>> GetExperimentTests(int experimentId)
    {
        var experimentTests = await _context.ExperimentTests
            .Where(expTest => expTest.Experiment.Id == experimentId)
            .ToListAsync();
        return experimentTests;
    }

    [HttpGet("test")]
    public async Task<ExperimentTest?> GetExperimentTestById(int experimentTestId)
    {
        var test = await context.ExperimentTests.Include(test => test.Experiment).Where(
            test => test.Id == experimentTestId).FirstOrDefaultAsync();
        return test;
    }

    [HttpGet("execution/find")]
    public async Task<ActionResult<ExperimentTestExecution>> FindExperimentTestByStateAndUserAndExperimentTest(int userId, string state, int testId)
    {
        
        var testExecution = await context.ExperimentTestExecutions.Where(execution => execution.ExperimentTest.Id == testId &&
            execution.State == state && execution.User.Id == userId).FirstOrDefaultAsync();

        if (testExecution != null)
        {
            return Ok(testExecution);
        }

        return NotFound("Keine Execution gefunden");
    }
    


    [HttpPost("execution/new")]
    public async Task<ActionResult<ExperimentTestExecution>> SaveExperimentTestExecution(
        [FromBody] ExperimentTestExecutionDto executionDto)
    {
        var user = await context.Users.FindAsync(executionDto.UserId);
        var experimentTest = await context.ExperimentTests.FindAsync(executionDto.ExperimentTestId);
        var experimentTestExecution = new ExperimentTestExecution()
        {
            User = user,
            StartedExecutionAt = executionDto.StartedExecutionAt,
            ExperimentTest = experimentTest,
            State = executionDto.State,
        };
        var result = context.Add(experimentTestExecution);
        await context.SaveChangesAsync();
        return result.Entity;
    }
    
    [HttpPut("execution/update")]
    public async Task<ActionResult<ExperimentTestExecution>> UpdateExperimentTestExecution(
        [FromBody] ExperimentTestExecutionDto executionDto)
    {
        var user = await context.Users.FindAsync(executionDto.UserId);
        var experimentTest = await context.ExperimentTests.FindAsync(executionDto.ExperimentTestId);
        var experimentTestExecution = new ExperimentTestExecution()
        {
            User = user,
            StartedExecutionAt = executionDto.StartedExecutionAt,
            ExperimentTest = experimentTest,
            FinishedExecutionAt = executionDto.FinishedExecutionAt,
            
        };
        var result = context.Add(experimentTestExecution);
        await context.SaveChangesAsync();
        if (result.Entity.FinishedExecutionAt != null)
        {
            TimeSpan difference = result.Entity.FinishedExecutionAt.Value.UtcDateTime - result.Entity.StartedExecutionAt.UtcDateTime;
            double seconds = difference.TotalSeconds;
            result.Entity.ExecutionTime = seconds;
            context.Add(result);
            await context.SaveChangesAsync();
        }
        
        return result.Entity;
    }
}