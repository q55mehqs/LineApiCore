using Newtonsoft.Json;

namespace LineApi.ResponseObjects.MessageObject
{
    public class TextMessage : IMessageObject
    {
        [JsonProperty(PropertyName = "type")] public string Type => "text";
        [JsonProperty(PropertyName = "text")] public string Text { get; }

        public TextMessage(string text)
        {
            Text = text;
        }
    }
}