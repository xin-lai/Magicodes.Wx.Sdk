namespace Magicodes.WeChat.Sdk
{
    /// <summary>
    /// 微信配置信息
    /// </summary>
    public class WeChatOptions
    {
        public const string WeChat = "WeChat";

        /// <summary>
        /// Gets or sets the AppId
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
        /// Gets or sets the AppSecret
        /// </summary>
        public string AppSecret { get; set; }

        /// <summary>
        /// Gets or sets the WeiXinAccount
        /// </summary>
        public string WeiXinAccount { get; set; }

        /// <summary>
        /// Gets or sets the Token
        /// </summary>
        public string Token { get; set; }
    }
}
