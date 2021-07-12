using Eventinars.Application.Interfaces.Common;
using Eventinars.Application.Requests.Identity;
using Eventinars.Shared.Wrapper;
using System.Threading.Tasks;

namespace Eventinars.Application.Interfaces.Services.Account
{
    public interface IAccountService : IService
    {
        Task<IResult> UpdateProfileAsync(UpdateProfileRequest model, string userId);

        Task<IResult> ChangePasswordAsync(ChangePasswordRequest model, string userId);

        Task<IResult<string>> GetProfilePictureAsync(string userId);

        Task<IResult<string>> UpdateProfilePictureAsync(UpdateProfilePictureRequest request, string userId);
    }
}