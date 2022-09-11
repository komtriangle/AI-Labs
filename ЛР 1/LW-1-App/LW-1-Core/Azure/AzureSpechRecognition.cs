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

            var speechConfig = SpeechConfig.FromSubscription(_config.SubscriptionKey, _config.ServiceRegion);
            speechConfig.SpeechRecognitionLanguage = "en-US";

            SpeechRecognitionResult result;
            try
            {
                using var audioConfig = AudioConfig.FromWavFileInput(pathToFile);
                using var speechRecognizer = new SpeechRecognizer(speechConfig, audioConfig);
                result = await speechRecognizer.RecognizeOnceAsync();
            }
            catch (Exception)
            {
                return new SpechResponse(ResponseTypes.Error, string.Empty, "Ошибка во время распознавания");
            }
            return outputSpeechRecognitionResult(result);
        }

        private SpechResponse outputSpeechRecognitionResult(SpeechRecognitionResult speechRecognitionResult)
        {
            switch (speechRecognitionResult.Reason)
            {
                case ResultReason.RecognizedSpeech:
                    return new SpechResponse(ResponseTypes.Recognized, speechRecognitionResult.Text);
                case ResultReason.NoMatch:
                    return new SpechResponse(ResponseTypes.NoMatch);
                default:
                    return new SpechResponse(ResponseTypes.Error);
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
