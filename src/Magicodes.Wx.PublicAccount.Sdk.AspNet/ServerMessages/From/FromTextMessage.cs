// ======================================================================
//  
//          Copyright (C) 2018-2068 湖南心莱信息科技有限公司    
//          All rights reserved
//  
//          filename : FromTextMessage.cs
//          description :
//  
//          created by codelove1314@live.cn at  2021-02-09 10:48:28
//          Blog：http://www.cnblogs.com/codelove/
//          GitHub ： https://github.com/xin-lai
//          Home：http://xin-lai.com
//  
// =======================================================================

namespace Magicodes.Wx.PublicAccount.Sdk.AspNet.ServerMessages.From
{
    using System;
    using System.Xml.Serialization;

    /// <summary>
    /// 接收文本消息
    /// </summary>
    [XmlRoot("xml")]
    [Serializable]
    public class FromTextMessage : FromMessageBase
    {
        /// <summary>
        /// Gets or sets the Content
        /// 文本消息内容
        /// </summary>
        public string Content { get; set; }
    }
}
