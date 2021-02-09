// ======================================================================
//  
//          Copyright (C) 2018-2068 湖南心莱信息科技有限公司    
//          All rights reserved
//  
//          filename : ToVoiceMessage.cs
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
    /// 回复语音消息
    /// </summary>
    [XmlRoot(ElementName = "xml")]
    public class ToVoiceMessage : ToMessageBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ToVoiceMessage"/> class.
        /// </summary>
        public ToVoiceMessage()
        {
            Type = ToMessageTypes.voice;
        }

        /// <summary>
        /// Gets or sets the Voice
        /// </summary>
        public VoiceInfo Voice { get; set; }

        /// <summary>
        /// Defines the <see cref="VoiceInfo" />
        /// </summary>
        [Serializable]
        public class VoiceInfo
        {
            /// <summary>
            /// Gets or sets the MediaId
            /// </summary>
            public string MediaId { get; set; }
        }
    }
}
