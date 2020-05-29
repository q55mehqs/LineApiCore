using System.Runtime.Serialization;

namespace LineApi.ResponseObjects.MessageObject.FlexContent.Component
{
    public enum LayoutProperty
    {
        [EnumMember(Value = "horizontal")] Horizontal,
        [EnumMember(Value = "vertical")] Vertical,
        [EnumMember(Value = "baseline")] Baseline
    }
}