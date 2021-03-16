using System.Collections.Generic;
using LineApi.ResponseObjects.ActionObject;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LineApi.ResponseObjects.MessageObject.TemplateObject
{
    public class ButtonTemplate : ITemplateObject
    {
        [JsonProperty(PropertyName = "type")] public string Type => "buttons";

        /// <summary>
        /// 画像URL（最大文字数：1000）
        /// HTTPS（TLS 1.2以降）
        /// JPEGまたはPNG
        /// 最大横幅サイズ：1024px
        /// 最大ファイルサイズ：10MB
        ///
        /// 画像のファイルメッセージの表示が遅延することを防ぐために、個々の画像ファイルサイズを小さくしてください（1MB以下推奨）。
        /// </summary>
        [JsonProperty(PropertyName = "thumbnailImageUrl")]
        public string? ThumbnailImageUrl { get; set; }

        /// <summary>
        /// 画像のアスペクト比。以下のいずれかの値を指定します。
        /// デフォルト値はrectangleです。
        /// </summary>
        [JsonProperty(PropertyName = "imageAspectRatio")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ImageAspect? ImageAspectRatio { get; set; }

        /// <summary>
        /// 画像の表示形式。以下のいずれかの値を指定します。
        /// デフォルト値はcoverです。
        /// </summary>
        [JsonProperty(PropertyName = "imageSize")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ImageSize? ImageSize { get; set; }

        /// <summary>
        /// 画像の背景色。RGB値で設定します。デフォルト値は#FFFFFF（白）です。
        /// </summary>
        [JsonProperty(PropertyName = "imageBackgroundColor")]
        public string? ImageBackgroundColor { get; set; }

        /// <summary>
        /// タイトル
        /// 最大文字数：40
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string? Title { get; set; }

        /// <summary>
        /// メッセージテキスト
        /// 画像もタイトルも指定しない場合の最大文字数：160
        /// 画像またはタイトルを指定する場合の最大文字数：60
        /// </summary>
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        /// <summary>
        /// 画像、タイトル、テキストの領域全体に対して設定できる、タップされたときのアクション
        /// </summary>
        [JsonProperty(PropertyName = "defaultAction")]
        public IActionObject? DefaultAction { get; set; }

        /// <summary>
        /// タップされたときのアクション
        /// 最大件数：4
        /// </summary>
        [JsonProperty(PropertyName = "actions")]
        public IEnumerable<IActionObject> Actions { get; }

        /// <summary>
        /// 画像、タイトル、テキストに加えて、複数のアクションボタンが含まれたテンプレートです。
        /// </summary>
        /// <param name="text">
        /// メッセージテキスト
        /// 画像もタイトルも指定しない場合の最大文字数：160
        /// 画像またはタイトルを指定する場合の最大文字数：60
        /// </param>
        /// <param name="actions">
        /// タップされたときのアクション
        /// 最大件数：4
        /// </param>
        public ButtonTemplate(string text, IEnumerable<IActionObject> actions)
        {
            Text = text;
            Actions = actions;
        }
    }
}