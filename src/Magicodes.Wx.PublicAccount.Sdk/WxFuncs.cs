using System;

namespace Magicodes.Wx.PublicAccount.Sdk
{
    public class WxFuncs
    {
        /// <summary>
        /// 获取公众号配置
        /// </summary>
        public Func<WxPublicAccountOption> GetWeChatOptions { get; set; }

        /// <summary>
        /// 根据AppId获取Access Token
        /// </summary>
        public Func<string, string> GetAccessTokenByAppId { get; set; }

        /// <summary>
        /// 缓存Access Token
        /// </summary>
        public Action<string, string> CacheAccessToken { get; set; }
    }
}
