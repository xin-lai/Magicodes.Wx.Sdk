// ======================================================================
//
//          Copyright (C) 2018-2068 湖南心莱信息科技有限公司
//          All rights reserved
//
//          filename : ToMessageExtensions.cs
//          description :
//
//          created by codelove1314@live.cn at  2021-02-09 10:48:31
//          Blog：http://www.cnblogs.com/codelove/
//          GitHub ： https://github.com/xin-lai
//          Home：http://xin-lai.com
//
// =======================================================================

namespace Magicodes.Wx.PublicAccount.Sdk.AspNet.ServerMessages
{
    using Magicodes.Wx.PublicAccount.Sdk.AspNet.ServerMessages.To;
    using Magicodes.Wx.PublicAccount.Sdk.Helper;

    /// <summary>
    /// 发送消息扩展
    /// </summary>
    public static class ToMessageExtensions
    {
        /// <summary>
        /// 序列化XML
        /// </summary>
        /// <param name="msg">发送消息</param>
        /// <returns></returns>
        public static string ToXml(this ToMessageBase msg)
        {
            //移除定义和命名空间
            return msg == null ? null : XmlHelper.SerializeObjectWithoutNamespace(msg);
        }
    }
}