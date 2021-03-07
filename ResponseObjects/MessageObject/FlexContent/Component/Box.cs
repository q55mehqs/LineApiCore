using System.Collections.Generic;
using System.Runtime.Serialization;
using LineApi.ResponseObjects.ActionObject;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LineApi.ResponseObjects.MessageObject.FlexContent.Component
{
    public class Box : IComponent
    {
        [JsonProperty(PropertyName = "type")] public string Type => "box";

        [JsonProperty(PropertyName = "layout")]
        [JsonConverter(typeof(StringEnumConverter))]
        public LayoutProperty Layout { get; set; }

        [JsonProperty(PropertyName = "contents")]
        public List<IComponent> Contents { get; set; } = null!;

        [JsonProperty(PropertyName = "backgroundColor")]
        public string? BackgroundColor { get; set; }

        [JsonProperty(PropertyName = "borderColor")]
        public string? BorderColor { get; set; }

        [JsonProperty(PropertyName = "borderWidth")]
        [JsonConverter(typeof(StringEnumConverter))]
        public BorderWidthProperty? BorderWidth { get; set; }

        [JsonProperty(PropertyName = "cornerRadius")]
        [JsonConverter(typeof(StringEnumConverter))]
        public SizeProperty? CornerRadius { get; set; }

        [JsonProperty(PropertyName = "width")] public string? Width { get; set; }

        [JsonProperty(PropertyName = "height")]
        public string? Height { get; set; }

        [JsonProperty(PropertyName = "flex")] public int? Flex { get; set; }

        [JsonProperty(PropertyName = "spacing")]
        public string? Spacing { get; set; }

        [JsonProperty(PropertyName = "margin")]
        public string? Margin { get; set; }

        [JsonProperty(PropertyName = "paddingAll")]
        public string? PaddingAll { get; set; }

        [JsonProperty(PropertyName = "paddingTop")]
        public string? PaddingTop { get; set; }

        [JsonProperty(PropertyName = "paddingBottom")]
        public string? PaddingBottom { get; set; }

        [JsonProperty(PropertyName = "paddingStart")]
        public string? PaddingStart { get; set; }

        [JsonProperty(PropertyName = "paddingEnd")]
        public string? PaddingEnd { get; set; }

        [JsonProperty(PropertyName = "position")]
        [JsonConverter(typeof(StringEnumConverter))]
        public PositionProperty Position { get; set; } = PositionProperty.Relative;

        [JsonProperty(PropertyName = "offsetTop")]
        public string? OffsetTop { get; set; }

        [JsonProperty(PropertyName = "offsetBottom")]
        public string? OffsetBottom { get; set; }

        [JsonProperty(PropertyName = "offsetStart")]
        public string? OffsetStart { get; set; }

        [JsonProperty(PropertyName = "offsetEnd")]
        public string? OffsetEnd { get; set; }

        [JsonProperty(PropertyName = "action")]
        public IActionObject? Action { get; set; }
    }

    public enum BorderWidthProperty
    {
        [EnumMember(Value = "none")] None,
        [EnumMember(Value = "light")] Light,
        [EnumMember(Value = "normal")] Normal,
        [EnumMember(Value = "medium")] Medium,
        [EnumMember(Value = "semi-bold")] SemiBold,
        [EnumMember(Value = "bold")] Bold
    }
}