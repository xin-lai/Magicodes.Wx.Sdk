namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Message
{
    /// <summary>
    ///     消息类型
    /// </summary>
    public enum MessageTypes
    {
        /// <summary>
        ///     文本为text
        /// </summary>
        text,

        /// <summary>
        ///     图片为image
        /// </summary>
        image,

        /// <summary>
        ///     语音为voice
        /// </summary>
        voice,

        /// <summary>
        ///     视频消息为video
        /// </summary>
        video,

        /// <summary>
        /// Defines the mpvideo
        /// </summary>
        mpvideo,

        /// <summary>
        ///     音乐消息为music
        /// </summary>
        music,

        /// <summary>
        ///     图文消息（点击跳转到外链）为news
        /// </summary>
        news,

        /// <summary>
        ///     图文消息（点击跳转到图文消息页面）为mpnews
        /// </summary>
        mpnews,

        /// <summary>
        ///     卡券为wxcard
        /// </summary>
        wxcard
    }
}