using Newtonsoft.Json;
using System.Collections.Generic;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Guide.Dtos
{
    public class GetGroupByGuideResult : ApiResultBase
    {
        /// <summary>
        /// 顾问分组列表
        /// </summary>
        [JsonProperty("group_id_list")]
        public List<long> GroupIdList { get; set; }
    }
}