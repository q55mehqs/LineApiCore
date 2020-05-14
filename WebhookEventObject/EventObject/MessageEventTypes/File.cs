using Newtonsoft.Json;

namespace LineApi.WebhookEventObject.EventObject.MessageEventTypes
{
    public class File : IEventMessage
    {
        [JsonProperty(PropertyName = "id")] public string Id { get; set; } = null!;
        [JsonProperty(PropertyName = "type")] public string Type { get; set; } = null!;

        [JsonProperty(PropertyName = "fileName")]
        public string FileName { get; set; } = null!;

        [JsonProperty(PropertyName = "fileSize")]
        public int FileSizeByte { get; set; }
    }
}