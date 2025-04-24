using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using WebLab.Data;
using WebLab.Models;

namespace WebLab.Controllers;

public class NavigationController(ApplicationDbContext context) : BaseController
{
    [HttpPost("navigation-click-time/new")]
    public async Task<ActionResult<NavigationClickTime>> SaveNavigationClickTime(
        [FromBody] NavigationClickTime navigationClickTime)
    {
        var result = await context.NavigationClickTimes.AddAsync(navigationClickTime);
        await context.SaveChangesAsync();
        return Ok(result);
    }
}