using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebLab.Data;
using WebLab.Models;

namespace WebLab.Controllers;

public class AccountController(ApplicationDbContext context): BaseController
{
    public readonly ApplicationDbContext _context = context;

    [HttpGet("login")]
    public async Task<ActionResult<User>> Login(string email)
    {
        var user = await context.Users.FirstOrDefaultAsync(user => user.Email == email);
        if (user != null)
        {
            return Ok(user);
        }
        else
        {
            return Unauthorized("Ungültige E-Mail Adresse");
        }
    }
}