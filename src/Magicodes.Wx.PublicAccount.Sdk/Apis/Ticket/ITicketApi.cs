using Magicodes.Wx.PublicAccount.Sdk.Apis.Ticket.Dtos;
using Magicodes.Wx.Sdk.Core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;
using WebApiClientCore.Attributes;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.JSSDK
{
    [HttpHost("https://api.weixin.qq.com/cgi-bin/ticket/")]
    public interface ITicketApi : IWxApiWithAccessTokenFilter
    {

        /// <summary>
        /// 获取ticket
        /// </summary>
        /// <param name="type">The type. [jsapi|wx_card]</param>
        /// <returns></returns>
        [HttpGet("getticket")] 
        Task<GetTicketApiResult> GetAsync([Required] string type = "jsapi");
    }
}
