using Newtonsoft.Json;

namespace LineApi
{
    public class ProfileInformation
    {
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; } = null!;

        [JsonProperty(PropertyName = "userId")]
        public string UserId { get; set; } = null!;

        [JsonProperty(PropertyName = "language")]
        public string Language { get; set; } = null!;

        [JsonProperty(PropertyName = "pictureUrl")]
        public string PictureUrl { get; set; } = null!;

        [JsonProperty(PropertyName = "statusMessage")]
        public string StatusMessage { get; set; } = null!;
    }
}