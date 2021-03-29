using Newtonsoft.Json;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.User.Dtos
{
    public class UpdateRemarkInput
    {
        /// <summary>
        /// 用户标识
        /// </summary>
        [JsonProperty("openid")]
        public string OpenId { get; set; }

        /// <summary>
        /// 新的备注名，长度必须小于30字符
        /// </summary>
        [JsonProperty("remark")]
        public string Remark { get; set; }
    }
}