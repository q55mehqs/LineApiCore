using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LineApi.ResponseObjects.MessageObject.TemplateObject
{
    public class CarouselTemplate: ITemplateObject
    {
        [JsonProperty(PropertyName = "type")] public string Type => "carousel";
        [JsonProperty(PropertyName = "columns")] public IEnumerable<ColumnObject> Columns { get; set; }
        
        [JsonProperty(PropertyName = "imageAspectRatio")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ImageAspect? ImageAspectRatio { get; set; }
        
        [JsonProperty(PropertyName = "imageSize")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ImageSize? ImageSize { get; set; }

        public CarouselTemplate(IEnumerable<ColumnObject> columns)
        {
            Columns = columns;
        }
    }
}