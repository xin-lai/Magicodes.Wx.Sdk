namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Media
{
    /// <summary>
    /// 
    /// </summary>
    public class UploadApiResult : ApiResultBase
    {
        public string type { get; set; }
        public string media_id { get; set; }
        public int created_at { get; set; }
    }
}