/* file "HoundCloudRequester.cs" */

/* Copyright 2014-2019 SoundHound, Incorporated.  All rights reserved. */

using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Collections.Generic;
using System.Diagnostics;


public class HoundCloudRequester : HoundRequester
  {
    private class pair
      {
        public string key;
        public string value;
      };

    private string text_request_url_base;
    private string voice_request_url_base;
    private string client_id;
    private string client_key;
    private string user_id;
    private bool use_proxy;
    private string proxy_server;
    private int proxy_port;
    private List<pair> proxy_parameters;
    private Dictionary<string, int> proxy_parameter_index;

    private string set_up_fetch(Fetch fetcher,
            ConversationStateJSON conversation_state,
            RequestInfoJSON request_info)
      {
        fetcher.setUserAgent("HoundCloudRequesterCSharp/1.0");

        if (use_proxy)
          {
            fetcher.setProxyServer(proxy_server, proxy_port);
            int param_count = proxy_parameters.Count;
            for (int param_num = 0; param_num < param_count; ++param_num)
              {
                fetcher.setProxyParameter(proxy_parameters[param_num].key,
                                          proxy_parameters[param_num].value);
              }
          }

        long time_stamp =
                (long)((DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0)).
                                TotalSeconds);
        request_info.setTimeStamp(time_stamp);
        if (conversation_state != null)
            request_info.setConversationState(conversation_state);
        string request_id = request_info.getRequestID();
        request_info.setUserID(user_id);
        request_info.setClientID(client_id);
        request_info.setPartialTranscriptsDesired(true);
        request_info.setObjectByteCountPrefix(false);
        request_info.setResultVersionAccepted(1.1);
        request_info.setSDK("C Sharp");
          {
            JSONObjectValue sdk_info = new JSONObjectValue();
            sdk_info.setField("SDKVariant",
                              new JSONStringValue(BuildInfo.SDKVariant));
            sdk_info.setField("SDKPrivateDomains",
                              new JSONStringValue(BuildInfo.SDKPrivateDomains));
            sdk_info.setField("BuildUser",
                              new JSONStringValue(BuildInfo.BuildUser));
            sdk_info.setField("BuildDate",
                              new JSONStringValue(BuildInfo.BuildDate));
            sdk_info.setField("BuildMachine",
                              new JSONStringValue(BuildInfo.BuildMachine));
            if(BuildInfo.BuildGitCommit.Equals("local changes"))
            {
              sdk_info.setField("BuildSVNRevision",
                                new JSONStringValue(BuildInfo.BuildSVNRevision));
              sdk_info.setField("BuildSVNBranch",
                                new JSONStringValue(BuildInfo.BuildSVNBranch));
            }
            else
            {
              sdk_info.setField("BuildGitCommit",
                                new JSONStringValue(BuildInfo.BuildGitCommit));
              sdk_info.setField("BuildGitBranch",
                                new JSONStringValue(BuildInfo.BuildGitBranch));
            }
            sdk_info.setField("BuildNumber",
                              new JSONStringValue(BuildInfo.BuildNumber));
            sdk_info.setField("BuildKind",
                              new JSONStringValue(BuildInfo.BuildKind));
            sdk_info.setField("BuildVariant",
                              new JSONStringValue(BuildInfo.BuildVariant));
            request_info.setSDKInfo(sdk_info);
          }
        StringWriter request_info_stream = new StringWriter();
        JSONStreamWriter request_info_writer = new JSONStreamWriter(
                request_info_stream,
                JSONWriter.whitespace_style.WHITESPACE_NONE);
        request_info.write_as_json(request_info_writer);
        string request_info_string = request_info_stream.ToString();
        fetcher.setParameter("Hound-Request-Info-Length", request_info_string.Length.ToString());

        string auth_id = user_id + ";" + request_id;
        fetcher.setParameter("Hound-Request-Authentication", auth_id);

        byte[] key_bits = Base64.base64url_decode(client_key);
        HMACSHA256 sha_256_hmac = new HMACSHA256(key_bits);
        byte[] hash_result = sha_256_hmac.ComputeHash(
                Encoding.UTF8.GetBytes(
                        String.Format("{0}{1}", auth_id, time_stamp)));

        fetcher.setParameter("Hound-Client-Authentication",
                client_id + ";" + String.Format("{0}", time_stamp) + ";" +
                new String(Base64.base64url_encode(hash_result)));

        if (request_info.hasInputLanguageEnglishName())
          {
            fetcher.setParameter("Hound-Input-Language-English-Name",
                                 request_info.getInputLanguageEnglishName());
          }
        if (request_info.hasInputLanguageNativeName())
          {
            fetcher.setParameter("Hound-Input-Language-Native-Name",
                                 request_info.getInputLanguageNativeName());
          }
        if (request_info.hasInputLanguageIETFTag())
          {
            fetcher.setParameter("Hound-Input-Language-IETF-Tag",
                                 request_info.getInputLanguageIETFTag());
          }

        fetcher.setTimeoutSeconds(30);
        return request_info_string;
      }

    public HoundCloudRequester(string init_client_id, string init_client_key,
            string init_user_id, string init_text_request_url_base,
            string init_voice_request_url_base)
      {
        text_request_url_base = init_text_request_url_base;
        voice_request_url_base = init_voice_request_url_base;
        client_id = init_client_id;
        client_key = init_client_key;
        user_id = init_user_id;
        use_proxy = false;
        proxy_parameters = new List<pair>();
        proxy_parameter_index = new Dictionary<string, int>();
      }

    public HoundCloudRequester(string init_client_id, string init_client_key,
                               string init_user_id)
      {
        text_request_url_base = default_text_request_url_base();
        voice_request_url_base = default_voice_request_url_base();
        client_id = init_client_id;
        client_key = init_client_key;
        user_id = init_user_id;
        use_proxy = false;
        proxy_parameters = new List<pair>();
        proxy_parameter_index = new Dictionary<string, int>();
      }

    public override HoundServerJSON do_text_request(string query,
            ConversationStateJSON conversation_state,
            RequestInfoJSON request_info)
      {
        string url =
                text_request_url_base + "?query=" + Uri.EscapeUriString(query);
        Fetch fetcher = new Fetch(url);
        string request_info_string = set_up_fetch(fetcher, conversation_state, request_info);
        try
          {
            HoundServerJSON.HoldingGenerator generator =
                    new HoundServerJSON.HoldingGenerator(
                            "the result from the Hound server");
            ResultHandler handler = new ResultHandler(generator);

            fetcher.startPost("POST", handler);
            fetcher.continuePost(request_info_string.Length, Encoding.ASCII.GetBytes(request_info_string));
            fetcher.finishPost(handler);
            return generator.value;
          }
        catch (Exception e1)
          {
            Console.Error.Write("Error trying to fetch from `{0}': {1}\n", url,
                                e1.Message);
            return null;
          }
      }

    public override VoiceRequest start_voice_request(
            ConversationStateJSON conversation_state,
            RequestInfoJSON request_info, PartialHandler partial_handler)
      {
        Fetch fetcher = new Fetch(voice_request_url_base);
        string request_info_string = set_up_fetch(fetcher, conversation_state, request_info);
        return new LocalVoiceRequest(fetcher, partial_handler, request_info_string);
      }

    public void setProxyServer(string new_proxy_server, int port)
      {
        use_proxy = true;
        proxy_server = new_proxy_server;
        proxy_port = port;
      }

    public void setProxyParameter(string key, string value)
      {
        Debug.Assert(key != null);
        Debug.Assert(value != null);

        string lower_key = key.ToLower();

        Debug.Assert(value != null);

        if (proxy_parameter_index.ContainsKey(lower_key))
          {
            int found_index = proxy_parameter_index[lower_key];
            Debug.Assert(found_index < proxy_parameters.Count);
            proxy_parameters[found_index].value = value;
            return;
          }

        Debug.Assert(lower_key != null);
        int index = proxy_parameters.Count;
        pair new_element = new pair();
        new_element.key = key;
        new_element.value = value;
        proxy_parameters.Add(new_element);
        proxy_parameter_index.Add(lower_key, index);
      }

    public static string default_text_request_url_base()
      {
        return "https://api.houndify.com/v1/text";
      }

    public static string default_voice_request_url_base()
      {
        return "https://api.houndify.com/v1/audio";
      }

    private class LocalVoiceRequest : HoundRequester.VoiceRequest
      {
        private Fetch fetcher;
        private HoundRequester.PartialHandler partial_handler;
        private ResultHandler handler;

        private class Generator : HoundMessageJSON.HoldingGenerator
          {
            private HoundRequester.PartialHandler partial_handler;

            protected override void handle_result(HoundMessageJSON result)
              {
                base.handle_result(result);
                if ((result.getValue().key == 1) && (partial_handler != null))
                    partial_handler.handle(result.getValue().u.choice1);
              }
            public Generator(HoundRequester.PartialHandler init_partial_handler,
                             string what) : base(what)
              {
                partial_handler = init_partial_handler;
              }
          };

        private Generator generator;

        public LocalVoiceRequest(Fetch init_fetcher,
                HoundRequester.PartialHandler init_partial_handler,
                string request_info_string)
          {
            fetcher = init_fetcher;
            partial_handler = init_partial_handler;
            generator = new Generator(partial_handler,
                                      "the result from the Hound server");
            handler = new ResultHandler(generator);
            fetcher.startPost("POST", handler);
            fetcher.continuePost(request_info_string.Length, Encoding.ASCII.GetBytes(request_info_string));
          }

        public override void add_audio(int byte_count, byte[] data)
          {
            if (byte_count > 0)
                fetcher.continuePost(byte_count, data);
          }

        public override HoundServerJSON finish()
          {
            fetcher.finishPost(handler);
            if (!generator.have_value ||
                    (generator.value == null) ||
                    (!generator.value.hasValue()) ||
                    (generator.value.getValue().key != 0))
              {
                throw(new Exception(
                        "The final message from the server was not a result " +
                        "message."));
              };
            return generator.value.getValue().u.choice0;
          }
      };

    class ResultHandler : FetchHandler
      {
        private bool is_good;
        private JSONIncrementalParser parser;
        Decoder decoder;
        char[] char_buffer;

        public ResultHandler(JSONHandler init_value_handler)
          {
            is_good = true;
            parser = new JSONIncrementalParser(init_value_handler);
            decoder = Encoding.UTF8.GetDecoder();
            char_buffer = new char[1024];
          }

        public override void handleStatusCode(int code)
          {
            if (code != 200)
              {
                Console.Error.Write(
                        "Error: The server returned status code {0}.\n", code);
                Console.Error.Write("       The response body was:\n");
                is_good = false;
              }
          }
        public override void handleContent(int byteCount, byte[] bytes)
          {
            int char_count = decoder.GetCharCount(bytes, 0, byteCount);
            if (char_count > char_buffer.Length)
                char_buffer = new char[char_count];
            decoder.GetChars(bytes, 0, byteCount, char_buffer, 0);
            if (is_good)
                parser.add_characters(char_buffer, char_count);
            else
                Console.Error.Write(new string(char_buffer, 0, char_count));
          }
        public override void handleContentEnd()
          {
            parser.end_of_input();
          }
      };
  };
