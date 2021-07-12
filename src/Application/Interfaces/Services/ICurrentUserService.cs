using Eventinars.Application.Interfaces.Common;

namespace Eventinars.Application.Interfaces.Services
{
    public interface ICurrentUserService : IService
    {
        string UserId { get; }
    }
}