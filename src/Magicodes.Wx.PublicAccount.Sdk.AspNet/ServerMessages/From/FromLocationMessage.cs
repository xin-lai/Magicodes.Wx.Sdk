// ======================================================================
//  
//          Copyright (C) 2018-2068 湖南心莱信息科技有限公司    
//          All rights reserved
//  
//          filename : FromLocationMessage.cs
//          description :
//  
//          created by codelove1314@live.cn at  2021-02-09 10:48:27
//          Blog：http://www.cnblogs.com/codelove/
//          GitHub ： https://github.com/xin-lai
//          Home：http://xin-lai.com
//  
// =======================================================================

namespace Magicodes.Wx.PublicAccount.Sdk.AspNet.ServerMessages.From
{
    using System.Xml.Serialization;

    /// <summary>
    /// 地理位置消息
    /// </summary>
    public class FromLocationMessage : FromMessageBase
    {
        /// <summary>
        /// Gets or sets the X
        /// 地理位置维度
        /// </summary>
        [XmlElement("Location_X")]
        public double X { get; set; }

        /// <summary>
        /// Gets or sets the Y
        /// 地理位置经度
        /// </summary>
        [XmlElement("Location_Y")]
        public double Y { get; set; }

        /// <summary>
        /// Gets or sets the Scale
        /// 地图缩放大小
        /// </summary>
        public double Scale { get; set; }

        /// <summary>
        /// Gets or sets the Label
        /// 地理位置信息
        /// </summary>
        public string Label { get; set; }
    }
}
