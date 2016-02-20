namespace WeiMain.Api
{
    public static class ErrorCode
    {
        public static readonly string OK = "22000";
        public static readonly string Failed = "22001";
        public static readonly string ActionToOften = "22011";  //操作过于频繁
        public static readonly string EncNEQ = "22013";         //加密内容和明文不相等
        public static readonly string DecFailed = "22014";      //解密失败

        public static readonly string FavoriteIllegal = "22321";            //非法的收藏类型
        public static readonly string FavoriteDuplicated = "22322";         //收藏重复
        public static readonly string FavoriteSongCountExceeded = "22331";  //收藏歌曲达到上限
        public static readonly string FavoriteAlbumCountExceeded = "22332"; //收藏歌曲达到上限
        public static readonly string FavoriteDiyCountExceeded = "22333";   //收藏歌曲达到上限

        public static readonly string UserAvatarUpdateFailed = "22451";     //用户头像更新失败
        public static readonly string UserHaveNotLoggedIn = "22452";        //用户未登录
        public static readonly string UserHaveNotActivated = "22453";       //用户尚未激活
        public static readonly string UserHaveBeenDeleted = "22454";        //用户已经被删除
        public static readonly string UserGetPassportInfoFailed = "22455";  //查询用户passport信息失败
        public static readonly string UserAddBaseInfoFailed = "22456";      //添加用户基本信息失败
        public static readonly string UserTingUidAssignedFailed = "22457";  //用户分配ting uid失败
        public static readonly string UserIsActivated = "22458";            //用户已激活
        public static readonly string UserNickNameEmpty = "22459";          //用户昵称为空
        public static readonly string UserSignTooLong = "22460";            //用户签名过长
        public static readonly string UserVersionTooLow = "22461";          //用户版本过低
        public static readonly string UserDownloadLimit = "22462";          //用户下载受限
        public static readonly string UserIPLimit = "22463";                //用户IP受限无法下载
        public static readonly string UserVersionLow = "22464";				//用户版本建议升级
    }
}
