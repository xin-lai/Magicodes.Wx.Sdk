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
}
