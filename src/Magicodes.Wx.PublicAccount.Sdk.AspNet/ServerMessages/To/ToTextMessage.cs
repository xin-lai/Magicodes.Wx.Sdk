// ======================================================================
//  
//          Copyright (C) 2018-2068 湖南心莱信息科技有限公司    
//          All rights reserved
//  
//          filename : ToTextMessage.cs
//          description :
//  
//          created by codelove1314@live.cn at  2021-02-09 10:48:30
//          Blog：http://www.cnblogs.com/codelove/
//          GitHub ： https://github.com/xin-lai
//          Home：http://xin-lai.com
//  
// =======================================================================

namespace Magicodes.Wx.PublicAccount.Sdk.AspNet.ServerMessages.To
{
    using System.Xml.Serialization;

    /// <summary>
    /// 回复文本消息
    /// </summary>
    [XmlRoot(ElementName = "xml")]
    public class ToTextMessage : ToMessageBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ToTextMessage"/> class.
        /// </summary>
        public ToTextMessage()
        {
            Type = ToMessageTypes.text;
        }

        /// <summary>
        /// Gets or sets the Content
        /// 文本消息内容
        /// </summary>
        public string Content { get; set; }
    }
}
