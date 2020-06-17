using System.Collections.Generic;
using LineApi.ResponseObjects.MessageObject;
using Newtonsoft.Json;

namespace LineApi.ResponseObjects
{
    public class MultiCastMessage
    {
        [JsonProperty(PropertyName = "to")] public IEnumerable<string> To { get; set; }

        [JsonProperty(PropertyName = "messages")]
        public IEnumerable<IMessageObject> Messages { get; set; }
        
        [JsonProperty(PropertyName = "notificationDisabled")]
        public bool NotificationDisabled { get; set; }

        public MultiCastMessage(IEnumerable<string> to, IEnumerable<IMessageObject> messages)
        {
            To = to;
            Messages = messages;
        }
    }
}