using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LW_1_Core.Yandex
{
    internal class YandexCloudRequest
    {
        private readonly string _filePath;
        private readonly YandexCloudConfiguration _configuration;
        public YandexCloudRequest(string filePath, YandexCloudConfiguration configuration)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("Файл не найден");
            }
            _filePath = filePath;
            _configuration = configuration 
                ?? throw new ArgumentNullException(nameof(configuration));
        }

        public async Task<ResponseMessage> SendRequest()
        {
            var uri = createUri();
            HttpClient client = new HttpClient();

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, uri);

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/bson"));

            try
            {
                var aimToken = KeysGenerator.GenerateAIMToken();
                request.Headers.Add("Authorization", $"Bearer {aimToken}");
            }
            catch (Exception)
            {
                throw new Exception("Ошибка во время генерирования авторизационного ключа");
            }
            

            try
            {
                using (BinaryReader reader = new BinaryReader(File.Open(_filePath, FileMode.Open)))
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

            if(response.StatusCode != HttpStatusCode.OK)
            {
                throw new Exception("Ошибка во время запроса к API");
            }

            try
            {
                var content = await response.Content.ReadAsStringAsync();
                ResponseMessage responseMessage = JsonConvert.DeserializeObject<ResponseMessage>(content);
                return responseMessage;
            }
            catch (Exception)
            {
                throw new Exception("Ошибка во время десериализации результата");
            }
        }

        private Uri createUri()
        {
            string uri = $"{_configuration.ApiUrl}/stt:recognize?topic=general&lang=en-US&folderId={_configuration.FolderId}";
            return new Uri(uri);
        }
    }
}
