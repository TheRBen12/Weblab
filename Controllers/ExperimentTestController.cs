using Microsoft.EntityFrameworkCore;
using WebLab.Data;
using WebLab.Models;

namespace WebLab.Controllers;

public class ExperimentTestController(ApplicationDbContext context): BaseController
{
    public readonly ApplicationDbContext _context = context;

    public async Task<IEnumerable<ExperimentTest>> GetExperimentTests(int experimentId)
    {
        var experimentTests =  await _context.ExperimentTests
            .Where(expTest => expTest.Experiment.Id == experimentId)
            .ToListAsync();
        return experimentTests;
    }

}