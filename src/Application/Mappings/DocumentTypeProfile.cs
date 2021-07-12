using AutoMapper;
using Eventinars.Application.Features.DocumentTypes.Commands.AddEdit;
using Eventinars.Application.Features.DocumentTypes.Queries.GetAll;
using Eventinars.Application.Features.DocumentTypes.Queries.GetById;
using Eventinars.Domain.Entities.Misc;

namespace Eventinars.Application.Mappings
{
    public class DocumentTypeProfile : Profile
    {
        public DocumentTypeProfile()
        {
            CreateMap<AddEditDocumentTypeCommand, DocumentType>().ReverseMap();
            CreateMap<GetDocumentTypeByIdResponse, DocumentType>().ReverseMap();
            CreateMap<GetAllDocumentTypesResponse, DocumentType>().ReverseMap();
        }
    }
}