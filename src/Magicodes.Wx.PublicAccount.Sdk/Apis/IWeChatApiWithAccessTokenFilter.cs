using WebApiClientCore.Attributes;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis
{
    [JsonNetReturn(EnsureMatchAcceptContentType = false)]
    [AccessTokenApiFilter]
    public interface IWeChatApiWithAccessTokenFilter
    {
    }
}
