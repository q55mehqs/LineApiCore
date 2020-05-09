using System.Collections.Generic;
using LineApi.ResponseObjects.MessageObject;
using Newtonsoft.Json;

namespace LineApi.ResponseObjects
{
    public class ResponseMessage
    {
        [JsonProperty(PropertyName = "replyToken")] public string ReplyToken { get; set; }
        [JsonProperty(PropertyName = "messages")] public List<IMessageObject> Messages { get; set; }

        // [JsonProperty(PropertyName = "notificationDisabled")] public bool NotificationDisabled { get; set; }

        public ResponseMessage(string replyToken, List<IMessageObject> messages)
        {
            ReplyToken = replyToken;
            Messages = messages;
        }
    }
}