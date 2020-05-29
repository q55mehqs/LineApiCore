using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LineApi.ResponseObjects.MessageObject.FlexContent.Component
{
    public class Separator : IComponent
    {
        [JsonProperty(PropertyName = "type")] public string Type => "separator";

        [JsonProperty(PropertyName = "margin")]
        [JsonConverter(typeof(StringEnumConverter))]
        public SizeProperty? Margin { get; set; }

        [JsonProperty(PropertyName = "color")] public string? Color { get; set; }
    }
}