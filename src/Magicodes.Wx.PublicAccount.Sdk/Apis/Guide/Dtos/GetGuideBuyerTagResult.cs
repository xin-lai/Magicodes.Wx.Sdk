using Newtonsoft.Json;
using System.Collections.Generic;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Guide.Dtos
{
    public class GetGuideBuyerTagResult : ApiResultBase
    {
        /// <summary>
        /// 标签值
        /// </summary>
        [JsonProperty("tag_values")]
        public List<string> TagValues { get; set; }
    }
}