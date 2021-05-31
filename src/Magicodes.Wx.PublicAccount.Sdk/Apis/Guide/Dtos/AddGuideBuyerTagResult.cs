using Newtonsoft.Json;
using System.Collections.Generic;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Guide.Dtos
{
    public class AddGuideBuyerTagResult : ApiResultBase
    {
        /// <summary>
        /// 客户列表添加结果，当请求openid_list列表大于0有意义
        /// </summary>
        [JsonProperty("buyer_resp")]
        public List<AddGuideBuyerTagBuyerRespInfo> BuyerResp { get; set; }
    }

    public class AddGuideBuyerTagBuyerRespInfo : ApiResultBase
    {
        /// <summary>
        /// 请求里的buyer_list客户openid
        /// </summary>
        [JsonProperty("openid")]
        public string OpenId { get; set; }
    }
}