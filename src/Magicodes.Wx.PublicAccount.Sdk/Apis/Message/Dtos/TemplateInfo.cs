using Newtonsoft.Json;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Message
{
    /// <summary>
    /// 模板信息
    /// </summary>
    public class TemplateInfo
    {

        /// <summary>
        /// 模板ID
        /// </summary>
        [JsonProperty("template_id")]
        public string TemplateId { get; set; }
        /// <summary>
        /// 模板标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 模板所属行业的一级行业
        /// </summary>
        [JsonProperty("primary_industry")]
        public string PrimaryIndustry { get; set; }
        /// <summary>
        /// 模板所属行业的二级行业
        /// </summary>
        [JsonProperty("deputy_industry")]
        public string DeputyIndustry { get; set; }
        /// <summary>
        /// 模板内容
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 模板示例
        /// </summary>
        public string Example { get; set; }
    }
}