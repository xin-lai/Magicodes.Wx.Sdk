using Newtonsoft.Json;
using System.Collections.Generic;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Message
{
    public class SendTemplateMessageInput
    {
        /// <summary>
        ///     接收人openId
        /// </summary>
        [JsonProperty("touser")]
        public string To { get; set; }

        /// <summary>
        /// 模板ID
        /// </summary>
        [JsonProperty("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 模板内容字体颜色，不填默认为黑色
        /// </summary>
        [JsonProperty("color")]
        public string Color { get; set; }

        /// <summary>
        ///     链接
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        ///     模板消息数据,如：
        ///     serviceInfo : new TemplateDataItem("您好，您的服务单123456789有新的客服回复。")
        ///     remark : new TemplateDataItem("详细处理结果请点击“详情”查看。", "#173177"),
        /// </summary>
        [JsonProperty("data")]
        public Dictionary<string, TemplateDataItem> Data { get; set; }

        /// <summary>
        /// 小程序配置
        /// </summary>
        [JsonProperty("miniprogram")]
        public TemplateMiniprogramSettings Miniprogram { get; set; }
    }
}
