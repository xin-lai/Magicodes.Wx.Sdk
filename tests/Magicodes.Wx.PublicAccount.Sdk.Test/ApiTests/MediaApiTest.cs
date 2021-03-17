using Magicodes.Wx.PublicAccount.Sdk.Apis.Media;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiClientCore.Parameters;
using Xunit;
using Xunit.Abstractions;

namespace Magicodes.Wx.PublicAccount.Sdk.Test.ApiTests
{
    public class MediaApiTest : TestBase, IClassFixture<TestWebApplicationFactory>
    {
        private readonly IMediaApi mediaApi;

        public MediaApiTest(TestWebApplicationFactory webApplicationFactory, ITestOutputHelper output) : base(webApplicationFactory, output)
        {
            mediaApi = GetRequiredService<IMediaApi>();
        }

        [Fact]
        public async Task UploadAsync_Test()
        {
            var file = new FormDataFile("Media/wechat.jpg");
            var result = await mediaApi.UploadAsync("image", file);
            result.EnsureSuccess();
        }

        [Fact]
        public async Task UploadImageAsync_Test()
        {
            var file = new FormDataFile("Media/wechat.jpg");
            var result = await mediaApi.UploadImageAsync(file);
            result.EnsureSuccess();
        }

        [Fact]
        public async Task UploadNewsAsync_Test()
        {
            var file = new FormDataFile("Media/book.jpg");
            var result = await mediaApi.UploadAsync("image", file);
            result.EnsureSuccess();

            var newsApiResult = await mediaApi.UploadNewsAsync(new UploadNewsInput()
            {
                articles = new List<UploadNewsInput.Article>()
                {
                    new UploadNewsInput.Article()
                    {
                        author = "雪雁",
                        content = @"作为互联网大军中的一员，我经常会思考：如何避免“996”和“ICU”？如何更好地解决软件的交付速度和质量的问题？毕竟过度的加班不仅伤身劳神，结果还不太理想——Bug和问题往往与加班时间成正比，修复问题的时间可能远远大于开发功能的时间。
针对这个问题，我们要一分为二地去看：一方面，我们需要明确自己的远近目标，确保正确的方向以及有效的工作；另一方面，团队需要不断地接受适合自身的先进理念、思维以及工作方式、团队文化、技术和工具，以提高交付速度，并且保障软件交付质量。
关于适合自身的先进理念、思维和工作方式、团队文化、技术和工具，时下流行的有很多，最热门的理念莫过于DevOps。它其实并不是新创造出来的，而是软件工程的过程和方法论变化、进化和升级的必然结果（可以参见本书的第11章）。做好了DevOps实践，团队必然可以更快、更可靠地交付软件，提高客户的满意度。但是，做好DevOps实践不但对团队文化有很高的要求，而且对相关工具、技术、部署环境等也有很高的要求，这对于大部分团队来说是一个极大的挑战——既没有精力，也没有实力。
抛开团队文化等，有没有更易于落地的配合DevOps的解决方案呢？有，那就是以Docker为代表的容器技术作为基础保障、以Kubernetes（简称k8s）为代表的容器编排技术作为支撑的解决方案！它们“出世”并不算早，Docker诞生于2013年，k8s v1发布于2015年，公开面世虽只有短短几年，它们却已经成为相关领域的事实标准。它们的出现是历史的必然，并不能算是新的技术和理念，而是容器技术和容器编排技术演进的创新结果，也是一代又一代互联网人追求高效生产活动的解决方案、思想、工具和愿景。
Docker+k8s短短几年就脱颖而出，除了更易配合DevOps落地之外，还有众多原因（比如Docker更轻、更快、开源、隔离应用，以及k8s便携、可扩展、自动修复等），但是其中很重要的一个原因是，在虚拟机时代那些无法解决或者说很难解决的问题以及那些积压已久的需求（比如分布式系统的部署和运维，物联网边缘计算的快速开发、测试、部署和运维，大规模的云计算，等等）在Docker+k8s 的组合下找到了突破口，并且极大地促进了云计算的发展。尤其是k8s，更是代表了云原生应用平台的未来——它借助Docker和微服务架构的发展迅速崛起，高举着云原生应用的设计法则，硬生生地打败了所有的对手，赢得了一片更广阔的天地和更璀璨的未来（在原有的云计算基础设施上抽象出了云原生平台基础设施，形成了一个高度自治的自动化系统平台）。
开发者普遍将Docker+k8s应用于敏捷开发、DevOps实践、混合云和微服务架构。同时，主流的互联网公司都将应用托管到了应用容器上，比如谷歌、微软、亚马逊、腾讯、阿里、京东、美团和新浪。主流的云厂商均提供了容器服务，并且为之打造了极其强大和丰富的生态。其中许多云厂商还推出了无服务器计算容器实例产品，这意味着容器能够在无服务器计算的基础设施上运行。比如在某些机器学习的场合，用户可以在无服务器计算的基础设施上几秒内启动成千上万个容器，然后挂载共享存储的数据或图像进行处理。当批量处理完成后，容器自动销毁，用户仅需按量付费。
现在的技术发展很快，Docker和k8s的技术点、命令行、接口参数说明以官网为主、本书为辅。一方面，官网的内容往往是最新、最及时的；另一方面，本书更多的是指导大家快速进入相关的实践，分享相关的思维、理念和技巧，并且指导大家将容器应用托管到自建或者云端的k8s集群以及云厂商提供的容器云服务。
",
                        thumb_media_id = result.media_id,
                        title = "Docker+Kubernetes应用开发与快速上云",
                        show_cover_pic = 1,
                    },
                    new UploadNewsInput.Article()
                    {
                        author = "雪雁",
                        content = @"Docker是目前*流行的容器技术之一，Kubernetes（简称k8s）是目前*流行的容器编排平台之一，本书主要围绕Docker和k8s进行讲解。
本书共分为11章。前7章主要讲解Docker相关内容，从发展简史到基础概念，从市场趋势、应用场景到各环境的安装，从基础操作命令到Docker应用持续开发的工作流程，从主流的编程语言实践到数据库容器化。第8~10章主要讲解Kubernetes的相关内容，从主体架构、核心概念到开发、生产环境搭建以及集群故障处理，从应用部署、伸缩、回滚到应用访问，从云端理念到将应用部署到容器云服务。第11章主要讲解容器化之后的DevOps实践，从DevOps的理念到CI、CD的流程和实践，*后讲述如何使用Azure DevOps、Tencent Hub以及自建的TeamCity来完成CI/CD，并附有相关参考流程讲解。",
                        thumb_media_id = result.media_id,
                        title = "Docker+Kubernetes应用开发与快速上云——简介",
                        show_cover_pic = 0,
                    }
                }
            });
            newsApiResult.media_id.ShouldNotBeNull();
            newsApiResult.EnsureSuccess();
        }
    }
}