using LineApi.ResponseObjects.MessageObject.TemplateObject.ActionObject;
using Newtonsoft.Json;

namespace LineApi.ResponseObjects.MessageObject.TemplateObject
{
    public class ImageColumnObject
    {
        [JsonProperty(PropertyName = "imageUrl")] public string ImageUrl { get; set; }
        [JsonProperty(PropertyName = "action")] public IActionObject Action { get; set; }

        public ImageColumnObject(string imageUrl, IActionObject action)
        {
            ImageUrl = imageUrl;
            Action = action;
        }
    }
}