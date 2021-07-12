using System.Linq;
using Eventinars.Shared.Constants.Localization;
using Eventinars.Shared.Settings;

namespace Eventinars.Server.Settings
{
    public record ServerPreference : IPreference
    {
        public string LanguageCode { get; set; } = LocalizationConstants.SupportedLanguages.FirstOrDefault()?.Code ?? "en-US";

        //TODO - add server preferences
    }
}