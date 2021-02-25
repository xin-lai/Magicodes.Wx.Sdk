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
}
