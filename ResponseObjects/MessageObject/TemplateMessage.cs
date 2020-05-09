using LineApi.ResponseObjects.MessageObject.TemplateObject;
using Newtonsoft.Json;

namespace LineApi.ResponseObjects.MessageObject
{
    public class TemplateMessage : IMessageObject
    {
        [JsonProperty(PropertyName = "type")] public string Type => "template";
        [JsonProperty(PropertyName = "altText")] public string AltText { get; set; }
        [JsonProperty(PropertyName = "template")] public ITemplateObject Template { get; set; }

        public TemplateMessage(string altText, ITemplateObject template)
        {
            AltText = altText;
            Template = template;
        }
    }
}