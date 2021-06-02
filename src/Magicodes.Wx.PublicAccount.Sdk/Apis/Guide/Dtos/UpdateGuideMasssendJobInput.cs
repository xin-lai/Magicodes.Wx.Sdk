using Newtonsoft.Json;
using System.Collections.Generic;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Guide.Dtos
{
    public class UpdateGuideMasssendJobInput
    {
        /// <summary>
        /// 任务id
        /// </summary>
        [JsonProperty("task_id")]
        public int TaskId { get; set; }

        /// <summary>
        /// 群发任务名称,不超过16字
        /// </summary>
        [JsonProperty("task_name")]
        public string TaskName { get; set; }

        /// <summary>
        /// 群发任务备注,不超过100字
        /// </summary>
        [JsonProperty("task_remark")]
        public string TaskRemark { get; set; }

        /// <summary>
        /// 任务下发给顾问的时间, 秒级时间戳, 范围为当前时间开始到最近一个月内
        /// </summary>
        [JsonProperty("push_time")]
        public int PushTime { get; set; }

        /// <summary>
        /// 客户openid列表
        /// </summary>
        [JsonProperty("openid")]
        public List<string> OpenId { get; set; }

        /// <summary>
        /// 不超过3个素材
        /// </summary>
        [JsonProperty("material")]
        public List<GuideMasssendJobMaterialInfo> Material { get; set; }
    }
}