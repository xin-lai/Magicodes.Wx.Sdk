using Newtonsoft.Json;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis
{
    /// <summary>
    ///     API请求结果
    ///     {"errcode":40164,"errmsg":"invalid ip 218.76.8.29 ipv6 ::ffff:218.76.8.29, not in whitelist rid: 60122c35-705c3134-51b45a3d"}
    /// </summary>
    public class ApiResultBase
    {
        /// <summary>
        ///     返回码
        /// </summary>
        [JsonProperty("errcode")]
        public virtual ReturnCodes ReturnCode { get; set; }

        /// <summary>
        ///     错误消息
        /// </summary>
        [JsonProperty("errmsg")]
        public virtual string Message { get; set; }

        /// <summary>
        ///     是否为成功返回
        /// </summary>
        /// <returns></returns>
        public virtual bool IsSuccess()
        {
            return ReturnCode == ReturnCodes.请求成功;
        }

        /// <summary>
        ///     获取友好提示
        /// </summary>
        /// <returns></returns>
        public virtual string GetFriendlyMessage()
        {
            return ReturnCode.ToString();
        }


    }
}