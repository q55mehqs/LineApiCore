using Newtonsoft.Json;

namespace LineApi.ResponseObjects.MessageObject.FlexContent.Component
{
    public class Filler : IComponent
    {
        [JsonProperty(PropertyName = "type")]
        public string Type => "filler";
        
        [JsonProperty(PropertyName = "flex")]
        public int? Flex { get; set; }
    }
}