using System.Threading.Tasks;

namespace Magicodes.Wx.PublicAccount.Sdk
{
    public interface ITokenManager
    {
        Task<string> GetAccessTokenAsync();
    }
}