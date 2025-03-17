using AutoMapper;
using WebLab.Data;
using WebLab.DTO;
using WebLab.Models;

namespace WebLab.Resolver;

public class UserBehaviourToDtoResolver: IValueResolver<UserBehaviourDTO, UserBehaviour, User>
{
    
    
    private readonly ApplicationDbContext _context;

    public UserBehaviourToDtoResolver(ApplicationDbContext context)
    {
        _context = context;
    }

    public User Resolve(UserBehaviourDTO source, UserBehaviour destination, User destMember, ResolutionContext context)
    {
        var user = _context.Users.Find(source.User);
        if (user != null)
        {
            return user;
        }

        throw new Exception($"User mit ID {source.User} wurde nicht gefunden.");
    }


}