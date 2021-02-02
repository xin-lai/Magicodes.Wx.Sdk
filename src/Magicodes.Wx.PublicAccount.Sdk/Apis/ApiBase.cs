//using Microsoft.Extensions.Logging;
//using Newtonsoft.Json;
//using RestSharp;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using System.Text.RegularExpressions;
//using RestSharp.Serialization.Json;
//using RestSharp.Serializers.NewtonsoftJson;

//namespace Magicodes.WeChat.Sdk.Apis
//{
//    /// <summary>
//    ///     接口基类
//    /// </summary>
//    public abstract class ApiBase
//    {
//        /// <summary>
//        ///     微信API地址
//        /// </summary>
//        protected const string BaseApiUrl = "https://api.weixin.qq.com/cgi-bin";
//        private const string AccessTokenString = "{ACCESS_TOKEN}";
//        protected readonly ILogger logger;
//        private readonly TokenManager tokenManager;

//        /// <summary>
//        /// 
//        /// </summary>
//        protected ApiBase(ILogger<ApiBase> logger, TokenManager tokenManager)
//        {
//            this.logger = logger;
//            this.tokenManager = tokenManager;
//        }

//        /// <summary>
//        /// 
//        /// </summary>
//        /// <typeparam name="T"></typeparam>
//        /// <param name="resourceUrl"></param>
//        /// <param name="queryParameters"></param>
//        /// <returns></returns>
//        protected virtual async Task<T> HttpGet<T>(string resourceUrl, Dictionary<string, string> queryParameters = null) where T : ApiResultBase, new()
//        {
//            logger.LogDebug($"GET {BaseApiUrl}/{resourceUrl}");
//            var client = CreateRestClient();
//            var request = await CreateRestRequestAsync(resourceUrl, Method.GET, queryParameters);
//            request.AddHeader("cache-control", "no-cache");
//            if (queryParameters != null && queryParameters.Count > 0)
//            {
//                foreach (KeyValuePair<string, string> par in queryParameters)
//                {
//                    request.AddQueryParameter(par.Key, par.Value, true);
//                }
//            }
//            return await ExecuteAsync<T>(client, request);
//        }

//        /// <summary>
//        /// 
//        /// </summary>
//        /// <typeparam name="T"></typeparam>
//        /// <param name="resourceUrl"></param>
//        /// <param name="data"></param>
//        /// <returns></returns>
//        protected virtual async Task<T> HttpPost<T>(string resourceUrl, object data = null) where T : ApiResultBase, new()
//        {
//            var client = CreateRestClient();
//            var request = await CreateRestRequestAsync(resourceUrl, Method.POST, data);

//            return await ExecuteAsync<T>(client, request);
//        }

//        /// <summary>
//        /// 下载文件
//        /// </summary>
//        /// <param name="resourceUrl"></param>
//        /// <param name="method"></param>
//        /// <param name="data"></param>
//        /// <returns></returns>
//        protected virtual async Task<byte[]> DownloadData(string resourceUrl, Method method, object data = null)
//        {
//            var client = CreateRestClient();
//            var request = await CreateRestRequestAsync(resourceUrl, method, data);
//            var response = await client.ExecuteAsync(request);
//            logger.LogDebug($"{response.StatusCode} {response.RawBytes.Length}");
//            if (response.Content.StartsWith("{"))
//            {
//                //throw new MiniProgramArgumentException(JsonConvert.DeserializeObject<JObject>(response.Content)["errmsg"]?.ToString());
//            }
//            return response.RawBytes;
//        }


//        private RestClient CreateRestClient()
//        {
//            var client = new RestClient(BaseApiUrl);
//            client.UseNewtonsoftJson();
//            client.ThrowOnAnyError = true;
//            return client;
//        }

//        private async Task<RestRequest> CreateRestRequestAsync(string resourceUrl, Method method, object data = null)
//        {
//            RestRequest request = new RestRequest(resourceUrl, method);
//            request.AddHeader("cache-control", "no-cache");
//            if (data != null)
//            {
//                request.AddJsonBody(data);
//            }
//            var tokenPar = request.Parameters.FirstOrDefault(p => p.Type == ParameterType.QueryString && AccessTokenString.Equals(p.Name, StringComparison.CurrentCultureIgnoreCase));
//            if (tokenPar != null)
//            {
//                var token = await tokenManager.GetAccessTokenAsync();
//                tokenPar.Value = token;
//            }
//            return request;
//        }

//        private async Task<T> ExecuteAsync<T>(RestClient client, RestRequest request) where T : ApiResultBase, new()
//        {
//            var response = await client.ExecuteAsync<T>(request);
//            var logMessage = $"{request.Method} {request.Resource} {response.StatusCode}{Environment.NewLine}{response.Content}";
//            if (!response.Data.IsSuccess())
//            {
//                logger.LogError(logMessage);
//            }
//            else
//                logger.LogDebug(logMessage);
//            return response.Data;
//        }

//        /// <summary>
//        ///     获取API访问Url
//        /// </summary>
//        /// <param name="apiAction">操作名</param>
//        /// <param name="apiName">API名称</param>
//        /// <param name="apiRoot">API根路径</param>
//        /// <param name="urlParams">url参数</param>
//        /// <returns>API地址</returns>
//        protected string GetAccessApiUrl(string apiAction, string apiName, string apiRoot = BaseApiUrl,
//            Dictionary<string, string> urlParams = null)
//        {
//            string paramsStr = string.Empty;
//            if (urlParams != null && urlParams.Count > 0)
//            {
//                paramsStr = urlParams.Aggregate(paramsStr, (current, item) => current +
//                                                                              $"&{item.Key}={item.Value}");
//            }
//            string urlMain = string.IsNullOrEmpty(apiAction) ? apiName : $"{apiName}/{apiAction}";
//            return $"{apiRoot}/{urlMain}?access_token={AccessTokenString}{paramsStr}";
//        }
//    }
//}