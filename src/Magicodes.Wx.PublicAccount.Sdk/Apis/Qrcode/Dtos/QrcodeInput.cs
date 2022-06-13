using Newtonsoft.Json;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Qrcode
{
    public class QrcodeInput
    {
        public QrcodeInput()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="expireSeconds"></param>
        /// <param name="actionName">二维码类型，QR_SCENE为临时的整型参数值，QR_STR_SCENE为临时的字符串参数值，QR_LIMIT_SCENE为永久的整型参数值，QR_LIMIT_STR_SCENE为永久的字符串参数值</param>
        /// <param name="sceneId">场景值ID，临时二维码时为32位非0整型，永久二维码时最大值为100000（目前参数只支持1--100000）</param>
        public QrcodeInput(int expireSeconds, string actionName, int sceneId)
        {
            ExpireSeconds = expireSeconds;
            ActionName = actionName;
            ActionInfo = new QrcodeInputActionInfo()
            {
                Scene = new QrcodeInputActionInfoScene()
                {
                    SceneId = sceneId
                }
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="expireSeconds">该二维码有效时间，以秒为单位。 最大不超过2592000（即30天），此字段如果不填，则默认有效期为60秒。</param>
        /// <param name="actionName">二维码类型，QR_SCENE为临时的整型参数值，QR_STR_SCENE为临时的字符串参数值，QR_LIMIT_SCENE为永久的整型参数值，QR_LIMIT_STR_SCENE为永久的字符串参数值</param>
        /// <param name="sceneStr">场景值ID（字符串形式的ID），字符串类型，长度限制为1到64</param>

        public QrcodeInput(int expireSeconds, string actionName, string sceneStr = null)
        {
            ExpireSeconds = expireSeconds;
            ActionName = actionName;
            ActionInfo = new QrcodeInputActionInfo()
            {
                Scene = new QrcodeInputActionInfoScene()
                {
                    SceneStr = sceneStr
                }
            };
        }

        /// <summary>
        /// 该二维码有效时间，以秒为单位。 最大不超过2592000（即30天），此字段如果不填，则默认有效期为60秒。
        /// </summary>
        [JsonProperty("expire_seconds")]
        public int ExpireSeconds { get; set; }

        /// <summary>
        /// 二维码类型
        /// QR_SCENE为临时的整型参数值
        /// QR_STR_SCENE为临时的字符串参数值
        /// QR_LIMIT_SCENE为永久的整型参数值
        /// QR_LIMIT_STR_SCENE为永久的字符串参数值
        /// </summary>
        [JsonProperty("action_name")]
        public string ActionName { get; set; }

        /// <summary>
        /// 二维码详细信息
        /// </summary>
        [JsonProperty("action_info")]
        public QrcodeInputActionInfo ActionInfo { get; set; }
    }
}