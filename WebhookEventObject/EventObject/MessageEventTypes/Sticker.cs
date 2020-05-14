using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LineApi.WebhookEventObject.EventObject.MessageEventTypes
{
    public class Sticker : IEventMessage
    {
        [JsonProperty(PropertyName = "id")] public string Id { get; set; } = null!;
        [JsonProperty(PropertyName = "type")] public string Type { get; set; } = null!;

        [JsonProperty(PropertyName = "packageId")]
        public string PackageId { get; set; } = null!;

        [JsonProperty(PropertyName = "stickerId")]
        public string StickerId { get; set; } = null!;

        [JsonProperty(PropertyName = "stickerResourceType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public StickerResourceType StickerResourceType { get; set; }
    }

    public enum StickerResourceType
    {
        Other,
        [EnumMember(Value = "STATIC")] Static,
        [EnumMember(Value = "ANIMATION")] Animation,
        [EnumMember(Value = "SOUND")] Sound,

        [EnumMember(Value = "ANIMATION_SOUND")]
        AnimationSound,
        [EnumMember(Value = "POPUP")] PopUp,
        [EnumMember(Value = "NAME_TEXT")] NameText,

        [EnumMember(Value = "PER_STICKER_TEXT")]
        PerStickerText
    }
}