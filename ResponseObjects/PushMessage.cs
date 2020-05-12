using System.Collections.Generic;
using LineApi.ResponseObjects.MessageObject;
using Newtonsoft.Json;

namespace LineApi.ResponseObjects
{
    public class PushMessage
    {
        [JsonProperty(PropertyName = "to")] public string To { get; set; }

        [JsonProperty(PropertyName = "messages")]
        public IEnumerable<IMessageObject> Messages { get; set; }

        [JsonProperty(PropertyName = "notificationDisabled")]
        public bool? NotificationDisabled { get; set; }

        public PushMessage(string to, IEnumerable<IMessageObject> messages)
        {
            To = to;
            Messages = messages;
        }
    }
}