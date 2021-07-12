using Eventinars.Application.Requests;

namespace Eventinars.Application.Interfaces.Services
{
    public interface IUploadService
    {
        string UploadAsync(UploadRequest request);
    }
}