using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace LineApi
{
    public class LineBaseObject
    {
        [JsonProperty(PropertyName = "destination")]
        public string? Destination { get; set; }

        [JsonProperty(PropertyName = "events")]
        public IEnumerable<JToken>? Events { get; set; }
    }
}