using Eventinars.Shared.Wrapper;
using System.Threading.Tasks;
using Eventinars.Application.Features.Dashboards.Queries.GetData;

namespace Eventinars.Client.Infrastructure.Managers.Dashboard
{
    public interface IDashboardManager : IManager
    {
        Task<IResult<DashboardDataResponse>> GetDataAsync();
    }
}