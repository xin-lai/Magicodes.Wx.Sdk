using Newtonsoft.Json;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.NewTmpl.Dtos
{
    public class DeleteTemplateInput
    {
        /// <summary>
        /// 要删除的模板id
        /// </summary>
        [JsonProperty("priTmplId")]
        public string PriTmplId { get; set; }
    }
}