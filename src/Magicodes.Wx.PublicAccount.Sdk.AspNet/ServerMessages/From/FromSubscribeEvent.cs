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
    /// 关注事件
    /// </summary>
    [XmlRoot("xml")]
    public class FromSubscribeEvent : FromEventBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FromSubscribeEvent"/> class.
        /// </summary>
        public FromSubscribeEvent()
        {
            Event = FromEventTypes.subscribe;
        }

        /// <summary>
        /// Gets or sets the EventKey
        /// 事件KEY值，qrscene_为前缀，后面为二维码的参数值
        /// </summary>
        public string EventKey { get; set; }

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

        /// <summary>
        /// Gets or sets the Ticket
        /// 二维码的ticket，可用来换取二维码图片
        /// </summary>
        public string Ticket { get; set; }
    }

    /// <summary>
    /// 取消关注事件
    /// </summary>
    [XmlRoot("xml")]
    public class FromUnsubscribeEvent : FromEventBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FromUnsubscribeEvent"/> class.
        /// </summary>
        public FromUnsubscribeEvent()
        {
            Event = FromEventTypes.unsubscribe;
        }
    }

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

    /// <summary>
    /// 点击菜单拉取消息时的事件推送
    ///     用户点击自定义菜单后，微信会把点击事件推送给开发者，请注意，点击菜单弹出子菜单，不会产生上报。
    /// </summary>
    [XmlRoot("xml")]
    public class FromClickEvent : FromEventBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FromClickEvent"/> class.
        /// </summary>
        public FromClickEvent()
        {
            Event = FromEventTypes.click;
        }

        /// <summary>
        /// Gets or sets the EventKey
        /// 事件KEY值，与自定义菜单接口中KEY值对应
        /// </summary>
        public string EventKey { get; set; }
    }

    /// <summary>
    /// 点击菜单跳转链接时的事件推送
    /// </summary>
    [XmlRoot("xml")]
    public class FromViewEvent : FromEventBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FromViewEvent"/> class.
        /// </summary>
        public FromViewEvent()
        {
            Event = FromEventTypes.view;
        }

        /// <summary>
        /// Gets or sets the EventKey
        /// 事件KEY值，与自定义菜单接口中KEY值对应
        /// </summary>
        public string EventKey { get; set; }
    }

    /// <summary>
    /// 模板消息推送成功的事件推送
    /// </summary>
    [XmlRoot("xml")]
    public class FromTemplateSendJobFinishEvent : FromEventBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FromTemplateSendJobFinishEvent"/> class.
        /// </summary>
        public FromTemplateSendJobFinishEvent()
        {
            Event = FromEventTypes.templatesendjobfinish;
        }

        /// <summary>
        /// Gets or sets the MsgID
        /// 消息id
        /// </summary>
        public string MsgID { get; set; }

        /// <summary>
        /// Gets or sets the Status
        /// 发送状态为成功
        /// </summary>
        public string Status { get; set; }
    }
}
