using System.Runtime.Serialization;

namespace LineApi.WebhookEventObject.EventObject
{
    public enum Mode
    {
        [EnumMember(Value = "active")] Active,
        [EnumMember(Value = "standby")] Standby
    }
}