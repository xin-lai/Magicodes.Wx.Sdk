using System.Threading.Tasks;

namespace Magicodes.WeChat.Sdk
{
    public interface ITokenManager
    {
        Task<string> GetAccessTokenAsync();
    }
}