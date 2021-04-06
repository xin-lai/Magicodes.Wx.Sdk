using Newtonsoft.Json;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Menu.Dtos
{
    public class DelConditionalInput
    {
        /// <summary>
        /// 菜单id
        /// </summary>
        [JsonProperty("menuid")]
        public int MenuId { get; set; }
    }
}