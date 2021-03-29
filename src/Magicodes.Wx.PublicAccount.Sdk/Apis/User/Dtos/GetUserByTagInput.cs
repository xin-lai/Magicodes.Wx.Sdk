using Newtonsoft.Json;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.User.Dtos
{
    public class GetUserByTagInput
    {
        [JsonProperty("tagid")]
        public int TagId { get; set; }

        /// <summary>
        /// 第一个拉取的OPENID，不填默认从头开始拉取
        /// </summary>
        [JsonProperty("next_openid")]
        public string NextOpenId { get; set; }
    }
}