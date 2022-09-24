using LW_2_Core.Exceptions;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LW_2_Core.ruGPT_3
{
    internal static  class ruGPT_3_Requester
    {
        private static readonly HttpClient _client;
        private static HttpRequestMessage _message;
        private static string _apiUrl;

        static ruGPT_3_Requester()
        {
            _client = new HttpClient();
        }

        public static async Task<ru_GPT_3_Response> Send(string startPhrase)
        {
            createMessage();
            setBody(startPhrase);
            var response = await send();

            try
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                var ruGpt3Response = JsonConvert.DeserializeObject<ru_GPT_3_Response>(responseBody);
                if(ruGpt3Response != null)
                {
                    return ruGpt3Response;
                }
                throw new ruGPT_3_Exception("Ошибка вовремя десериализации результата");
            }
            catch (Exception)
            {
                throw new ruGPT_3_Exception("Ошибка во время получения результатов генерации");
            }

        }
        public static void setApiUrl(string apiUrl)
        {
            if (string.IsNullOrWhiteSpace(apiUrl))
            {
                throw new ruGPT_3_Exception("Api url не может быть пустой строкой или null");
            }
            _apiUrl = apiUrl;
        }

        public static void setBody(string startPahrase)
        {
            var body = new ruGPT_3_RequestBody()
            {
                text = startPahrase
            };

            _message.Content = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
        }

        private static void createMessage()
        {

            if (string.IsNullOrEmpty(_apiUrl))
            {
                throw new ruGPT_3_Exception("Необоходимо установить значение Api Url");
            }
            HttpRequestMessage message = new HttpRequestMessage()
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri(_apiUrl)
            };
            message.Headers.Add("Host", "api.aicloud.sbercloud.ru");
            message.Headers.Add("Origin", @"https://russiannlp.github.io");
            message.Headers.Add("User-Agent", "PostmanRuntime/7.29.2");

            _message = message;
        }
        
        private  static Task<HttpResponseMessage> send()
        {
            if (string.IsNullOrEmpty(_apiUrl))
            {
                throw new ruGPT_3_Exception("Небоходимо установить значение Api Url");
            }
            try
            {
                return _client.SendAsync(_message);
            }
            catch(Exception ex)
            {
                throw new ruGPT_3_Exception("Ошибка по время запроса к API ruGPT-3");
            }
        }
    }
}
