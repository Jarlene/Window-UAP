using WeiMain.Api;
using System.Runtime.Serialization;

namespace WeiMain.model
{
    [DataContract]
    public abstract class BaseObject
    {
        protected string error = ErrorCode.OK;


    }
}
