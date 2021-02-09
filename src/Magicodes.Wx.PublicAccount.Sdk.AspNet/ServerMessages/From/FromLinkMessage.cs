// ======================================================================
//  
//          Copyright (C) 2018-2068 湖南心莱信息科技有限公司    
//          All rights reserved
//  
//          filename : FromLinkMessage.cs
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
    /// <summary>
    /// 链接消息
    /// </summary>
    public class FromLinkMessage : FromMessageBase
    {
        /// <summary>
        /// Gets or sets the Title
        /// 消息标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the Description
        /// 消息描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the Url
        /// 消息链接
        /// </summary>
        public string Url { get; set; }
    }
}
