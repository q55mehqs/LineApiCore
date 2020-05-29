using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LineApi.ResponseObjects.MessageObject.FlexContent
{
    public interface IContainer
    {
        [JsonProperty(PropertyName = "type")]
        public string Type { get; }
    }
}