// ======================================================================
//  
//          Copyright (C) 2018-2068 湖南心莱信息科技有限公司    
//          All rights reserved
//  
//          filename : FromEventTypes.cs
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
    ///     事件类型
    /// </summary>
    public enum FromEventTypes
    {
        /// <summary>
        ///     关注
        /// </summary>
        [XmlEnum(Name = "subscribe")]
        subscribe = 0,
        /// <summary>
        ///     取消关注
        /// </summary>
        [XmlEnum(Name = "unsubscribe")]
        unsubscribe = 1,
        /// <summary>
        ///     扫描带参数二维码
        /// </summary>
        [XmlEnum(Name = "scan")]
        scan = 2,
        /// <summary>
        ///     上报地理位置
        /// </summary>
        [XmlEnum(Name = "location")]
        location = 3,
        /// <summary>
        ///     点击菜单拉取消息时的事件推送
        /// </summary>
        [XmlEnum(Name = "click")]
        click = 4,
        /// <summary>
        ///     点击菜单跳转链接时的事件推送
        /// </summary>
        [XmlEnum(Name = "view")]
        view = 5,
        /// <summary>
        /// 模板消息发送完成
        /// </summary>
        [XmlEnum(Name = "templatesendjobfinish")]
        templatesendjobfinish = 6
    }
}
