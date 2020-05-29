using System.Runtime.Serialization;
using LineApi.ResponseObjects.MessageObject.TemplateObject.ActionObject;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LineApi.ResponseObjects.MessageObject.FlexContent.Component
{
    public class Image : IComponent
    {
        [JsonProperty(PropertyName = "type")] public string Type => "image";
        [JsonProperty(PropertyName = "url")] public string Url { get; set; } = null!;
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

        [JsonProperty(PropertyName = "aspectRatio")]
        public string AspectRatio { get; set; } = "1:1";
        
        [JsonProperty(PropertyName = "aspectMode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public AspectModeProperty? AspectMode { get; set; }
        
        [JsonProperty(PropertyName = "backgroundColor")]
        public string? BackgroundColor { get; set; }
        
        [JsonProperty(PropertyName = "action")]
        public IActionObject? Action { get; set; }
    }

    public enum ImageSizeProperty
    {
        [EnumMember(Value = "xxs")] Xxs,
        [EnumMember(Value = "xs")] Xs,
        [EnumMember(Value = "sm")] Small,
        [EnumMember(Value = "md")] Medium,
        [EnumMember(Value = "lg")] Large,
        [EnumMember(Value = "xl")] Xl,
        [EnumMember(Value = "xxl")] Xxl,
        [EnumMember(Value = "3xl")] _3xl,
        [EnumMember(Value = "4xl")] _4xl,
        [EnumMember(Value = "5xl")] _5xl,
        [EnumMember(Value = "full")] Full
    }

    public enum AspectModeProperty
    {
        [EnumMember(Value = "cover")] Cover,
        [EnumMember(Value = "fit")] Fit
    }
}