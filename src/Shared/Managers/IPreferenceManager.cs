using Eventinars.Shared.Settings;
using System.Threading.Tasks;
using Eventinars.Shared.Wrapper;

namespace Eventinars.Shared.Managers
{
    public interface IPreferenceManager
    {
        Task SetPreference(IPreference preference);

        Task<IPreference> GetPreference();

        Task<IResult> ChangeLanguageAsync(string languageCode);
    }
}