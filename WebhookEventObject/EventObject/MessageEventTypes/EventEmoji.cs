using Newtonsoft.Json;

namespace LineApi.WebhookEventObject.EventObject.MessageEventTypes
{
    public class EventEmoji
    {
        [JsonProperty(PropertyName = "index")] public int Index { get; set; }

        [JsonProperty(PropertyName = "length")]
        public int Length { get; set; }

        [JsonProperty(PropertyName = "productId")]
        public string ProductId { get; set; } = null!;

        [JsonProperty(PropertyName = "emojiId")]
        public string EmojiId { get; set; } = null!;
    }
}