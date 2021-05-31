using Newtonsoft.Json;
using System.Collections.Generic;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Guide.Dtos
{
    public class RebindGuideAcctForBuyerInput
    {
        /// <summary>
        /// 原顾问微信号（old_guide_account和new_guide_account配套使用）
        /// </summary>
        [JsonProperty("old_guide_account")]
        public string OldGuideAccount { get; set; }

        /// <summary>
        /// 原顾问openid或者unionid（old_guide_openid和new_guide_openid配套使用）
        /// </summary>
        [JsonProperty("old_guide_openid")]
        public string OldGuideOpenId { get; set; }

        /// <summary>
        /// 新顾问微信号（new_guide_account和new_guide_openid二选一）
        /// </summary>
        [JsonProperty("new_guide_account")]
        public string NewGuideAccount { get; set; }

        /// <summary>
        /// 新顾问openid或者unionid（new_guide_account和new_guide_openid二选一）
        /// </summary>
        [JsonProperty("new_guide_openid")]
        public string NewGuideOpenId { get; set; }

        /// <summary>
        /// 客户openid
        /// </summary>
        [JsonProperty("openid")]
        public string OpenId { get; set; }

        /// <summary>
        /// 客户列表，不超过200（openid和openid_list二选一）
        /// </summary>
        [JsonProperty("openid_list")]
        public List<string> OpenIdList { get; set; }
    }
}