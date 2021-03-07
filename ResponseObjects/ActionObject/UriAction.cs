using Newtonsoft.Json;

namespace LineApi.ResponseObjects.ActionObject
{
    public class UriAction : IActionObject
    {
        [JsonProperty(PropertyName = "type")] public string Type => "uri";
        [JsonProperty(PropertyName = "label")] public string? Label { get; set; }
        [JsonProperty(PropertyName = "uri")] public string Uri { get; set; }

        /// <summary>
        /// ImageCarouselTemplate でのみ利用可
        /// </summary>
        /// <param name="uri">アクション実行時に開かれるURI(最大文字数: 1000) http, https, line, telを利用可</param>
        public UriAction(string uri)
        {
            Uri = uri;
        }

        /// <summary>
        /// ImageCarouselTemplate以外ではこちらを利用する
        /// </summary>
        /// <param name="label"></param>
        /// <param name="uri"></param>
        public UriAction(string label, string uri)
        {
            Label = label;
            Uri = uri;
        }
    }
}