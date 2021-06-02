using Newtonsoft.Json;
using System.Collections.Generic;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Guide.Dtos
{
    public class AddGuideMasssendJobResult : ApiResultBase
    {
        /// <summary>
        /// 群发任务列表
        /// </summary>
        [JsonProperty("task_result")]
        public List<TaskResultInfo> TaskResult { get; set; }
    }

    public class TaskResultInfo
    {
        /// <summary>
        /// 群发任务id
        /// </summary>
        [JsonProperty("task_id")]
        public int TaskId { get; set; }

        /// <summary>
        /// 此任务包括的openid列表
        /// </summary>
        [JsonProperty("openid")]
        public List<string> OpenId { get; set; }
    }
}