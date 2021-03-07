using Newtonsoft.Json;

namespace LineApi.ResponseObjects.MessageObject
{
    public class AudioMessage : IMessageObject
    {
        [JsonProperty(PropertyName = "type")] public string Type => "audio";

        /// <summary>
        /// 音声ファイルのURL（最大文字数：1000）
        /// HTTPS（TLS 1.2以降）
        /// m4a
        /// 最大ファイルサイズ：200MB
        /// </summary>
        [JsonProperty("originalContentUrl")]
        public string OriginalContentUrl { get; }
        
        /// <summary>
        /// 音声ファイルの長さ（ミリ秒）
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public int Duration { get; }

        /// <summary>
        /// 音声メッセージ
        /// </summary>
        /// <param name="originalContentUrl">
        /// 音声ファイルのURL（最大文字数：1000）
        /// HTTPS（TLS 1.2以降）
        /// m4a
        /// 最大ファイルサイズ：200MB
        /// </param>
        /// <param name="duration">音声ファイルの長さ（ミリ秒）</param>
        public AudioMessage(string originalContentUrl, int duration)
        {
            OriginalContentUrl = originalContentUrl;
            Duration = duration;
        }
    }
}