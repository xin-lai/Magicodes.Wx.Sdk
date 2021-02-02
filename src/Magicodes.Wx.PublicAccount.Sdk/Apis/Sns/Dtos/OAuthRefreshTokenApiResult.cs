using Newtonsoft.Json;
using System;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Sns
{
    public class OAuthRefreshTokenApiResult : ApiResultBase
    {
        /// <summary>
        ///     获取到的凭证
        /// </summary>
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        ///     凭证有效时间，单位：秒
        /// </summary>
        [JsonProperty("expires_in")]
        internal int Expires { get; set; }

        /// <summary>
        ///     凭证过期时间
        /// </summary>
        public DateTime ExpiresTime { get; set; }

        /// <summary>
        ///     用户刷新access_token
        /// </summary>
        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }

        /// <summary>
        ///     用户唯一标识，请注意，在未关注公众号时，用户访问公众号的网页，也会产生一个用户和公众号唯一的OpenID
        /// </summary>
        [JsonProperty("openid")]
        public string OpenId { get; set; }

        /// <summary>
        ///     用户授权的作用域，使用逗号（,）分隔
        /// </summary>
        [JsonProperty("scope")]
        public string Scope { get; set; }
    }
}
