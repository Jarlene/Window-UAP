using Newtonsoft.Json;

namespace WeiMain.model
{
    class Album : BaseObject
    {
        [JsonProperty(PropertyName = "song_id")]
        public string SongID { get; set; }

        [JsonProperty(PropertyName = "author")]
        public string Artist { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "pic_small")]
        public string SmallImageUrl { get; set; }

        [JsonProperty(PropertyName = "pic_big")]
        public string BigImageUrl { get; set; }

        public override void ParaseJson(string jsonString)
        {
            
        }
    }
}
