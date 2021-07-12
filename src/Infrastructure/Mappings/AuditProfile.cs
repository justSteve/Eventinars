using AutoMapper;
using Eventinars.Infrastructure.Models.Audit;
using Eventinars.Application.Responses.Audit;

namespace Eventinars.Infrastructure.Mappings
{
    public class AuditProfile : Profile
    {
        public AuditProfile()
        {
            CreateMap<AuditResponse, Audit>().ReverseMap();
        }
    }
}