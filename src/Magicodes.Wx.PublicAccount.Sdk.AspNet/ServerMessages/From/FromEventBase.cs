// ======================================================================
//
//          Copyright (C) 2018-2068 湖南心莱信息科技有限公司
//          All rights reserved
//
//          filename : FromEventBase.cs
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
    using Magicodes.Wx.PublicAccount.Sdk.Helper;
    using System;
    using System.Xml.Serialization;

    /// <summary>
    /// Defines the <see cref="FromEventBase" />
    /// </summary>
    [XmlRoot("xml")]
    [Serializable]
    public abstract class FromEventBase : IFromMessage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FromEventBase"/> class.
        /// </summary>
        protected FromEventBase()
        {
            Type = "event";
        }

        /// <summary>
        /// Gets or sets the ToUserName
        /// 开发者微信号
        /// </summary>
        [XmlElement("ToUserName")]
        public string ToUserName { get; set; }

        /// <summary>
        /// Gets or sets the FromUserName
        /// 发送方帐号（一个OpenID）
        /// </summary>
        [XmlElement("FromUserName")]
        public string FromUserName { get; set; }

        /// <summary>
        /// Gets or sets the CreateTimestamp
        /// </summary>
        [XmlElement("CreateTime")]
        internal long CreateTimestamp { get; set; }

        /// <summary>
        /// Gets the CreateDateTime
        /// 创建时间
        /// </summary>
        [XmlIgnore]
        public DateTime CreateDateTime => CreateTimestamp > 0 ? CreateTimestamp.ConvertToDateTime() : default(DateTime);

        /// <summary>
        /// Gets or sets the Type
        /// 消息类型
        /// </summary>
        [XmlElement("MsgType")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the Event
        /// 事件类型，subscribe(订阅)、unsubscribe(取消订阅)
        /// </summary>
        public FromEventTypes Event { get; set; }
    }
}