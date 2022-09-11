/* file "SampleHoundDriver.cs" */

/* Copyright 2014-2016 SoundHound, Incorporated.  All rights reserved. */


using System;
using System.IO;
using System.Threading;


public class SampleHoundDriver
  {
    private class LocalPartialHandler : HoundRequester.PartialHandler
      {
        private bool show_transcript;

        public LocalPartialHandler(bool init_show_transcript)
          {
            show_transcript = init_show_transcript;
          }

        public override void handle(HoundPartialTranscriptJSON partial)
          {
            if (show_transcript)
              {
                Console.Error.Write("Partial Transcript");
                if (partial.hasLocalOrRemote())
                  {
                    Console.Error.Write(" [{0}]",
                            ((partial.getLocalOrRemote() ==
                              HoundPartialTranscriptJSON.TypeLocalOrRemote.
                                      LocalOrRemote_Local) ? "Local" :
                             "Remote"));
                  }
                Console.Error.Write(": `{0}'.\n",
                                    partial.getPartialTranscript());
              }
          }
      };

    public static int sample_hound_driver(HoundRequester requester)
      {
        string session_id = Guid.NewGuid().ToString();
        ConversationStateJSON conversation_state = null;
        while (true)
          {
            string line = Console.ReadLine();
            if (line == null)
                return 0;
            RequestInfoJSON request_info = new RequestInfoJSON();
            request_info.setUnitPreference(
                    RequestInfoJSON.TypeUnitPreference.UnitPreference_US);
            request_info.setRequestID(Guid.NewGuid().ToString());
            request_info.setSessionID(session_id);
            RequestInfoJSON.TypeClientVersion client_version =
                    new RequestInfoJSON.TypeClientVersion();
            client_version.key = 0;
            client_version.choice0 = "1.0";
            request_info.setClientVersion(client_version);

            HoundServerJSON hound_result;
            if ((line.StartsWith("-audio ")) ||
                (line.StartsWith("-transcript-audio ")) ||
                (line.StartsWith("-slow-transcript-audio ")))
              {
                bool go_slowly = line.StartsWith("-slow-transcript-audio ");
                bool show_transcript =
                        (line.StartsWith("-transcript-audio ") ||
                         line.StartsWith("-slow-transcript-audio "));
                LocalPartialHandler partial_handler =
                        new LocalPartialHandler(show_transcript);
                HoundRequester.VoiceRequest request =
                        requester.start_voice_request(conversation_state,
                                request_info, partial_handler);
                int file_name_position = 0;
                while (line[file_name_position] != ' ')
                    ++file_name_position;
                ++file_name_position;
                String file_name = line.Substring(file_name_position);
                BinaryReader audio_stream;
                try
                  {
                    audio_stream = new BinaryReader(
                            File.Open(file_name, FileMode.Open));
                  }
                catch (Exception e1)
                  {
                    Console.Error.Write(
                            "Error trying to open audio file `{0}': {1}\n",
                            file_name, e1.Message);
                    return 1;
                  }
                while (true)
                  {
                    byte[] buffer = new byte[2052];
                    int byte_count = audio_stream.Read(buffer, 0, 2052);
                    if (byte_count > 0)
                        request.add_audio(byte_count, buffer);
                    if (byte_count < 2052)
                        break;
                    if (go_slowly)
                        Thread.Sleep(500);
                  }
                audio_stream.Close();
                hound_result = request.finish();
              }
            else
              {
                hound_result = requester.do_text_request(line,
                        conversation_state, request_info);
              }

            if (hound_result == null)
                return 1;

            if (hound_result.hasAllResults())
              {
                if (hound_result.countOfAllResults() == 0)
                  {
                    Console.Write("No match.\n");
                    conversation_state = null;
                  }
                else
                  {
                    CommandResultJSON command =
                            hound_result.elementOfAllResults(0);
                    Console.Write("Result");
                    if (hound_result.hasLocalOrRemote())
                      {
                        Console.Write(" [{0}]",
                                ((hound_result.getLocalOrRemote() ==
                                  HoundServerJSON.TypeLocalOrRemote.
                                          LocalOrRemote_Local) ? "Local" :
                                 "Remote"));
                      }
                    Console.Write(": {0}\n", command.getWrittenResponseLong());
                    if (command.hasConversationState())
                        conversation_state = command.getConversationState();
                    else
                        conversation_state = null;
                  }
              }
            else if (hound_result.hasErrorMessage())
              {
                Console.Write("Error from server: {0}\n",
                              hound_result.getErrorMessage());
                conversation_state = null;
              }
            else
              {
                Console.Write("No result or error from server.\n");
                conversation_state = null;
              }
          }
      }
  }
