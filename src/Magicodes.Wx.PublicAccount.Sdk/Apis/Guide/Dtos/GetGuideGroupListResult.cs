using Newtonsoft.Json;
using System.Collections.Generic;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Guide.Dtos
{
    public class GetGuideGroupListResult : ApiResultBase
    {
        /// <summary>
        /// 顾问分组列表
        /// </summary>
        [JsonProperty("group_list")]
        public List<GroupInfo> GroupList { get; set; }
    }

    public class GroupInfo
    {
        /// <summary>
        /// 顾问分组id
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// 顾问分组名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 创建时间戳
        /// </summary>
        [JsonProperty("create_time")]
        public int CreateTime { get; set; }

        /// <summary>
        /// 更新时间戳
        /// </summary>
        [JsonProperty("update_time")]
        public int UpdateTime { get; set; }
    }
}