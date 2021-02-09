// ======================================================================
//  
//          Copyright (C) 2018-2068 湖南心莱信息科技有限公司    
//          All rights reserved
//  
//          filename : FromImageMessage.cs
//          description :
//  
//          created by codelove1314@live.cn at  2021-02-09 10:48:26
//          Blog：http://www.cnblogs.com/codelove/
//          GitHub ： https://github.com/xin-lai
//          Home：http://xin-lai.com
//  
// =======================================================================

namespace Magicodes.Wx.PublicAccount.Sdk.AspNet.ServerMessages.From
{
    using System.Xml.Serialization;

    /// <summary>
    /// 图片消息
    /// </summary>
    public class FromImageMessage : FromMessageBase
    {
        /// <summary>
        /// Gets or sets the ImageUrl
        /// 图片链接
        /// </summary>
        [XmlElement("PicUrl")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Gets or sets the MediaId
        /// 图片消息媒体id，可以调用多媒体文件下载接口拉取数据。
        /// </summary>
        [XmlElement("MediaId")]
        public string MediaId { get; set; }
    }
}
