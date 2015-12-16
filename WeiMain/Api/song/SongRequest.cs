using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                song.Title = jsonObject.GetNamedString("title", "");
                song.SongId = jsonObject.GetNamedString("song_id", "");
                song.Album = jsonObject.GetNamedString("album_title", "");
                song.Artist = jsonObject.GetNamedString("author", "");
                song.PicPremium = jsonObject.GetNamedString("pic_premium", "");
                song.PicRadio = jsonObject.GetNamedString("pic_radio", "");
                song.PicSmall = jsonObject.GetNamedString("pic_small", "");
                song.PicBig = jsonObject.GetNamedString("pic_big", "");
                song.LyricLink = jsonObject.GetNamedString("lrclink", "");
                return song;
            }
            catch (Exception e)
            {
                ContentErrorCode = ErrorCode.Failed;
            }
            return null;

        }
    }
}
