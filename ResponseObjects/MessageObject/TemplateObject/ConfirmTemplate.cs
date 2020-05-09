using System.Collections.Generic;
using LineApi.ResponseObjects.MessageObject.TemplateObject.ActionObject;
using Newtonsoft.Json;

namespace LineApi.ResponseObjects.MessageObject.TemplateObject
{
    public class ConfirmTemplate : ITemplateObject
    {
        [JsonProperty(PropertyName = "type")] public string Type => "confirm";
        [JsonProperty(PropertyName = "text")] public string Text { get; }
        [JsonProperty(PropertyName = "actions")] public IEnumerable<IActionObject> Actions { get; }

        public ConfirmTemplate(string text, IEnumerable<IActionObject> actions)
        {
            Text = text;
            Actions = actions;
        }
    }
}