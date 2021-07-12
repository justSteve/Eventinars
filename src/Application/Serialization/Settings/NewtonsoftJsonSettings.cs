
using Eventinars.Application.Interfaces.Serialization.Settings;
using Newtonsoft.Json;

namespace Eventinars.Application.Serialization.Settings
{
    public class NewtonsoftJsonSettings : IJsonSerializerSettings
    {
        public JsonSerializerSettings JsonSerializerSettings { get; } = new();
    }
}