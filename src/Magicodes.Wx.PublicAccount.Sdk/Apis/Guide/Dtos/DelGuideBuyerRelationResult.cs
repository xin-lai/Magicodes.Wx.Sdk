using Newtonsoft.Json;
using System.Collections.Generic;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Guide.Dtos
{
    public class DelGuideBuyerRelationResult : ApiResultBase
    {
        /// <summary>
        /// 客户列表绑定结果,当请求buyer_list列表大于0有意义
        /// </summary>
        [JsonProperty("buyer_resp")]
        public List<DelBuyerRespInfo> BuyerResp { get; set; }
    }

    public class DelBuyerRespInfo : ApiResultBase
    {
        /// <summary>
        /// 请求里的buyer_list粉丝openid
        /// </summary>
        [JsonProperty("openid")]
        public string OpenId { get; set; }
    }
}