using System.Runtime.Serialization;

namespace LineApi.ResponseObjects.MessageObject.TemplateObject
{
    public enum ImageAspect
    {
        [EnumMember(Value = "rectangle")] Rectangle,
        [EnumMember(Value = "square")] Square
    }

    public enum ImageSize
    {
        [EnumMember(Value = "cover")] Cover,
        [EnumMember(Value = "contain")] Contain
    }
}