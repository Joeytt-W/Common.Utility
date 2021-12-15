using RestSharp;//要引用RestSharp
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Utility.Web
{
    public class RestSharpReqApiHelper
    {
        /// <summary>
        /// Post 方法
        /// </summary>
        /// <param name="Url">地址</param>
        /// <param name="cookies">Cookie</param>
        /// <param name="requestBody">参数</param>
        /// <returns></returns>
        public static string Post(string Url,Dictionary<string,object> cookies,string requestBody)
        {
            var client = new RestClient(Url);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            
            foreach(var dic in cookies)
            {
                request.AddParameter(dic.Key, dic.Value, ParameterType.Cookie);
            }

            request.AddHeader("Content-Type", "application/json");

            request.AddParameter("application/json", requestBody, ParameterType.RequestBody);

            IRestResponse response = client.Execute(request);
            return response.Content;
        } 

        /// <summary>
        /// Get 方法
        /// </summary>
        /// <param name="Url">地址</param>
        /// <param name="cookies">Cookie</param>
        /// <param name="paramDic">参数</param>
        /// <returns></returns>
        public static string Get(string Url, Dictionary<string, object> cookies, Dictionary<string, object> paramDic)
        {
            var client = new RestClient(Url);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);

            //Cookie
            foreach (var dic in cookies)
            {
                request.AddParameter(dic.Key, dic.Value, ParameterType.Cookie);
            }

            //参数
            foreach (var dic in paramDic)
            {
                request.AddParameter(dic.Key, dic.Value, ParameterType.QueryString);
            }

            //client.DownloadData(request).SaveAs(filePath);//下载文件
            IRestResponse response = client.Execute(request);
            return response.Content;

        }
    }
}
