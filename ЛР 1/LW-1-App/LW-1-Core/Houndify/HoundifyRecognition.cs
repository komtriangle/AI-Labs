using Gst.Audio;
using LW_1_Core.Enums;
using LW_1_Core.Models;
using LW_1_Core.Validators;
using Microsoft.Extensions.Options;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW_1_Core.Houndify
{
    public class HoundifyRecognition : ISpechRecongnition
    {
        private readonly HoundifyConfiguration _configuration;
        

        public HoundifyRecognition(IOptions<HoundifyConfiguration> options)
        {
            _configuration = options.Value;
        }
        public async Task<SpechResponse> Recognize(string pathToFile)
        {

            if (!FilePathValidator.ValidatePath(pathToFile, out string message))
            {
                return new SpechResponse(ResponseTypes.Error, string.Empty, message);
            }

            bool isExtensionChanged = false;
            try
            {
                changeExtension(ref pathToFile, ref isExtensionChanged);
            }
            catch(Exception ex)
            {
                return new SpechResponse(ResponseTypes.Error, string.Empty,
                        ex.Message);
            }
            
           
            var partialHandler = new LocalPartialHandler(true);
            HoundRequester.VoiceRequest voiceRequest = createVoiceRequest(partialHandler);

            using (BinaryReader reader = new BinaryReader(File.Open(pathToFile, FileMode.Open)))
            {
                var bytes = reader.ReadBytes(1_000_000_00);
                voiceRequest.add_audio(bytes.Count(), bytes);
            }
            if (isExtensionChanged)
            {
                deleteFile(pathToFile);
            }
            try
            {
                HoundServerJSON hound_result = voiceRequest.finish();

                if (hound_result.getStatus() == HoundServerJSON.TypeStatus.Status_OK)
                {
                    string result = partialHandler.RecognizedText;
                    if (!string.IsNullOrWhiteSpace(result))
                    {
                        return new SpechResponse(ResponseTypes.Recognized, result);
                    }
                    else
                    {
                        return new SpechResponse(ResponseTypes.NoMatch);
                    }

                }
                else
                {
                    return new SpechResponse(ResponseTypes.Error, string.Empty, 
                        "Ошибка во время запроса к API");
                }
            }
            catch (Exception)
            {
                if (isExtensionChanged)
                {
                    File.Delete(pathToFile);
                }
                return new SpechResponse(ResponseTypes.Error, string.Empty,
                    "Ошибка по время получения результатов распознавания");
            }
           
        }

        private HoundRequester.VoiceRequest createVoiceRequest(LocalPartialHandler partialHandler)
        {
            HoundCloudRequester requester = new HoundCloudRequester(_configuration.Client_id,
             _configuration.Client_key, Guid.NewGuid().ToString());

            RequestInfoJSON.TypeClientVersion client_version = new RequestInfoJSON.TypeClientVersion();
            client_version.key = 0;
            client_version.choice0 = "1.0";

            RequestInfoJSON request_info = new RequestInfoJSON();
            request_info.setUnitPreference(RequestInfoJSON.TypeUnitPreference.UnitPreference_US);
            request_info.setRequestID(Guid.NewGuid().ToString());
            request_info.setSessionID(Guid.NewGuid().ToString());
            request_info.setClientVersion(client_version);
            ConversationStateJSON conversation_state = null;
            return requester.start_voice_request(conversation_state, request_info, partialHandler);

        }

        private void changeExtension(ref string pathToFile, ref bool isExtensionChanged)
        {
            if (Path.GetExtension(pathToFile) != ".opus")
            {
                string newPath;
                try
                {
                    Utils.AudioConverter.ConvertAduio(pathToFile, out newPath, ".opus");
                }
                catch (Exception)
                {
                    throw new Exception("Ошибка во время конвертации файла в ogg формат");
                }

                if (!File.Exists(newPath))
                {
                    throw new Exception("Ошибка копирования аудиофайла файла");
                }
                isExtensionChanged = true;
                pathToFile = newPath;
            }
        }

        public class LocalPartialHandler : HoundRequester.PartialHandler
        {
            private bool show_transcript;
            private string _recognizedText;
            public string RecognizedText
            {
                get
                {
                    return _recognizedText;
                }
            }
            public LocalPartialHandler(bool init_show_transcript)
            {
                show_transcript = init_show_transcript;
            }
            public override void handle(HoundPartialTranscriptJSON partial)
            {
                if (show_transcript)
                {
                    _recognizedText = partial.getPartialTranscript();
                }
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
