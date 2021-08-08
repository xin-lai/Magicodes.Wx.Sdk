using Magicodes.Wx.Sdk.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebApiClientCore.Attributes;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Message
{
    /// <summary>
    /// 群发消息接口
    /// </summary>
    [HttpHost("https://api.weixin.qq.com/cgi-bin/message/mass/")]
    public interface IMassApi : IWxApiWithAccessTokenFilter
    {
        /// <summary>
        ///根据标签进行群发【订阅号与服务号认证后均可用】
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("sendall")]
        Task<SendAllApiResult> SendAllAsync([JsonNetContent(CharSet = "utf-8")] SendAllInputBase input);

        /// <summary>
        /// 根据OpenID列表群发【订阅号不可用，服务号认证后可用】
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("send")]
        Task<SendAllApiResult> SendAsync([JsonNetContent(CharSet = "utf-8")] SendInputBase input);

        /// <summary>
        /// 删除群发【订阅号与服务号认证后均可用】
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("delete")]
        Task<ApiResultBase> DeleteAsync(DeleteInput input);
    }
}