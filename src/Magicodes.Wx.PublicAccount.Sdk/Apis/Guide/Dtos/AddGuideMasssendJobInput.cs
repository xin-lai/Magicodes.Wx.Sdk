using Newtonsoft.Json;
using System.Collections.Generic;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Guide.Dtos
{
    public class AddGuideMasssendJobInput
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

    public class GuideMasssendJobMaterialInfo
    {
        /// <summary>
        /// 素材类型,1.文本,3.图片,49.小程序卡片
        /// </summary>
        [JsonProperty("type")]
        public int Type { get; set; }

        /// <summary>
        /// 图片类型素材或者卡片类型素材的封面，只能用《素材管理获取media_id》
        /// </summary>
        [JsonProperty("media_id")]
        public string MediaId { get; set; }

        /// <summary>
        /// 小程序卡片标题,最多35字
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
        /// 文本类型素材的内容,不超过300字节
        /// </summary>
        [JsonProperty("word")]
        public string Word { get; set; }
    }
}