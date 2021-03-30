using Newtonsoft.Json;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.NewTmpl.Dtos
{
    public class AddTemplateApiResult : ApiResultBase
    {
        /// <summary>
        /// 添加至帐号下的模板id，发送订阅通知时所需
        /// </summary>
        [JsonProperty("priTmplId")]
        public string PriTmplId { get; set; }
    }
}