/* file "HoundRequester.cs" */

/* Copyright 2014-2016 SoundHound, Incorporated.  All rights reserved. */


using System.IO;


public abstract class HoundRequester
  {
    protected HoundRequester()  { }

    public abstract class PartialHandler
      {
        protected PartialHandler()  { }

        public abstract void handle(HoundPartialTranscriptJSON partial);
      };

    public abstract class VoiceRequest
      {
        protected VoiceRequest()  { }

        public abstract void add_audio(int byte_count, byte[] data);
        public abstract HoundServerJSON finish();
      };

    public abstract HoundServerJSON do_text_request(string query,
            ConversationStateJSON conversation_state,
            RequestInfoJSON request_info);
    public abstract VoiceRequest start_voice_request(
            ConversationStateJSON conversation_state,
            RequestInfoJSON request_info,
            PartialHandler partial_handler = null);

    static public void show_version_information(TextWriter stream)
      {
        stream.Write("        SDK Variant: {0}\n", BuildInfo.SDKVariant);
        stream.Write("SDK Private Domains: {0}\n", BuildInfo.SDKPrivateDomains);
        stream.Write("         Build User: {0}\n", BuildInfo.BuildUser);
        stream.Write("         Build Date: {0}\n", BuildInfo.BuildDate);
        stream.Write("      Build Machine: {0}\n", BuildInfo.BuildMachine);
        stream.Write(" Build SVN Revision: {0}\n", BuildInfo.BuildSVNRevision);
        stream.Write("   Build SVN Branch: {0}\n", BuildInfo.BuildSVNBranch);
        stream.Write("       Build Number: {0}\n", BuildInfo.BuildNumber);
        stream.Write("         Build Kind: {0}\n", BuildInfo.BuildKind);
        stream.Write("      Build Variant: {0}\n", BuildInfo.BuildVariant);
      }
  };
