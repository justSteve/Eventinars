using AutoMapper;
using Eventinars.Application.Features.Brands.Commands.AddEdit;
using Eventinars.Application.Features.Brands.Queries.GetAll;
using Eventinars.Application.Features.Brands.Queries.GetById;
using Eventinars.Domain.Entities.Catalog;

namespace Eventinars.Application.Mappings
{
    public class BrandProfile : Profile
    {
        public BrandProfile()
        {
            CreateMap<AddEditBrandCommand, Brand>().ReverseMap();
            CreateMap<GetBrandByIdResponse, Brand>().ReverseMap();
            CreateMap<GetAllBrandsResponse, Brand>().ReverseMap();
        }
    }
}