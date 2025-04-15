using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebLab.Data;
using WebLab.DTO;
using WebLab.Models;

namespace WebLab.Controllers;

public class UserNavigationController(ApplicationDbContext context) : BaseController
{
    private readonly ApplicationDbContext context = context;


    [HttpPost("new")]
    public async Task<ActionResult<UserNavigationTimeDto>> SaveUserNavigationTime(
        [FromBody] UserNavigationTimeDto userNavigationTimeDto)
    {
        var user = await context.Users.Where(user => user.Id == userNavigationTimeDto.UserId).FirstOrDefaultAsync();
        var userSetting = await context.UserSettings.Where(setting => setting.Id == userNavigationTimeDto.UserSettingId)
            .FirstOrDefaultAsync();
        
        var toExperiment = await context.ExperimentTests.Where(exp => exp.Id == userNavigationTimeDto.ToExperimentId)
            .FirstOrDefaultAsync();

        var userNavigationTime = new UserNavigationTime
        {
            User = user,
            FromExperiment = null,
            ToExperiment = toExperiment,
            FinishedNavigation = DateTimeOffset.Now.UtcDateTime,
            StartedNavigation = userNavigationTimeDto.StartedNavigation,
            UserSetting = userSetting,
            NumberClicks = userNavigationTimeDto.NumberClicks,
            UsedRoutes = userNavigationTimeDto.UsedRoutes,
        };

        if (userNavigationTimeDto.FromExperimentId != null)
        {
            var fromExperiment = await context.ExperimentTests
                .Where(exp => exp.Id == userNavigationTimeDto.FromExperimentId)
                .FirstOrDefaultAsync();
            userNavigationTime.FromExperiment = fromExperiment;
        }

        await context.UserNavigationTimes.AddAsync(userNavigationTime);
        var result = await context.SaveChangesAsync() > 0;

        if (result == true)
        {
            return Ok();
        }

        return NotFound("Navigation time konnte nicht gespeicher werden");
    }
}