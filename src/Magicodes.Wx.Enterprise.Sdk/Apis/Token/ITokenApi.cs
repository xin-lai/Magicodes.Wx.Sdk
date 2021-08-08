using Magicodes.Wx.Enterprise.Sdk.Apis.Token.Dtos;
using Magicodes.Wx.Sdk.Core;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using WebApiClientCore.Attributes;

namespace Magicodes.Wx.Enterprise.Sdk.Apis.Token
{
    [HttpHost("https://qyapi.weixin.qq.com/cgi-bin/")]
    public interface ITokenApi : IWxApiBase
    {
        /// <summary>
        /// 获取access_token
        /// </summary>
        /// <param name="corpid">企业ID，获取方式参考：术语说明-corpid</param>
        /// <param name="corpsecret">应用的凭证密钥，获取方式参考：术语说明-secret</param>
        /// <returns></returns>
        [HttpGet("gettoken")]
        Task<TokenApiResult> GetAsync([Required] string corpid, [Required] string corpsecret);
    }
}