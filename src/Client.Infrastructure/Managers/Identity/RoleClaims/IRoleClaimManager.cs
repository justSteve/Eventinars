using System.Collections.Generic;
using System.Threading.Tasks;
using Eventinars.Application.Requests.Identity;
using Eventinars.Application.Responses.Identity;
using Eventinars.Shared.Wrapper;

namespace Eventinars.Client.Infrastructure.Managers.Identity.RoleClaims
{
    public interface IRoleClaimManager : IManager
    {
        Task<IResult<List<RoleClaimResponse>>> GetRoleClaimsAsync();

        Task<IResult<List<RoleClaimResponse>>> GetRoleClaimsByRoleIdAsync(string roleId);

        Task<IResult<string>> SaveAsync(RoleClaimRequest role);

        Task<IResult<string>> DeleteAsync(string id);
    }
}