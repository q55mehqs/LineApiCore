using System.Collections.Generic;
using Newtonsoft.Json;

namespace LineApi
{
    public class LineBaseObject
    {
        [JsonProperty(PropertyName = "destination")]
        public string? Destination { get; set; }

        [JsonProperty(PropertyName = "events")]
        public IEnumerable<object>? Events { get; set; }
    }
}