using System.Collections.Generic;
using System.Threading.Tasks;
using Eventinars.Application.Interfaces.Common;
using Eventinars.Application.Requests.Identity;
using Eventinars.Application.Responses.Identity;
using Eventinars.Shared.Wrapper;

namespace Eventinars.Application.Interfaces.Services.Identity
{
    public interface IRoleClaimService : IService
    {
        Task<Result<List<RoleClaimResponse>>> GetAllAsync();

        Task<int> GetCountAsync();

        Task<Result<RoleClaimResponse>> GetByIdAsync(int id);

        Task<Result<List<RoleClaimResponse>>> GetAllByRoleIdAsync(string roleId);

        Task<Result<string>> SaveAsync(RoleClaimRequest request);

        Task<Result<string>> DeleteAsync(int id);
    }
}