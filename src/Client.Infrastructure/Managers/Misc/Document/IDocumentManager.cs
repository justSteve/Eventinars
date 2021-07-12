using Eventinars.Application.Features.Documents.Commands.AddEdit;
using Eventinars.Application.Features.Documents.Queries.GetAll;
using Eventinars.Application.Requests.Documents;
using Eventinars.Shared.Wrapper;
using System.Threading.Tasks;
using Eventinars.Application.Features.Documents.Queries.GetById;

namespace Eventinars.Client.Infrastructure.Managers.Misc.Document
{
    public interface IDocumentManager : IManager
    {
        Task<PaginatedResult<GetAllDocumentsResponse>> GetAllAsync(GetAllPagedDocumentsRequest request);

        Task<IResult<GetDocumentByIdResponse>> GetByIdAsync(GetDocumentByIdQuery request);

        Task<IResult<int>> SaveAsync(AddEditDocumentCommand request);

        Task<IResult<int>> DeleteAsync(int id);
    }
}