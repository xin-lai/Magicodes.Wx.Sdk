using Magicodes.Wx.PublicAccount.Sdk.Apis.Sns;
using Magicodes.Wx.Sdk.Core.Helper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace Magicodes.Wx.PublicAccount.Sdk.AspNet
{
    /// <summary>
    /// 公众号网页授权筛选器
    /// </summary>
    public class WxPublicAccountOAuthFilter : AuthorizeAttribute, IAsyncAuthorizationFilter
    {
        private readonly string _state = "mc.wx";

        /// <summary>
        /// 验证级别
        /// </summary>
        public OAuthLevels OAuthLevel { get; set; } = OAuthLevels.OpenId;

        public async Task OnAuthorizationAsync(AuthorizationFilterContext context)
        {
            IServiceProvider serviceProvider = context.HttpContext.RequestServices;
            ILogger<WxPublicAccountOAuthFilter> logger = serviceProvider.GetRequiredService<ILogger<WxPublicAccountOAuthFilter>>();

            //通过判断Cookie（网页授权Token【115】分钟）是否存在发起跳转获得code
            logger.LogDebug($"WeChatOAuthFilter Begin {context.HttpContext.Request.Path}");
            switch (OAuthLevel)
            {
                case OAuthLevels.OpenId:
                    if (context.HttpContext.Request.Cookies.ContainsKey(WxConsts.COOKIE_WX_OPENID))
                    {
                        return;
                    }
                    break;

                case OAuthLevels.OpenIdAndToken:
                case OAuthLevels.OpenIdAndUserInfo:
                    if (context.HttpContext.Request.Cookies.ContainsKey(WxConsts.COOKIE_WX_OPENID) && context.HttpContext.Request.Cookies.ContainsKey(WxConsts.COOKIE_WX_WEBTOKEN))
                    {
                        return;
                    }
                    break;

                default:
                    break;
            }

            HttpRequest request = context.HttpContext.Request;

            string code = request.Query["code"].ToString();
            string state = request.Query["state"].ToString();

            //TODO:验证Token，过期自动刷新

            #region 如果是从微信验证页面跳转回来，根据Code和State拿到OpenId等信息

            if (!string.IsNullOrEmpty(code) && !string.IsNullOrEmpty(state))
            {
                logger.LogDebug($"从微信验证页面跳转回来... code:{code}\tstate:{state}");
                WxFuncs weChatFuncs = serviceProvider.GetRequiredService<WxFuncs>();
                IOauth2Api oauth2Api = serviceProvider.GetRequiredService<IOauth2Api>();
                WxPublicAccountOption option = weChatFuncs.GetWeChatOptions();
                //通过code换取access_token,Code只能用一次
                //网页授权接口调用凭证,注意：此access_token与基础支持的access_token不同
                OAuthAccessTokenApiResult result = await oauth2Api.GetAccessTokenAsync(option.AppId, option.AppSecret, code);

                result.EnsureSuccess();
                logger.LogDebug($"AccessToken:{result.AccessToken}");

                IResponseCookies cookies = context.HttpContext.Response.Cookies;

                cookies.Append(WxConsts.COOKIE_WX_OPENID, result.OpenId, new CookieOptions()
                {
                    Path = "/",
                    Expires = DateTimeOffset.Now.AddDays(30),
                    HttpOnly = true,
                    IsEssential = true,
                });

                cookies.Append(WxConsts.COOKIE_WX_WEBTOKEN, result.AccessToken, new CookieOptions()
                {
                    Path = "/",
                    Expires = DateTimeOffset.Now.AddMinutes(115),
                    HttpOnly = true,
                    IsEssential = true,
                });

                context.HttpContext.Items[WxConsts.COOKIE_WX_OPENID] = result.OpenId;
                context.HttpContext.Items[WxConsts.COOKIE_WX_WEBTOKEN] = result.AccessToken;
                logger.LogDebug("微信网页授权完成...");
                return;
            }

            #endregion 如果是从微信验证页面跳转回来，根据Code和State拿到OpenId等信息

            else if (!context.HttpContext.Request.Cookies.ContainsKey(WxConsts.COOKIE_WX_OPENID) || !context.HttpContext.Request.Cookies.ContainsKey(WxConsts.COOKIE_WX_WEBTOKEN))
            {
                string redirectUrl = UriHelper.GetDisplayUrl(request);
                WxFuncs weChatFuncs = serviceProvider.GetRequiredService<WxFuncs>();
                WxPublicAccountOption option = weChatFuncs.GetWeChatOptions();
                //获取授权Url
                string url = GetAuthorizeUrl(redirectUrl, _state, option.AppId, OAuthLevel == OAuthLevels.OpenIdAndUserInfo ? OAuthScopes.snsapi_userinfo : OAuthScopes.snsapi_base);
                logger.LogDebug($"跳转至微信服务器获取授权...{Environment.NewLine}RedirectUrl：{redirectUrl}{Environment.NewLine}AuthUrl:{url}");
                context.Result = new RedirectResult(url);
            }
            else
            {
                logger.LogError($"授权出错，请检查...{request.Path}");
                context.Result = new ContentResult { Content = "授权出错，请检查！" };
            }
        }

        /// <summary>
        ///     获取网页授权链接
        /// </summary>
        /// <param name="redirectUrl">授权后重定向的回调链接地址，请使用urlencode对链接进行处理</param>
        /// <param name="state">重定向后会带上state参数，开发者可以填写a-zA-Z0-9的参数值，最多128字节</param>
        /// <param name="appid"></param>
        /// <param name="scope">
        ///     应用授权作用域
        ///     snsapi_base （不弹出授权页面，直接跳转，只能获取用户openid），
        ///     snsapi_userinfo（弹出授权页面，可通过openid拿到昵称、性别、所在地。并且，即使在未关注的情况下，只要用户授权，也能获取其信息）
        /// </param>
        /// <returns></returns>
        private static string GetAuthorizeUrl(string redirectUrl, string state, string appid, OAuthScopes scope = OAuthScopes.snsapi_userinfo)
        {
            return $"https://open.weixin.qq.com/connect/oauth2/authorize?appid={appid}&redirect_uri={UrlEncoder.Default.Encode(redirectUrl)}&response_type=code&scope={scope}&state={state}#wechat_redirect";
        }
    }
}