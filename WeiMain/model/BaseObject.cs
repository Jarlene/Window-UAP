using WeiMain.Api;

namespace WeiMain.model
{
    public abstract class BaseObject
    {
        protected string error = ErrorCode.OK;


        public abstract void ParaseJson(string jsonString);

    }
}
