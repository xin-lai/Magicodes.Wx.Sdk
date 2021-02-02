using System.Threading.Tasks;
using WebApiClientCore.Attributes;

namespace Magicodes.WeChat.Sdk.Apis.Message
{
    /// <summary>
    /// 模板消息接口
    /// </summary>
    [HttpHost("https://api.weixin.qq.com/cgi-bin/message/template")]
    public interface ITemplateApi : IWeChatApiWithAccessTokenFilter
    {
        Task<SendTemplateMessageApiResult> SendAsync(SendTemplateMessageInput input);
    }
}
