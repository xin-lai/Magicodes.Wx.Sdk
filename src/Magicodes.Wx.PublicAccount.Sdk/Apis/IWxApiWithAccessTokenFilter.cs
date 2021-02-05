using WebApiClientCore.Attributes;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis
{
    /// <summary>
    /// 
    /// </summary>
    [JsonNetReturn(EnsureMatchAcceptContentType = false)]
    [AccessTokenApiFilter]
    [LoggingFilter]
    public interface IWxApiWithAccessTokenFilter
    {
    }
}
