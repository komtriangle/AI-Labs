using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace LW_1_Core.Azure
{
    internal class AzureApiResuster
    {
        private readonly AzureConfiguration _config;
        private readonly string _pathToFile;
        public AzureApiResuster(AzureConfiguration config,string pathToFile)
        {

            _config = config ?? 
                throw new ArgumentNullException(nameof(config));
            if (!File.Exists(pathToFile))
            {
                throw new FileNotFoundException("Файл не найден");
            }
            _pathToFile = pathToFile;
        }
        public async Task<AzureResponse> SendRequest()
        {
            var uri = createUri();
            HttpClient client = new HttpClient();

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, uri);

            client.DefaultRequestHeaders
                .Accept
                .Add(new MediaTypeWithQualityHeaderValue("audio/wav"));
            request.Headers.Add("Ocp-Apim-Subscription-Key", _config.SubscriptionKey);
           

            try
            {
                using (BinaryReader reader = new BinaryReader(File.Open(_pathToFile, FileMode.Open)))
                {
                    var bytes = reader.ReadBytes(1_000_000_00);
                    request.Content = new ByteArrayContent(bytes);
                }
            }
            catch (Exception)
            {
                throw new Exception("Ошибка по время чтения аудиофайла");
            }

            HttpResponseMessage response;
            try
            {
                response = await client.SendAsync(request);
            }
            catch (Exception)
            {
                throw new Exception("Ошибка запроса к API Яндекс облака");
            }

            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new Exception("Ошибка во время запроса к API");
            }

            try
            {
                var content = await response.Content.ReadAsStringAsync();
                AzureResponse responseMessage = JsonConvert.DeserializeObject<AzureResponse>(content);
                return responseMessage;
            }
            catch (Exception)
            {
                throw new Exception("Ошибка во время десериализации результата");
            }
        }

        private string createUri()
        {
            return $"https://{_config.ServiceRegion}.stt.speech.microsoft.com/speech/recognition/conversation/cognitiveservices/v1?language={_config.Language}";
        }
    }
}
