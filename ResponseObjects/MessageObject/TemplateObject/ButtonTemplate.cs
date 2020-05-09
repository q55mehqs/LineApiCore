using System.Collections.Generic;
using LineApi.ResponseObjects.MessageObject.TemplateObject.ActionObject;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LineApi.ResponseObjects.MessageObject.TemplateObject
{
    public class ButtonTemplate : ITemplateObject
    {
        [JsonProperty(PropertyName = "type")] public string Type => "buttons";

        [JsonProperty(PropertyName = "thumbnailImageUrl")]
        public string? ThumbnailImageUrl { get; set; }

        [JsonProperty(PropertyName = "imageAspectRatio")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ImageAspect? ImageAspectRatio { get; set; }

        [JsonProperty(PropertyName = "imageSize")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ImageSize? ImageSize { get; set; }

        [JsonProperty(PropertyName = "imageBackgroundColor")]
        public string? ImageBackgroundColor { get; set; }

        [JsonProperty(PropertyName = "title")] public string? Title { get; set; }
        [JsonProperty(PropertyName = "text")] public string Text { get; set; }

        [JsonProperty(PropertyName = "defaultAction")]
        public IActionObject? DefaultAction { get; set; }

        [JsonProperty(PropertyName = "actions")]
        public IEnumerable<IActionObject> Actions { get; }

        public ButtonTemplate(string text, IEnumerable<IActionObject> actions)
        {
            Text = text;
            Actions = actions;
        }
    }
}