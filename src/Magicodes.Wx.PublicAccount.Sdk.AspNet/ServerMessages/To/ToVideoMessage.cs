// ======================================================================
//  
//          Copyright (C) 2018-2068 湖南心莱信息科技有限公司    
//          All rights reserved
//  
//          filename : ToVideoMessage.cs
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
    using System;
    using System.Xml.Serialization;

    /// <summary>
    /// 回复视频消息
    /// </summary>
    [XmlRoot(ElementName = "xml")]
    public class ToVideoMessage : ToMessageBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ToVideoMessage"/> class.
        /// </summary>
        public ToVideoMessage()
        {
            Type = ToMessageTypes.video;
        }

        /// <summary>
        /// Gets or sets the Voice
        /// </summary>
        public VideoInfo Voice { get; set; }

        /// <summary>
        /// Defines the <see cref="VideoInfo" />
        /// </summary>
        [Serializable]
        public class VideoInfo
        {
            /// <summary>
            /// Gets or sets the MediaId
            /// </summary>
            public string MediaId { get; set; }

            /// <summary>
            /// Gets or sets the Title
            /// 视频消息的标题
            /// </summary>
            public string Title { get; set; }

            /// <summary>
            /// Gets or sets the Description
            /// 视频消息的描述
            /// </summary>
            public string Description { get; set; }
        }
    }
}
