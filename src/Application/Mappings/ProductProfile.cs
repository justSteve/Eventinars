using AutoMapper;
using Eventinars.Application.Features.Products.Commands.AddEdit;
using Eventinars.Domain.Entities.Catalog;

namespace Eventinars.Application.Mappings
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<AddEditProductCommand, Product>().ReverseMap();
        }
    }
}