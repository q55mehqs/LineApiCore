using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LineApi.ResponseObjects.MessageObject.FlexContent.Component
{
    public class Icon : IComponent
    {
        [JsonProperty(PropertyName = "type")] public string Type => "icon";

        [JsonProperty(PropertyName = "url")] public string Url { get; set; } = null!;

        [JsonProperty(PropertyName = "margin")]
        [JsonConverter(typeof(StringEnumConverter))]
        public SizeProperty? Margin { get; set; }

        [JsonProperty(PropertyName = "position")]
        [JsonConverter(typeof(StringEnumConverter))]
        public PositionProperty? Position { get; set; }

        [JsonProperty(PropertyName = "offsetTop")]
        public string? OffsetTop { get; set; }

        [JsonProperty(PropertyName = "offsetBottom")]
        public string? OffsetBottom { get; set; }

        [JsonProperty(PropertyName = "offsetStart")]
        public string? OffsetStart { get; set; }

        [JsonProperty(PropertyName = "offsetEnd")]
        public string? OffsetEnd { get; set; }

        [JsonProperty(PropertyName = "size")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ImageSizeProperty Size { get; set; } = ImageSizeProperty.Medium;

        [JsonProperty(PropertyName = "aspectRatio")]
        public string AspectRatio { get; set; } = "1:1";
    }
}