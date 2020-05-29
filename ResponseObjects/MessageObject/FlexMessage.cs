using LineApi.ResponseObjects.MessageObject.FlexContent;
using Newtonsoft.Json;

namespace LineApi.ResponseObjects.MessageObject
{
    public class FlexMessage : IMessageObject
    {
        [JsonProperty(PropertyName = "type")]
        public string Type => "flex";

        [JsonProperty(PropertyName = "altText")]
        public string AltText { get; set; } = null!;

        [JsonProperty(PropertyName = "contents")]
        public IContainer Contents { get; set; } = null!;
    }
}