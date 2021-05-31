using Newtonsoft.Json;
using System.Collections.Generic;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Guide.Dtos
{
    public class DelGuideBuyerTagInput
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
        /// 客户openid
        /// </summary>
        [JsonProperty("openid")]
        public string OpenId { get; set; }

        /// <summary>
        /// 标签值，该值必须在标签可选值集合中
        /// </summary>
        [JsonProperty("tag_value")]
        public string TagValue { get; set; }

        /// <summary>
        /// 客户列表，不超过200，openid和openid_list二选一
        /// </summary>
        [JsonProperty("openid_list")]
        public List<string> OpenIdList { get; set; }
    }
}