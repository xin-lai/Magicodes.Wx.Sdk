using System;

namespace Magicodes.Wx.PublicAccount.Sdk
{
    public class WxFuncs
    {
        public Func<WxPublicAccountOption> GetWeChatOptions { get; set; }

        public Func<string, string> GetAccessTokenByAppId { get; set; }

        public Action<string, string> CacheAccessToken { get; set; }
    }
}
