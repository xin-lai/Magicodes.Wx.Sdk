# Magicodes.Wx.Sdk


## 概述
最简洁最易于使用的微信Sdk，包括公众号Sdk、小程序Sdk、企业微信Sdk等，以及Abp VNext集成。

- [GitHub地址：https://github.com/xin-lai/Magicodes.Wx.Sdk](https://github.com/xin-lai/Magicodes.Wx.Sdk)
- [Gitee地址：https://gitee.com/xl_wenqiang/Magicodes.Wx.Sdk](https://gitee.com/xl_wenqiang/Magicodes.Wx.Sdk)

| **名称** |      **Nuget**      |
|----------|:-------------:|
| **Magicodes.Wx.PublicAccount.Sdk** | **[![NuGet](https://buildstats.info/nuget/Magicodes.Wx.PublicAccount.Sdk)](https://www.nuget.org/packages/Magicodes.Wx.PublicAccount.Sdk)** |
| **Magicodes.Wx.PublicAccount.Sdk.AspNet** | **[![NuGet](https://buildstats.info/nuget/Magicodes.Wx.PublicAccount.Sdk.AspNet)](https://www.nuget.org/packages/Magicodes.Wx.PublicAccount.Sdk.AspNet)** |
| **Magicodes.Wx.PublicAccount.Sdk.Abp** | **[![NuGet](https://buildstats.info/nuget/Magicodes.Wx.PublicAccount.Sdk.Abp)](https://www.nuget.org/packages/Magicodes.Wx.PublicAccount.Sdk.Abp)** |

## 如何贡献？

[如何快速封装一个微信接口？](./docs/如何快速编写一个微信Api.md)（30秒编写一个微信Api，欢迎多多PR）

如何快速定义一个微信上传文件的接口？

## RoadMap

### 公众号

- [x] 全局

  - [x] 接口结果基类（`ApiResultBase`）

    - [x] 全局返回码（`ReturnCodes`）
    - [x] 是否成功返回（`IsSuccess`）
    - [x] 获取异常友好提示消息（`GetFriendlyMessage`）

  - [x] Access Token获取（`ITokenApi`）

  - [x] Token管理器（`ITokenManager`）

  - [x] Access Token API请求筛选器（`AccessTokenApiFilter`）

    - [x] IWxApiBase
    - [x] IWxApiWithAccessTokenFilter（启用`AccessTokenApiFilter`）

  - [x] 从配置文件获取公众号配置

    ```json
      "Wx": {
        "PublicAccount": {
          "AppId": "",
          "AppSecret": ""
        }
      }
    ```

  - [x] 函数注入（`WxFuncs`）

    - [x] GetWeChatOptions【获取公众号配置】
    - [x] GetAccessTokenByAppId【根据AppId获取Access Token】
    - [x] CacheAccessToken【缓存Access Token】

  - [x] 异常（`WxSdkException`）

  - [x] Abp Vnext集成（`Magicodes.Wx.PublicAccount.Sdk.Abp`）

    - [x] WxPublicAccountSdkModule（默认已实现IDistributedCache）

  - [x] Magicodes.Wx.PublicAccount.Sdk.AspNet模块

    - [x] 事件消息控制器（`WxEventController`）
    - [x] 服务器事件消息处理器（`IWxEventsHandler`）
    - [x] 公众号网页开发基类（`WxPublicAccountControllerBase`）
    - [x] 公众号授权筛选器（`WxPublicAccountOAuthFilter`）

- [ ] 基础消息能力

  - [x] 服务器事件消息

    - [x] 服务器事件消息配置接入以及验证
    - [x] 事件推送
      - [x] 关注事件：`FromSubscribeEvent`
      - [x] 取消关注事件：`FromUnsubscribeEvent`
      - [x] 扫码事件：`FromScanEvent`
      - [x] 地理位置选择器事件：`FromLocationEvent`
      - [x] 点击事件：`FromClickEvent`
      - [x] 点击菜单链接跳转事件：`FromViewEvent`
      - [x] 模板消息推送完成事件：`FromTemplateSendJobFinishEvent`
      - [x] 点击菜单跳转小程序事件：`FromViewMiniprogramEvent`
    - [x] 基础消息
      - [x] 文本消息：`FromTextMessage`
      - [x] 图片消息：`FromImageMessage`
      - [x] 语音消息：`FromVoiceMessage`
      - [x] 视频消息：`FromVideoMessage`
      - [x] 小视频消息：`FromShortVideoMessage`
      - [x] 地理位置消息：`FromLocationMessage`
      - [x] 链接消息：`FromLinkMessage`
    - [x] 被动消息回复
      - [x] 回复文本消息：`ToTextMessage`
      - [x] 回复图片消息：`ToImageMessage`
      - [x] 回复语音消息：`ToVoiceMessage`
      - [x] 回复视频消息：`ToVideoMessage`
      - [x] 回复音乐消息：`ToMusicMessage`
      - [x] 回复图文消息：`ToNewsMessage`
      - [x] 回复空消息（不回复）：`ToNullMessage`
  - [ ] 群发接口
    - [x] 上传图文消息内的图片获取URL【订阅号与服务号认证后均可用】（`IMediaApi`>>`UploadImageAsync`）
    - [x] 上传图文消息素材【订阅号与服务号认证后均可用】
    - [x] 根据标签进行群发【订阅号与服务号认证后均可用】
    - [x] 根据OpenID列表群发【订阅号不可用，服务号认证后可用】
    - [x] 删除群发【订阅号与服务号认证后均可用】
    - [ ] 预览接口【订阅号与服务号认证后均可用】
    - [ ] 查询群发消息发送状态【订阅号与服务号认证后均可用】
  - [ ] api调用次数进行清零
  - [ ] 获取公众号当前使用的自动回复规则
  - [ ] 公众号一次性订阅消息
  - [x] 模板消息（`ITemplateApi`）

    - [x] [1 设置所属行业](https://developers.weixin.qq.com/doc/offiaccount/Message_Management/Template_Message_Interface.html#0)（`SetIndustryAsync`）

    - [x] [2 获取设置的行业信息](https://developers.weixin.qq.com/doc/offiaccount/Message_Management/Template_Message_Interface.html#1)（`GetIndustryAsync`）

    - [x] [3 获得模板ID](https://developers.weixin.qq.com/doc/offiaccount/Message_Management/Template_Message_Interface.html#2)（`GetTemplateIdAsync`）

    - [x] [4 获取模板列表](https://developers.weixin.qq.com/doc/offiaccount/Message_Management/Template_Message_Interface.html#3)（`GetAllPrivateTemplateAsync`）

    - [x] [5 删除模板](https://developers.weixin.qq.com/doc/offiaccount/Message_Management/Template_Message_Interface.html#4)（`DelPrivateTemplateAsync`）

    - [x] [6 发送模板消息](https://developers.weixin.qq.com/doc/offiaccount/Message_Management/Template_Message_Interface.html#5)（`SendAsync`）

- [ ] 自定义菜单（`IMenuApi`）

  - [x] 创建接口（`CreateAsync`）
  - [x] 查询接口（`GetAsync`）
  - [x] 删除接口（`DeleteAsync`）
  - [x] 个性化菜单接口
    - [x] 创建个性化菜单（`AddConditionalAsync`）
    - [x] 删除个性化菜单（`DelConditionalAsync`）
    - [x] 测试个性化菜单匹配结果（`TryMatchAsync`）
  - [x] 获取自定义菜单配置（`GetAsync`）

- [x] 订阅通知（`INewTmplApi`）

  - [x] 选用模板（`AddTemplateAsync`）
  - [x] 删除模板（`DeleteTemplateAsync`）
  - [x] 获取公众号类目（`GetCategoryAsync`）
  - [x] 获取模板中的关键词（`GetPubTemplateKeyWordsByIdAsync`）
  - [x] 获取所属类目的公共模板（`GetPubTemplateTitleListAsync`）
  - [x] 获取私有模板列表（`GetTemplateListAsync`）
  - [x] 发送订阅通知（`SendAsync`）

- [ ] 客服消息

  - [ ] 客服管理（`IKfAccountApi`）
    - [x] 获取客服基本信息（`GetKFListAsync`）
    - [x] 添加客服账号（`AddAsync`）
    - [x] 邀请绑定客服账号（`InviteWorkerAsync`）
    - [x] 设置客服信息（`UpdateAsync`）
    - [x] 上传客服头像（`UploadHeadimg`）
    - [x] 删除客服账号（`DelAsync`）
    - [x] 获取在线客服接待会话数（`GetOnlineKFListAsync`）

- [x] 微信网页开发

  - [x] 网页授权
    - [x] 获取授权链接（`WxHelper >> GetAuthorizeUrl`）
    - [x] 通过code换取网页授权access_token（`IOauth2Api >> GetAccessTokenAsync`)
    - [x] 刷新access_token（`IOauth2Api >> RefreshTokenAsync`)
    - [x] 拉取用户信息（`ISnsApi >> GetUserInfoAsync`）
    - [x] 检验授权凭证（access_token）是否有效（`ISnsApi >> AuthAsync`）

- [ ] 对话能力

  - [ ] 顾问管理（`IGuideApi`）
    - [x] 添加顾问（`AddGuideAcctAsync`）
    - [x] 获取顾问信息（`GetGuideAcctAsync`）
    - [x] 修改顾问信息（`UpdateGuideAcctAsync`）
    - [x] 删除顾问（`DelGuideAcctAsync`）
    - [x] 获取服务号顾问列表（`GetGuideAcctListAsync`）
    - [x] 生产顾问二维码（`GuideCreateQrCodeAsync`）
    - [ ] 扫顾问二维码后的事件推送
    - [x] 获取顾问聊天记录（`GetGuideBuyerChatRecordAsync`）
    - [x] 设置快捷回复与关注自动回复（`SetGuideConfigAsync`）
    - [x] 获取快捷回复与关注自动回复（`GetGuideConfigAsync`）
    - [x] 设置离线自动回复与敏感词（`SetGuideAcctConfigAsync`）
    - [x] 获取离线自动回复与敏感词（`GetGuideAcctConfigAsync`）
    - [x] 允许微信用户复制小程序页面路径（`PushShowWxaPathMenuAsync`）
    - [x] 新建顾问分组（`NewGuideGroupAsync`）
    - [x] 获取顾问分组列表（`GetGuideGroupListAsync`）
    - [x] 获取顾问分组信息（`GetGroupInfoAsync`）
    - [x] 分组内添加顾问（`AddGuide2GuideGroupAsync`）
    - [x] 分组内删除顾问（`DelGuide2GuideGroupAsync`）
    - [x] 获取顾问所在分组（`GetGroupByGuideAsync`）
    - [x] 删除顾问分组（`DelGuideGroupAsync`）
  - [x] 客户管理
    - [x] 为顾问分配客户（`AddGuideBuyerRelationAsync`）
    - [x] 为顾问移除客户（`DelGuideBuyerRelationAsync`）
    - [x] 获取顾问的客户列表（`GetGuideBuyerRelationListAsync`）
    - [x] 为客户更好顾问（`RebindGuideAcctForBuyerAsync`）
    - [x] 修改客户昵称（`UpdateGuideBuyerRelationAsync`）
    - [x] 查询客户所属顾问（`GetGuideBuyerRelationByBuyerAsync`）
    - [x] 查询指定顾问和客户的关系（`GetGuideBuyerRelationAsync`）
  - [x] 标签管理
    - [x] 新建标签类型（`NewGuideTagOptionAsync`）
    - [x] 删除标签类型（`DelGuideTagOptionAsync`）
    - [x] 为标签添加可选值（`AddGuideTagOptionAsync`）
    - [x] 获取标签和可选值（`GetGuideTagOptionAsync`）
    - [x] 为客户设置标签（`AddGuideBuyerTagAsync`）
    - [x] 查询客户标签（`GetGuideBuyerTagAsync`）
    - [x] 根据标签值刷选客户（`QueryGuideBuyerByTagAsync`）
    - [x] 删除客户标签（`DelGuideBuyerTagAsync`）
    - [x] 设置自定义客户信息（`AddGuideBuyerDisplayTagAsync`）
    - [x] 获取自定义客户信息（`GetGuideBuyerDisplayTagAsync`）
  - [ ] 素材管理
    - [ ] 添加小程序卡片素材
    - [ ] 查询小程序卡片素材
    - [ ] 删除 小程序卡片素材
    - [ ] 添加图片素材
    - [ ] 查询图片素材
    - [ ] 删除图片素材
    - [ ] 添加文字素材
    - [ ] 查询文字素材
    - [ ] 删除文字素材
  - [ ] 群发任务管理
    - [ ] 添加群发任务
    - [ ] 获取群发任务列表
    - [ ] 获取指定群发任务信息
    - [ ] 修改群发任务
    - [ ] 取消群发任务

- [ ] 素材管理（`IMediaApi`）

  - [x] 新增临时素材（`UploadAsync`）
  - [ ] 获取临时素材
  - [ ] 新增永久素材
  - [ ] 获取永久素材
  - [ ] 删除永久素材
  - [ ] 修改永久图文素材
  - [ ] 获取素材总数
  - [ ] 获取素材列表

- [ ] 图文消息留言管理

- [x] 用户管理（`IUserApi`）

  - [x] 设置用户备注名（`UpdateRemarkAsync`）
  - [x] 获取用户基本信息（UnionID机制）（`InfoAsync`）
  - [x] 获取用户列表（`GetAsync`）

  - [x] 黑名单管理（`ITagsApi`）

    - [x] 获取公众号的黑名单列表（`GetBlackListAsync`）
    - [x] 拉黑用户（`BatchBlackListAsync`）
    - [x] 取消拉黑用户（`BatchUnBlackListAsync`）

- [x] 用户标签管理（`ITagsApi`）

  - [x] 创建标签（`CreateAsync`）
  - [x] 获取公众号已创建的标签（`GetAsync`）
  - [x] 编辑标签（`UpdateAsync`）
  - [x] 删除标签（`DeleteAsync`）
  - [x] 获取标签下粉丝列表（`IUserApi`>>`GetUserByTagAsync`）
  - [x] 批量为用户打标签（`BatchTaggingAsync`）
  - [x] 批量为用户取消标签（`BatchUnTaggingAsync`）
  - [x] 获取用户身上的标签列表（`GetIdListAsync`）

- [ ] 账号管理

  - [ ] 生产带参数的二维码
  - [ ] 长链接转短链接接口
  - [ ] 短key托管
  - [ ] 微信认证时间推送

- [ ] 数据统计

  - [ ] 用户分析
  - [ ] 图文分析
  - [ ] 消息分析
  - [ ] 广告分析
    - [ ] 分广告位数据
    - [ ] 返佣商品数据
    - [ ] 结算收入数据
  - [ ] 接口分析

- [ ] 微信卡券

  - [ ] 微信卡券接口
  - [ ] 更新日志
  - [ ] 创建卡券
  - [ ] 投放卡券
  - [ ] 核销卡券
  - [ ] 管理卡券
  - [ ] 卡券事件推送
  - [ ] 卡券-小程序打通
  - [ ] 微信礼品卡
  - [ ] 会员卡专区
    - [ ] 玩法介绍
    - [ ] 创建会员卡
    - [ ] 管理会员卡
  - [ ] 特殊票券
  - [ ] 卡券错误码
  - [ ] 第三方开发者模式

- [ ] 微信门店

  - [ ] 微信门店接口
  - [ ] 微信门店小程序接口

- [ ] 微信小店

- [ ] 智能接口

  - [ ] 语义理解
  - [ ] AI开放接口
  - [ ] OCR识别
  - [ ] 图像处理

- [ ] 一物一码

- [ ] 微信发票

- [ ] 微信非税缴费

### 小程序

- [ ] 登录
- [ ] 用户信息
- [ ] ...

## 快速上手

本Sdk上手非常简单，参考教程如下所示。

### 1）安装包

```powershell
Install-Package Magicodes.Wx.PublicAccount.Sdk.AspNet
```

推荐使用此包，亦可使用`Magicodes.Wx.PublicAccount.Sdk`来进行更多的自定义配置。

### 2）基础配置

- **配置文件配置**

公众号的参考配置如下所示，请在`appsettings.json`文件中进行配置：

```json
  "Wx": {
    "PublicAccount": {
      "AppId": "",
      "AppSecret": ""
    }
```

- **通过代码配置**

  参考代码如下所示：

  ```csharp
          app.UseMagicodesWeChatSdk(setup =>
          {
              setup.GetWeChatOptions = () =>
              {
                  //配置
                  return new WxPublicAccountOption()
                  {
                      AppId = "",
                      AppSecret = ""
                  };
              };
          });
  ```

### 3）配置Sdk

参考代码如下所示：

```csharp
        public void ConfigureServices(IServiceCollection services)
        {
            //添加公众号Sdk集成
            services.AddMPublicAccountSdk()
                //使用内存缓存
                .AddDistributedMemoryCache();
        }

        public void Configure(IApplicationBuilder app)
        {
            //配置公众号Sdk
            app.UseMPublicAccountSdk()
                //使用分布式缓存缓存Access Token
                .UseWxDistributedCacheForAccessToken();
        }
```
Tips:

- [Configure(IApplicationBuilder) 方法：配置应用程序](https://docs.microsoft.com/zh-cn/dotnet/api/microsoft.aspnetcore.hosting.startupbase.configure?view=aspnetcore-5.0&WT.mc_id=DT-MVP-5004079)
- [ConfigureServices(IServiceCollection) ：将服务注册到中 IServiceCollection](https://docs.microsoft.com/zh-cn/dotnet/api/microsoft.aspnetcore.hosting.startupbase.configureservices?view=aspnetcore-5.0&WT.mc_id=DT-MVP-5004079)
- [ASP.NET Core 中的分布式缓存](https://docs.microsoft.com/zh-cn/aspnet/core/performance/caching/distributed?view=aspnetcore-5.0&WT.mc_id=DT-MVP-5004079)

### 4）调用Api

接下来就简单了，通过依赖注入的方式注入相关Api，比如构造函数注入：

```csharp
    public HomeController(IMenuApi menuApi)
    {
        _menuApi = menuApi;
    }
```
Tips：

- [在 ASP.NET Core 中将依赖项注入到控制器](https://docs.microsoft.com/zh-cn/aspnet/core/mvc/controllers/dependency-injection?view=aspnetcore-5.0&WT.mc_id=DT-MVP-5004079)

然后就可以使用了，如下面代码：

```csharp
        var result = await _menuApi.CreateAsync(new CreateMenuInput()
        {
            Button = new List<MenuButtonBase>()
            {
                new ClickButton()
                {
                    Name = "今日歌曲",
                    Key = "V1001_TODAY_MUSIC"
                },
                new SubMenuButton()
                {
                    Name = "菜单",
                    SubButtons = new List<MenuButtonBase>()
                    {
                        new ViewButton()
                        {
                            Name = "搜索",
                            Url = "http://www.soso.com/"
                        },
                        //需关联小程序后
                        //new MiniprogramButton()
                        //{
                        //    Name = "wxa",
                        //    Url = "http://mp.weixin.qq.com",
                        //    AppId = "wx286b93c14bbf93aa",
                        //    Pagepath = "pages/lunar/index"
                        //},
                        new ClickButton()
                        {
                            Name = "赞一下我们",
                            Key = "V1001_GOOD"
                        }
                    }
                }
            }
        }); 
        result.EnsureSuccess();
```
## 微信服务器事件、消息处理和被动消息回复

如何处理微信服务器事件、消息，步骤如下所示：

### 1）配置Sdk

nuget包的安装和公众号的配置我们这里跳过，直接秀出Sdk配置代码：

```csharp
    public void ConfigureServices(IServiceCollection services)
    {
        //注册IWxEventsHandler,如需处理自定义事件消息,请务必实现IWxEventsHandler
        services.AddSingleton<IWxEventsHandler, TestWxEventsHandler>();
        services.AddMPublicAccountSdk()
            .AddDistributedMemoryCache()
            //添加服务器消息事件处理器
            .AddServerMessageHandler();
    }

    public void Configure(IApplicationBuilder app)
    {
        //配置公众号Sdk
        app.UseMPublicAccountSdk()
            //使用分布式缓存缓存Access Token
            .UseWxDistributedCacheForAccessToken();
    }
```
### 2）实现IWxEventsHandler

参考代码如下所示：

```csharp
/// <summary>
/// 公众号事件消息处理程序
/// </summary>
public class TestWxEventsHandler : IWxEventsHandler
{
    /// <summary>
    /// 执行
    /// </summary>
    /// <param name="fromMessage"></param>
    /// <returns></returns>
    public async Task<ToMessageBase> Execute(IFromMessage fromMessage)
    {
        if (fromMessage is FromTextMessage)
        {
            //返回多图文
            var toMsg = new ToNewsMessage()
            {
                Articles = new List<ToNewsMessage.ArticleInfo>()
                {
                    new ToNewsMessage.ArticleInfo()
                    {
                        Description = "最简洁最易于使用的微信Sdk，包括公众号Sdk、小程序Sdk、企业微信Sdk等，以及Abp VNext集成。",
                        PicUrl = "https://www.xin-lai.com/imgs/xinlai-logo_9d2c29c2794e6a173738bf92b056ab69.png",
                        Title="Magicodes.Wx.Sdk简介",
                        Url = "http://xin-lai.com"
                    }
                },
                FromUserName = "Test",
                ToUserName = "Test"
            };
            return await Task.FromResult(toMsg);
        }
        else if (fromMessage is FromSubscribeEvent)
        {
            //返回文本消息
            return await Task.FromResult(new ToTextMessage()
            {
                Content = "欢迎关注!",
            });
        }
        else if (fromMessage is FromTextMessage)
        {
            //返回文本
            return await Task.FromResult(new ToTextMessage()
            {
                Content = "Test",
            });
        }
        return await Task.FromResult(new ToNullMessage());
    }
}
```

相关事件和消息以及消息回复的定义，如下所示：

- 事件推送
  - 关注事件：`FromSubscribeEvent`
  - 取消关注事件：`FromUnsubscribeEvent`
  - 扫码事件：`FromScanEvent`
  - 地理位置选择器事件：`FromLocationEvent`
  - 点击事件：`FromClickEvent`
  - 点击菜单链接跳转事件：`FromViewEvent`
  - 模板消息推送完成事件：`FromTemplateSendJobFinishEvent`
  - 点击菜单跳转小程序事件：`FromViewMiniprogramEvent`

- 基础消息
  - 文本消息：`FromTextMessage`
  - 图片消息：`FromImageMessage`
  - 语音消息：`FromVoiceMessage`
  - 视频消息：`FromVideoMessage`
  - 小视频消息：`FromShortVideoMessage`
  - 地理位置消息：`FromLocationMessage`
  - 链接消息：`FromLinkMessage`

- 被动消息回复
  - 回复文本消息：`ToTextMessage`
  - 回复图片消息：`ToImageMessage`
  - 回复语音消息：`ToVoiceMessage`
  - 回复视频消息：`ToVideoMessage`
  - 回复音乐消息：`ToMusicMessage`
  - 回复图文消息：`ToNewsMessage`
  - 回复空消息（不回复）：`ToNullMessage`

## MVC网页授权

在ASP.NET MVC，我们可以通过本SDK快速获得微信用户信息，参考代码如下所示：

```csharp
//注意继承WxPublicAccountControllerBase
public class HomeController : WxPublicAccountControllerBase
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    //设置了WxPublicAccountOAuthFilter的Action在缓存过期的情况下，将自动跳转到微信网页授权页面进行授权
    //OAuthLevel设置为OpenIdAndUserInfo允许获取粉丝信息
    [WxPublicAccountOAuthFilter(OAuthLevel = OAuthLevels.OpenIdAndUserInfo)]
    public async Task<IActionResult> IndexAsync()
    {
        //调用父级控制器的获取粉丝信息方法，该方法从ISnsApi中获取粉丝详细信息
        var userResult = await GetWeChatUserInfoAsync();
        var model = new UserInfo()
        {
            Headimgurl = userResult.Headimgurl,
            NickName = userResult.NickName,
            Sex = userResult.Sex
        };
        _logger.LogDebug($"NickName:{userResult.NickName}");
        return View(model);
    }
}
```
## Abp VNext集成

Magicodes.Wx.PublicAccount.Sdk默认提供了Abp VNext模块，相关步骤如下所示：

### 1）安装Magicodes.Wx.PublicAccount.Sdk.Abp

```powershell
Install-Package Magicodes.Wx.PublicAccount.Sdk.Abp
```

### 2）添加模块依赖

```csharp
[DependsOn(
    typeof(WxPublicAccountSdkModule)
)]
```
如需处理服务器事件消息，还需注册IWxEventsHandler：

```csharp
context.Services.AddSingleton<IWxEventsHandler, WxEventsHandler>();
```



## 联系我们

### 订阅号
关注“**麦扣聊技术**”订阅号可以获得最新文章、教程、文档，并且加入微信生态群：
![](https://docs.xin-lai.com/medias/wechat.jpg "麦扣聊技术")

### QQ群

- **编程交流群<85318032>**（由于不经常在线，为了避免骚扰，设置了一定门槛）


#### 文档官网&官方博客

- **文档官网：<https://docs.xin-lai.com/>**
- **博客：<http://www.cnblogs.com/codelove/>**

#### 其他开源库

- **<https://github.com/xin-lai>**
- **<https://gitee.com/magicodes>**