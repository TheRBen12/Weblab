using AutoMapper;
using WebLab.DTO;
using WebLab.Models;
using WebLab.Resolver;

namespace WebLab;

public class MappingProfile: Profile
{
    public MappingProfile()
    {
         CreateMap<UserBehaviour, UserBehaviourDTO>()
                    .ForMember(destination => destination.User, opt => opt.MapFrom(src => src.User.Id));
         
         CreateMap<UserBehaviourDTO, UserBehaviour>()
             .ForMember(dest => dest.User, opt => opt.MapFrom<UserBehaviourToDtoResolver>());
         
         
    }
}