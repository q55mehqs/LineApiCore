using Newtonsoft.Json;

namespace LineApi.ResponseObjects.MessageObject.FlexContent.Component
{
    public interface IComponent
    {
        [JsonProperty(PropertyName = "type")] public string Type { get; }
    }
}