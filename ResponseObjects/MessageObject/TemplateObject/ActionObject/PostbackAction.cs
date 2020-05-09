using Newtonsoft.Json;

namespace LineApi.ResponseObjects.MessageObject.TemplateObject.ActionObject
{
    public class PostbackAction : IActionObject
    {
        [JsonProperty(PropertyName = "type")] public string Type => "postback";
        [JsonProperty(PropertyName = "label")] public string? Label { get; set; }
        [JsonProperty(PropertyName = "data")] public string Data { get; set; }

        [JsonProperty(PropertyName = "displayText")]
        public string? DisplayText { get; set; }

        /// <summary>
        /// ImageCarouselTemplate でのみ利用可
        /// </summary>
        /// <param name="data">Webhookを介して、ポストバックイベントの["postback"]["data"] で返される文字列 最大文字数: 300</param>
        public PostbackAction(string data)
        {
            Data = data;
        }

        /// <summary>
        /// ImageCarouselTemplate以外ではこちらを利用する
        /// </summary>
        /// <param name="label">アクションのラベル 最大文字数: 20</param>
        /// <param name="data">Webhookを介して、ポストバックイベントの["postback"]["data"] で返される文字列 最大文字数: 300</param>
        public PostbackAction(string label, string data)
        {
            Label = label;
            Data = data;
        }
    }
}