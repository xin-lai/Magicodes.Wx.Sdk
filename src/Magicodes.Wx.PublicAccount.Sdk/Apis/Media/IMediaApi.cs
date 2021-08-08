using Magicodes.Wx.Sdk.Core;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using WebApiClientCore.Attributes;
using WebApiClientCore.Parameters;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Media
{
    /// <summary>
    /// 素材管理
    /// </summary>
    [HttpHost("https://api.weixin.qq.com/cgi-bin/media/")]
    public interface IMediaApi : IWxApiWithAccessTokenFilter
    {
        /// <summary>
        /// 新增临时素材
        /// </summary>
        /// <param name="type">
        /// 图片（image）: 10M，支持PNG\JPEG\JPG\GIF格式
        /// 语音（voice）：2M，播放长度不超过60s，支持AMR\MP3格式
        /// 视频（video）：10MB，支持MP4格式
        /// 缩略图（thumb）：64KB，支持JPG格式
        /// </param>
        /// <param name="media"></param>
        /// <returns></returns>
        [HttpPost("upload")]
        Task<UploadApiResult> UploadAsync([Required] string type, FormDataFile media);

        /// <summary>
        /// 上传图文消息内的图片获取URL【订阅号与服务号认证后均可用】
        /// </summary>
        /// <param name="media"></param>
        /// <returns></returns>
        [HttpPost("uploadimg")]
        Task<UploadImageApiResult> UploadImageAsync(FormDataFile media);

        /// <summary>
        /// 上传视频
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("uploadvideo")]
        Task<UploadVideoApiResult> UploadVideoAsync(UploadVideoInput input);

        /// <summary>
        /// 上传图文消息素材【订阅号与服务号认证后均可用】
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("uploadnews")]
        Task<UploadApiResult> UploadNewsAsync(UploadNewsInput input);
    }
}