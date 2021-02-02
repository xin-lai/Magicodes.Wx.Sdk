using Newtonsoft.Json;
using System;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Token
{
    public class TokenApiResult : ApiResultBase
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
    }
}