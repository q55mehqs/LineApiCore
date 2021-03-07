using Newtonsoft.Json;

namespace LineApi.ResponseObjects.ActionObject
{
    public class MessageAction : IActionObject
    {
        [JsonProperty(PropertyName = "type")] public string Type => "message";
        [JsonProperty(PropertyName = "label")] public string? Label { get; set; }
        [JsonProperty(PropertyName = "text")] public string Text { get; set; }

        /// <summary>
        /// ImageCarouselTemplate でのみ利用可
        /// </summary>
        /// <param name="text">アクションの実行時に送信されるテキスト 最大文字数：300</param>
        public MessageAction(string text)
        {
            Text = text;
        }

        /// <summary>
        /// ImageCarouselTemplate以外ではこちらを利用する
        /// </summary>
        /// <param name="label">アクションのラベル</param>
        /// <param name="text">アクションの実行時に送信されるテキスト 最大文字数：300</param>
        public MessageAction(string label, string text)
        {
            Label = label;
            Text = text;
        }
    }
}