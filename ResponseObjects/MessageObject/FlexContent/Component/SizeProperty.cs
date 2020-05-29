using System.Runtime.Serialization;

namespace LineApi.ResponseObjects.MessageObject.FlexContent.Component
{
    public enum SizeProperty
    {
        [EnumMember(Value = "none")] None,
        [EnumMember(Value = "xs")] Xs,
        [EnumMember(Value = "sm")] Small,
        [EnumMember(Value = "md")] Medium,
        [EnumMember(Value = "lg")] Large,
        [EnumMember(Value = "xl")] Xl,
        [EnumMember(Value = "xxl")] Xxl
    }
}