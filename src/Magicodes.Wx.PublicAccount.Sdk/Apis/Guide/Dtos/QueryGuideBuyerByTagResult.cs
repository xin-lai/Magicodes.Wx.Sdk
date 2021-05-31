using Newtonsoft.Json;
using System.Collections.Generic;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Guide.Dtos
{
    public class QueryGuideBuyerByTagResult : ApiResultBase
    {
        /// <summary>
        /// 客户openid列表
        /// </summary>
        [JsonProperty("openid_list")]
        public List<string> OpenIdList { get; set; }
    }
}