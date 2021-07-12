using Eventinars.Application.Interfaces.Common;
using Eventinars.Application.Requests.Identity;
using Eventinars.Application.Responses.Identity;
using Eventinars.Shared.Wrapper;
using System.Threading.Tasks;

namespace Eventinars.Application.Interfaces.Services.Identity
{
    public interface ITokenService : IService
    {
        Task<Result<TokenResponse>> LoginAsync(TokenRequest model);

        Task<Result<TokenResponse>> GetRefreshTokenAsync(RefreshTokenRequest model);
    }
}