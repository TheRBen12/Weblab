using WebLab.Data;
using WebLab.DTO;
using WebLab.Interfaces;
using WebLab.Models;

namespace WebLab.Services;

public class ExperimentService(ApplicationDbContext context): IExperimentService
{
    
    public readonly ApplicationDbContext _context = context;
    public async Task<ExperimentTestExecution?> SaveExperimentExecution(ExperimentTestExecution experimentTestExecution)
    {
        
            experimentTestExecution.State = "FINISHED";
            if (experimentTestExecution.FinishedExecutionAt != null)
            {
                TimeSpan difference = experimentTestExecution.FinishedExecutionAt.Value.UtcDateTime -
                                                  experimentTestExecution.StartedExecutionAt.UtcDateTime;
                            double seconds = difference.TotalSeconds;
                            experimentTestExecution.ExecutionTime = seconds;
            }
            
            experimentTestExecution = context.ExperimentTestExecutions.Update(experimentTestExecution).Entity;
            await context.SaveChangesAsync();
            
            return experimentTestExecution;
       
    }


}