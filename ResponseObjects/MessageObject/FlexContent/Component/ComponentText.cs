using System.Collections.Generic;
using System.Runtime.Serialization;
using LineApi.ResponseObjects.ActionObject;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LineApi.ResponseObjects.MessageObject.FlexContent.Component
{
    public class ComponentText : IComponent
    {
        [JsonProperty(PropertyName = "type")] public string Type => "text";
        [JsonProperty(PropertyName = "text")] public string? Text { get; set; }

        [JsonProperty(PropertyName = "contents")]
        public List<Span>? Contents { get; set; }

        [JsonProperty(PropertyName = "flex")] public int? Flex { get; set; }

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

        [JsonProperty(PropertyName = "align")]
        [JsonConverter(typeof(StringEnumConverter))]
        public AlignProperty Align { get; set; } = AlignProperty.Center;

        [JsonProperty(PropertyName = "gravity")]
        [JsonConverter(typeof(StringEnumConverter))]
        public GravityProperty? Gravity { get; set; }

        [JsonProperty(PropertyName = "size")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ImageSizeProperty Size { get; set; } = ImageSizeProperty.Medium;

        [JsonProperty(PropertyName = "wrap")] public bool Wrap { get; set; }

        [JsonProperty(PropertyName = "maxLines")]
        public int MaxLines { get; set; }

        [JsonProperty(PropertyName = "weight")]
        [JsonConverter(typeof(StringEnumConverter))]
        public TextWeightProperty Weight { get; set; } = TextWeightProperty.Regular;

        [JsonProperty(PropertyName = "color")] public string? Color { get; set; }

        [JsonProperty(PropertyName = "action")]
        public IActionObject? Action { get; set; }

        [JsonProperty(PropertyName = "style")]
        [JsonConverter(typeof(StringEnumConverter))]
        public TextStyleProperty Style { get; set; } = TextStyleProperty.Normal;

        [JsonProperty(PropertyName = "decoration")]
        [JsonConverter(typeof(StringEnumConverter))]
        public TextDecorationProperty Decoration { get; set; } = TextDecorationProperty.None;
    }

    public class Span
    {
        [JsonProperty(PropertyName = "type")] public string Type => "span";
        [JsonProperty(PropertyName = "text")] public string Text { get; set; } = null!;
        [JsonProperty(PropertyName = "color")] public string? Color { get; set; }

        [JsonProperty(PropertyName = "size")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ImageSizeProperty Size { get; set; } = ImageSizeProperty.Medium;

        [JsonProperty(PropertyName = "weight")]
        [JsonConverter(typeof(StringEnumConverter))]
        public TextWeightProperty Weight { get; set; } = TextWeightProperty.Regular;

        [JsonProperty(PropertyName = "style")]
        [JsonConverter(typeof(StringEnumConverter))]
        public TextStyleProperty Style { get; set; } = TextStyleProperty.Normal;

        [JsonProperty(PropertyName = "decoration")]
        [JsonConverter(typeof(StringEnumConverter))]
        public TextDecorationProperty Decoration { get; set; } = TextDecorationProperty.None;
    }

    public enum TextWeightProperty
    {
        [EnumMember(Value = "regular")] Regular,
        [EnumMember(Value = "bold")] Bold
    }

    public enum TextStyleProperty
    {
        [EnumMember(Value = "normal")] Normal,
        [EnumMember(Value = "italic")] Italic
    }

    public enum TextDecorationProperty
    {
        [EnumMember(Value = "none")] None,
        [EnumMember(Value = "underline")] Underline,
        [EnumMember(Value = "line-through")] LineThrough
    }
}