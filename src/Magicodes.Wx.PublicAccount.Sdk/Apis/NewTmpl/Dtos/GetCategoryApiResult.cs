using Newtonsoft.Json;
using System.Collections.Generic;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.NewTmpl.Dtos
{
    public class GetCategoryApiResult : ApiResultBase
    {
        [JsonProperty("data")]
        public IEnumerable<CategoryDataInfo> Data { get; set; }
    }

    public class CategoryDataInfo
    {
        /// <summary>
        /// 类目id，查询公共模板库时需要
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// 类目的中文名
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}