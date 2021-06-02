using Newtonsoft.Json;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Guide.Dtos
{
    public class GetGuideMassendJobResult : ApiResultBase
    {
        /// <summary>
        /// 群发任务
        /// </summary>
        [JsonProperty("job")]
        public GuideMassendJobListInfo Job { get; set; }
    }
}