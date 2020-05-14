using System.Collections.Generic;
using Newtonsoft.Json;

namespace LineApi.ResponseObjects.MessageObject
{
    public class TextMessage : IMessageObject
    {
        [JsonProperty(PropertyName = "type")] public string Type => "text";
        [JsonProperty(PropertyName = "text")] public string Text { get; }
        [JsonProperty(PropertyName = "emojis")] public List<Emoji>? Emojis { get; set; }

        public TextMessage(string text)
        {
            Text = text;
        }
    }

    public class Emoji
    {
        [JsonProperty(PropertyName = "index")] public int Index { get; }
        [JsonProperty(PropertyName = "productId")] public string ProductId { get; }
        [JsonProperty(PropertyName = "emojiId")] public string EmojiId { get; }

        public Emoji(int index, string productId, string emojiId)
        {
            Index = index;
            ProductId = productId;
            EmojiId = emojiId;
        }
    }
}