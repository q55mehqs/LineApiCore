using Newtonsoft.Json;

namespace LineApi.ResponseObjects.MessageObject
{
    public class VideoMessage : IMessageObject
    {
        [JsonProperty(PropertyName = "type")] public string Type => "video";

        /// <summary>
        /// 動画ファイルのURL（最大文字数：1000） HTTPS（TLS 1.2以降）
        /// mp4 最大ファイルサイズ：200MB
        /// </summary>
        [JsonProperty(PropertyName = "originalContentUrl")]
        public string OriginalContentUrl { get; }

        /// <summary>
        /// プレビュー画像のURL（最大文字数：1000） HTTPS（TLS 1.2以降）
        /// JPEGまたはPNG 最大ファイルサイズ：1MB
        /// </summary>
        [JsonProperty(PropertyName = "previewImageUrl")]
        public string PreviewImageUrl { get; }

        /// <summary>
        /// 動画視聴完了イベントが発生したときに、動画を識別するためのID。trackingIdを付与した動画メッセージを送信した場合に限り、ユーザーが動画の視聴を完了すると動画視聴完了イベントが発生します。
        /// 複数のメッセージで同じIDを使用することができます。
        /// 最大文字数：100
        /// 使用可能文字種：半角英数字（a〜z、A～Z、0～9）、記号
        /// 注意：trackingIdプロパティは、グループやトークルーム宛てのメッセージや、オーディエンスマッチでは使用できません。
        /// </summary>
        [JsonProperty(PropertyName = "trackingId")]
        public string? TrackingId { get; }

        /// <summary>
        /// 動画メッセージ
        /// https://developers.line.biz/ja/reference/messaging-api/#video-message
        /// </summary>
        /// <param name="originalContentUrl">動画ファイルのURL（最大文字数：1000） HTTPS（TLS 1.2以降）
        /// mp4 最大ファイルサイズ：200MB</param>
        /// <param name="previewImageUrl">プレビュー画像のURL（最大文字数：1000） HTTPS（TLS 1.2以降）
        /// JPEGまたはPNG 最大ファイルサイズ：1MB</param>
        public VideoMessage(string originalContentUrl, string previewImageUrl)
        {
            OriginalContentUrl = originalContentUrl;
            PreviewImageUrl = previewImageUrl;
        }
    }
}