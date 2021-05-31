using Newtonsoft.Json;
using System.Collections.Generic;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Guide.Dtos
{
    public class NewGuideTagOptionInput
    {
        /// <summary>
        /// 标签类型的名字，不能为空
        /// </summary>
        [JsonProperty("tag_name")]
        public string TagName { get; set; }

        /// <summary>
        /// 标签可选值列表，可选值不能为空值，所有的标签可选值不能有相等重复的值
        /// </summary>
        [JsonProperty("tag_values")]
        public List<string> TagValues { get; set; }
    }
}