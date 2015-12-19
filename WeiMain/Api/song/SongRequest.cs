using Newtonsoft.Json;
using System;
using WeiMain.model;
using Windows.Data.Json;

namespace WeiMain.Api.song
{
    public class SongRequest : BaseRequest<Song>
    {

        private string SongId;
        private Song song;

        /** 根据songId请求网络，获取song*/
        public SongRequest(Song song, string songId)
        {
            this.SongId = songId;
            this.song = song;
        }

        public override string GetMethodName()
        {
            return @"baidu.ting.song.getInfos";
        }

        protected override string GetQueryContent()
        {
            var tick = System.Environment.TickCount;
            string query = string.Format("songid={0}&ts={1}", SongId, tick);
            return query;
        }

        protected override Song ParseAsync(string jsonString)
        {
            try
            {
                JsonObject jsonObject = JsonObject.Parse(jsonString);
                song = JsonConvert.DeserializeObject<Song>(jsonObject["songinfo"].ToString());
            }
            catch (Exception e)
            {
                ContentErrorCode = ErrorCode.Failed;
            }
            return null;

        }
    }
}
