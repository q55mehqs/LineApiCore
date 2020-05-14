using Newtonsoft.Json;

namespace LineApi.WebhookEventObject.EventObject.MessageEventTypes
{
    public interface IEventMessage
    {
        [JsonProperty(PropertyName = "id")] public string Id { get; set; }
        [JsonProperty(PropertyName = "type")] public string Type { get; set; }
    }
}