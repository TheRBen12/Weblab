using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebLab.Data;
using WebLab.DTO;
using WebLab.Models;

namespace WebLab.Controllers;

public class EmailController(ApplicationDbContext context) : BaseController
{
    public readonly ApplicationDbContext _context = context;


    [HttpPost("new")]
    public async Task<ActionResult<DeletedMailDto>> DeleteEmail(DeletedMailDto email)
    {
        
        if (email == null)
        {
            return BadRequest("Email object is null");
        }

        var mail = context.Mails.FindAsync(email.Id).Result;
        if (mail != null)
        {
            context.Mails.Remove(mail);
        }

        var user = await context.Users.FindAsync(email.User);
        
        var deletedMail = new DeletedMail()
        {
            Id = email.Id,
            Sender = email.Sender,
            Receiver = email.Receiver,
            Body = email.Body,
            User = user,
            Subject = email.Subject,
            Date = email.Date,
            DeletedAt = new DateTime()
        };

        context.DeletedMails.Add(deletedMail);
        await context.SaveChangesAsync();
        return Ok(email);
        
    }


    [HttpGet("deleted/all")]
    public async Task<ActionResult<IEnumerable<DeletedMail>>> GetDeletedEmails()
    {
        return await context.DeletedMails.ToListAsync();
    }
    
    [HttpGet("mails/all")]
    public async Task<ActionResult<IEnumerable<Mail>>> GetEmails()
    {
        return await context.Mails.ToListAsync();
    }
}