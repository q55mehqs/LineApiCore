using Newtonsoft.Json;

namespace LineApi
{
    public class GroupInformation
    {
        [JsonProperty(PropertyName = "groupId")]
        public string GroupId { get; set; } = null!;

        [JsonProperty(PropertyName = "groupName")]
        public string GroupName { get; set; } = null!;

        [JsonProperty(PropertyName = "pictureUrl")]
        public string PictureUrl { get; set; } = null!;
    }
}