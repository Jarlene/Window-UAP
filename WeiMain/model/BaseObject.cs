using System.Runtime.Serialization;
using WeiMain.Api;

namespace WeiMain.model
{
    [DataContract]
    public class BaseObject
    {
        protected string error = ErrorCode.OK;

        // 主动解析json，目前所有的model都提供两种解析方式，一种是自解析，另一种是主动解析。
        public virtual void ParaseJson(string jsonString)
        {

        }

    }
}
