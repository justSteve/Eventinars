using Eventinars.Application.Features.Products.Commands.AddEdit;
using Eventinars.Application.Features.Products.Queries.GetAllPaged;
using Eventinars.Application.Requests.Catalog;
using Eventinars.Shared.Wrapper;
using System.Threading.Tasks;

namespace Eventinars.Client.Infrastructure.Managers.Catalog.Product
{
    public interface IProductManager : IManager
    {
        Task<PaginatedResult<GetAllPagedProductsResponse>> GetProductsAsync(GetAllPagedProductsRequest request);

        Task<IResult<string>> GetProductImageAsync(int id);

        Task<IResult<int>> SaveAsync(AddEditProductCommand request);

        Task<IResult<int>> DeleteAsync(int id);

        Task<IResult<string>> ExportToExcelAsync(string searchString = "");
    }
}