using Newtonsoft.Json;

namespace LineApi.WebhookEventObject.SenderSource
{
    public class SourceObject
    {
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
            
        [JsonProperty(PropertyName = "userId")]
        public string UserId { get; set; }
        
        [JsonProperty(PropertyName = "groupId")]
        public string? GroupId { get; set; }
        
        [JsonProperty(PropertyName = "roomId")]
        public string? RoomId { get; set; }

        public SourceObject()
        {
            Type = null!;
            UserId = null!;
        }
    }
}