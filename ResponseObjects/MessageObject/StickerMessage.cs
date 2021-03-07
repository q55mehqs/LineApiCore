using Newtonsoft.Json;

namespace LineApi.ResponseObjects.MessageObject
{
    public class StickerMessage : IMessageObject
    {
        [JsonProperty(PropertyName = "type")] public string Type => "sticker";

        [JsonProperty(PropertyName = "packageId")]
        public string PackageId { get; }

        [JsonProperty(PropertyName = "stickerId")]
        public string StickerId { get; }

        /// <summary>
        /// スタンプメッセージ
        /// https://developers.line.biz/ja/reference/messaging-api/#sticker-message
        /// </summary>
        /// <param name="packageId">スタンプセットのパッケージID。パッケージIDについては、スタンプリストを参照してください。</param>
        /// <param name="stickerId">スタンプID。Messaging APIで送信できるスタンプのスタンプIDについては、スタンプリストを参照してください。</param>
        public StickerMessage(string packageId, string stickerId)
        {
            PackageId = packageId;
            StickerId = stickerId;
        }
    }
}