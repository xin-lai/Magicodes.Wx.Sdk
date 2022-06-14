using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Qrcode
{
    public class QrcodeInputActionInfo
    {
        [JsonProperty("scene")]
        public QrcodeInputActionInfoScene Scene { get; set; }
    }
}
