using Newtonsoft.Json;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Guide.Dtos
{
    public class GetGuideMassendJobInput
    {
        /// <summary>
        /// 任务id
        /// </summary>
        [JsonProperty("task_id")]
        public int TaskId { get; set; }
    }
}