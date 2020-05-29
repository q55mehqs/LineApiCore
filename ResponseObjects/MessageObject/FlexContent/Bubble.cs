using System.Collections.Generic;
using System.Runtime.Serialization;
using LineApi.ResponseObjects.MessageObject.TemplateObject.ActionObject;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace LineApi.ResponseObjects.MessageObject.FlexContent
{
    public class Bubble : IContainer
    {
        [JsonProperty(PropertyName = "type")] public string Type => "bubble";

        [JsonProperty(PropertyName = "size")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ContainerSize Size { get; set; } = ContainerSize.Mega;

        [JsonProperty(PropertyName = "direction")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Directions Direction { get; set; } = Directions.LeftToRight;

        [JsonProperty(PropertyName = "header")]
        public Dictionary<string, JToken>? Header { get; set; }

        [JsonProperty(PropertyName = "hero")] public Dictionary<string, JToken>? Hero { get; set; }

        [JsonProperty(PropertyName = "body")] public Dictionary<string, JToken>? Body { get; set; }

        [JsonProperty(PropertyName = "footer")]
        public Dictionary<string, JToken>? Footer { get; set; }

        [JsonProperty(PropertyName = "styles")]
        public Dictionary<string, JToken>? Styles { get; set; }

        [JsonProperty(PropertyName = "action")]
        public IActionObject? Action { get; set; }
    }

    public enum Directions
    {
        [EnumMember(Value = "ltr")] LeftToRight,
        [EnumMember(Value = "rtl")] RightToLeft
    }
}