using Newtonsoft.Json;
using System.Collections.Generic;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Guide.Dtos
{
    public class GetGuideBuyerRelationListResult : ApiResultBase
    {
        /// <summary>
        /// 顾问总数量
        /// </summary>
        [JsonProperty("total_num")]
        public int TotalNum { get; set; }

        /// <summary>
        /// 账号列表
        /// </summary>
        [JsonProperty("list")]
        public List<GuideBuyerRelationInfo> List { get; set; }
    }

    public class GuideBuyerRelationInfo
    {
        /// <summary>
        /// 客户openid
        /// </summary>
        [JsonProperty("openid")]
        public string OpenId { get; set; }

        /// <summary>
        /// 绑定时间戳
        /// </summary>
        [JsonProperty("create_time")]
        public int CreateTime { get; set; }

        /// <summary>
        /// 客户昵称
        /// </summary>
        [JsonProperty("buyer_nickname")]
        public string BuyerNickName { get; set; }
    }
}