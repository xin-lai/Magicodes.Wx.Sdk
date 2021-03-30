using Newtonsoft.Json;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.NewTmpl.Dtos
{
    public class AddTemplateInput
    {
        /// <summary>
        /// 模板标题 id，可通过getPubTemplateTitleList接口获取，也可登录公众号后台查看获取
        /// </summary>
        [JsonProperty("tid")]
        public string Tid { get; set; }

        /// <summary>
        /// 开发者自行组合好的模板关键词列表，关键词顺序可以自由搭配（例如 [3,5,4] 或 [4,5,3]），最多支持5个，最少2个关键词组合
        /// </summary>
        [JsonProperty("kidList")]
        public int[] KidList { get; set; }

        /// <summary>
        /// 服务场景描述，15个字以内
        /// </summary>
        [JsonProperty("sceneDesc")]
        public string SceneDesc { get; set; }
    }
}