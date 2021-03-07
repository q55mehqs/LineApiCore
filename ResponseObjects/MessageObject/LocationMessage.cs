using Newtonsoft.Json;

namespace LineApi.ResponseObjects.MessageObject
{
    public class LocationMessage : IMessageObject
    {
        [JsonProperty(PropertyName = "type")]
        public string Type => "location";
        
        /// <summary>
        /// タイトル (my location など)
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; }
        
        /// <summary>
        /// 住所 (〒160-0022 東京都新宿区新宿４丁目１−６ など)
        /// </summary>
        [JsonProperty(PropertyName = "address")]
        public string Address { get; }
        
        /// <summary>
        /// 緯度
        /// </summary>
        [JsonProperty(PropertyName = "latitude")]
        public double Latitude { get; }
        
        /// <summary>
        /// 経度
        /// </summary>
        [JsonProperty(PropertyName = "longitude")]
        public double Longitude { get; }

        public LocationMessage(string title, string address, double latitude, double longitude)
        {
            Title = title;
            Address = address;
            Latitude = latitude;
            Longitude = longitude;
        }
    }
}