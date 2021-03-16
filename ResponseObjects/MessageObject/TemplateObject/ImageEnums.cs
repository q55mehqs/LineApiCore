using System.Runtime.Serialization;

namespace LineApi.ResponseObjects.MessageObject.TemplateObject
{
    /// <summary>
    /// Rectangle 1.51:1
    /// Square 1:1
    /// </summary>
    public enum ImageAspect
    {
        [EnumMember(Value = "rectangle")] Rectangle,
        [EnumMember(Value = "square")] Square
    }

    /// <summary>
    /// cover：画像領域全体に画像を表示します。画像領域に収まらない部分は切り詰められます。
    /// contain：画像領域に画像全体を表示します。縦長の画像では左右に、横長の画像では上下に余白が表示されます。
    /// </summary>
    public enum ImageSize
    {
        [EnumMember(Value = "cover")] Cover,
        [EnumMember(Value = "contain")] Contain
    }
}