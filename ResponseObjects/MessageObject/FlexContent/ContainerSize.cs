using System.Runtime.Serialization;

namespace LineApi.ResponseObjects.MessageObject.FlexContent
{
    public enum ContainerSize
    {
        [EnumMember(Value = "nano")] Nano,
        [EnumMember(Value = "micro")] Micro,
        [EnumMember(Value = "kilo")] Kilo,
        [EnumMember(Value = "mega")] Mega,
        [EnumMember(Value = "giga")] Giga
    }
}