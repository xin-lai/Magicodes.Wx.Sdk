namespace Magicodes.WeChat.Sdk.Apis.Message
{
    /// <summary>
    ///     模板消息的数据项类型
    /// </summary>
    public class TemplateDataItem
    {
        /// <summary>
        /// </summary>
        /// <param name="value">value</param>
        /// <param name="color">color</param>
        public TemplateDataItem(string value, string color = "#173177")
        {
            Value = value;
            Color = color;
        }

        /// <summary>
        ///     项目值
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        ///     16进制颜色代码，如：#FF0000
        /// </summary>
        public string Color { get; set; }
    }
}
