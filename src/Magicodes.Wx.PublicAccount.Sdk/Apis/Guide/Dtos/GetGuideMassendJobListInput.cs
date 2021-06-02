using Newtonsoft.Json;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Guide.Dtos
{
    public class GetGuideMassendJobListInput
    {
        /// <summary>
        /// 顾问微信号（guide_account和guide_openid二选一）
        /// </summary>
        [JsonProperty("guide_account")]
        public string GuideAccount { get; set; }

        /// <summary>
        /// 顾问openid或者unionid（guide_account和guide_openid二选一）
        /// </summary>
        [JsonProperty("guide_openid")]
        public string GuideOpenId { get; set; }

        /// <summary>
        /// 获取指定状态的任务（为空则表示拉取所有状态的任务）
        /// 1	任务未执行
        /// 2	已执行
        /// 3	执行完成
        /// 4	任务取消
        /// </summary>
        [JsonProperty("task_status")]
        public int TaskStatus { get; set; }

        /// <summary>
        /// 偏移位置
        /// </summary>
        [JsonProperty("offset")]
        public int Offset { get; set; }

        /// <summary>
        /// 条数
        /// </summary>
        [JsonProperty("limit")]
        public int Limit { get; set; }
    }
}