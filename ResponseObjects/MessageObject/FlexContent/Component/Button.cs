using System.Runtime.Serialization;
using LineApi.ResponseObjects.MessageObject.TemplateObject.ActionObject;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LineApi.ResponseObjects.MessageObject.FlexContent.Component
{
    public class Button : IComponent
    {
        [JsonProperty(PropertyName = "type")] public string Type => "button";

        [JsonProperty(PropertyName = "action")]
        public IActionObject Action { get; set; } = null!;

        [JsonProperty(PropertyName = "flex")] public int? Flex { get; set; }

        [JsonProperty(PropertyName = "margin")]
        [JsonConverter(typeof(StringEnumConverter))]
        public SizeProperty? Margin { get; set; }

        [JsonProperty(PropertyName = "position")]
        public PositionProperty? Position { get; set; }

        [JsonProperty(PropertyName = "offsetTop")]
        public string? OffsetTop { get; set; }

        [JsonProperty(PropertyName = "offsetBottom")]
        public string? OffsetBottom { get; set; }

        [JsonProperty(PropertyName = "offsetStart")]
        public string? OffsetStart { get; set; }

        [JsonProperty(PropertyName = "offsetEnd")]
        public string? OffsetEnd { get; set; }

        [JsonProperty(PropertyName = "height")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ButtonHeightProperty? Height { get; set; }

        [JsonProperty(PropertyName = "style")]
        public ButtonStyleProperty Style { get; set; } = ButtonStyleProperty.Link;

        [JsonProperty(PropertyName = "color")] public string? Color { get; set; }

        [JsonProperty(PropertyName = "gravity")]
        [JsonConverter(typeof(StringEnumConverter))]
        public GravityProperty? Gravity { get; set; }
    }

    public enum ButtonHeightProperty
    {
        [EnumMember(Value = "sm")] Small,
        [EnumMember(Value = "md")] Medium
    }

    public enum ButtonStyleProperty
    {
        [EnumMember(Value = "primary")] Primary,
        [EnumMember(Value = "secondary")] Secondary,
        [EnumMember(Value = "link")] Link
    }
}