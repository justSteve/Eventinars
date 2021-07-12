using AutoMapper;
using Eventinars.Application.Features.Documents.Commands.AddEdit;
using Eventinars.Application.Features.Documents.Queries.GetById;
using Eventinars.Domain.Entities.Misc;

namespace Eventinars.Application.Mappings
{
    public class DocumentProfile : Profile
    {
        public DocumentProfile()
        {
            CreateMap<AddEditDocumentCommand, Document>().ReverseMap();
            CreateMap<GetDocumentByIdResponse, Document>().ReverseMap();
        }
    }
}