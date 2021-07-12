using AutoMapper;
using Eventinars.Infrastructure.Models.Identity;
using Eventinars.Application.Responses.Identity;

namespace Eventinars.Infrastructure.Mappings
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<RoleResponse, BlazorHeroRole>().ReverseMap();
        }
    }
}