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
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Xml.Serialization;

    /// <summary>
    /// 扫描带参数二维码事件
    /// </summary>
    [XmlRoot("xml")]
    public class FromScanEvent : FromEventBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FromScanEvent"/> class.
        /// </summary>
        public FromScanEvent()
        {
            Event = FromEventTypes.scan;
        }

        /// <summary>
        /// Gets or sets the EventKey
        /// 事件KEY值，qrscene_为前缀，后面为二维码的参数值
        /// </summary>
        public string EventKey { get; set; }

        /// <summary>
        /// Gets or sets the Ticket
        /// 二维码的ticket，可用来换取二维码图片
        /// </summary>
        public string Ticket { get; set; }

        /// <summary>
        /// Gets the Data
        /// 事件字典值
        /// </summary>
        [XmlIgnore]
        public Dictionary<string, string> Data
        {
            get
            {
                if (string.IsNullOrWhiteSpace(EventKey))
                {
                    return null;
                }
                return EventKey.StartsWith("{") ? JsonConvert.DeserializeObject<Dictionary<string, string>>(EventKey) : null;
            }
        }
    }
}
