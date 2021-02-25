// ======================================================================
//  
//          Copyright (C) 2018-2068 湖南心莱信息科技有限公司    
//          All rights reserved
//  
//          filename : FromSubscribeEvent.cs
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
    /// 上报地理位置事件
    /// </summary>
    [XmlRoot("xml")]
    public class FromLocationEvent : FromEventBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FromLocationEvent"/> class.
        /// </summary>
        public FromLocationEvent()
        {
            Event = FromEventTypes.location;
        }

        /// <summary>
        /// Gets or sets the Latitude
        /// 地理位置纬度
        /// </summary>
        public double Latitude { get; set; }

        /// <summary>
        /// Gets or sets the Longitude
        /// 地理位置经度
        /// </summary>
        public double Longitude { get; set; }

        /// <summary>
        /// Gets or sets the Precision
        /// 地理位置精度
        /// </summary>
        public double Precision { get; set; }
    }
}
