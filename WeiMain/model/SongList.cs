using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Windows.Data.Json;

namespace WeiMain.model
{
    public class SongList : BaseObject
    {
        public override void ParaseJson(string jsonString)
        {
            if (string.IsNullOrEmpty(jsonString))
            {
                return;
            }

            JsonObject jsonObject = JsonObject.Parse(jsonString).GetNamedObject("song_list_info");
            if (jsonObject != null)
            {

            }
        }
    }
}
