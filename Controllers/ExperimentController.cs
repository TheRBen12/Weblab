using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebLab.Data;
using WebLab.Models;

namespace WebLab.Controllers;

public class ExperimentController(ApplicationDbContext context): BaseController
{
    public readonly ApplicationDbContext _context = context;
    
    
    [HttpGet]
    public async Task<ActionResult<List<Experiment>>> GetExperiments()
    {
        var experiments = await context.Experiments.ToListAsync();
        return experiments;
    }
}