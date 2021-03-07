using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LineApi.ResponseObjects.ActionObject
{
    public class DateTimePickerAction : IActionObject
    {
        [JsonProperty(PropertyName = "type")] public string Type => "datetimepicker";
        [JsonProperty(PropertyName = "label")] public string? Label { get; set; }
        [JsonProperty(PropertyName = "data")] public string Data { get; set; }

        [JsonProperty(PropertyName = "mode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public DateTimePickerMode Mode { get; set; }

        [JsonProperty(PropertyName = "initial")]
        public string? Initial { get; set; }

        [JsonProperty(PropertyName = "max")] public string? Max { get; set; }
        [JsonProperty(PropertyName = "min")] public string? Min { get; set; }

        /// <summary>
        /// ImageCarouselTemplate でのみ利用可
        /// </summary>
        /// <param name="data">ポストバックで返される文字列</param>
        /// <param name="mode"></param>
        /// <param name="initial">(省略可能) 日付または時刻の初期値</param>
        /// <param name="min">(省略可能) 選択可能な日付または時刻の最小値。maxの値より小さい必要があります。</param>
        /// <param name="max">(省略可能) 選択可能な日付または時刻の最大値。minの値より大きい必要があります。</param>
        public DateTimePickerAction(string data, DateTimePickerMode mode, DateTime? initial = null,
            DateTime? min = null, DateTime? max = null)
        {
            Data = data;
            Mode = mode;

            if (initial == null && max == null && min == null) return;
            var format = mode switch
            {
                DateTimePickerMode.Date => "yyyy-MM-dd",
                DateTimePickerMode.Time => "HH:mm",
                DateTimePickerMode.DateTime => "yyyy-MM-ddTHH:mm",
                _ => throw new ArgumentOutOfRangeException()
            };
            Initial = initial?.ToString(format);
            Max = max?.ToString(format);
            Min = min?.ToString(format);
        }

        /// <summary>
        /// ImageCarouselTemplate以外ではこちらを利用する
        /// </summary>
        /// <param name="label"></param>
        /// <param name="data"></param>
        /// <param name="mode"></param>
        /// <param name="initial">(省略可能) 日付または時刻の初期値</param>
        /// <param name="min">(省略可能) 選択可能な日付または時刻の最小値。maxの値より小さい必要があります。</param>
        /// <param name="max">(省略可能) 選択可能な日付または時刻の最大値。minの値より大きい必要があります。</param>
        public DateTimePickerAction(string label, string data, DateTimePickerMode mode, DateTime? initial = null,
            DateTime? min = null, DateTime? max = null)
        {
            Label = label;
            Data = data;
            Mode = mode;

            if (initial == null && max == null && min == null) return;
            var format = mode switch
            {
                DateTimePickerMode.Date => "yyyy-MM-dd",
                DateTimePickerMode.Time => "HH:mm",
                DateTimePickerMode.DateTime => "yyyy-MM-ddTHH:mm",
                _ => throw new ArgumentOutOfRangeException()
            };
            Initial = initial?.ToString(format);
            Max = max?.ToString(format);
            Min = min?.ToString(format);
        }
    }

    public enum DateTimePickerMode
    {
        [EnumMember(Value = "date")] Date,
        [EnumMember(Value = "time")] Time,
        [EnumMember(Value = "datetime")] DateTime
    }
}