namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Media
{
    public class UploadImageApiResult :  ApiResultBase
    {
        /// <summary>
        /// 上传图片的URL，可用于后续群发中，放置到图文消息中
        /// </summary>
        public string url { get; set; }
    }
}