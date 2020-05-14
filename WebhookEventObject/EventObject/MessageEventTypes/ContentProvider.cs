using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LineApi.WebhookEventObject.EventObject.MessageEventTypes
{
    public class ContentProvider
    {
        [JsonProperty(PropertyName = "type")] public ContentProviderType Type { get; set; }

        [JsonProperty(PropertyName = "originalContentUrl")]
        public string? OriginalContentUrl { get; set; }

        [JsonProperty(PropertyName = "previewImageUrl")]
        public string? PreviewImageUrl { get; set; }
    }


    public enum ContentProviderType
    {
        Other,
        [EnumMember(Value = "line")] Line,
        [EnumMember(Value = "external")] External
    }
}