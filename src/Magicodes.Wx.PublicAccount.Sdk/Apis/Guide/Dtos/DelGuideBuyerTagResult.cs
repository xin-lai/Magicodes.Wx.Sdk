using Newtonsoft.Json;
using System.Collections.Generic;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Guide.Dtos
{
    public class DelGuideBuyerTagResult : ApiResultBase
    {
        /// <summary>
        /// 客户列表处理结果,当请求openid_list列表大于0有意义
        /// </summary>
        [JsonProperty("buyer_resp")]
        public List<DelGuideBuyerTagBuyerRespInfo> BuyerResp { get; set; }
    }

    public class DelGuideBuyerTagBuyerRespInfo : ApiResultBase
    {
        /// <summary>
        /// 请求里的buyer_list粉丝openid
        /// </summary>
        [JsonProperty("openid")]
        public string OpenId { get; set; }
    }
}