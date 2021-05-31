using Newtonsoft.Json;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Guide.Dtos
{
    public class AddGuideBuyerTagInput
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
        /// 标签的可选值，该值必须在标签的可选值集合中
        /// </summary>
        [JsonProperty("tag_value")]
        public string TagValue { get; set; }

        /// <summary>
        /// 客户列表，不超过200，openid和openid_list二选一
        /// </summary>
        [JsonProperty("openid_list")]
        public string OpenIdList { get; set; }
    }
}