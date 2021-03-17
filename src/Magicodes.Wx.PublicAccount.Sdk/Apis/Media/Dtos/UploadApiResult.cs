namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Media
{
    /// <summary>
    ///
    /// </summary>
    public class UploadApiResult : ApiResultBase
    {
        /// <summary>
        /// 媒体文件类型，分别有图片（image）、语音（voice）、视频（video）和缩略图（thumb），图文消息（news）
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// 媒体文件/图文消息上传后获取的唯一标识
        /// </summary>
        public string media_id { get; set; }

        /// <summary>
        /// 媒体文件上传时间
        /// </summary>

        public int created_at { get; set; }
    }
}