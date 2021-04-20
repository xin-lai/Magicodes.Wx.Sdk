using Newtonsoft.Json;
using System;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Ticket.Dtos
{
    public class GetTicketApiResult : ApiResultBase
    {
        /// <summary>
        ///     获取到的凭证
        /// </summary>
        [JsonProperty("ticket")]
        public string Ticket { get; set; }

        /// <summary>
        ///     凭证有效时间，单位：秒
        /// </summary>
        [JsonProperty("expires_in")]
        internal int Expires { get; set; }

        /// <summary>
        ///     凭证过期时间
        /// </summary>
        public DateTime ExporesTime { get; set; }
    }
}
