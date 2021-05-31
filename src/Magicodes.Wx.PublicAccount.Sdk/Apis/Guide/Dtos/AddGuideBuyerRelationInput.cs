using Newtonsoft.Json;
using System.Collections.Generic;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Guide.Dtos
{
    public class AddGuideBuyerRelationInput
    {
        /// <summary>
        /// 顾问微信号（guide_account和guide_openid二选一）
        /// </summary>
        [JsonProperty("guide_account")]
        public string GuideAccount { get; set; }

        /// <summary>
        /// 顾问openid或者unionid（guide_account和guide_openid二选一）
        /// </summary>
        [JsonProperty("guide_openid")]
        public string GuideOpenId { get; set; }

        /// <summary>
        /// 客户openid（openid和buyer_list二选一）
        /// </summary>
        [JsonProperty("openid")]
        public string OpenId { get; set; }

        /// <summary>
        /// 客户openid对应的昵称
        /// </summary>
        [JsonProperty("buyer_nickname")]
        public string BuyerNickName { get; set; }

        /// <summary>
        /// 客户列表（不超过200，openid和buyer_list二选一）
        /// </summary>
        [JsonProperty("buyer_list")]
        public List<BuyerInfo> BuyerList { get; set; }
    }

    public class BuyerInfo
    {
        /// <summary>
        /// 客户openid
        /// </summary>
        [JsonProperty("openid")]
        public string OpenId { get; set; }

        /// <summary>
        /// 客户昵称
        /// </summary>
        [JsonProperty("buyer_nickname")]
        public string BuyerNickName { get; set; }
    }
}