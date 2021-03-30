using Newtonsoft.Json;
using System.Collections.Generic;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.NewTmpl.Dtos
{
    public class GetTemplateListApiResult : ApiResultBase
    {
        [JsonProperty("data")]
        public IEnumerable<TemplateDataInfo> Data { get; set; }
    }

    public class TemplateDataInfo
    {
        /// <summary>
        /// 添加至帐号下的模板 id，发送订阅通知时所需
        /// </summary>
        [JsonProperty("priTmplId")]
        public string PriTmplId { get; set; }

        /// <summary>
        /// 模版标题
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// 模版内容
        /// </summary>
        [JsonProperty("content")]
        public string Content { get; set; }

        /// <summary>
        /// 模板内容示例
        /// </summary>
        [JsonProperty("example")]
        public string Example { get; set; }

        /// <summary>
        /// 模版类型，2 为一次性订阅，3 为长期订阅
        /// </summary>
        [JsonProperty("type")]
        public int Type { get; set; }
    }
}