using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Http;
using Magicodes.Wx.PublicAccount.Sdk.Apis.Sns;

namespace Magicodes.Wx.PublicAccount.Sdk.AspNet.AspNet
{
    public class WeChatOAuthFilter : AuthorizeAttribute, IAsyncAuthorizationFilter
    {
        private const string RedirectUrlCookieName = "Magicodes.Wechat_RedirectUrlCookie";
        
        private readonly string _state = "magicodes.wechat";

        /// <summary>
        /// 验证级别
        /// </summary>
        public OAuthLevels OAuthLevel { get; set; } = OAuthLevels.OpenId;

        public async Task OnAuthorizationAsync(AuthorizationFilterContext context)
        {
            var serviceProvider = context.HttpContext.RequestServices;
            var logger = serviceProvider.GetRequiredService<ILogger<WeChatOAuthFilter>>();

            //通过判断Cookie（网页授权Token【115】分钟）是否存在发起跳转获得code
            logger.LogDebug($"WeChatOAuthFilter Begin {context.HttpContext.Request.Path}");
            switch (OAuthLevel)
            {
                case OAuthLevels.OpenId:
                    if (context.HttpContext.Request.Cookies.ContainsKey(WeChatAspNetConsts.COOKIE_WX_OPENID))
                    {
                        return;
                    }
                    break;

                case OAuthLevels.OpenIdAndToken:
                case OAuthLevels.OpenIdAndUserInfo:
                    if (context.HttpContext.Request.Cookies.ContainsKey(WeChatAspNetConsts.COOKIE_WX_OPENID) && context.HttpContext.Request.Cookies.ContainsKey(WeChatAspNetConsts.COOKIE_WX_WEBTOKEN))
                    {
                        return;
                    }
                    break;

                default:
                    break;
            }

            var request = context.HttpContext.Request;

            var code = request.Query["code"].ToString();
            var state = request.Query["state"].ToString();

            //TODO:验证Token，过期自动刷新

            #region 如果是从微信验证页面跳转回来，根据Code和State拿到OpenId等信息

            if (!string.IsNullOrEmpty(code) && !string.IsNullOrEmpty(state))
            {
                logger.LogDebug($"从微信验证页面跳转回来... code:{code}\tstate:{state}");
                var weChatFuncs = serviceProvider.GetRequiredService<WeChatFuncs>();
                var oauth2Api = serviceProvider.GetRequiredService<IOauth2Api>();
                var option = weChatFuncs.GetWeChatOptions();
                //通过code换取access_token,Code只能用一次
                //网页授权接口调用凭证,注意：此access_token与基础支持的access_token不同
                var result = await oauth2Api.GetAccessTokenAsync(option.AppId, option.AppSecret, code);

                result.EnsureSuccess();
                logger.LogDebug($"AccessToken:{result.AccessToken}");

                var cookies = context.HttpContext.Response.Cookies;
                
                cookies.Append(WeChatAspNetConsts.COOKIE_WX_OPENID, result.OpenId, new CookieOptions()
                {
                    Path = "/",
                    Expires = DateTimeOffset.Now.AddDays(30),
                    HttpOnly = true,
                    IsEssential = true,
                });

                cookies.Append(WeChatAspNetConsts.COOKIE_WX_WEBTOKEN, result.AccessToken, new CookieOptions()
                {
                    Path = "/",
                    Expires = DateTimeOffset.Now.AddMinutes(115),
                    HttpOnly = true,
                    IsEssential = true,
                });

                context.HttpContext.Items[WeChatAspNetConsts.COOKIE_WX_OPENID] = result.OpenId;
                context.HttpContext.Items[WeChatAspNetConsts.COOKIE_WX_WEBTOKEN] = result.AccessToken;
                logger.LogDebug("微信网页授权完成...");
                return;
            }

            #endregion 如果是从微信验证页面跳转回来，根据Code和State拿到OpenId等信息

            else if (!context.HttpContext.Request.Cookies.ContainsKey(WeChatAspNetConsts.COOKIE_WX_OPENID) || !context.HttpContext.Request.Cookies.ContainsKey(WeChatAspNetConsts.COOKIE_WX_WEBTOKEN))
            {
                var redirectUrl = UriHelper.GetDisplayUrl(request);
                var weChatFuncs = serviceProvider.GetRequiredService<WeChatFuncs>();
                var option = weChatFuncs.GetWeChatOptions();
                //获取授权Url
                var url = WeChatHelper.GetAuthorizeUrl(redirectUrl, _state, option.AppId, OAuthLevel == OAuthLevels.OpenIdAndUserInfo ? OAuthScopes.snsapi_userinfo : OAuthScopes.snsapi_base);
                logger.LogDebug($"跳转至微信服务器获取授权...{Environment.NewLine}RedirectUrl：{redirectUrl}{Environment.NewLine}AuthUrl:{url}");
                context.Result = new RedirectResult(url);
            }
            else
            {
                logger.LogError($"授权出错，请检查...{request.Path}");
                context.Result = new ContentResult { Content = "授权出错，请检查！" };
            }
        }
    }
}