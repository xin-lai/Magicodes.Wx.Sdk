using Newtonsoft.Json;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Guide.Dtos
{
    public class GetGuideBuyerRelationByBuyerResult : ApiResultBase
    {
        /// <summary>
        /// 客户openid
        /// </summary>
        [JsonProperty("openid")]
        public string OpenId { get; set; }

        /// <summary>
        /// 如果绑定顾问的时候，是用guide_accout参数绑定，拉取时才有这个数据
        /// </summary>
        [JsonProperty("guide_account")]
        public string GuideAccount { get; set; }

        /// <summary>
        /// 如果绑定顾问的时候，是用guide_openid参数绑定，拉取时才有这个数据
        /// </summary>
        [JsonProperty("guide_openid")]
        public string GuideOpenId { get; set; }

        /// <summary>
        /// 客户昵称
        /// </summary>
        [JsonProperty("buyer_nickname")]
        public string BuyerNickName { get; set; }

        /// <summary>
        /// 绑定时间戳
        /// </summary>
        [JsonProperty("create_time")]
        public int CreateTime { get; set; }
    }
}