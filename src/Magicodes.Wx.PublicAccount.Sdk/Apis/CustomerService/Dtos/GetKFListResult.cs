using System.Collections.Generic;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.CustomerService
{
    /// <summary>
    /// 获取客服基本信息返回结果
    /// </summary>
    public class GetKFListResult
    {
        /// <summary>
        /// 客服列表
        /// </summary>
        public List<KFDataItem> KFList { get; set; }

    }
}