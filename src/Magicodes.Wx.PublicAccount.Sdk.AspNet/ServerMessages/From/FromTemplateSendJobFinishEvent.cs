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
