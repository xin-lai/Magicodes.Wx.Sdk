using System.Collections.Generic;
using Newtonsoft.Json;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Guide.Dtos
{
    public class RebindGuideAcctForBuyerResult : ApiResultBase
    {
        /// <summary>
        /// 客户列表绑定结果,当请求buyer_list列表大于0有意义
        /// </summary>
        [JsonProperty("buyer_resp")]
        public List<BuyerRespInfo> BuyerResp { get; set; }
    }
}