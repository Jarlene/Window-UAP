using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WeiMain.model
{
    [DataContract]
    public class Song:BaseObject
    {
    
        public string SongId { get; set; }

        public string Title { get; set; }

        public string Artist { get; set; }

        public string Album { get; set; }

        public string PicPremium { get; set; }

        public string PicRadio { get; set; }

        public string PicBig { get; set; }

        public string PicSmall { get; set; }

        public string LyricLink { get; set; }
    }
}
