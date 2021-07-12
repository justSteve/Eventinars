using AutoMapper;
using Eventinars.Application.Requests.Identity;
using Eventinars.Application.Responses.Identity;

namespace Eventinars.Client.Infrastructure.Mappings
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<PermissionResponse, PermissionRequest>().ReverseMap();
            CreateMap<RoleClaimResponse, RoleClaimRequest>().ReverseMap();
        }
    }
}