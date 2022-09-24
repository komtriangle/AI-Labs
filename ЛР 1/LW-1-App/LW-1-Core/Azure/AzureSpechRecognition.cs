using LW_1_Core.Enums;
using LW_1_Core.Models;
using LW_1_Core.Utils;
using LW_1_Core.Validators;
using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Audio;
using Microsoft.Extensions.Options;
using System;
using System.IO;
using System.Threading.Tasks;

namespace LW_1_Core.Azure
{
    public class AzureSpechRecognition : ISpechRecongnition
    {
        private readonly AzureConfiguration _config;

        public AzureSpechRecognition(IOptions<AzureConfiguration> options)
        {
            _config = options.Value;
        }
        public async Task<SpechResponse> Recognize(string pathToFile)
        {
            if (!FilePathValidator.ValidatePath(pathToFile, out string message))
            {
                return new SpechResponse(ResponseTypes.Error, string.Empty, message);
            }

            try
            {
                changeExtension(ref pathToFile);
            }
            catch (Exception ex)
            {
                return new SpechResponse(ResponseTypes.Error, string.Empty,
                       ex.Message);
            }

            try
            {
                var requester = new AzureApiResuster(_config, pathToFile);
                AzureResponse response = await requester.SendRequest();
                if(response!= null && response.RecognitionStatus == "Success")
                {
                    return new SpechResponse(ResponseTypes.Recognized, response.DisplayText,
                      String.Empty);
                }
                else
                {
                    return new SpechResponse(ResponseTypes.NoMatch, String.Empty,
                     String.Empty);
                }
            }
            catch(Exception ex)
            {
                return new SpechResponse(ResponseTypes.Error, string.Empty,
                       ex.Message);
            }

        }


        private void changeExtension(ref string pathToFile)
        {
            if (Path.GetExtension(pathToFile) != ".wav")
            {
                string newPath;
                try
                {
                    AudioConverter.ConvertAduio(pathToFile, out newPath, ".wav");
                }
                catch (Exception)
                {
                    throw new Exception("Ошибка во время конвертации mp3 файла в wav файл");
                }
                pathToFile = newPath;
            }
        }


    }
}
