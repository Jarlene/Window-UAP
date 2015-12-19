using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WeiMain.model
{
    [DataContract]
    public class Song:BaseObject
    {

        [JsonProperty(PropertyName = "song_id")]
        public string SongId { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "author")]
        public string Artist { get; set; }

        [JsonProperty(PropertyName = "album_title")]
        public string Album { get; set; }

        [JsonProperty(PropertyName = "pic_premium")]
        public string PicPremium { get; set; }

        [JsonProperty(PropertyName = "pic_radio")]
        public string PicRadio { get; set; }

        [JsonProperty(PropertyName = "pic_big")]
        public string PicBig { get; set; }

        [JsonProperty(PropertyName = "pic_small")]
        public string PicSmall { get; set; }

        [JsonProperty(PropertyName = "lrclink")]
        public string LyricLink { get; set; }
    }
}
