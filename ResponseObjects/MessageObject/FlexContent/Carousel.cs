using System.Collections.Generic;
using Newtonsoft.Json;

namespace LineApi.ResponseObjects.MessageObject.FlexContent
{
    public class Carousel : IContainer
    {
        [JsonProperty(PropertyName = "type")] public string Type => "carousel";

        [JsonProperty(PropertyName = "contents")]
        public List<Bubble> Contents { get; set; } = null!;
    }
}