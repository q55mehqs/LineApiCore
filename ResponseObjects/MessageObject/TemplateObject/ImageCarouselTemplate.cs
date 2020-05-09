using System.Collections.Generic;
using Newtonsoft.Json;

namespace LineApi.ResponseObjects.MessageObject.TemplateObject
{
    public class ImageCarouselTemplate : ITemplateObject
    {
        [JsonProperty(PropertyName = "type")] public string Type => "image_carousel";

        [JsonProperty(PropertyName = "columns")]
        public IEnumerable<ImageColumnObject> Columns { get; set; }

        public ImageCarouselTemplate(IEnumerable<ImageColumnObject> columns)
        {
            Columns = columns;
        }
    }
}