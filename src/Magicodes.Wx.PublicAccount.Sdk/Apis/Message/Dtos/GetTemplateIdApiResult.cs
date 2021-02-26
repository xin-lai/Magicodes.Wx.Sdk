using Newtonsoft.Json;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Message
{
    public class GetTemplateIdApiResult : ApiResultBase
    {

        /// <summary>
        /// 错误代码
        /// </summary>
        public int ErrCode { get; set; }
        /// <summary>
        /// 错误描述
        /// </summary>
        public string ErrMsg { get; set; }
        /// <summary>
        /// 模板ID
        /// </summary>
        [JsonProperty("template_id")]
        public string TemplateId { get; set; }


    }
}