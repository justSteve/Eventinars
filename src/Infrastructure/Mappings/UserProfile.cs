using AutoMapper;
using Eventinars.Infrastructure.Models.Identity;
using Eventinars.Application.Responses.Identity;

namespace Eventinars.Infrastructure.Mappings
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserResponse, BlazorHeroUser>().ReverseMap();
            CreateMap<ChatUserResponse, BlazorHeroUser>().ReverseMap()
                .ForMember(dest => dest.EmailAddress, source => source.MapFrom(source => source.Email)); //Specific Mapping
        }
    }
}