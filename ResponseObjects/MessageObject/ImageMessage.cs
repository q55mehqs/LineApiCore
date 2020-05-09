using Newtonsoft.Json;

namespace LineApi.ResponseObjects.MessageObject
{
    public class ImageMessage : IMessageObject
    {
        [JsonProperty(PropertyName = "type")] public string Type => "image";
        [JsonProperty(PropertyName = "originalContentUrl")] public string OriginalContentUrl { get; set; }
        [JsonProperty(PropertyName = "previewImageUrl")] public string PreviewImageUrl { get; set; }

        public ImageMessage(string originalUrl, string previewUrl)
        {
            OriginalContentUrl = originalUrl;
            PreviewImageUrl = previewUrl;
        }
    }
}