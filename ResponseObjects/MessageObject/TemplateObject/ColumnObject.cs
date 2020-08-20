using System.Collections.Generic;
using LineApi.ResponseObjects.MessageObject.TemplateObject.ActionObject;
using Newtonsoft.Json;

namespace LineApi.ResponseObjects.MessageObject.TemplateObject
{
    public class ColumnObject
    {
        [JsonProperty(PropertyName = "thumbnailImageUrl")]
        public string? ThumbnailImageUrl { get; set; }

        [JsonProperty(PropertyName = "imageBackgroundColor")]
        public string? ImageBackgroundColor { get; set; }

        [JsonProperty(PropertyName = "title")] public string? Title { get; set; }
        [JsonProperty(PropertyName = "text")] public string Text { get; set; }

        [JsonProperty(PropertyName = "defaultAction")]
        public IActionObject? DefaultAction { get; set; }

        [JsonProperty(PropertyName = "actions")]
        public IEnumerable<IActionObject> Actions { get; set; }

        public ColumnObject(string text, IEnumerable<IActionObject> actions)
        {
            Text = text;
            Actions = actions;
        }

        public ColumnObject(string title, string text, IEnumerable<IActionObject> actions)
        {
            Title = title;
            Text = text;
            Actions = actions;
        }

        public static IEnumerable<ColumnObject> ClassListColumns(string command, bool useAs = true,
            string asColumnText = "応用科学コース", IActionObject? asFooter = null)
        {
            var columns = new List<ColumnObject>();
            var grade1Actions = new[]
            {
                new MessageAction("1-1", $">> {command} 1-1"),
                new MessageAction("1-2", $">> {command} 1-2"),
                new MessageAction("1-3", $">> {command} 1-3")
            };
            columns.Add(new ColumnObject("1学年", grade1Actions));

            for (var i = 2; i <= 4; i++)
            {
                var gradeActions = new[]
                {
                    new MessageAction($"IS{i}", $">> {command} IS{i}"),
                    new MessageAction($"IT{i}", $">> {command} IT{i}"),
                    new MessageAction($"IE{i}", $">> {command} IE{i}")
                };
                columns.Add(new ColumnObject($"{i}学年", gradeActions));
            }

            if (!useAs) return columns;
            asFooter ??= new UriAction("押すなよ！！", "https://www.sendai-nct.ac.jp/");
            var asActions = new[]
            {
                new MessageAction("AS4", $">> {command} AS4"),
                new MessageAction("AS5", $">> {command} AS5"),
                asFooter
            };
            columns.Add(new ColumnObject(asColumnText, asActions));

            return columns;
        }
    }
}