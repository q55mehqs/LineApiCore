using System.Runtime.Serialization;

namespace LineApi.ResponseObjects.MessageObject.FlexContent.Component
{
    public enum AlignProperty
    {
        [EnumMember(Value = "start")] Start,
        [EnumMember(Value = "end")] End,
        [EnumMember(Value = "center")] Center
    }
}