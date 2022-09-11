using LW_1_Core.Enums;
using LW_1_Core.Models;
using LW_1_Core.Utils;
using LW_1_Core.Validators;
using Microsoft.Extensions.Options;
using System;
using System.IO;
using System.Threading.Tasks;

namespace LW_1_Core.Yandex
{
    public class YandexCloudSpeechRecognition : ISpechRecongnition
    {
        private readonly YandexCloudConfiguration _config;
        public YandexCloudSpeechRecognition(IOptions<YandexCloudConfiguration> options)
        {
            _config = options.Value;
        }
        public async Task<SpechResponse> Recognize(string pathToFile)
        {
            if (!FilePathValidator.ValidatePath(pathToFile, out string message))
            {
                return new SpechResponse(ResponseTypes.Error, string.Empty, message);
            }

            bool IsExtensionChanged = false;
            try
            {
                changeExtension(ref pathToFile, ref IsExtensionChanged);
            }
            catch (Exception ex)
            {
                return new SpechResponse(ResponseTypes.Error, string.Empty,
                       ex.Message);
            }

            try
            {
                var request = new YandexCloudRequest(pathToFile, _config);
                ResponseMessage responseMessage = await  request.SendRequest();

                if (IsExtensionChanged)
                {
                    deleteFile(pathToFile);
                }

                if (responseMessage != null)
                {
                    return new SpechResponse(ResponseTypes.Recognized, responseMessage.Result);
                }
                else
                {
                    return new SpechResponse(ResponseTypes.Error, "Ошибка по время получения результатов");
                }
            }
            catch (Exception ex)
            {
                if (IsExtensionChanged)
                {
                    deleteFile(pathToFile);
                }
                return new SpechResponse(ResponseTypes.Error, string.Empty, ex.Message);
            }
        }

        private void changeExtension(ref string pathToFile, ref bool IsExtensionChanged)
        {
            if (Path.GetExtension(pathToFile) != ".opus")
            {
                string newPath;
                try
                {
                    AudioConverter.ConvertAduio(pathToFile, out newPath, ".opus");
                }
                catch (Exception)
                {
                    throw new Exception("Ошибка во время конвертации файла в ogg формат");
                }

                if (!File.Exists(newPath))
                {
                    throw new Exception("Ошибка копирования аудиофайла файла");
                }
                IsExtensionChanged = true;
                pathToFile = newPath;
            }
        }
        private void deleteFile(string pathToFile)
        {
            if (File.Exists(pathToFile))
            {
                File.Delete(pathToFile);
            }
        }
    }
}
