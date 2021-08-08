using Magicodes.Wx.Sdk.Core;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using WebApiClientCore.Attributes;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Sns
{
    /// <summary>
    /// 网页授权接口
    /// https://developers.weixin.qq.com/doc/offiaccount/OA_Web_Apps/Wechat_webpage_authorization.html
    /// </summary>
    [HttpHost("https://api.weixin.qq.com/sns/oauth2/")]
    public interface IOauth2Api : IWxApiBase
    {
        /// <summary>
        /// 通过code换取网页授权access_token
        /// 
        /// </summary>
        /// <param name="appid">公众号的唯一标识</param>
        /// <param name="secret"></param>
        /// <param name="code"></param>
        /// <param name="grant_type"></param>
        /// <returns></returns>
        [HttpGet("access_token")]
        Task<OAuthAccessTokenApiResult> GetAccessTokenAsync([Required] string appid, [Required] string secret, [Required] string code, string grant_type = "authorization_code");

        /// <summary>
        /// 刷新access_token
        /// 由于access_token拥有较短的有效期，当access_token超时后，可以使用refresh_token进行刷新，refresh_token有效期为30天，当refresh_token失效之后，需要用户重新授权。
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="refresh_token"></param>
        /// <param name="grant_type"></param>
        /// <returns></returns>
        [HttpGet("refresh_token")]
        Task<OAuthRefreshTokenApiResult> RefreshTokenAsync([Required] string appId, [Required] string refresh_token, string grant_type = "refresh_token");
    }
}
