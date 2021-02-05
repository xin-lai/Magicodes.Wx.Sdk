using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Menu
{
    /// <summary>
    ///     菜单按钮自定义对象创建转换器
    ///     根据菜单类型自定义创建
    /// </summary>
    public class MenuButtonsCustomConverter : CustomCreationConverter<MenuButtonBase>
    {
        /// <summary>
        ///     读取目标对象的JSON表示
        /// </summary>
        /// <param name="reader">JsonReader</param>
        /// <param name="objectType">对象类型</param>
        /// <param name="existingValue"></param>
        /// <param name="serializer"></param>
        /// <returns>对象</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
            JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var jObject = JObject.Load(reader);
            var target = default(MenuButtonBase);
            var subButton = jObject.Property("sub_button");
            if (subButton != null && subButton.Count > 0)
            {
                target = new SubMenuButton
                {
                    Type = MenuButtonTypes.click
                };
            }
            else
            {
                //获取type属性
                var type = jObject.Property("type");
                if (type != null && type.Count > 0)
                {
                    var typeValue = type.Value.ToString();
                    var menuButtonType = (MenuButtonTypes)Enum.Parse(typeof(MenuButtonTypes), typeValue);

                    #region 根据类型返回相应菜单类型

                    switch (menuButtonType)
                    {
                        case MenuButtonTypes.click:
                            target = new ClickButton();
                            break;
                        case MenuButtonTypes.view:
                            target = new ViewButton();
                            break;
                        case MenuButtonTypes.scancode_push:
                            target = new ScancodePushButton();
                            break;
                        case MenuButtonTypes.scancode_waitmsg:
                            target = new ScancodeWaitmsgButton();
                            break;
                        case MenuButtonTypes.pic_sysphoto:
                            target = new PicSysphotoButton();
                            break;
                        case MenuButtonTypes.pic_photo_or_album:
                            target = new PicPhotoOrAlbumButton();
                            break;
                        case MenuButtonTypes.pic_weixin:
                            target = new PicWeixinButton();
                            break;
                        case MenuButtonTypes.location_select:
                            target = new LocationSelectButton();
                            break;
                        case MenuButtonTypes.media_id:
                            target = new MediaIdButton();
                            break;
                        case MenuButtonTypes.view_limited:
                            target = new ViewLimitedButton();
                            break;
                        case MenuButtonTypes.miniprogram:
                            target = new MiniprogramButton();
                            break;
                        default:
                            throw new NotSupportedException("不支持此类型的菜单按钮：" + menuButtonType);
                    }

                    #endregion
                }
            }

            serializer.Populate(jObject.CreateReader(), target);
            return target;
        }

        /// <summary>
        ///     创建对象（会被填充）
        /// </summary>
        /// <param name="objectType">对象类型</param>
        /// <returns>对象</returns>
        public override MenuButtonBase Create(Type objectType)
        {
            return new SubMenuButton();
        }
    }
}