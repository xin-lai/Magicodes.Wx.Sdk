using Microsoft.Extensions.Configuration;
using System;
using System.Collections;
using System.Security.Cryptography;
using System.Text;
using System.Text.Encodings.Web;

namespace Magicodes.Wx.Sdk.Core.Helper
{
    /// <summary>
    /// 微信公众号辅助类
    /// </summary>
    public class WxHelper
    {


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

        

        /// <summary>
        /// 获取时间戳
        /// </summary>
        /// <returns></returns>
        public static string GetTimestamp()
        {
            var ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64(ts.TotalSeconds).ToString();
        }

        /// <summary>
        /// sha1加密
        /// </summary>
        /// <param name="parameters">The parameters<see cref="Hashtable"/></param>
        /// <returns></returns>
        private static string CreateSha1(Hashtable parameters)
        {
            var sb = new StringBuilder();
            var akeys = new ArrayList(parameters.Keys);
            akeys.Sort();

            foreach (var k in akeys)
                if (parameters[k] != null)
                {
                    var v = (string)parameters[k];

                    if (sb.Length == 0)
                        sb.Append(k + "=" + v);
                    else
                        sb.Append("&" + k + "=" + v);
                }
            return GetSha1(sb.ToString()).ToLower();
        }

        /// <summary>
        /// 生成cardSign的加密方法
        /// </summary>
        /// <param name="parameters">The parameters<see cref="Hashtable"/></param>
        /// <returns></returns>
        private static string CreateCardSha1(Hashtable parameters)
        {
            var sb = new StringBuilder();
            //此处需要根据参数值进行排序
            var aValues = new ArrayList(parameters.Values);
            aValues.Sort();

            foreach (var value in aValues)
                if (value != null)
                    sb.Append(value);
            return GetSha1(sb.ToString()).ToLower();
        }

        /// <summary>
        /// 添加卡券Ext参数的签名加密方法
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        private static string CreateNonekeySha1(Hashtable parameters)
        {
            var sb = new StringBuilder();
            var aValues = new ArrayList(parameters.Values);
            aValues.Sort();

            foreach (var v in aValues)
                sb.Append(v);
            return GetSha1(sb.ToString()).ToLower();
        }

        /// <summary>
        /// 获取JS-SDK权限验证的签名Signature
        /// </summary>
        /// <param name="ticket"></param>
        /// <param name="noncestr"></param>
        /// <param name="timestamp"></param>
        /// <param name="url"></param>
        /// <returns></returns>
        public static string GetSignature(string ticket, string noncestr, string timestamp, string url)
        {
            var parameters = new Hashtable
            {
                {"jsapi_ticket", ticket},
                {"noncestr", noncestr},
                {"timestamp", timestamp},
                {"url", url}
            };
            return CreateSha1(parameters);
        }

        /// <summary>
        /// 签名算法
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string GetSha1(string str)
        {
            //建立SHA1对象
            SHA1 sha = new SHA1CryptoServiceProvider();
            //将mystr转换成byte[] 
            var enc = new ASCIIEncoding();
            var dataToHash = enc.GetBytes(str);
            //Hash运算
            var dataHashed = sha.ComputeHash(dataToHash);
            //将运算结果转换成string
            var hash = BitConverter.ToString(dataHashed).Replace("-", "");
            return hash;
        }
    }
}
