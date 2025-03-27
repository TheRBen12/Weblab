using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebLab.Data;
using WebLab.Models;

namespace WebLab.Controllers;

public class ExperimentController(ApplicationDbContext context) : BaseController
{
    public readonly ApplicationDbContext _context = context;


    [HttpGet]
    public async Task<ActionResult<List<Experiment>>> GetExperiments(int userId)
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
        return experiment;
    }
}