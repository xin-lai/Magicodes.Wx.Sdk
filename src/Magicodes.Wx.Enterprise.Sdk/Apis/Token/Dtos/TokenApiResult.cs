using Newtonsoft.Json;
using System;

namespace Magicodes.Wx.Enterprise.Sdk.Apis.Token.Dtos
{
    public class TokenApiResult : ApiResultBase
    {
        /// <summary>
        ///     获取到的凭证
        /// </summary>
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        ///     凭证有效时间，单位：秒。正常情况下为7200秒（2小时）
        /// </summary>
        [JsonProperty("expires_in")]
        internal int Expires { get; set; }

        /// <summary>
        ///     凭证过期时间
        /// </summary>
        public DateTime ExpiresTime { get; set; }
    }
}