using cyclefriends.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebLab.Data;

namespace WebLab.Controllers;

[ApiController]
[Route("api/users")]
public class UserController(ApplicationDbContext context): ControllerBase
{
    public readonly ApplicationDbContext _context = context;

    [HttpGet ("{email}")]
    public async Task<ActionResult<User>> GetUser(string email)
    {
        var user = await context.Users.FindAsync(email);
        if (user != null)
        {
            return Ok(user);
        }
        else
        {
            return NotFound("User was not found");
        }
    }
}