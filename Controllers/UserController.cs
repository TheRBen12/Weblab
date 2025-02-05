using WebLab.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebLab.Data;
using WebLab.DTO;

namespace WebLab.Controllers;

public class UserController(ApplicationDbContext context) : BaseController
{
    public readonly ApplicationDbContext _context = context;

    [HttpGet("{email}")]
    public async Task<ActionResult<User>> GetUser(string email)
    {
        var user = await context.Users.FirstOrDefaultAsync(user => user.Email == email);
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