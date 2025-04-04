using Microsoft.AspNetCore.Mvc;
using WebLab.Data;
using WebLab.DTO;
using WebLab.Interfaces;
using WebLab.Models;

namespace WebLab.Controllers;

public class FormAndFeedbackExperimentController(ApplicationDbContext context, IExperimentService experimentService)
    : BaseController
{
    private ApplicationDbContext _context = context;
    private IExperimentService _experimentService = experimentService;


    [HttpPost("form-feedback-experiment/new")]
    public async Task<ActionResult<FormAndFeedbackExperimentExecution>> SaveNavigationSetting(
        FormAndFeedbackExperimentExecutionDto formAndFeedbackExperimentDto)
    {
        var experimentTestExecution =
            await experimentService.FindExecutionById(formAndFeedbackExperimentDto.ExperimentTestExecutionId);

        if (experimentTestExecution != null)
        {
            experimentTestExecution.FinishedExecutionAt = formAndFeedbackExperimentDto.FinishedExecutionAt;
            experimentTestExecution = await experimentService.SaveExperimentExecution(experimentTestExecution);
        }

        var result = new FormAndFeedbackExperimentExecution
        {
            ExperimentTestExecution = experimentTestExecution,
            NumberClicks = formAndFeedbackExperimentDto.NumberClicks,
            ExecutionTime = formAndFeedbackExperimentDto.ExecutionTime,
            NumberFormValidations = formAndFeedbackExperimentDto.NumberFormValidations,
        };

        context.FormAndFeedbackExperimentExecutions.AddAsync(result);
        if (await context.SaveChangesAsync() > 0)
        {
            return Ok();
        }
        else
        {
            return BadRequest("Execution could not be saved");
        }
    }
}