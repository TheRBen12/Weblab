using AutoMapper;
using WebLab.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebLab.Data;
using WebLab.DTO;

namespace WebLab.Controllers;

public class UserController(ApplicationDbContext context, IMapper mapper) : BaseController
{
    public readonly ApplicationDbContext _context = context;
    private readonly IMapper _mapper = mapper;

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


    [HttpPut("update")]
    public async Task<ActionResult<User>> GetUser([FromBody] User user)
    {
        var updatedUser = context.Users.Update(user);
        await context.SaveChangesAsync();
        return Ok(updatedUser.Entity);
    }


    [HttpPut("behaviour/update")]
    public async Task<ActionResult<UserBehaviour>> UpdateUserBehaviour([FromBody] UserBehaviourDTO userBehaviourDto)
    {
        var userBehaviour = mapper.Map<UserBehaviour>(userBehaviourDto);
        var updatedUserBehaviour = context.UserBehaviours.Update(userBehaviour);
        await context.SaveChangesAsync();
        var updatedUserBehaviourDto = mapper.Map<UserBehaviourDTO>(updatedUserBehaviour.Entity);
        return Ok(updatedUserBehaviourDto);
    }


    [HttpPost("behaviour/create")]
    public async Task<ActionResult<UserBehaviourDTO>> CreateUserBehaviour([FromBody] UserBehaviourDTO userBehaviour)
    {
        
        var user = await context.Users.FindAsync(userBehaviour.User);
        var existingUserBehaviour = await context.UserBehaviours.Where(behaviour => behaviour.User == user).FirstOrDefaultAsync();
        if (existingUserBehaviour != null)
        {
            return mapper.Map<UserBehaviourDTO>(existingUserBehaviour);
        }
        var newUserBehaviour = new UserBehaviour()
        {
            ClickedOnHelp = userBehaviour.ClickedOnHelp,
            ClickedOnSettings = userBehaviour.ClickedOnSettings,
            ClickedOnHint = false,
            NumberClickedOnSettings = userBehaviour.NumberClickedOnSettings,
            NumberClickedOnHelp = userBehaviour.NumberClickedOnHelp,
            TimeReadingWelcomeModal = userBehaviour.TimeReadingWelcomeModal,
            NumberClickedOnHint = 0,
            User = user,
            WelcomeModalTipIndex = userBehaviour.WelcomeModalTipIndex,
            LastUpdatedAt = userBehaviour.LastUpdatedAt
        };

        var updatedUserBehaviour = context.UserBehaviours.Add(newUserBehaviour);
        await context.SaveChangesAsync();
        var dto = mapper.Map<UserBehaviourDTO>(updatedUserBehaviour.Entity);
        return Ok(dto);
    }


    [HttpGet("behaviour/find")]
    public async Task<ActionResult<UserBehaviourDTO>> GetUserBehaviour(int userId)
    {
        var userBehaviour = await context.UserBehaviours.Where(b => b.User.Id == userId).FirstOrDefaultAsync();
        if (userBehaviour != null)
        {
            var userBehaviourDto = mapper.Map<UserBehaviourDTO>(userBehaviour);
            userBehaviourDto.User = userId;
            return Ok(userBehaviourDto);
        }

        return NotFound("User wurde nicht gefunden");
    }
}