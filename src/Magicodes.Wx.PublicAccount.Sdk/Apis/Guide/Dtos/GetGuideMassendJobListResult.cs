using Newtonsoft.Json;
using System.Collections.Generic;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Guide.Dtos
{
    public class GetGuideMassendJobListResult : ApiResultBase
    {
        /// <summary>
        /// 群发任务列表
        /// </summary>
        [JsonProperty("list")]
        public List<GuideMassendJobListInfo> List { get; set; }

        /// <summary>
        /// 总任务数
        /// </summary>
        [JsonProperty("total_count")]
        public int TotalCount { get; set; }
    }

    public class GuideMassendJobListInfo
    {
        /// <summary>
        /// 任务id
        /// </summary>
        [JsonProperty("task_id")]
        public int TaskId { get; set; }

        /// <summary>
        /// 顾问openid
        /// </summary>
        [JsonProperty("guide_openid")]
        public string GuideOpenId { get; set; }

        /// <summary>
        /// 任务创建时间
        /// </summary>
        [JsonProperty("create_time")]
        public int CreateTime { get; set; }

        /// <summary>
        /// 任务最后修改时间
        /// </summary>
        [JsonProperty("update_time")]
        public int UpdateTime { get; set; }

        /// <summary>
        /// 任务下发时间
        /// </summary>
        [JsonProperty("push_time")]
        public int PushTime { get; set; }

        /// <summary>
        /// 任务完成时间
        /// </summary>
        [JsonProperty("finish_time")]
        public int FinishTime { get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [JsonProperty("task_name")]
        public string TaskName { get; set; }

        /// <summary>
        /// 任务备注
        /// </summary>
        [JsonProperty("task_remark")]
        public string TaskRemark { get; set; }

        /// <summary>
        /// 任务状态
        /// 1	任务未执行
        /// 2	已执行
        /// 3	执行完成
        /// 4	任务取消
        /// </summary>
        [JsonProperty("task_status")]
        public int TaskStatus { get; set; }

        /// <summary>
        /// 素材
        /// </summary>
        [JsonProperty("material")]
        public List<GuideMassendJobListMaterialInfo> Material { get; set; }

        /// <summary>
        /// 客户列表
        /// </summary>
        [JsonProperty("buyer_info")]
        public List<GuideMassendJobListBuyerInfo> BuyerInfo { get; set; }
    }

    public class GuideMassendJobListMaterialInfo
    {
        /// <summary>
        /// 素材类型,1.文本,3.图片,49.小程序卡片
        /// </summary>
        [JsonProperty("type")]
        public int Type { get; set; }

        /// <summary>
        /// 小程序卡片标题
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// 小程序卡片路径
        /// </summary>
        [JsonProperty("path")]
        public string Path { get; set; }

        /// <summary>
        /// 小程序卡片appid,需要关联到公众号
        /// </summary>
        [JsonProperty("appid")]
        public string AppId { get; set; }

        /// <summary>
        /// 文本类型素材的内容,不超过10240字节
        /// </summary>
        [JsonProperty("word")]
        public string Word { get; set; }

        /// <summary>
        /// 图片url
        /// </summary>
        [JsonProperty("pic_url")]
        public string PicUrl { get; set; }
    }

    public class GuideMassendJobListBuyerInfo
    {
        /// <summary>
        /// 粉丝openid
        /// </summary>
        [JsonProperty("openid")]
        public string OpenId { get; set; }

        /// <summary>
        /// 消息发送状态
        /// 1	未发送
        /// 2	发送成功
        /// 3	未关注公众号
        /// 4	没有quota
        /// 5	系统错误
        /// </summary>
        [JsonProperty("send_status")]
        public int SendStatus { get; set; }
    }
}