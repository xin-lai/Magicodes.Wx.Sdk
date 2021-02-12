using Magicodes.Wx.PublicAccount.Sdk.AspNet.ServerMessages.From;
using Magicodes.Wx.PublicAccount.Sdk.AspNet.ServerMessages.To;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Magicodes.Wx.PublicAccount.Sdk.AspNet.ServerMessages
{
    /// <summary>
    /// 微信服务消息、事件处理器
    /// </summary>
    public interface IWxEventsHandler
    {
        /// <summary>
        /// 处理服务器消息事件
        /// </summary>
        /// <param name="fromMessage"></param>
        /// <returns></returns>
        Task<ToMessageBase> Execute(IFromMessage fromMessage);
    }
}