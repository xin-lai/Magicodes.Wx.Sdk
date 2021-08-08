using System.Threading.Tasks;

namespace Magicodes.Wx.Sdk.Core
{
    /// <summary>
    /// Token管理器
    /// </summary>
    public interface ITokenManager
    {
        /// <summary>
        /// 获取访问Token
        /// </summary>
        /// <returns></returns>
        Task<string> GetAccessTokenAsync();
    }
}