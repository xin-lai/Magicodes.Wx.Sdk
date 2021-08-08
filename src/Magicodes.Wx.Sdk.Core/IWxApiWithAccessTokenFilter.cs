using WebApiClientCore.Attributes;

namespace Magicodes.Wx.Sdk.Core
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
