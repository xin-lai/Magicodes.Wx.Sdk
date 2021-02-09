// ======================================================================
//  
//          Copyright (C) 2018-2068 湖南心莱信息科技有限公司    
//          All rights reserved
//  
//          filename : FromVoiceMessage.cs
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
    using System.Xml.Serialization;

    /// <summary>
    /// 语音消息
    /// </summary>
    public class FromVoiceMessage : FromMessageBase
    {
        /// <summary>
        /// Gets or sets the Format
        /// 语音格式，如amr，speex等
        /// </summary>
        public string Format { get; set; }

        /// <summary>
        /// Gets or sets the MediaId
        /// 语音消息媒体id，可以调用多媒体文件下载接口拉取数据。
        /// </summary>
        [XmlElement("MediaId")]
        public string MediaId { get; set; }

        /// <summary>
        /// Gets or sets the Recognition
        /// 语音识别结果（仅启用了语音识别之后才返回）
        /// </summary>
        [XmlElement("Recognition")]
        public string Recognition { get; set; }
    }
}
