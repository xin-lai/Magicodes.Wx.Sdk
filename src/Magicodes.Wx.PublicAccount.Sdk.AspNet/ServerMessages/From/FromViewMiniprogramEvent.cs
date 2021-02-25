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
    /// 点击菜单跳转小程序的事件推送
    /// </summary>
    [XmlRoot("xml")]
    public class FromViewMiniprogramEvent : FromEventBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FromViewEvent"/> class.
        /// </summary>
        public FromViewMiniprogramEvent()
        {
            Event = FromEventTypes.viewminiprogram;
        }

        /// <summary>
        /// 事件KEY值，跳转的小程序路径
        /// </summary>
        public string EventKey { get; set; }

        /// <summary>
        /// 菜单ID，如果是个性化菜单，则可以通过这个字段，知道是哪个规则的菜单被点击了
        /// </summary>
        public string MenuId { get; set; }
    }
}
