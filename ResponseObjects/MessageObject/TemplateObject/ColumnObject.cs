using System.Collections.Generic;
using LineApi.ResponseObjects.MessageObject.TemplateObject.ActionObject;
using Newtonsoft.Json;

namespace LineApi.ResponseObjects.MessageObject.TemplateObject
{
    public class ColumnObject
    {
        [JsonProperty(PropertyName = "thumbnailImageUrl")]
        public string? ThumbnailImageUrl { get; set; }

        [JsonProperty(PropertyName = "imageBackgroundColor")]
        public string? ImageBackgroundColor { get; set; }

        [JsonProperty(PropertyName = "title")] public string? Title { get; set; }
        [JsonProperty(PropertyName = "text")] public string Text { get; set; }

        [JsonProperty(PropertyName = "defaultAction")]
        public IActionObject? DefaultAction { get; set; }

        [JsonProperty(PropertyName = "actions")]
        public IEnumerable<IActionObject> Actions { get; set; }

        public ColumnObject(string text, IEnumerable<IActionObject> actions)
        {
            Text = text;
            Actions = actions;
        }

        public ColumnObject(string title, string text, IEnumerable<IActionObject> actions)
        {
            Title = title;
            Text = text;
            Actions = actions;
        }
    }
}