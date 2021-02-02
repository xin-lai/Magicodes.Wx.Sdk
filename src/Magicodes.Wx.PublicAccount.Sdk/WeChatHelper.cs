using Magicodes.WeChat.Sdk.Apis.Sns;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Text.Encodings.Web;

namespace Magicodes.WeChat.Sdk
{
    public class WeChatHelper
    {
        /// <summary>
        ///     获取网页授权链接
        /// </summary>
        /// <param name="redirectUrl">授权后重定向的回调链接地址，请使用urlencode对链接进行处理</param>
        /// <param name="state">重定向后会带上state参数，开发者可以填写a-zA-Z0-9的参数值，最多128字节</param>
        /// <param name="scope">
        ///     应用授权作用域
        ///     snsapi_base （不弹出授权页面，直接跳转，只能获取用户openid），
        ///     snsapi_userinfo（弹出授权页面，可通过openid拿到昵称、性别、所在地。并且，即使在未关注的情况下，只要用户授权，也能获取其信息）
        /// </param>
        /// <returns></returns>
        public static string GetAuthorizeUrl(string redirectUrl, string state, string appid, OAuthScopes scope = OAuthScopes.snsapi_userinfo)
        {
            return $"https://open.weixin.qq.com/connect/oauth2/authorize?appid={appid}&redirect_uri={UrlEncoder.Default.Encode(redirectUrl)}&response_type=code&scope={scope}&state={state}#wechat_redirect";
        }

        /// <summary>
        /// The GetWeChatMd5
        /// </summary>
        /// <param name="encypStr">The encypStr<see cref="string"/></param>
        /// <returns>The <see cref="string"/></returns>
        public static string GetWeChatMd5(string encypStr)
        {
            return MD5(encypStr, "GB2312");
        }

        /// <summary>
        /// 获取大写的MD5签名结果
        /// </summary>
        /// <param name="encypStr"></param>
        /// <param name="charset"></param>
        /// <returns></returns>
        public static string MD5(string encypStr, string charset)
        {
            MD5CryptoServiceProvider m5 = new MD5CryptoServiceProvider();
            //创建md5对象
            byte[] inputBye;
            //使用GB2312编码方式把字符串转化为字节数组．
            try
            {
                inputBye = Encoding.GetEncoding(charset).GetBytes(encypStr);
            }
            catch (Exception)
            {
                inputBye = Encoding.GetEncoding("GB2312").GetBytes(encypStr);
            }
            byte[] outputBye = m5.ComputeHash(inputBye);
            string retStr = BitConverter.ToString(outputBye);
            retStr = retStr.Replace("-", "").ToUpper();
            return retStr;
        }
    }
}
