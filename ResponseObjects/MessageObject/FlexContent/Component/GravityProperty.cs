using System.Runtime.Serialization;

namespace LineApi.ResponseObjects.MessageObject.FlexContent.Component
{
    public enum GravityProperty
    {
        [EnumMember(Value = "top")] Top,
        [EnumMember(Value = "bottom")] Bottom,
        [EnumMember(Value = "center")] Center
    }
}