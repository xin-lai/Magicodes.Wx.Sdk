using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Magicodes.Wx.PublicAccount.Sdk.Apis.Sns;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace Magicodes.Wx.PublicAccount.Sdk.AspNet
{
    /// <summary>
    /// 
    /// </summary>
    [AllowAnonymous]
    public class WxPublicAccountControllerBase : Controller
    {
        /// <summary>
        /// 获取WebToken
        /// </summary>
        protected string WebAccessToken
        {
            get
            {
                var webAccessToken = Request.HttpContext.Items[WxConsts.COOKIE_WX_WEBTOKEN]?.ToString();
                if (webAccessToken == null)
                {
                    webAccessToken = Request.Cookies[WxConsts.COOKIE_WX_WEBTOKEN];
                }

                return webAccessToken;
            }
        }

        /// <summary>
        /// 获取OpenId
        /// </summary>
        protected string OpenId
        {
            get
            {
                var openId = Request.HttpContext.Items[WxConsts.COOKIE_WX_OPENID]?.ToString();
                if (openId == null)
                {
                    openId = Request.Cookies[WxConsts.COOKIE_WX_OPENID];
                }
                return openId;
            }
        }

        /// <summary>
        /// 获取微信用户信息
        /// </summary>
        /// <returns></returns>
        protected async Task<GetUserInfoApiResult> GetWeChatUserInfoAsync()
        {
            var snsApi =
               Request.HttpContext.RequestServices.GetRequiredService<ISnsApi>();
            var result = await snsApi.GetUserInfoAsync(WebAccessToken, OpenId);
            result.EnsureSuccess();
            return result;
        }
    }
}
