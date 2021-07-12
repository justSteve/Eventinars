using Newtonsoft.Json;

namespace Eventinars.Application.Interfaces.Serialization.Settings
{
    public interface IJsonSerializerSettings
    {
        /// <summary>
        /// Settings for <see cref="Newtonsoft.Json"/>.
        /// </summary>
        public JsonSerializerSettings JsonSerializerSettings { get; }
    }
}