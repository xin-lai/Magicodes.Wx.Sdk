// ======================================================================
//  
//          Copyright (C) 2018-2068 湖南心莱信息科技有限公司    
//          All rights reserved
//  
//          filename : ToImageMessage.cs
//          description :
//  
//          created by codelove1314@live.cn at  2021-02-09 10:48:29
//          Blog：http://www.cnblogs.com/codelove/
//          GitHub ： https://github.com/xin-lai
//          Home：http://xin-lai.com
//  
// =======================================================================

namespace Magicodes.Wx.PublicAccount.Sdk.AspNet.ServerMessages.To
{
    using System;
    using System.Xml.Serialization;

    /// <summary>
    /// 回复图片消息
    /// </summary>
    [XmlRoot(ElementName = "xml")]
    public class ToImageMessage : ToMessageBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ToImageMessage"/> class.
        /// </summary>
        public ToImageMessage()
        {
            Type = ToMessageTypes.image;
        }

        /// <summary>
        /// Gets or sets the Image
        /// </summary>
        public ImageInfo Image { get; set; }

        /// <summary>
        /// Defines the <see cref="ImageInfo" />
        /// </summary>
        [Serializable]
        public class ImageInfo
        {
            /// <summary>
            /// Gets or sets the MediaId
            /// </summary>
            public string MediaId { get; set; }
        }
    }
}
