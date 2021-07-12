using System.Text.Json;
using Eventinars.Application.Interfaces.Serialization.Options;

namespace Eventinars.Application.Serialization.Options
{
    public class SystemTextJsonOptions : IJsonSerializerOptions
    {
        public JsonSerializerOptions JsonSerializerOptions { get; } = new();
    }
}