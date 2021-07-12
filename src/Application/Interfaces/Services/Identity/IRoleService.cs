using Eventinars.Application.Interfaces.Common;
using Eventinars.Application.Requests.Identity;
using Eventinars.Application.Responses.Identity;
using Eventinars.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Eventinars.Application.Interfaces.Services.Identity
{
    public interface IRoleService : IService
    {
        Task<Result<List<RoleResponse>>> GetAllAsync();

        Task<int> GetCountAsync();

        Task<Result<RoleResponse>> GetByIdAsync(string id);

        Task<Result<string>> SaveAsync(RoleRequest request);

        Task<Result<string>> DeleteAsync(string id);

        Task<Result<PermissionResponse>> GetAllPermissionsAsync(string roleId);

        Task<Result<string>> UpdatePermissionsAsync(PermissionRequest request);
    }
}