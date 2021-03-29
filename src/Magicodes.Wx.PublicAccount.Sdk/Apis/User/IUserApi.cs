using Magicodes.Wx.PublicAccount.Sdk.Apis.User.Dtos;
using Newtonsoft.Json;
using System.Threading.Tasks;
using WebApiClientCore.Attributes;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.User
{
    /// <summary>
    /// 用户管理
    /// </summary>
    [HttpHost("https://api.weixin.qq.com/cgi-bin/user/")]
    public interface IUserApi : IWxApiWithAccessTokenFilter
    {
        /// <summary>
        /// 获取用户基本信息(UnionID机制)
        /// </summary>
        /// <returns></returns>
        [HttpGet("info")]
        Task<UserInfoApiResult> InfoAsync(string openId, string lang = "zh_CN");

        /// <summary>
        /// 设置用户备注名
        /// </summary>
        /// <returns></returns>
        [HttpPost("info/updateremark")]
        Task<ApiResultBase> UpdateRemarkAsync([JsonNetContent(CharSet = "utf-8")] UpdateRemarkInput input);

        /// <summary>
        /// 获取用户列表
        /// </summary>
        /// <param name="nextOpenId">第一个拉取的OPENID，不填默认从头开始拉取</param>
        /// <returns></returns>
        [HttpGet("get")]
        Task<GetUserApiResult> GetAsync([JsonProperty("next_openid")] string nextOpenId = null);

        /// <summary>
        /// 获取标签下粉丝列表
        /// </summary>
        /// <returns></returns>
        [HttpPost("tag/get")]
        Task<GetUserApiResult> GetUserByTagAsync([JsonProperty("next_openid")] GetUserByTagInput input);
    }
}