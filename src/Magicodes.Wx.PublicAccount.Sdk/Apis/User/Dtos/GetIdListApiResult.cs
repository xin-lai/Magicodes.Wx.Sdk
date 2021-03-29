using Newtonsoft.Json;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.User.Dtos
{
    public class GetIdListApiResult : ApiResultBase
    {
        /// <summary>
        /// 被置上的标签列表
        /// </summary>
        [JsonProperty("tagid_list")]
        public int[] TagIdList { get; set; }
    }
}