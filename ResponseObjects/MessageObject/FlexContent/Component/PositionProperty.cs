using System.Runtime.Serialization;

namespace LineApi.ResponseObjects.MessageObject.FlexContent.Component
{
    public enum PositionProperty
    {
        [EnumMember(Value = "relative")] Relative,
        [EnumMember(Value = "absolute")] Absolute
    }
}