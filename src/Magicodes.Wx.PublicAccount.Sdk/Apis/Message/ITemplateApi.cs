using System.Threading.Tasks;
using WebApiClientCore.Attributes;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Message
{
    /// <summary>
    /// 模板消息接口
    /// </summary>
    [HttpHost("https://api.weixin.qq.com/cgi-bin/message/template/")]
    public interface ITemplateApi : IWxApiWithAccessTokenFilter
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("send")]
        Task<SendTemplateMessageApiResult> SendAsync([JsonNetContent(CharSet = "utf-8")] SendTemplateMessageInput input);
    }
}
