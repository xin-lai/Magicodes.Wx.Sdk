using Newtonsoft.Json;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Guide.Dtos
{
    public class GetGroupInfoInput
    {
        /// <summary>
        /// 顾问群组id
        /// </summary>
        [JsonProperty("group_id")]
        public long GroupId { get; set; }

        /// <summary>
        /// 分页页数，从0开始，用于组内顾问分页获取
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        [JsonProperty("num")]
        public int Num { get; set; }
    }
}