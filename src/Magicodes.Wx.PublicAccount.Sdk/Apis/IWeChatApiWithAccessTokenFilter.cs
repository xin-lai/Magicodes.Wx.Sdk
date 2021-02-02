using WebApiClientCore.Attributes;

namespace Magicodes.WeChat.Sdk.Apis
{
    [JsonNetReturn(EnsureMatchAcceptContentType = false)]
    [AccessTokenApiFilter]
    public interface IWeChatApiWithAccessTokenFilter
    {
    }
}
