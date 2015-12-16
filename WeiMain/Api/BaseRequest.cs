using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace WeiMain.Api
{
    public abstract class BaseRequest<T>
    {
        protected const string BASE_URL = @"http://tingapi.ting.baidu.com/v1/restserver/ting?method={0}&format=json&from={1}&version={2}";
        protected const string FROM = @"wp10";
        protected const string VERSION = @"1.0.0.0";

        public string ContentErrorCode { get; set; }
        public bool RequestSucceeded { get; set; }
        public HttpStatusCode HttpStatusCode { get; set; }

        public BaseRequest()
        {
            ContentErrorCode = ErrorCode.OK;
            RequestSucceeded = false;
            HttpStatusCode = HttpStatusCode.OK;
        }
        

        public abstract string GetMethodName();

        protected abstract string GetQueryContent();

        // 此处判断是否ResponseOk，从解析结果来看
        protected abstract T ParseAsync(string json);


        public bool IsRequestAllOK()
        {
            return RequestSucceeded && HttpStatusCode == HttpStatusCode.OK && ContentErrorCode == ErrorCode.OK;
        }

        private string GetUrl()
        {
            string url = string.Format(BASE_URL, GetMethodName(), FROM, VERSION);
            string content = GetQueryContent();
            if (!string.IsNullOrWhiteSpace(content))
            {
                url += ("&" + content);
            }
            return url;
        }

        private void ResponseCallback(IAsyncResult result)
        {
            if(result == null)
            {
                HttpStatusCode = HttpStatusCode.NoContent;
                return;
            }
            try
            {
                HttpWebRequest request = (HttpWebRequest)result.AsyncState;
                WebResponse response = request.EndGetResponse(result);
                using (Stream stream = response.GetResponseStream())
                using(StreamReader reader = new StreamReader(stream))
                {
                    string responseContent = reader.ReadToEnd();
                    if (string.IsNullOrEmpty(responseContent))
                    {
                        HttpStatusCode = HttpStatusCode.NoContent;
                        return;
                    } else
                    {
                        HttpStatusCode = HttpStatusCode.OK;
                        ParseAsync(responseContent);
                    }

                    
                }
            }
            catch( Exception e)
            {
                RequestSucceeded = false;
            } 

        }

        public void AsyncRequest()
        {
            string url = GetUrl();
            var request = HttpWebRequest.Create(url);
            request.ContentType = "application/json";
            request.Method = "GET";
            request.BeginGetResponse(ResponseCallback, request);
        }
    }
}
