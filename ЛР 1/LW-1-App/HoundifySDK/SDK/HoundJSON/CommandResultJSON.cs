/* file "CommandResultJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public abstract class CommandResultJSON : JSONBase
  {
    public enum TypeViewType
      {
        ViewType_Native,
        ViewType_Template,
        ViewType_HTML,
        ViewType_None,
        ViewType_Error
      };

    public static TypeViewType  stringToViewType(string chars)
      {
        switch (chars[0])
          {
            case 'E':
                if ((String.Compare(chars, 1, "rror", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeViewType.ViewType_Error;
                break;
            case 'H':
                if ((String.Compare(chars, 1, "TML", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeViewType.ViewType_HTML;
                break;
            case 'N':
                switch (chars[1])
                  {
                    case 'a':
                        if ((String.Compare(chars, 2, "tive", 0, 4, false) == 0) && (chars.Length == 6))
                            return TypeViewType.ViewType_Native;
                        break;
                    case 'o':
                        if ((String.Compare(chars, 2, "ne", 0, 2, false) == 0) && (chars.Length == 4))
                            return TypeViewType.ViewType_None;
                        break;
                    default:
                        break;
                  }
                break;
            case 'T':
                if ((String.Compare(chars, 1, "emplate", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeViewType.ViewType_Template;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `ViewType' is not one of the legal values.");
      }

    public static string  stringFromViewType(TypeViewType the_enum)
      {
        switch (the_enum)
          {
            case TypeViewType.ViewType_Native:
                return "Native";
            case TypeViewType.ViewType_Template:
                return "Template";
            case TypeViewType.ViewType_HTML:
                return "HTML";
            case TypeViewType.ViewType_None:
                return "None";
            case TypeViewType.ViewType_Error:
                return "Error";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeResponseAudioEncodingKnownValues
      {
        ResponseAudioEncoding_WAV,
        ResponseAudioEncoding_Speex,
        ResponseAudioEncoding__none
      };
    public struct TypeResponseAudioEncoding
      {
        public bool in_known_list;
        public string string_value;
        public TypeResponseAudioEncodingKnownValues list_value;
      };

    public static TypeResponseAudioEncodingKnownValues  stringToResponseAudioEncoding(string chars)
      {
        switch (chars[0])
          {
            case 'S':
                if ((String.Compare(chars, 1, "peex", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeResponseAudioEncodingKnownValues.ResponseAudioEncoding_Speex;
                break;
            case 'W':
                if ((String.Compare(chars, 1, "AV", 0, 2, false) == 0) && (chars.Length == 3))
                    return TypeResponseAudioEncodingKnownValues.ResponseAudioEncoding_WAV;
                break;
            default:
                break;
          }
        return TypeResponseAudioEncodingKnownValues.ResponseAudioEncoding__none;
      }

    public static string  stringFromResponseAudioEncoding(TypeResponseAudioEncodingKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeResponseAudioEncodingKnownValues.ResponseAudioEncoding_WAV:
                return "WAV";
            case TypeResponseAudioEncodingKnownValues.ResponseAudioEncoding_Speex:
                return "Speex";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasSpokenResponse;
    private string storeSpokenResponse;
    private bool flagHasSpokenResponseLong;
    private string storeSpokenResponseLong;
    private bool flagHasWrittenResponse;
    private string storeWrittenResponse;
    private bool flagHasWrittenResponseLong;
    private string storeWrittenResponseLong;
    private bool flagHasSpokenResponseSSML;
    private string storeSpokenResponseSSML;
    private bool flagHasSpokenResponseSSMLLong;
    private string storeSpokenResponseSSMLLong;
    private bool flagHasAutoListen;
    private bool storeAutoListen;
    private bool flagHasUserVisibleMode;
    private string storeUserVisibleMode;
    private bool flagHasIsRepeat;
    private bool storeIsRepeat;
    private bool flagHasAdditionalInformation;
    private List< InformationNuggetJSON  > storeAdditionalInformation;
    private bool flagHasConversationState;
    private ConversationStateJSON  storeConversationState;
    private bool flagHasViewType;
    private List< TypeViewType > storeViewType;
    private bool flagHasTemplateName;
    private string storeTemplateName;
    private bool flagHasTemplateData;
    private TemplateJSON  storeTemplateData;
    private bool flagHasCombiningTemplateData;
    private TemplateJSON  storeCombiningTemplateData;
    private bool flagHasPreview;
    private PreviewJSON  storePreview;
    private bool flagHasHTMLData;
    private HTMLDataJSON  storeHTMLData;
    private bool flagHasHints;
    private HintsJSON  storeHints;
    private bool flagHasEmotion;
    private EmotionJSON  storeEmotion;
    private bool flagHasIcon;
    private IconJSON  storeIcon;
    private bool flagHasResponseAudioBytes;
    private string storeResponseAudioBytes;
    private bool flagHasResponseAudioURL;
    private string storeResponseAudioURL;
    private bool flagHasResponseAudioEncoding;
    private TypeResponseAudioEncoding storeResponseAudioEncoding;
    private bool flagHasResponseAudioError;
    private string storeResponseAudioError;
    private bool flagHasResponseAudioDiagnostics;
    private List< string > storeResponseAudioDiagnostics;
    private bool flagHasOutputOverrideDiagnostics;
    private List< string > storeOutputOverrideDiagnostics;
    private bool flagHasUploadedTerrierDiagnostics;
    private List< string > storeUploadedTerrierDiagnostics;
    private bool flagHasRequiredFeatures;
    private List< string > storeRequiredFeatures;
    private bool flagHasClientActionSucceededResult;
    private DynamicResponseJSON  storeClientActionSucceededResult;
    private bool flagHasClientActionFailedResult;
    private DynamicResponseJSON  storeClientActionFailedResult;
    private bool flagHasRequiredFeaturesSupportedResult;
    private DynamicResponseJSON  storeRequiredFeaturesSupportedResult;
    private bool flagHasSendBack;
    private JSONValue  storeSendBack;
    private bool flagHasUnderstandingConfidence;
    private double storeUnderstandingConfidence;
    private string textStoreUnderstandingConfidence;
    private bool flagHasErrorType;
    private string storeErrorType;
    private bool flagHasErrorData;
    private CommandErrorJSON  storeErrorData;


    private void  fromJSONSpokenResponse(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenResponse of CommandResultJSON is not a string.");
        setSpokenResponse(json_string.getData());
      }


    private void  fromJSONSpokenResponseLong(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenResponseLong of CommandResultJSON is not a string.");
        setSpokenResponseLong(json_string.getData());
      }


    private void  fromJSONWrittenResponse(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field WrittenResponse of CommandResultJSON is not a string.");
        setWrittenResponse(json_string.getData());
      }


    private void  fromJSONWrittenResponseLong(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field WrittenResponseLong of CommandResultJSON is not a string.");
        setWrittenResponseLong(json_string.getData());
      }


    private void  fromJSONSpokenResponseSSML(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenResponseSSML of CommandResultJSON is not a string.");
        setSpokenResponseSSML(json_string.getData());
      }


    private void  fromJSONSpokenResponseSSMLLong(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenResponseSSMLLong of CommandResultJSON is not a string.");
        setSpokenResponseSSMLLong(json_string.getData());
      }


    private void  fromJSONAutoListen(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONTrueValue json_true = json_value.true_value();
        bool the_bool;
        if (json_true != null)
          {
            the_bool = true;
          }
        else
          {
            JSONFalseValue json_false = json_value.false_value();
            if (json_false != null)
              {
                the_bool = false;
              }
            else
              {
                throw new Exception("The value for field AutoListen of CommandResultJSON is not true for false.");
              }
          }
        setAutoListen(the_bool);
      }


    private void  fromJSONUserVisibleMode(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field UserVisibleMode of CommandResultJSON is not a string.");
        setUserVisibleMode(json_string.getData());
      }


    private void  fromJSONIsRepeat(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONTrueValue json_true = json_value.true_value();
        bool the_bool;
        if (json_true != null)
          {
            the_bool = true;
          }
        else
          {
            JSONFalseValue json_false = json_value.false_value();
            if (json_false != null)
              {
                the_bool = false;
              }
            else
              {
                throw new Exception("The value for field IsRepeat of CommandResultJSON is not true for false.");
              }
          }
        setIsRepeat(the_bool);
      }


    private void  fromJSONAdditionalInformation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field AdditionalInformation of CommandResultJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field AdditionalInformation of CommandResultJSON has too few elements.");
        List< InformationNuggetJSON  > vector_AdditionalInformation1 = new List< InformationNuggetJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            InformationNuggetJSON convert_classy = InformationNuggetJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_AdditionalInformation1.Add(convert_classy);
          }
        Debug.Assert(vector_AdditionalInformation1.Count >= 1);
        initAdditionalInformation();
        for (int num1 = 0; num1 < vector_AdditionalInformation1.Count; ++num1)
            appendAdditionalInformation(vector_AdditionalInformation1[num1]);
        for (int num1 = 0; num1 < vector_AdditionalInformation1.Count; ++num1)
          {
          }
      }


    private void  fromJSONConversationState(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        ConversationStateJSON convert_classy = ConversationStateJSON.from_json(json_value, ignore_extras, true);
        setConversationState(convert_classy);
      }


    private void  fromJSONViewType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field ViewType of CommandResultJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field ViewType of CommandResultJSON has too few elements.");
        List< TypeViewType > vector_ViewType1 = new List< TypeViewType >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field ViewType of CommandResultJSON is not a string.");
            TypeViewType the_enum;
            switch (json_string.getData()[0])
              {
                case 'E':
                    if ((String.Compare(json_string.getData(), 1, "rror", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                          {
                            the_enum = TypeViewType.ViewType_Error;
                            goto enum_is_done;
                          }
                    break;
                case 'H':
                    if ((String.Compare(json_string.getData(), 1, "TML", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                          {
                            the_enum = TypeViewType.ViewType_HTML;
                            goto enum_is_done;
                          }
                    break;
                case 'N':
                    switch (json_string.getData()[1])
                      {
                        case 'a':
                            if ((String.Compare(json_string.getData(), 2, "tive", 0, 4, false) == 0) && (json_string.getData().Length == 6))
                                  {
                                    the_enum = TypeViewType.ViewType_Native;
                                    goto enum_is_done;
                                  }
                            break;
                        case 'o':
                            if ((String.Compare(json_string.getData(), 2, "ne", 0, 2, false) == 0) && (json_string.getData().Length == 4))
                                  {
                                    the_enum = TypeViewType.ViewType_None;
                                    goto enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'T':
                    if ((String.Compare(json_string.getData(), 1, "emplate", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                          {
                            the_enum = TypeViewType.ViewType_Template;
                            goto enum_is_done;
                          }
                    break;
                default:
                    break;
              }
            throw new Exception("The value for an element of field ViewType of CommandResultJSON is not one of the legal strings.");
          enum_is_done:;
            vector_ViewType1.Add(the_enum);
          }
        Debug.Assert(vector_ViewType1.Count >= 1);
        initViewType();
        for (int num2 = 0; num2 < vector_ViewType1.Count; ++num2)
            appendViewType(vector_ViewType1[num2]);
        for (int num1 = 0; num1 < vector_ViewType1.Count; ++num1)
          {
          }
      }


    private void  fromJSONTemplateName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field TemplateName of CommandResultJSON is not a string.");
        setTemplateName(json_string.getData());
      }


    private void  fromJSONTemplateData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TemplateJSON convert_classy = TemplateJSON.from_json(json_value, ignore_extras, true);
        setTemplateData(convert_classy);
      }


    private void  fromJSONCombiningTemplateData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TemplateJSON convert_classy = TemplateJSON.from_json(json_value, ignore_extras, true);
        setCombiningTemplateData(convert_classy);
      }


    private void  fromJSONPreview(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        PreviewJSON convert_classy = PreviewJSON.from_json(json_value, ignore_extras, true);
        setPreview(convert_classy);
      }


    private void  fromJSONHTMLData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        HTMLDataJSON convert_classy = HTMLDataJSON.from_json(json_value, ignore_extras, true);
        setHTMLData(convert_classy);
      }


    private void  fromJSONHints(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        HintsJSON convert_classy = HintsJSON.from_json(json_value, ignore_extras, true);
        setHints(convert_classy);
      }


    private void  fromJSONEmotion(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        EmotionJSON convert_classy = EmotionJSON.from_json(json_value, ignore_extras, true);
        setEmotion(convert_classy);
      }


    private void  fromJSONIcon(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        IconJSON convert_classy = IconJSON.from_json(json_value, ignore_extras, true);
        setIcon(convert_classy);
      }


    private void  fromJSONResponseAudioBytes(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ResponseAudioBytes of CommandResultJSON is not a string.");
        setResponseAudioBytes(json_string.getData());
      }


    private void  fromJSONResponseAudioURL(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ResponseAudioURL of CommandResultJSON is not a string.");
        setResponseAudioURL(json_string.getData());
      }


    private void  fromJSONResponseAudioEncoding(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ResponseAudioEncoding of CommandResultJSON is not a string.");
        TypeResponseAudioEncoding the_open_enum = new TypeResponseAudioEncoding();
        switch (json_string.getData()[0])
          {
            case 'S':
                if ((String.Compare(json_string.getData(), 1, "peex", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeResponseAudioEncodingKnownValues.ResponseAudioEncoding_Speex;
                        goto open_enum_is_done;
                      }
                break;
            case 'W':
                if ((String.Compare(json_string.getData(), 1, "AV", 0, 2, false) == 0) && (json_string.getData().Length == 3))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeResponseAudioEncodingKnownValues.ResponseAudioEncoding_WAV;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setResponseAudioEncoding(the_open_enum);
      }


    private void  fromJSONResponseAudioError(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ResponseAudioError of CommandResultJSON is not a string.");
        setResponseAudioError(json_string.getData());
      }


    private void  fromJSONResponseAudioDiagnostics(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field ResponseAudioDiagnostics of CommandResultJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_ResponseAudioDiagnostics1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field ResponseAudioDiagnostics of CommandResultJSON is not a string.");
            vector_ResponseAudioDiagnostics1.Add(json_string.getData());
          }
        initResponseAudioDiagnostics();
        for (int num3 = 0; num3 < vector_ResponseAudioDiagnostics1.Count; ++num3)
            appendResponseAudioDiagnostics(vector_ResponseAudioDiagnostics1[num3]);
        for (int num1 = 0; num1 < vector_ResponseAudioDiagnostics1.Count; ++num1)
          {
          }
      }


    private void  fromJSONOutputOverrideDiagnostics(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field OutputOverrideDiagnostics of CommandResultJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_OutputOverrideDiagnostics1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field OutputOverrideDiagnostics of CommandResultJSON is not a string.");
            vector_OutputOverrideDiagnostics1.Add(json_string.getData());
          }
        initOutputOverrideDiagnostics();
        for (int num4 = 0; num4 < vector_OutputOverrideDiagnostics1.Count; ++num4)
            appendOutputOverrideDiagnostics(vector_OutputOverrideDiagnostics1[num4]);
        for (int num1 = 0; num1 < vector_OutputOverrideDiagnostics1.Count; ++num1)
          {
          }
      }


    private void  fromJSONUploadedTerrierDiagnostics(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field UploadedTerrierDiagnostics of CommandResultJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_UploadedTerrierDiagnostics1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field UploadedTerrierDiagnostics of CommandResultJSON is not a string.");
            vector_UploadedTerrierDiagnostics1.Add(json_string.getData());
          }
        initUploadedTerrierDiagnostics();
        for (int num5 = 0; num5 < vector_UploadedTerrierDiagnostics1.Count; ++num5)
            appendUploadedTerrierDiagnostics(vector_UploadedTerrierDiagnostics1[num5]);
        for (int num1 = 0; num1 < vector_UploadedTerrierDiagnostics1.Count; ++num1)
          {
          }
      }


    private void  fromJSONRequiredFeatures(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field RequiredFeatures of CommandResultJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field RequiredFeatures of CommandResultJSON has too few elements.");
        List< string > vector_RequiredFeatures1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field RequiredFeatures of CommandResultJSON is not a string.");
            vector_RequiredFeatures1.Add(json_string.getData());
          }
        Debug.Assert(vector_RequiredFeatures1.Count >= 1);
        initRequiredFeatures();
        for (int num6 = 0; num6 < vector_RequiredFeatures1.Count; ++num6)
            appendRequiredFeatures(vector_RequiredFeatures1[num6]);
        for (int num1 = 0; num1 < vector_RequiredFeatures1.Count; ++num1)
          {
          }
      }


    private void  fromJSONClientActionSucceededResult(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setClientActionSucceededResult(convert_classy);
      }


    private void  fromJSONClientActionFailedResult(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setClientActionFailedResult(convert_classy);
      }


    private void  fromJSONRequiredFeaturesSupportedResult(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setRequiredFeaturesSupportedResult(convert_classy);
      }


    private void  fromJSONSendBack(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        setSendBack(json_value);
      }


    private void  fromJSONUnderstandingConfidence(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONRationalValue json_rational = json_value.rational_value();
        string the_rational_text;
        if (json_rational != null)
          {
            the_rational_text = json_rational.getText();
          }
        else
          {
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer != null)
              {
                the_rational_text = json_integer.getText();
              }
            else
              {
                throw new Exception("The value for field UnderstandingConfidence of CommandResultJSON is not a number.");
              }
          }
        setUnderstandingConfidenceText(the_rational_text);
      }


    private void  fromJSONErrorType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ErrorType of CommandResultJSON is not a string.");
        setErrorType(json_string.getData());
      }


    private void  fromJSONErrorData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        CommandErrorJSON convert_classy = CommandErrorJSON.from_json(json_value, ignore_extras, true);
        setErrorData(convert_classy);
      }


    public CommandResultJSON()
      {
        flagHasSpokenResponse = false;
        flagHasSpokenResponseLong = false;
        flagHasWrittenResponse = false;
        flagHasWrittenResponseLong = false;
        flagHasSpokenResponseSSML = false;
        flagHasSpokenResponseSSMLLong = false;
        flagHasAutoListen = false;
        flagHasUserVisibleMode = false;
        flagHasIsRepeat = false;
        flagHasAdditionalInformation = false;
        flagHasConversationState = false;
        flagHasViewType = false;
        flagHasTemplateName = false;
        flagHasTemplateData = false;
        flagHasCombiningTemplateData = false;
        flagHasPreview = false;
        flagHasHTMLData = false;
        flagHasHints = false;
        flagHasEmotion = false;
        flagHasIcon = false;
        flagHasResponseAudioBytes = false;
        flagHasResponseAudioURL = false;
        flagHasResponseAudioEncoding = false;
        flagHasResponseAudioError = false;
        flagHasResponseAudioDiagnostics = false;
        flagHasOutputOverrideDiagnostics = false;
        flagHasUploadedTerrierDiagnostics = false;
        flagHasRequiredFeatures = false;
        flagHasClientActionSucceededResult = false;
        flagHasClientActionFailedResult = false;
        flagHasRequiredFeaturesSupportedResult = false;
        flagHasSendBack = false;
        flagHasUnderstandingConfidence = false;
        flagHasErrorType = false;
        flagHasErrorData = false;
        storeAutoListen = false;
        storeAdditionalInformation = new List< InformationNuggetJSON  >();
        storeViewType = new List< TypeViewType >();
        storeResponseAudioDiagnostics = new List< string >();
        storeOutputOverrideDiagnostics = new List< string >();
        storeUploadedTerrierDiagnostics = new List< string >();
        storeRequiredFeatures = new List< string >();
      }

    public abstract string getCommandKind();
    public bool  hasSpokenResponse()
      {
        return flagHasSpokenResponse;
      }

    public string  getSpokenResponse()
      {
        Debug.Assert(flagHasSpokenResponse);
        return storeSpokenResponse;
      }

    public bool  hasSpokenResponseLong()
      {
        return flagHasSpokenResponseLong;
      }

    public string  getSpokenResponseLong()
      {
        Debug.Assert(flagHasSpokenResponseLong);
        return storeSpokenResponseLong;
      }

    public bool  hasWrittenResponse()
      {
        return flagHasWrittenResponse;
      }

    public string  getWrittenResponse()
      {
        Debug.Assert(flagHasWrittenResponse);
        return storeWrittenResponse;
      }

    public bool  hasWrittenResponseLong()
      {
        return flagHasWrittenResponseLong;
      }

    public string  getWrittenResponseLong()
      {
        Debug.Assert(flagHasWrittenResponseLong);
        return storeWrittenResponseLong;
      }

    public bool  hasSpokenResponseSSML()
      {
        return flagHasSpokenResponseSSML;
      }

    public string  getSpokenResponseSSML()
      {
        Debug.Assert(flagHasSpokenResponseSSML);
        return storeSpokenResponseSSML;
      }

    public bool  hasSpokenResponseSSMLLong()
      {
        return flagHasSpokenResponseSSMLLong;
      }

    public string  getSpokenResponseSSMLLong()
      {
        Debug.Assert(flagHasSpokenResponseSSMLLong);
        return storeSpokenResponseSSMLLong;
      }

    public bool  hasAutoListen()
      {
        return flagHasAutoListen;
      }

    public bool  getAutoListen()
      {
        return storeAutoListen;
      }

    public bool  hasUserVisibleMode()
      {
        return flagHasUserVisibleMode;
      }

    public string  getUserVisibleMode()
      {
        Debug.Assert(flagHasUserVisibleMode);
        return storeUserVisibleMode;
      }

    public bool  hasIsRepeat()
      {
        return flagHasIsRepeat;
      }

    public bool  getIsRepeat()
      {
        Debug.Assert(flagHasIsRepeat);
        return storeIsRepeat;
      }

    public bool  hasAdditionalInformation()
      {
        return flagHasAdditionalInformation;
      }

    public int  countOfAdditionalInformation()
      {
        Debug.Assert(flagHasAdditionalInformation);
        return storeAdditionalInformation.Count;
      }

    public InformationNuggetJSON   elementOfAdditionalInformation(int element_num)
      {
        Debug.Assert(flagHasAdditionalInformation);
        return storeAdditionalInformation[element_num];
      }

    public List< InformationNuggetJSON  >  getAdditionalInformation()
      {
        Debug.Assert(flagHasAdditionalInformation);
        return storeAdditionalInformation;
      }

    public bool  hasConversationState()
      {
        return flagHasConversationState;
      }

    public ConversationStateJSON   getConversationState()
      {
        Debug.Assert(flagHasConversationState);
        return storeConversationState;
      }

    public bool  hasViewType()
      {
        return flagHasViewType;
      }

    public int  countOfViewType()
      {
        Debug.Assert(flagHasViewType);
        return storeViewType.Count;
      }

    public TypeViewType  elementOfViewType(int element_num)
      {
        Debug.Assert(flagHasViewType);
        return storeViewType[element_num];
      }

    public List< TypeViewType >  getViewType()
      {
        Debug.Assert(flagHasViewType);
        return storeViewType;
      }

    public bool  hasTemplateName()
      {
        return flagHasTemplateName;
      }

    public string  getTemplateName()
      {
        Debug.Assert(flagHasTemplateName);
        return storeTemplateName;
      }

    public bool  hasTemplateData()
      {
        return flagHasTemplateData;
      }

    public TemplateJSON   getTemplateData()
      {
        Debug.Assert(flagHasTemplateData);
        return storeTemplateData;
      }

    public bool  hasCombiningTemplateData()
      {
        return flagHasCombiningTemplateData;
      }

    public TemplateJSON   getCombiningTemplateData()
      {
        Debug.Assert(flagHasCombiningTemplateData);
        return storeCombiningTemplateData;
      }

    public bool  hasPreview()
      {
        return flagHasPreview;
      }

    public PreviewJSON   getPreview()
      {
        Debug.Assert(flagHasPreview);
        return storePreview;
      }

    public JSONValue   getPreviewValue()
      {
        return getPreview().getValue();
      }

    public bool  hasHTMLData()
      {
        return flagHasHTMLData;
      }

    public HTMLDataJSON   getHTMLData()
      {
        Debug.Assert(flagHasHTMLData);
        return storeHTMLData;
      }

    public bool  hasHints()
      {
        return flagHasHints;
      }

    public HintsJSON   getHints()
      {
        Debug.Assert(flagHasHints);
        return storeHints;
      }

    public bool  hasEmotion()
      {
        return flagHasEmotion;
      }

    public EmotionJSON   getEmotion()
      {
        Debug.Assert(flagHasEmotion);
        return storeEmotion;
      }

    public EmotionJSON.TypeValue  getEmotionValue()
      {
        return getEmotion().getValue();
      }

    public string  getEmotionAsString()
      {
        return getEmotion().getValueAsString();
      }

    public bool  hasIcon()
      {
        return flagHasIcon;
      }

    public IconJSON   getIcon()
      {
        Debug.Assert(flagHasIcon);
        return storeIcon;
      }

    public IconJSON.TypeValue  getIconValue()
      {
        return getIcon().getValue();
      }

    public string  getIconAsString()
      {
        return getIcon().getValueAsString();
      }

    public bool  hasResponseAudioBytes()
      {
        return flagHasResponseAudioBytes;
      }

    public string  getResponseAudioBytes()
      {
        Debug.Assert(flagHasResponseAudioBytes);
        return storeResponseAudioBytes;
      }

    public bool  hasResponseAudioURL()
      {
        return flagHasResponseAudioURL;
      }

    public string  getResponseAudioURL()
      {
        Debug.Assert(flagHasResponseAudioURL);
        return storeResponseAudioURL;
      }

    public bool  hasResponseAudioEncoding()
      {
        return flagHasResponseAudioEncoding;
      }

    public TypeResponseAudioEncoding  getResponseAudioEncoding()
      {
        Debug.Assert(flagHasResponseAudioEncoding);
        return storeResponseAudioEncoding;
      }

    public string  getResponseAudioEncodingAsString()
      {
        TypeResponseAudioEncoding result = getResponseAudioEncoding();
        if (result.in_known_list)
            return stringFromResponseAudioEncoding(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasResponseAudioError()
      {
        return flagHasResponseAudioError;
      }

    public string  getResponseAudioError()
      {
        Debug.Assert(flagHasResponseAudioError);
        return storeResponseAudioError;
      }

    public bool  hasResponseAudioDiagnostics()
      {
        return flagHasResponseAudioDiagnostics;
      }

    public int  countOfResponseAudioDiagnostics()
      {
        Debug.Assert(flagHasResponseAudioDiagnostics);
        return storeResponseAudioDiagnostics.Count;
      }

    public string  elementOfResponseAudioDiagnostics(int element_num)
      {
        Debug.Assert(flagHasResponseAudioDiagnostics);
        return storeResponseAudioDiagnostics[element_num];
      }

    public List< string >  getResponseAudioDiagnostics()
      {
        Debug.Assert(flagHasResponseAudioDiagnostics);
        return storeResponseAudioDiagnostics;
      }

    public bool  hasOutputOverrideDiagnostics()
      {
        return flagHasOutputOverrideDiagnostics;
      }

    public int  countOfOutputOverrideDiagnostics()
      {
        Debug.Assert(flagHasOutputOverrideDiagnostics);
        return storeOutputOverrideDiagnostics.Count;
      }

    public string  elementOfOutputOverrideDiagnostics(int element_num)
      {
        Debug.Assert(flagHasOutputOverrideDiagnostics);
        return storeOutputOverrideDiagnostics[element_num];
      }

    public List< string >  getOutputOverrideDiagnostics()
      {
        Debug.Assert(flagHasOutputOverrideDiagnostics);
        return storeOutputOverrideDiagnostics;
      }

    public bool  hasUploadedTerrierDiagnostics()
      {
        return flagHasUploadedTerrierDiagnostics;
      }

    public int  countOfUploadedTerrierDiagnostics()
      {
        Debug.Assert(flagHasUploadedTerrierDiagnostics);
        return storeUploadedTerrierDiagnostics.Count;
      }

    public string  elementOfUploadedTerrierDiagnostics(int element_num)
      {
        Debug.Assert(flagHasUploadedTerrierDiagnostics);
        return storeUploadedTerrierDiagnostics[element_num];
      }

    public List< string >  getUploadedTerrierDiagnostics()
      {
        Debug.Assert(flagHasUploadedTerrierDiagnostics);
        return storeUploadedTerrierDiagnostics;
      }

    public bool  hasRequiredFeatures()
      {
        return flagHasRequiredFeatures;
      }

    public int  countOfRequiredFeatures()
      {
        Debug.Assert(flagHasRequiredFeatures);
        return storeRequiredFeatures.Count;
      }

    public string  elementOfRequiredFeatures(int element_num)
      {
        Debug.Assert(flagHasRequiredFeatures);
        return storeRequiredFeatures[element_num];
      }

    public List< string >  getRequiredFeatures()
      {
        Debug.Assert(flagHasRequiredFeatures);
        return storeRequiredFeatures;
      }

    public bool  hasClientActionSucceededResult()
      {
        return flagHasClientActionSucceededResult;
      }

    public DynamicResponseJSON   getClientActionSucceededResult()
      {
        Debug.Assert(flagHasClientActionSucceededResult);
        return storeClientActionSucceededResult;
      }

    public bool  hasClientActionFailedResult()
      {
        return flagHasClientActionFailedResult;
      }

    public DynamicResponseJSON   getClientActionFailedResult()
      {
        Debug.Assert(flagHasClientActionFailedResult);
        return storeClientActionFailedResult;
      }

    public bool  hasRequiredFeaturesSupportedResult()
      {
        return flagHasRequiredFeaturesSupportedResult;
      }

    public DynamicResponseJSON   getRequiredFeaturesSupportedResult()
      {
        Debug.Assert(flagHasRequiredFeaturesSupportedResult);
        return storeRequiredFeaturesSupportedResult;
      }

    public bool  hasSendBack()
      {
        return flagHasSendBack;
      }

    public JSONValue   getSendBack()
      {
        Debug.Assert(flagHasSendBack);
        return storeSendBack;
      }

    public bool  hasUnderstandingConfidence()
      {
        return flagHasUnderstandingConfidence;
      }

    public double  getUnderstandingConfidence()
      {
        Debug.Assert(flagHasUnderstandingConfidence);
        if (textStoreUnderstandingConfidence != "")
          {
            return Double.Parse(textStoreUnderstandingConfidence);
          }
        return storeUnderstandingConfidence;
      }

    public string  getUnderstandingConfidenceAsText()
      {
        Debug.Assert(flagHasUnderstandingConfidence);
        if (textStoreUnderstandingConfidence == "")
          {
            return Convert.ToString(storeUnderstandingConfidence);
          }
        else
          {
            return (textStoreUnderstandingConfidence);
          }
      }

    public bool  hasErrorType()
      {
        return flagHasErrorType;
      }

    public string  getErrorType()
      {
        Debug.Assert(flagHasErrorType);
        return storeErrorType;
      }

    public bool  hasErrorData()
      {
        return flagHasErrorData;
      }

    public CommandErrorJSON   getErrorData()
      {
        Debug.Assert(flagHasErrorData);
        return storeErrorData;
      }


    public abstract int extraCommandResultComponentCount();
    public abstract string extraCommandResultComponentKey(int component_num);
    public abstract JSONValue extraCommandResultComponentValue(int component_num);
    public abstract JSONValue extraCommandResultLookup(string field_name);

    public void setSpokenResponse(string new_value)
      {
        flagHasSpokenResponse = true;
        storeSpokenResponse = new_value;
      }
    public void unsetSpokenResponse()
      {
        flagHasSpokenResponse = false;
      }
    public void setSpokenResponseLong(string new_value)
      {
        flagHasSpokenResponseLong = true;
        storeSpokenResponseLong = new_value;
      }
    public void unsetSpokenResponseLong()
      {
        flagHasSpokenResponseLong = false;
      }
    public void setWrittenResponse(string new_value)
      {
        flagHasWrittenResponse = true;
        storeWrittenResponse = new_value;
      }
    public void unsetWrittenResponse()
      {
        flagHasWrittenResponse = false;
      }
    public void setWrittenResponseLong(string new_value)
      {
        flagHasWrittenResponseLong = true;
        storeWrittenResponseLong = new_value;
      }
    public void unsetWrittenResponseLong()
      {
        flagHasWrittenResponseLong = false;
      }
    public void setSpokenResponseSSML(string new_value)
      {
        flagHasSpokenResponseSSML = true;
        storeSpokenResponseSSML = new_value;
      }
    public void unsetSpokenResponseSSML()
      {
        flagHasSpokenResponseSSML = false;
      }
    public void setSpokenResponseSSMLLong(string new_value)
      {
        flagHasSpokenResponseSSMLLong = true;
        storeSpokenResponseSSMLLong = new_value;
      }
    public void unsetSpokenResponseSSMLLong()
      {
        flagHasSpokenResponseSSMLLong = false;
      }
    public void setAutoListen(bool new_value)
      {
        flagHasAutoListen = true;
        storeAutoListen = new_value;
      }
    public void unsetAutoListen()
      {
        flagHasAutoListen = false;
      }
    public void setUserVisibleMode(string new_value)
      {
        flagHasUserVisibleMode = true;
        storeUserVisibleMode = new_value;
      }
    public void unsetUserVisibleMode()
      {
        flagHasUserVisibleMode = false;
      }
    public void setIsRepeat(bool new_value)
      {
        flagHasIsRepeat = true;
        storeIsRepeat = new_value;
      }
    public void unsetIsRepeat()
      {
        flagHasIsRepeat = false;
      }
    public void initAdditionalInformation()
      {
        if (flagHasAdditionalInformation)
          {
            for (int num1 = 0; num1 < storeAdditionalInformation.Count; ++num1)
              {
              }
          }
        flagHasAdditionalInformation = true;
        storeAdditionalInformation.Clear();
      }
    public void appendAdditionalInformation(InformationNuggetJSON  to_append)
      {
        if (!flagHasAdditionalInformation)
          {
            flagHasAdditionalInformation = true;
            storeAdditionalInformation.Clear();
          }
        Debug.Assert(flagHasAdditionalInformation);
        storeAdditionalInformation.Add(to_append);
      }
    public void unsetAdditionalInformation()
      {
        if (flagHasAdditionalInformation)
          {
            for (int num2 = 0; num2 < storeAdditionalInformation.Count; ++num2)
              {
              }
          }
        flagHasAdditionalInformation = false;
        storeAdditionalInformation.Clear();
      }
    public void setConversationState(ConversationStateJSON  new_value)
      {
        if (flagHasConversationState)
          {
          }
        flagHasConversationState = true;
        storeConversationState = new_value;
      }
    public void unsetConversationState()
      {
        if (flagHasConversationState)
          {
          }
        flagHasConversationState = false;
      }
    public void initViewType()
      {
        flagHasViewType = true;
        storeViewType.Clear();
      }
    public void appendViewType(TypeViewType to_append)
      {
        if (!flagHasViewType)
          {
            flagHasViewType = true;
            storeViewType.Clear();
          }
        Debug.Assert(flagHasViewType);
        storeViewType.Add(to_append);
      }
    public void appendViewType(string chars)
      {
        appendViewType(stringToViewType(chars));
      }
    public void unsetViewType()
      {
        flagHasViewType = false;
        storeViewType.Clear();
      }
    public void setTemplateName(string new_value)
      {
        flagHasTemplateName = true;
        storeTemplateName = new_value;
      }
    public void unsetTemplateName()
      {
        flagHasTemplateName = false;
      }
    public void setTemplateData(TemplateJSON  new_value)
      {
        if (flagHasTemplateData)
          {
          }
        flagHasTemplateData = true;
        storeTemplateData = new_value;
      }
    public void unsetTemplateData()
      {
        if (flagHasTemplateData)
          {
          }
        flagHasTemplateData = false;
      }
    public void setCombiningTemplateData(TemplateJSON  new_value)
      {
        if (flagHasCombiningTemplateData)
          {
          }
        flagHasCombiningTemplateData = true;
        storeCombiningTemplateData = new_value;
      }
    public void unsetCombiningTemplateData()
      {
        if (flagHasCombiningTemplateData)
          {
          }
        flagHasCombiningTemplateData = false;
      }
    public void setPreview(PreviewJSON  new_value)
      {
        if (flagHasPreview)
          {
          }
        flagHasPreview = true;
        storePreview = new_value;
      }
    public void setPreview(JSONValue  new_value)
      {
        setPreview(new PreviewJSON(new_value));
      }
    public void unsetPreview()
      {
        if (flagHasPreview)
          {
          }
        flagHasPreview = false;
      }
    public void setHTMLData(HTMLDataJSON  new_value)
      {
        if (flagHasHTMLData)
          {
          }
        flagHasHTMLData = true;
        storeHTMLData = new_value;
      }
    public void unsetHTMLData()
      {
        if (flagHasHTMLData)
          {
          }
        flagHasHTMLData = false;
      }
    public void setHints(HintsJSON  new_value)
      {
        if (flagHasHints)
          {
          }
        flagHasHints = true;
        storeHints = new_value;
      }
    public void unsetHints()
      {
        if (flagHasHints)
          {
          }
        flagHasHints = false;
      }
    public void setEmotion(EmotionJSON  new_value)
      {
        if (flagHasEmotion)
          {
          }
        flagHasEmotion = true;
        storeEmotion = new_value;
      }
    public void setEmotion(EmotionJSON.TypeValue new_value)
      {
        setEmotion(new EmotionJSON(new_value));
      }
    public void setEmotion(string chars)
      {
        setEmotion(new EmotionJSON(chars));
      }
    public void unsetEmotion()
      {
        if (flagHasEmotion)
          {
          }
        flagHasEmotion = false;
      }
    public void setIcon(IconJSON  new_value)
      {
        if (flagHasIcon)
          {
          }
        flagHasIcon = true;
        storeIcon = new_value;
      }
    public void setIcon(IconJSON.TypeValue new_value)
      {
        setIcon(new IconJSON(new_value));
      }
    public void setIcon(string chars)
      {
        setIcon(new IconJSON(chars));
      }
    public void unsetIcon()
      {
        if (flagHasIcon)
          {
          }
        flagHasIcon = false;
      }
    public void setResponseAudioBytes(string new_value)
      {
        flagHasResponseAudioBytes = true;
        storeResponseAudioBytes = new_value;
      }
    public void unsetResponseAudioBytes()
      {
        flagHasResponseAudioBytes = false;
      }
    public void setResponseAudioURL(string new_value)
      {
        flagHasResponseAudioURL = true;
        storeResponseAudioURL = new_value;
      }
    public void unsetResponseAudioURL()
      {
        flagHasResponseAudioURL = false;
      }
    public void setResponseAudioEncoding(TypeResponseAudioEncoding new_value)
      {
        flagHasResponseAudioEncoding = true;
        storeResponseAudioEncoding = new_value;
      }
    public void setResponseAudioEncoding(string chars)
      {
        TypeResponseAudioEncodingKnownValues known = stringToResponseAudioEncoding(chars);
        TypeResponseAudioEncoding new_value = new TypeResponseAudioEncoding();
        if (known == TypeResponseAudioEncodingKnownValues.ResponseAudioEncoding__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setResponseAudioEncoding(new_value);
      }
    public void setResponseAudioEncoding(TypeResponseAudioEncodingKnownValues new_value)
      {
        TypeResponseAudioEncoding new_full_value = new TypeResponseAudioEncoding();
        Debug.Assert(new_value != TypeResponseAudioEncodingKnownValues.ResponseAudioEncoding__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setResponseAudioEncoding(new_full_value);
      }
    public void unsetResponseAudioEncoding()
      {
        flagHasResponseAudioEncoding = false;
      }
    public void setResponseAudioError(string new_value)
      {
        flagHasResponseAudioError = true;
        storeResponseAudioError = new_value;
      }
    public void unsetResponseAudioError()
      {
        flagHasResponseAudioError = false;
      }
    public void initResponseAudioDiagnostics()
      {
        flagHasResponseAudioDiagnostics = true;
        storeResponseAudioDiagnostics.Clear();
      }
    public void appendResponseAudioDiagnostics(string to_append)
      {
        if (!flagHasResponseAudioDiagnostics)
          {
            flagHasResponseAudioDiagnostics = true;
            storeResponseAudioDiagnostics.Clear();
          }
        Debug.Assert(flagHasResponseAudioDiagnostics);
        storeResponseAudioDiagnostics.Add(to_append);
      }
    public void unsetResponseAudioDiagnostics()
      {
        flagHasResponseAudioDiagnostics = false;
        storeResponseAudioDiagnostics.Clear();
      }
    public void initOutputOverrideDiagnostics()
      {
        flagHasOutputOverrideDiagnostics = true;
        storeOutputOverrideDiagnostics.Clear();
      }
    public void appendOutputOverrideDiagnostics(string to_append)
      {
        if (!flagHasOutputOverrideDiagnostics)
          {
            flagHasOutputOverrideDiagnostics = true;
            storeOutputOverrideDiagnostics.Clear();
          }
        Debug.Assert(flagHasOutputOverrideDiagnostics);
        storeOutputOverrideDiagnostics.Add(to_append);
      }
    public void unsetOutputOverrideDiagnostics()
      {
        flagHasOutputOverrideDiagnostics = false;
        storeOutputOverrideDiagnostics.Clear();
      }
    public void initUploadedTerrierDiagnostics()
      {
        flagHasUploadedTerrierDiagnostics = true;
        storeUploadedTerrierDiagnostics.Clear();
      }
    public void appendUploadedTerrierDiagnostics(string to_append)
      {
        if (!flagHasUploadedTerrierDiagnostics)
          {
            flagHasUploadedTerrierDiagnostics = true;
            storeUploadedTerrierDiagnostics.Clear();
          }
        Debug.Assert(flagHasUploadedTerrierDiagnostics);
        storeUploadedTerrierDiagnostics.Add(to_append);
      }
    public void unsetUploadedTerrierDiagnostics()
      {
        flagHasUploadedTerrierDiagnostics = false;
        storeUploadedTerrierDiagnostics.Clear();
      }
    public void initRequiredFeatures()
      {
        flagHasRequiredFeatures = true;
        storeRequiredFeatures.Clear();
      }
    public void appendRequiredFeatures(string to_append)
      {
        if (!flagHasRequiredFeatures)
          {
            flagHasRequiredFeatures = true;
            storeRequiredFeatures.Clear();
          }
        Debug.Assert(flagHasRequiredFeatures);
        storeRequiredFeatures.Add(to_append);
      }
    public void unsetRequiredFeatures()
      {
        flagHasRequiredFeatures = false;
        storeRequiredFeatures.Clear();
      }
    public void setClientActionSucceededResult(DynamicResponseJSON  new_value)
      {
        if (flagHasClientActionSucceededResult)
          {
          }
        flagHasClientActionSucceededResult = true;
        storeClientActionSucceededResult = new_value;
      }
    public void unsetClientActionSucceededResult()
      {
        if (flagHasClientActionSucceededResult)
          {
          }
        flagHasClientActionSucceededResult = false;
      }
    public void setClientActionFailedResult(DynamicResponseJSON  new_value)
      {
        if (flagHasClientActionFailedResult)
          {
          }
        flagHasClientActionFailedResult = true;
        storeClientActionFailedResult = new_value;
      }
    public void unsetClientActionFailedResult()
      {
        if (flagHasClientActionFailedResult)
          {
          }
        flagHasClientActionFailedResult = false;
      }
    public void setRequiredFeaturesSupportedResult(DynamicResponseJSON  new_value)
      {
        if (flagHasRequiredFeaturesSupportedResult)
          {
          }
        flagHasRequiredFeaturesSupportedResult = true;
        storeRequiredFeaturesSupportedResult = new_value;
      }
    public void unsetRequiredFeaturesSupportedResult()
      {
        if (flagHasRequiredFeaturesSupportedResult)
          {
          }
        flagHasRequiredFeaturesSupportedResult = false;
      }
    public void setSendBack(JSONValue  new_value)
      {
        if (flagHasSendBack)
          {
          }
        flagHasSendBack = true;
        storeSendBack = new_value;
      }
    public void unsetSendBack()
      {
        if (flagHasSendBack)
          {
          }
        flagHasSendBack = false;
      }
    public void setUnderstandingConfidence(double new_value)
      {
        flagHasUnderstandingConfidence = true;
        if (new_value < 0)
            throw new Exception("The value for field UnderstandingConfidence of CommandResultJSON is less than the lower bound (0) for that field.");
        if (new_value > 1)
            throw new Exception("The value for field UnderstandingConfidence of CommandResultJSON is greater than the upper bound (1) for that field.");
        storeUnderstandingConfidence = new_value;
        textStoreUnderstandingConfidence = "";
      }
    public void setUnderstandingConfidenceText(string new_value)
      {
        flagHasUnderstandingConfidence = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field UnderstandingConfidence of CommandResultJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field UnderstandingConfidence of CommandResultJSON is less than the lower bound (0) for that field.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "1", "", false, "1") > 0)
            throw new Exception("The value for field UnderstandingConfidence of CommandResultJSON is greater than the upper bound (1) for that field.");
        textStoreUnderstandingConfidence = new_value;
      }
    public void unsetUnderstandingConfidence()
      {
        flagHasUnderstandingConfidence = false;
      }
    public void setErrorType(string new_value)
      {
        flagHasErrorType = true;
        storeErrorType = new_value;
      }
    public void unsetErrorType()
      {
        flagHasErrorType = false;
      }
    public void setErrorData(CommandErrorJSON  new_value)
      {
        if (flagHasErrorData)
          {
          }
        flagHasErrorData = true;
        storeErrorData = new_value;
      }
    public void unsetErrorData()
      {
        if (flagHasErrorData)
          {
          }
        flagHasErrorData = false;
      }

    public abstract void extraCommandResultAppendPair(string key, JSONValue new_component);
    public abstract void extraCommandResultSetField(string key, JSONValue new_component);

    public override void write_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler);
        handler.finish_object();
      }

    public virtual void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public virtual void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        handler.pair("CommandKind", getCommandKind());
        Debug.Assert(partial_allowed || flagHasSpokenResponse);
        if (flagHasSpokenResponse)
          {
            handler.start_pair("SpokenResponse");
            handler.string_value(storeSpokenResponse);
          }
        Debug.Assert(partial_allowed || flagHasSpokenResponseLong);
        if (flagHasSpokenResponseLong)
          {
            handler.start_pair("SpokenResponseLong");
            handler.string_value(storeSpokenResponseLong);
          }
        Debug.Assert(partial_allowed || flagHasWrittenResponse);
        if (flagHasWrittenResponse)
          {
            handler.start_pair("WrittenResponse");
            handler.string_value(storeWrittenResponse);
          }
        Debug.Assert(partial_allowed || flagHasWrittenResponseLong);
        if (flagHasWrittenResponseLong)
          {
            handler.start_pair("WrittenResponseLong");
            handler.string_value(storeWrittenResponseLong);
          }
        if (flagHasSpokenResponseSSML)
          {
            handler.start_pair("SpokenResponseSSML");
            handler.string_value(storeSpokenResponseSSML);
          }
        if (flagHasSpokenResponseSSMLLong)
          {
            handler.start_pair("SpokenResponseSSMLLong");
            handler.string_value(storeSpokenResponseSSMLLong);
          }
        if (flagHasAutoListen)
          {
            handler.start_pair("AutoListen");
            handler.boolean_value(storeAutoListen);
          }
        if (flagHasUserVisibleMode)
          {
            handler.start_pair("UserVisibleMode");
            handler.string_value(storeUserVisibleMode);
          }
        if (flagHasIsRepeat)
          {
            handler.start_pair("IsRepeat");
            handler.boolean_value(storeIsRepeat);
          }
        if (flagHasAdditionalInformation)
          {
            handler.start_pair("AdditionalInformation");
            Debug.Assert(storeAdditionalInformation.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeAdditionalInformation.Count; ++num1)
              {
                if (partial_allowed)
                    storeAdditionalInformation[num1].write_partial_as_json(handler);
                else
                    storeAdditionalInformation[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasConversationState)
          {
            handler.start_pair("ConversationState");
            if (partial_allowed)
                storeConversationState.write_partial_as_json(handler);
            else
                storeConversationState.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasViewType);
        if (flagHasViewType)
          {
            handler.start_pair("ViewType");
            Debug.Assert(storeViewType.Count >= 1);
            handler.start_array();
            for (int num2 = 0; num2 < storeViewType.Count; ++num2)
              {
                switch (storeViewType[num2])
                  {
                    case TypeViewType.ViewType_Native:
                        handler.string_value("Native");
                        break;
                    case TypeViewType.ViewType_Template:
                        handler.string_value("Template");
                        break;
                    case TypeViewType.ViewType_HTML:
                        handler.string_value("HTML");
                        break;
                    case TypeViewType.ViewType_None:
                        handler.string_value("None");
                        break;
                    case TypeViewType.ViewType_Error:
                        handler.string_value("Error");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            handler.finish_array();
          }
        if (flagHasTemplateName)
          {
            handler.start_pair("TemplateName");
            handler.string_value(storeTemplateName);
          }
        if (flagHasTemplateData)
          {
            handler.start_pair("TemplateData");
            if (partial_allowed)
                storeTemplateData.write_partial_as_json(handler);
            else
                storeTemplateData.write_as_json(handler);
          }
        if (flagHasCombiningTemplateData)
          {
            handler.start_pair("CombiningTemplateData");
            if (partial_allowed)
                storeCombiningTemplateData.write_partial_as_json(handler);
            else
                storeCombiningTemplateData.write_as_json(handler);
          }
        if (flagHasPreview)
          {
            handler.start_pair("Preview");
            if (partial_allowed)
                storePreview.write_partial_as_json(handler);
            else
                storePreview.write_as_json(handler);
          }
        if (flagHasHTMLData)
          {
            handler.start_pair("HTMLData");
            if (partial_allowed)
                storeHTMLData.write_partial_as_json(handler);
            else
                storeHTMLData.write_as_json(handler);
          }
        if (flagHasHints)
          {
            handler.start_pair("Hints");
            if (partial_allowed)
                storeHints.write_partial_as_json(handler);
            else
                storeHints.write_as_json(handler);
          }
        if (flagHasEmotion)
          {
            handler.start_pair("Emotion");
            if (partial_allowed)
                storeEmotion.write_partial_as_json(handler);
            else
                storeEmotion.write_as_json(handler);
          }
        if (flagHasIcon)
          {
            handler.start_pair("Icon");
            if (partial_allowed)
                storeIcon.write_partial_as_json(handler);
            else
                storeIcon.write_as_json(handler);
          }
        if (flagHasResponseAudioBytes)
          {
            handler.start_pair("ResponseAudioBytes");
            handler.string_value(storeResponseAudioBytes);
          }
        if (flagHasResponseAudioURL)
          {
            handler.start_pair("ResponseAudioURL");
            handler.string_value(storeResponseAudioURL);
          }
        if (flagHasResponseAudioEncoding)
          {
            handler.start_pair("ResponseAudioEncoding");
            if (storeResponseAudioEncoding.in_known_list)
              {
                switch (storeResponseAudioEncoding.list_value)
                  {
                    case TypeResponseAudioEncodingKnownValues.ResponseAudioEncoding_WAV:
                        handler.string_value("WAV");
                        break;
                    case TypeResponseAudioEncodingKnownValues.ResponseAudioEncoding_Speex:
                        handler.string_value("Speex");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeResponseAudioEncoding.string_value);
              }
          }
        if (flagHasResponseAudioError)
          {
            handler.start_pair("ResponseAudioError");
            handler.string_value(storeResponseAudioError);
          }
        if (flagHasResponseAudioDiagnostics)
          {
            handler.start_pair("ResponseAudioDiagnostics");
            handler.start_array();
            for (int num3 = 0; num3 < storeResponseAudioDiagnostics.Count; ++num3)
              {
                handler.string_value(storeResponseAudioDiagnostics[num3]);
              }
            handler.finish_array();
          }
        if (flagHasOutputOverrideDiagnostics)
          {
            handler.start_pair("OutputOverrideDiagnostics");
            handler.start_array();
            for (int num4 = 0; num4 < storeOutputOverrideDiagnostics.Count; ++num4)
              {
                handler.string_value(storeOutputOverrideDiagnostics[num4]);
              }
            handler.finish_array();
          }
        if (flagHasUploadedTerrierDiagnostics)
          {
            handler.start_pair("UploadedTerrierDiagnostics");
            handler.start_array();
            for (int num5 = 0; num5 < storeUploadedTerrierDiagnostics.Count; ++num5)
              {
                handler.string_value(storeUploadedTerrierDiagnostics[num5]);
              }
            handler.finish_array();
          }
        if (flagHasRequiredFeatures)
          {
            handler.start_pair("RequiredFeatures");
            Debug.Assert(storeRequiredFeatures.Count >= 1);
            handler.start_array();
            for (int num6 = 0; num6 < storeRequiredFeatures.Count; ++num6)
              {
                handler.string_value(storeRequiredFeatures[num6]);
              }
            handler.finish_array();
          }
        if (flagHasClientActionSucceededResult)
          {
            handler.start_pair("ClientActionSucceededResult");
            if (partial_allowed)
                storeClientActionSucceededResult.write_partial_as_json(handler);
            else
                storeClientActionSucceededResult.write_as_json(handler);
          }
        if (flagHasClientActionFailedResult)
          {
            handler.start_pair("ClientActionFailedResult");
            if (partial_allowed)
                storeClientActionFailedResult.write_partial_as_json(handler);
            else
                storeClientActionFailedResult.write_as_json(handler);
          }
        if (flagHasRequiredFeaturesSupportedResult)
          {
            handler.start_pair("RequiredFeaturesSupportedResult");
            if (partial_allowed)
                storeRequiredFeaturesSupportedResult.write_partial_as_json(handler);
            else
                storeRequiredFeaturesSupportedResult.write_as_json(handler);
          }
        if (flagHasSendBack)
          {
            handler.start_pair("SendBack");
            storeSendBack.write(handler);
          }
        if (flagHasUnderstandingConfidence)
          {
            handler.start_pair("UnderstandingConfidence");
            if (textStoreUnderstandingConfidence != "")
                handler.number_value(textStoreUnderstandingConfidence);
            else if (((double)(long)storeUnderstandingConfidence) == storeUnderstandingConfidence)
                handler.number_value((long)storeUnderstandingConfidence);
            else
                handler.number_value(storeUnderstandingConfidence);
          }
        if (flagHasErrorType)
          {
            handler.start_pair("ErrorType");
            handler.string_value(storeErrorType);
          }
        if (flagHasErrorData)
          {
            handler.start_pair("ErrorData");
            if (partial_allowed)
                storeErrorData.write_partial_as_json(handler);
            else
                storeErrorData.write_as_json(handler);
          }
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler, true);
        handler.finish_object();
      }
    public virtual string missing_field_error(bool allow_unpolished)
      {
        if ((!allow_unpolished) && !(hasSpokenResponse()))
          {
            return "When parsing the object for %what%, the \"SpokenResponse\" field was missing.";
          }
        if ((!allow_unpolished) && !(hasSpokenResponseLong()))
          {
            return "When parsing the object for %what%, the \"SpokenResponseLong\" field was missing.";
          }
        if ((!allow_unpolished) && !(hasWrittenResponse()))
          {
            return "When parsing the object for %what%, the \"WrittenResponse\" field was missing.";
          }
        if ((!allow_unpolished) && !(hasWrittenResponseLong()))
          {
            return "When parsing the object for %what%, the \"WrittenResponseLong\" field was missing.";
          }
        if (!(hasViewType()))
          {
            return "When parsing the object for %what%, the \"ViewType\" field was missing.";
          }
        return null;
      }

    public static CommandResultJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CommandResultJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CommandResult", ignore_extras);
            generator.set_allow_incomplete(allow_incomplete);
            generator.set_allow_unpolished(allow_unpolished);
            if (allow_incomplete || allow_unpolished)
                json_value.write(generator);
            else
                json_value.write(generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static CommandResultJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static CommandResultJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CommandResultJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CommandResult", ignore_extras);
            generator.set_allow_incomplete(allow_incomplete);
            generator.set_allow_unpolished(allow_unpolished);
            if (allow_incomplete || allow_unpolished)
                json_value.write_partial_as_json(generator);
            else
                json_value.write_as_json(generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static CommandResultJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static CommandResultJSON from_text(string text, bool ignore_extras)
      {
        CommandResultJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CommandResult", ignore_extras);
            JSONParse.parse_json_value(text, "Text for CommandResultJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static CommandResultJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        CommandResultJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CommandResult", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorSpokenResponse;
        private JSONHoldingStringGenerator fieldGeneratorSpokenResponseLong;
        private JSONHoldingStringGenerator fieldGeneratorWrittenResponse;
        private JSONHoldingStringGenerator fieldGeneratorWrittenResponseLong;
        private JSONHoldingStringGenerator fieldGeneratorSpokenResponseSSML;
        private JSONHoldingStringGenerator fieldGeneratorSpokenResponseSSMLLong;
        private JSONHoldingBooleanGenerator fieldGeneratorAutoListen;
        private JSONHoldingStringGenerator fieldGeneratorUserVisibleMode;
        private JSONHoldingBooleanGenerator fieldGeneratorIsRepeat;
        private InformationNuggetJSON.HoldingArrayGenerator fieldGeneratorAdditionalInformation;
        private ConversationStateJSON.HoldingGenerator fieldGeneratorConversationState;
    private abstract class FieldGeneratorViewType : JSONStringGenerator
          {
            protected FieldGeneratorViewType(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorViewType()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToViewType(result));
              }
            protected abstract void handle_result(TypeViewType result);
          };
    private class FieldHoldingGeneratorViewType : FieldGeneratorViewType
  {
    protected override void handle_result(TypeViewType result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorViewType(String what)
      {
        have_value = false;
        base.set_what(what);
      }

    public override void reset()
      {
        have_value = false;
        base.reset();
      }

    public bool have_value;
    public TypeViewType value;
  };
    private class FieldHoldingArrayGeneratorViewType : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorViewType
      {
        private FieldHoldingArrayGeneratorViewType top;

        protected override void handle_result(TypeViewType result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorViewType init_top)
          {
            top = init_top;
          }
      };

    private ElementHandler element_handler;

    protected override JSONHandler start()
      {
        have_value = true;
        value.Clear();
        return element_handler;
      }
    protected override void finish()
      {
        Debug.Assert(have_value);
        handle_result(value);
        element_handler.reset();
      }
    protected virtual void handle_result(List<TypeViewType> result)
      {
      }

    public FieldHoldingArrayGeneratorViewType(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeViewType>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorViewType()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeViewType>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeViewType> value;
  };
        private FieldHoldingArrayGeneratorViewType fieldGeneratorViewType;
        private JSONHoldingStringGenerator fieldGeneratorTemplateName;
        private TemplateJSON.HoldingGenerator fieldGeneratorTemplateData;
        private TemplateJSON.HoldingGenerator fieldGeneratorCombiningTemplateData;
        private PreviewJSON.HoldingGenerator fieldGeneratorPreview;
        private HTMLDataJSON.HoldingGenerator fieldGeneratorHTMLData;
        private HintsJSON.HoldingGenerator fieldGeneratorHints;
        private EmotionJSON.HoldingGenerator fieldGeneratorEmotion;
        private IconJSON.HoldingGenerator fieldGeneratorIcon;
        private JSONHoldingStringGenerator fieldGeneratorResponseAudioBytes;
        private JSONHoldingStringGenerator fieldGeneratorResponseAudioURL;
    private abstract class FieldGeneratorResponseAudioEncoding : JSONStringGenerator
          {
            protected FieldGeneratorResponseAudioEncoding(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorResponseAudioEncoding()
              {
              }
            protected override void handle_result(string result)
              {
                TypeResponseAudioEncodingKnownValues known = stringToResponseAudioEncoding(result);
                TypeResponseAudioEncoding new_value = new TypeResponseAudioEncoding();
                if (known == TypeResponseAudioEncodingKnownValues.ResponseAudioEncoding__none)
                  {
                    new_value.in_known_list = false;
                    new_value.string_value = result;
                  }
                else
                  {
                    new_value.in_known_list = true;
                    new_value.list_value = known;
                  }
                handle_result(new_value);
              }
            protected abstract void handle_result(TypeResponseAudioEncoding result);
          };
    private class FieldHoldingGeneratorResponseAudioEncoding : FieldGeneratorResponseAudioEncoding
  {
    protected override void handle_result(TypeResponseAudioEncoding result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorResponseAudioEncoding(String what)
      {
        have_value = false;
        base.set_what(what);
      }

    public override void reset()
      {
        have_value = false;
        base.reset();
      }

    public bool have_value;
    public TypeResponseAudioEncoding value;
  };
    private class FieldHoldingArrayGeneratorResponseAudioEncoding : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorResponseAudioEncoding
      {
        private FieldHoldingArrayGeneratorResponseAudioEncoding top;

        protected override void handle_result(TypeResponseAudioEncoding result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorResponseAudioEncoding init_top)
          {
            top = init_top;
          }
      };

    private ElementHandler element_handler;

    protected override JSONHandler start()
      {
        have_value = true;
        value.Clear();
        return element_handler;
      }
    protected override void finish()
      {
        Debug.Assert(have_value);
        handle_result(value);
        element_handler.reset();
      }
    protected virtual void handle_result(List<TypeResponseAudioEncoding> result)
      {
      }

    public FieldHoldingArrayGeneratorResponseAudioEncoding(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeResponseAudioEncoding>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorResponseAudioEncoding()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeResponseAudioEncoding>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeResponseAudioEncoding> value;
  };
        private FieldHoldingGeneratorResponseAudioEncoding fieldGeneratorResponseAudioEncoding;
        private JSONHoldingStringGenerator fieldGeneratorResponseAudioError;
        private JSONHoldingStringArrayGenerator fieldGeneratorResponseAudioDiagnostics;
        private JSONHoldingStringArrayGenerator fieldGeneratorOutputOverrideDiagnostics;
        private JSONHoldingStringArrayGenerator fieldGeneratorUploadedTerrierDiagnostics;
        private JSONHoldingStringArrayGenerator fieldGeneratorRequiredFeatures;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorClientActionSucceededResult;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorClientActionFailedResult;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorRequiredFeaturesSupportedResult;
        private JSONHoldingValueGenerator fieldGeneratorSendBack;
        private JSONHoldingNumberTextGenerator fieldGeneratorUnderstandingConfidence;
        private JSONHoldingStringGenerator fieldGeneratorErrorType;
        private CommandErrorJSON.HoldingGenerator fieldGeneratorErrorData;
        private class UnknownFieldGenerator : JSONValueHandler
          {
            public bool ignore;
            public List<string> field_names;
            public List<JSONValue > field_values;
            public Dictionary<string, JSONValue > index;
            public UnknownFieldGenerator(bool init_ignore)
              {
                ignore = init_ignore;
                field_names = new List<string>();
                field_values = new List<JSONValue >();
            index = new Dictionary<string, JSONValue >();
              }

            protected override void new_value(JSONValue item)
              {
                if (ignore)
                    return;
                Debug.Assert(field_names.Count == (field_values.Count + 1));
                index.Add(field_names[field_values.Count], item);
                field_values.Add(item);
              }
            public override void reset()
              {
                field_names.Clear();
                field_values.Clear();
            index = new Dictionary<string, JSONValue >();
              }
          };
        private UnknownFieldGenerator unknownFieldGenerator;
        private JSONHoldingStringGenerator keyGenerator;

        protected bool allow_incomplete;

        protected bool allow_unpolished;

        protected override void start()
          {
          }
        protected override JSONHandler start_field(string field_name)
          {
            JSONHandler result = start_known_field(field_name);
            if (result != null)
                return result;
            Debug.Assert(unknownFieldGenerator.field_names.Count ==
                   unknownFieldGenerator.field_values.Count);
            if (unknownFieldGenerator.ignore)
              {
                Debug.Assert(unknownFieldGenerator.field_names.Count == 0);
              }
            else
              {
                unknownFieldGenerator.field_names.Add(field_name);
              }
            return unknownFieldGenerator;
          }
        protected override void finish_field(string field_name, JSONHandler field_handler)
          {
          }
        protected override void finish()
          {
            if (!(keyGenerator.have_value))
                throw new Exception("The `CommandKind' field is missing.");
            CommandResultJSON result = createForKey(keyGenerator.value, unknownFieldGenerator.index);
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraCommandResultAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            if (!allow_incomplete)
              {
                string missing_field_error = result.missing_field_error(allow_unpolished);
                if (missing_field_error != null)
                    error(missing_field_error);
              }
            handle_result(result);
          }
        protected string getCommandResultJSONKey()
          {
            if (!(keyGenerator.have_value))
                throw new Exception("The `CommandKind' field is missing.");
            return keyGenerator.value;
          }
        protected void finish(CommandResultJSON result)
          {
            if (fieldGeneratorSpokenResponse.have_value)
              {
                result.setSpokenResponse(fieldGeneratorSpokenResponse.value);
                fieldGeneratorSpokenResponse.have_value = false;
              }
            else if ((!(result.hasSpokenResponse())) && (!allow_unpolished) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"SpokenResponse\" field was missing.");
              }
            if (fieldGeneratorSpokenResponseLong.have_value)
              {
                result.setSpokenResponseLong(fieldGeneratorSpokenResponseLong.value);
                fieldGeneratorSpokenResponseLong.have_value = false;
              }
            else if ((!(result.hasSpokenResponseLong())) && (!allow_unpolished) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"SpokenResponseLong\" field was missing.");
              }
            if (fieldGeneratorWrittenResponse.have_value)
              {
                result.setWrittenResponse(fieldGeneratorWrittenResponse.value);
                fieldGeneratorWrittenResponse.have_value = false;
              }
            else if ((!(result.hasWrittenResponse())) && (!allow_unpolished) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"WrittenResponse\" field was missing.");
              }
            if (fieldGeneratorWrittenResponseLong.have_value)
              {
                result.setWrittenResponseLong(fieldGeneratorWrittenResponseLong.value);
                fieldGeneratorWrittenResponseLong.have_value = false;
              }
            else if ((!(result.hasWrittenResponseLong())) && (!allow_unpolished) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"WrittenResponseLong\" field was missing.");
              }
            if (fieldGeneratorSpokenResponseSSML.have_value)
              {
                result.setSpokenResponseSSML(fieldGeneratorSpokenResponseSSML.value);
                fieldGeneratorSpokenResponseSSML.have_value = false;
              }
            if (fieldGeneratorSpokenResponseSSMLLong.have_value)
              {
                result.setSpokenResponseSSMLLong(fieldGeneratorSpokenResponseSSMLLong.value);
                fieldGeneratorSpokenResponseSSMLLong.have_value = false;
              }
            if (fieldGeneratorAutoListen.have_value)
              {
                result.setAutoListen(fieldGeneratorAutoListen.value);
                fieldGeneratorAutoListen.have_value = false;
              }
            if (fieldGeneratorUserVisibleMode.have_value)
              {
                result.setUserVisibleMode(fieldGeneratorUserVisibleMode.value);
                fieldGeneratorUserVisibleMode.have_value = false;
              }
            if (fieldGeneratorIsRepeat.have_value)
              {
                result.setIsRepeat(fieldGeneratorIsRepeat.value);
                fieldGeneratorIsRepeat.have_value = false;
              }
            if (fieldGeneratorAdditionalInformation.have_value)
              {
                result.initAdditionalInformation();
                int count = fieldGeneratorAdditionalInformation.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendAdditionalInformation(fieldGeneratorAdditionalInformation.value[num]);
                  }
                fieldGeneratorAdditionalInformation.value.Clear();
                fieldGeneratorAdditionalInformation.have_value = false;
              }
            if (fieldGeneratorConversationState.have_value)
              {
                result.setConversationState(fieldGeneratorConversationState.value);
                fieldGeneratorConversationState.have_value = false;
              }
            if (fieldGeneratorViewType.have_value)
              {
                result.initViewType();
                int count = fieldGeneratorViewType.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendViewType(fieldGeneratorViewType.value[num]);
                  }
                fieldGeneratorViewType.value.Clear();
                fieldGeneratorViewType.have_value = false;
              }
            else if ((!(result.hasViewType())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ViewType\" field was missing.");
              }
            if (fieldGeneratorTemplateName.have_value)
              {
                result.setTemplateName(fieldGeneratorTemplateName.value);
                fieldGeneratorTemplateName.have_value = false;
              }
            if (fieldGeneratorTemplateData.have_value)
              {
                result.setTemplateData(fieldGeneratorTemplateData.value);
                fieldGeneratorTemplateData.have_value = false;
              }
            if (fieldGeneratorCombiningTemplateData.have_value)
              {
                result.setCombiningTemplateData(fieldGeneratorCombiningTemplateData.value);
                fieldGeneratorCombiningTemplateData.have_value = false;
              }
            if (fieldGeneratorPreview.have_value)
              {
                result.setPreview(fieldGeneratorPreview.value);
                fieldGeneratorPreview.have_value = false;
              }
            if (fieldGeneratorHTMLData.have_value)
              {
                result.setHTMLData(fieldGeneratorHTMLData.value);
                fieldGeneratorHTMLData.have_value = false;
              }
            if (fieldGeneratorHints.have_value)
              {
                result.setHints(fieldGeneratorHints.value);
                fieldGeneratorHints.have_value = false;
              }
            if (fieldGeneratorEmotion.have_value)
              {
                result.setEmotion(fieldGeneratorEmotion.value);
                fieldGeneratorEmotion.have_value = false;
              }
            if (fieldGeneratorIcon.have_value)
              {
                result.setIcon(fieldGeneratorIcon.value);
                fieldGeneratorIcon.have_value = false;
              }
            if (fieldGeneratorResponseAudioBytes.have_value)
              {
                result.setResponseAudioBytes(fieldGeneratorResponseAudioBytes.value);
                fieldGeneratorResponseAudioBytes.have_value = false;
              }
            if (fieldGeneratorResponseAudioURL.have_value)
              {
                result.setResponseAudioURL(fieldGeneratorResponseAudioURL.value);
                fieldGeneratorResponseAudioURL.have_value = false;
              }
            if (fieldGeneratorResponseAudioEncoding.have_value)
              {
                result.setResponseAudioEncoding(fieldGeneratorResponseAudioEncoding.value);
                fieldGeneratorResponseAudioEncoding.have_value = false;
              }
            if (fieldGeneratorResponseAudioError.have_value)
              {
                result.setResponseAudioError(fieldGeneratorResponseAudioError.value);
                fieldGeneratorResponseAudioError.have_value = false;
              }
            if (fieldGeneratorResponseAudioDiagnostics.have_value)
              {
                result.initResponseAudioDiagnostics();
                int count = fieldGeneratorResponseAudioDiagnostics.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendResponseAudioDiagnostics(fieldGeneratorResponseAudioDiagnostics.value[num]);
                  }
                fieldGeneratorResponseAudioDiagnostics.value.Clear();
                fieldGeneratorResponseAudioDiagnostics.have_value = false;
              }
            if (fieldGeneratorOutputOverrideDiagnostics.have_value)
              {
                result.initOutputOverrideDiagnostics();
                int count = fieldGeneratorOutputOverrideDiagnostics.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendOutputOverrideDiagnostics(fieldGeneratorOutputOverrideDiagnostics.value[num]);
                  }
                fieldGeneratorOutputOverrideDiagnostics.value.Clear();
                fieldGeneratorOutputOverrideDiagnostics.have_value = false;
              }
            if (fieldGeneratorUploadedTerrierDiagnostics.have_value)
              {
                result.initUploadedTerrierDiagnostics();
                int count = fieldGeneratorUploadedTerrierDiagnostics.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendUploadedTerrierDiagnostics(fieldGeneratorUploadedTerrierDiagnostics.value[num]);
                  }
                fieldGeneratorUploadedTerrierDiagnostics.value.Clear();
                fieldGeneratorUploadedTerrierDiagnostics.have_value = false;
              }
            if (fieldGeneratorRequiredFeatures.have_value)
              {
                result.initRequiredFeatures();
                int count = fieldGeneratorRequiredFeatures.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendRequiredFeatures(fieldGeneratorRequiredFeatures.value[num]);
                  }
                fieldGeneratorRequiredFeatures.value.Clear();
                fieldGeneratorRequiredFeatures.have_value = false;
              }
            if (fieldGeneratorClientActionSucceededResult.have_value)
              {
                result.setClientActionSucceededResult(fieldGeneratorClientActionSucceededResult.value);
                fieldGeneratorClientActionSucceededResult.have_value = false;
              }
            if (fieldGeneratorClientActionFailedResult.have_value)
              {
                result.setClientActionFailedResult(fieldGeneratorClientActionFailedResult.value);
                fieldGeneratorClientActionFailedResult.have_value = false;
              }
            if (fieldGeneratorRequiredFeaturesSupportedResult.have_value)
              {
                result.setRequiredFeaturesSupportedResult(fieldGeneratorRequiredFeaturesSupportedResult.value);
                fieldGeneratorRequiredFeaturesSupportedResult.have_value = false;
              }
            if (fieldGeneratorSendBack.have_value)
              {
                result.setSendBack(fieldGeneratorSendBack.value);
                fieldGeneratorSendBack.have_value = false;
              }
            if (fieldGeneratorUnderstandingConfidence.have_value)
              {
                result.setUnderstandingConfidenceText(fieldGeneratorUnderstandingConfidence.value);
                fieldGeneratorUnderstandingConfidence.have_value = false;
              }
            if (fieldGeneratorErrorType.have_value)
              {
                result.setErrorType(fieldGeneratorErrorType.value);
                fieldGeneratorErrorType.have_value = false;
              }
            if (fieldGeneratorErrorData.have_value)
              {
                result.setErrorData(fieldGeneratorErrorData.value);
                fieldGeneratorErrorData.have_value = false;
              }
          }
        protected abstract void handle_result(CommandResultJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    switch (field_name[1])
                      {
                        case 'd':
                            if ((String.Compare(field_name, 2, "ditionalInformation", 0, 19, false) == 0) && (field_name.Length == 21))
                                return fieldGeneratorAdditionalInformation;
                            break;
                        case 'u':
                            if ((String.Compare(field_name, 2, "toListen", 0, 8, false) == 0) && (field_name.Length == 10))
                                return fieldGeneratorAutoListen;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'C':
                    switch (field_name[1])
                      {
                        case 'l':
                            if (String.Compare(field_name, 2, "ientAction", 0, 10, false) == 0)
                              {
                                switch (field_name[12])
                                  {
                                    case 'F':
                                        if ((String.Compare(field_name, 13, "ailedResult", 0, 11, false) == 0) && (field_name.Length == 24))
                                            return fieldGeneratorClientActionFailedResult;
                                        break;
                                    case 'S':
                                        if ((String.Compare(field_name, 13, "ucceededResult", 0, 14, false) == 0) && (field_name.Length == 27))
                                            return fieldGeneratorClientActionSucceededResult;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'o':
                            switch (field_name[2])
                              {
                                case 'm':
                                    switch (field_name[3])
                                      {
                                        case 'b':
                                            if ((String.Compare(field_name, 4, "iningTemplateData", 0, 17, false) == 0) && (field_name.Length == 21))
                                                return fieldGeneratorCombiningTemplateData;
                                            break;
                                        case 'm':
                                            if ((String.Compare(field_name, 4, "andKind", 0, 7, false) == 0) && (field_name.Length == 11))
                                                {
                                                keyGenerator.reset();
                                                return keyGenerator;
                                                }
                                            break;
                                        default:
                                            break;
                                      }
                                    break;
                                case 'n':
                                    if ((String.Compare(field_name, 3, "versationState", 0, 14, false) == 0) && (field_name.Length == 17))
                                        return fieldGeneratorConversationState;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'E':
                    switch (field_name[1])
                      {
                        case 'm':
                            if ((String.Compare(field_name, 2, "otion", 0, 5, false) == 0) && (field_name.Length == 7))
                                return fieldGeneratorEmotion;
                            break;
                        case 'r':
                            if (String.Compare(field_name, 2, "ror", 0, 3, false) == 0)
                              {
                                switch (field_name[5])
                                  {
                                    case 'D':
                                        if ((String.Compare(field_name, 6, "ata", 0, 3, false) == 0) && (field_name.Length == 9))
                                            return fieldGeneratorErrorData;
                                        break;
                                    case 'T':
                                        if ((String.Compare(field_name, 6, "ype", 0, 3, false) == 0) && (field_name.Length == 9))
                                            return fieldGeneratorErrorType;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'H':
                    switch (field_name[1])
                      {
                        case 'T':
                            if ((String.Compare(field_name, 2, "MLData", 0, 6, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorHTMLData;
                            break;
                        case 'i':
                            if ((String.Compare(field_name, 2, "nts", 0, 3, false) == 0) && (field_name.Length == 5))
                                return fieldGeneratorHints;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'I':
                    switch (field_name[1])
                      {
                        case 'c':
                            if ((String.Compare(field_name, 2, "on", 0, 2, false) == 0) && (field_name.Length == 4))
                                return fieldGeneratorIcon;
                            break;
                        case 's':
                            if ((String.Compare(field_name, 2, "Repeat", 0, 6, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorIsRepeat;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'O':
                    if ((String.Compare(field_name, 1, "utputOverrideDiagnostics", 0, 24, false) == 0) && (field_name.Length == 25))
                        return fieldGeneratorOutputOverrideDiagnostics;
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "review", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorPreview;
                    break;
                case 'R':
                    if (String.Compare(field_name, 1, "e", 0, 1, false) == 0)
                      {
                        switch (field_name[2])
                          {
                            case 'q':
                                if (String.Compare(field_name, 3, "uiredFeatures", 0, 13, false) == 0)
                                  {
                                    if (field_name.Length == 16)
                                      {
                                        return fieldGeneratorRequiredFeatures;
                                      }
                                    switch (field_name[16])
                                      {
                                        case 'S':
                                            if ((String.Compare(field_name, 17, "upportedResult", 0, 14, false) == 0) && (field_name.Length == 31))
                                                return fieldGeneratorRequiredFeaturesSupportedResult;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 's':
                                if (String.Compare(field_name, 3, "ponseAudio", 0, 10, false) == 0)
                                  {
                                    switch (field_name[13])
                                      {
                                        case 'B':
                                            if ((String.Compare(field_name, 14, "ytes", 0, 4, false) == 0) && (field_name.Length == 18))
                                                return fieldGeneratorResponseAudioBytes;
                                            break;
                                        case 'D':
                                            if ((String.Compare(field_name, 14, "iagnostics", 0, 10, false) == 0) && (field_name.Length == 24))
                                                return fieldGeneratorResponseAudioDiagnostics;
                                            break;
                                        case 'E':
                                            switch (field_name[14])
                                              {
                                                case 'n':
                                                    if ((String.Compare(field_name, 15, "coding", 0, 6, false) == 0) && (field_name.Length == 21))
                                                        return fieldGeneratorResponseAudioEncoding;
                                                    break;
                                                case 'r':
                                                    if ((String.Compare(field_name, 15, "ror", 0, 3, false) == 0) && (field_name.Length == 18))
                                                        return fieldGeneratorResponseAudioError;
                                                    break;
                                                default:
                                                    break;
                                              }
                                            break;
                                        case 'U':
                                            if ((String.Compare(field_name, 14, "RL", 0, 2, false) == 0) && (field_name.Length == 16))
                                                return fieldGeneratorResponseAudioURL;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'S':
                    switch (field_name[1])
                      {
                        case 'e':
                            if ((String.Compare(field_name, 2, "ndBack", 0, 6, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorSendBack;
                            break;
                        case 'p':
                            if (String.Compare(field_name, 2, "okenResponse", 0, 12, false) == 0)
                              {
                                if (field_name.Length == 14)
                                  {
                                    return fieldGeneratorSpokenResponse;
                                  }
                                switch (field_name[14])
                                  {
                                    case 'L':
                                        if ((String.Compare(field_name, 15, "ong", 0, 3, false) == 0) && (field_name.Length == 18))
                                            return fieldGeneratorSpokenResponseLong;
                                        break;
                                    case 'S':
                                        if (String.Compare(field_name, 15, "SML", 0, 3, false) == 0)
                                          {
                                            if (field_name.Length == 18)
                                              {
                                                return fieldGeneratorSpokenResponseSSML;
                                              }
                                            switch (field_name[18])
                                              {
                                                case 'L':
                                                    if ((String.Compare(field_name, 19, "ong", 0, 3, false) == 0) && (field_name.Length == 22))
                                                        return fieldGeneratorSpokenResponseSSMLLong;
                                                    break;
                                                default:
                                                    break;
                                              }
                                          }
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'T':
                    if (String.Compare(field_name, 1, "emplate", 0, 7, false) == 0)
                      {
                        switch (field_name[8])
                          {
                            case 'D':
                                if ((String.Compare(field_name, 9, "ata", 0, 3, false) == 0) && (field_name.Length == 12))
                                    return fieldGeneratorTemplateData;
                                break;
                            case 'N':
                                if ((String.Compare(field_name, 9, "ame", 0, 3, false) == 0) && (field_name.Length == 12))
                                    return fieldGeneratorTemplateName;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'U':
                    switch (field_name[1])
                      {
                        case 'n':
                            if ((String.Compare(field_name, 2, "derstandingConfidence", 0, 21, false) == 0) && (field_name.Length == 23))
                                return fieldGeneratorUnderstandingConfidence;
                            break;
                        case 'p':
                            if ((String.Compare(field_name, 2, "loadedTerrierDiagnostics", 0, 24, false) == 0) && (field_name.Length == 26))
                                return fieldGeneratorUploadedTerrierDiagnostics;
                            break;
                        case 's':
                            if ((String.Compare(field_name, 2, "erVisibleMode", 0, 13, false) == 0) && (field_name.Length == 15))
                                return fieldGeneratorUserVisibleMode;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'V':
                    if ((String.Compare(field_name, 1, "iewType", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorViewType;
                    break;
                case 'W':
                    if (String.Compare(field_name, 1, "rittenResponse", 0, 14, false) == 0)
                      {
                        if (field_name.Length == 15)
                          {
                            return fieldGeneratorWrittenResponse;
                          }
                        switch (field_name[15])
                          {
                            case 'L':
                                if ((String.Compare(field_name, 16, "ong", 0, 3, false) == 0) && (field_name.Length == 19))
                                    return fieldGeneratorWrittenResponseLong;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorSpokenResponse = new JSONHoldingStringGenerator("field \"SpokenResponse\" of the CommandResult class");
            fieldGeneratorSpokenResponseLong = new JSONHoldingStringGenerator("field \"SpokenResponseLong\" of the CommandResult class");
            fieldGeneratorWrittenResponse = new JSONHoldingStringGenerator("field \"WrittenResponse\" of the CommandResult class");
            fieldGeneratorWrittenResponseLong = new JSONHoldingStringGenerator("field \"WrittenResponseLong\" of the CommandResult class");
            fieldGeneratorSpokenResponseSSML = new JSONHoldingStringGenerator("field \"SpokenResponseSSML\" of the CommandResult class");
            fieldGeneratorSpokenResponseSSMLLong = new JSONHoldingStringGenerator("field \"SpokenResponseSSMLLong\" of the CommandResult class");
            fieldGeneratorAutoListen = new JSONHoldingBooleanGenerator("field \"AutoListen\" of the CommandResult class");
            fieldGeneratorUserVisibleMode = new JSONHoldingStringGenerator("field \"UserVisibleMode\" of the CommandResult class");
            fieldGeneratorIsRepeat = new JSONHoldingBooleanGenerator("field \"IsRepeat\" of the CommandResult class");
            fieldGeneratorAdditionalInformation = new InformationNuggetJSON.HoldingArrayGenerator("field \"AdditionalInformation\" of the CommandResult class", ignore_extras);
            fieldGeneratorConversationState = new ConversationStateJSON.HoldingGenerator("field \"ConversationState\" of the CommandResult class", ignore_extras);
            fieldGeneratorViewType = new FieldHoldingArrayGeneratorViewType("field \"ViewType\" of the CommandResult class");
            fieldGeneratorTemplateName = new JSONHoldingStringGenerator("field \"TemplateName\" of the CommandResult class");
            fieldGeneratorTemplateData = new TemplateJSON.HoldingGenerator("field \"TemplateData\" of the CommandResult class", ignore_extras);
            fieldGeneratorCombiningTemplateData = new TemplateJSON.HoldingGenerator("field \"CombiningTemplateData\" of the CommandResult class", ignore_extras);
            fieldGeneratorPreview = new PreviewJSON.HoldingGenerator("field \"Preview\" of the CommandResult class", ignore_extras);
            fieldGeneratorHTMLData = new HTMLDataJSON.HoldingGenerator("field \"HTMLData\" of the CommandResult class", ignore_extras);
            fieldGeneratorHints = new HintsJSON.HoldingGenerator("field \"Hints\" of the CommandResult class", ignore_extras);
            fieldGeneratorEmotion = new EmotionJSON.HoldingGenerator("field \"Emotion\" of the CommandResult class", ignore_extras);
            fieldGeneratorIcon = new IconJSON.HoldingGenerator("field \"Icon\" of the CommandResult class", ignore_extras);
            fieldGeneratorResponseAudioBytes = new JSONHoldingStringGenerator("field \"ResponseAudioBytes\" of the CommandResult class");
            fieldGeneratorResponseAudioURL = new JSONHoldingStringGenerator("field \"ResponseAudioURL\" of the CommandResult class");
            fieldGeneratorResponseAudioEncoding = new FieldHoldingGeneratorResponseAudioEncoding("field \"ResponseAudioEncoding\" of the CommandResult class");
            fieldGeneratorResponseAudioError = new JSONHoldingStringGenerator("field \"ResponseAudioError\" of the CommandResult class");
            fieldGeneratorResponseAudioDiagnostics = new JSONHoldingStringArrayGenerator("field \"ResponseAudioDiagnostics\" of the CommandResult class");
            fieldGeneratorOutputOverrideDiagnostics = new JSONHoldingStringArrayGenerator("field \"OutputOverrideDiagnostics\" of the CommandResult class");
            fieldGeneratorUploadedTerrierDiagnostics = new JSONHoldingStringArrayGenerator("field \"UploadedTerrierDiagnostics\" of the CommandResult class");
            fieldGeneratorRequiredFeatures = new JSONHoldingStringArrayGenerator("field \"RequiredFeatures\" of the CommandResult class");
            fieldGeneratorClientActionSucceededResult = new DynamicResponseJSON.HoldingGenerator("field \"ClientActionSucceededResult\" of the CommandResult class", ignore_extras);
            fieldGeneratorClientActionFailedResult = new DynamicResponseJSON.HoldingGenerator("field \"ClientActionFailedResult\" of the CommandResult class", ignore_extras);
            fieldGeneratorRequiredFeaturesSupportedResult = new DynamicResponseJSON.HoldingGenerator("field \"RequiredFeaturesSupportedResult\" of the CommandResult class", ignore_extras);
            fieldGeneratorSendBack = new JSONHoldingValueGenerator("field \"SendBack\" of the CommandResult class");
            fieldGeneratorUnderstandingConfidence = new JSONHoldingNumberTextGenerator("field \"UnderstandingConfidence\" of the CommandResult class");
            fieldGeneratorErrorType = new JSONHoldingStringGenerator("field \"ErrorType\" of the CommandResult class");
            fieldGeneratorErrorData = new CommandErrorJSON.HoldingGenerator("field \"ErrorData\" of the CommandResult class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            keyGenerator = new JSONHoldingStringGenerator("key field \"CommandKind\" of the CommandResult class");
            set_what("the CommandResult class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorSpokenResponse = new JSONHoldingStringGenerator("field \"SpokenResponse\" of the CommandResult class");
            fieldGeneratorSpokenResponseLong = new JSONHoldingStringGenerator("field \"SpokenResponseLong\" of the CommandResult class");
            fieldGeneratorWrittenResponse = new JSONHoldingStringGenerator("field \"WrittenResponse\" of the CommandResult class");
            fieldGeneratorWrittenResponseLong = new JSONHoldingStringGenerator("field \"WrittenResponseLong\" of the CommandResult class");
            fieldGeneratorSpokenResponseSSML = new JSONHoldingStringGenerator("field \"SpokenResponseSSML\" of the CommandResult class");
            fieldGeneratorSpokenResponseSSMLLong = new JSONHoldingStringGenerator("field \"SpokenResponseSSMLLong\" of the CommandResult class");
            fieldGeneratorAutoListen = new JSONHoldingBooleanGenerator("field \"AutoListen\" of the CommandResult class");
            fieldGeneratorUserVisibleMode = new JSONHoldingStringGenerator("field \"UserVisibleMode\" of the CommandResult class");
            fieldGeneratorIsRepeat = new JSONHoldingBooleanGenerator("field \"IsRepeat\" of the CommandResult class");
            fieldGeneratorAdditionalInformation = new InformationNuggetJSON.HoldingArrayGenerator("field \"AdditionalInformation\" of the CommandResult class", false);
            fieldGeneratorConversationState = new ConversationStateJSON.HoldingGenerator("field \"ConversationState\" of the CommandResult class", false);
            fieldGeneratorViewType = new FieldHoldingArrayGeneratorViewType("field \"ViewType\" of the CommandResult class");
            fieldGeneratorTemplateName = new JSONHoldingStringGenerator("field \"TemplateName\" of the CommandResult class");
            fieldGeneratorTemplateData = new TemplateJSON.HoldingGenerator("field \"TemplateData\" of the CommandResult class", false);
            fieldGeneratorCombiningTemplateData = new TemplateJSON.HoldingGenerator("field \"CombiningTemplateData\" of the CommandResult class", false);
            fieldGeneratorPreview = new PreviewJSON.HoldingGenerator("field \"Preview\" of the CommandResult class", false);
            fieldGeneratorHTMLData = new HTMLDataJSON.HoldingGenerator("field \"HTMLData\" of the CommandResult class", false);
            fieldGeneratorHints = new HintsJSON.HoldingGenerator("field \"Hints\" of the CommandResult class", false);
            fieldGeneratorEmotion = new EmotionJSON.HoldingGenerator("field \"Emotion\" of the CommandResult class", false);
            fieldGeneratorIcon = new IconJSON.HoldingGenerator("field \"Icon\" of the CommandResult class", false);
            fieldGeneratorResponseAudioBytes = new JSONHoldingStringGenerator("field \"ResponseAudioBytes\" of the CommandResult class");
            fieldGeneratorResponseAudioURL = new JSONHoldingStringGenerator("field \"ResponseAudioURL\" of the CommandResult class");
            fieldGeneratorResponseAudioEncoding = new FieldHoldingGeneratorResponseAudioEncoding("field \"ResponseAudioEncoding\" of the CommandResult class");
            fieldGeneratorResponseAudioError = new JSONHoldingStringGenerator("field \"ResponseAudioError\" of the CommandResult class");
            fieldGeneratorResponseAudioDiagnostics = new JSONHoldingStringArrayGenerator("field \"ResponseAudioDiagnostics\" of the CommandResult class");
            fieldGeneratorOutputOverrideDiagnostics = new JSONHoldingStringArrayGenerator("field \"OutputOverrideDiagnostics\" of the CommandResult class");
            fieldGeneratorUploadedTerrierDiagnostics = new JSONHoldingStringArrayGenerator("field \"UploadedTerrierDiagnostics\" of the CommandResult class");
            fieldGeneratorRequiredFeatures = new JSONHoldingStringArrayGenerator("field \"RequiredFeatures\" of the CommandResult class");
            fieldGeneratorClientActionSucceededResult = new DynamicResponseJSON.HoldingGenerator("field \"ClientActionSucceededResult\" of the CommandResult class", false);
            fieldGeneratorClientActionFailedResult = new DynamicResponseJSON.HoldingGenerator("field \"ClientActionFailedResult\" of the CommandResult class", false);
            fieldGeneratorRequiredFeaturesSupportedResult = new DynamicResponseJSON.HoldingGenerator("field \"RequiredFeaturesSupportedResult\" of the CommandResult class", false);
            fieldGeneratorSendBack = new JSONHoldingValueGenerator("field \"SendBack\" of the CommandResult class");
            fieldGeneratorUnderstandingConfidence = new JSONHoldingNumberTextGenerator("field \"UnderstandingConfidence\" of the CommandResult class");
            fieldGeneratorErrorType = new JSONHoldingStringGenerator("field \"ErrorType\" of the CommandResult class");
            fieldGeneratorErrorData = new CommandErrorJSON.HoldingGenerator("field \"ErrorData\" of the CommandResult class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            keyGenerator = new JSONHoldingStringGenerator("key field \"CommandKind\" of the CommandResult class");
            set_what("the CommandResult class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorSpokenResponse.reset();
            fieldGeneratorSpokenResponseLong.reset();
            fieldGeneratorWrittenResponse.reset();
            fieldGeneratorWrittenResponseLong.reset();
            fieldGeneratorSpokenResponseSSML.reset();
            fieldGeneratorSpokenResponseSSMLLong.reset();
            fieldGeneratorAutoListen.reset();
            fieldGeneratorUserVisibleMode.reset();
            fieldGeneratorIsRepeat.reset();
            fieldGeneratorAdditionalInformation.reset();
            fieldGeneratorConversationState.reset();
            fieldGeneratorViewType.reset();
            fieldGeneratorTemplateName.reset();
            fieldGeneratorTemplateData.reset();
            fieldGeneratorCombiningTemplateData.reset();
            fieldGeneratorPreview.reset();
            fieldGeneratorHTMLData.reset();
            fieldGeneratorHints.reset();
            fieldGeneratorEmotion.reset();
            fieldGeneratorIcon.reset();
            fieldGeneratorResponseAudioBytes.reset();
            fieldGeneratorResponseAudioURL.reset();
            fieldGeneratorResponseAudioEncoding.reset();
            fieldGeneratorResponseAudioError.reset();
            fieldGeneratorResponseAudioDiagnostics.reset();
            fieldGeneratorOutputOverrideDiagnostics.reset();
            fieldGeneratorUploadedTerrierDiagnostics.reset();
            fieldGeneratorRequiredFeatures.reset();
            fieldGeneratorClientActionSucceededResult.reset();
            fieldGeneratorClientActionFailedResult.reset();
            fieldGeneratorRequiredFeaturesSupportedResult.reset();
            fieldGeneratorSendBack.reset();
            fieldGeneratorUnderstandingConfidence.reset();
            fieldGeneratorErrorType.reset();
            fieldGeneratorErrorData.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorAdditionalInformation.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorConversationState.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorTemplateData.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorCombiningTemplateData.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorPreview.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorHTMLData.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorHints.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorEmotion.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorIcon.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorClientActionSucceededResult.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorClientActionFailedResult.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorRequiredFeaturesSupportedResult.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorErrorData.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorAdditionalInformation.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorConversationState.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorTemplateData.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorCombiningTemplateData.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorPreview.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorHTMLData.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorHints.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorEmotion.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorIcon.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorClientActionSucceededResult.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorClientActionFailedResult.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorRequiredFeaturesSupportedResult.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorErrorData.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(CommandResultJSON  result)
          {
//@@@            Debug.Assert(!have_value);
            have_value = true;
            value = result;
          }

        public HoldingGenerator(String what, bool ignore_extras) : base(ignore_extras)
          {
            have_value = false;
            base.set_what(what);
          }

        public HoldingGenerator(String what) : base(false)
          {
            have_value = false;
            base.set_what(what);
          }

        public override void reset()
          {
            have_value = false;
            base.reset();
          }

        public bool have_value;
        public CommandResultJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(CommandResultJSON  result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(HoldingArrayGenerator init_top, bool ignore_extras) : base(ignore_extras)
          {
            top = init_top;
          }
      };

    private ElementHandler element_handler;

    protected override JSONHandler start()
      {
        have_value = true;
        value.Clear();
        return element_handler;
      }
    protected override void finish()
      {
        Debug.Assert(have_value);
        handle_result(value);
        element_handler.reset();
      }
    protected virtual void handle_result(List<CommandResultJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<CommandResultJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<CommandResultJSON>();
        have_value = false;
      }

    public void set_allow_incomplete(bool new_allow_incomplete)
      {
        element_handler.set_allow_incomplete(new_allow_incomplete);
      }

    public void set_allow_unpolished(bool new_allow_unpolished)
      {
        element_handler.set_allow_unpolished(new_allow_unpolished);
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<CommandResultJSON> value;
  };
    class GenericCommandResultJSON : CommandResultJSON
      {
        private string key;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;
        public GenericCommandResultJSON(string init_key)
          {
            key = init_key;
            extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public override string getCommandKind()  { return key; }
        public override int extraCommandResultComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public override string extraCommandResultComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public override JSONValue extraCommandResultComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public override JSONValue extraCommandResultLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }
        public override void extraCommandResultAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public override void extraCommandResultSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraCommandResultLookup(key);
            if (old_field == null)
              {
                extraCommandResultAppendPair(key, new_component);
              }
            else
              {
                int count = extraKeys.Count;
                Debug.Assert(count == extraValues.Count);
                for (int num = 0; num < count; ++num)
                  {
                    if (extraKeys[num].Equals(key))
                      {
                        extraValues[num] = new_component;
                        break;
                      }
                  }
                extraIndex.Add(key, new_component);
              }
          }

        public override void write_as_json(JSONHandler handler)
          {
            handler.start_object();
            write_fields_as_json(handler);
            int extra_count = extraKeys.Count;
            Debug.Assert(extra_count == extraValues.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                handler.start_pair(extraKeys[extra_num]);
                extraValues[extra_num].write(handler);
              }
            handler.finish_object();
          }
        public override void write_partial_as_json(JSONHandler handler)
          {
            handler.start_object();
            write_fields_as_json(handler, true);
            int extra_count = extraKeys.Count;
            Debug.Assert(extra_count == extraValues.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                handler.start_pair(extraKeys[extra_num]);
                extraValues[extra_num].write(handler);
              }
            handler.finish_object();
          }
      };
    public static CommandResultJSON createForKey(string key, Dictionary<string, JSONValue > other_field_index)
      {
    switch (key[0])
      {
        case 'A':
            switch (key[1])
              {
                case 'g':
                    if (String.Compare(key, 2, "eCalculator", 0, 11, false) == 0)
                      {
                        switch (key[13])
                          {
                            case 'C':
                                switch (key[14])
                                  {
                                    case 'a':
                                        if ((String.Compare(key, 15, "ncelCommand", 0, 11, false) == 0) && (key.Length == 26))
                                            return new AgeCalculatorCancelCommandJSON();
                                        break;
                                    case 'o':
                                        if ((String.Compare(key, 15, "mmand", 0, 5, false) == 0) && (key.Length == 20))
                                            return new AgeCalculatorCommandJSON();
                                        break;
                                    default:
                                        break;
                                  }
                                break;
                            case 'S':
                                if ((String.Compare(key, 14, "tartCommand", 0, 11, false) == 0) && (key.Length == 25))
                                    return new AgeCalculatorStartCommandJSON();
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'l':
                    if ((String.Compare(key, 2, "armCommand", 0, 10, false) == 0) && (key.Length == 12))
                      {
                        JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("AlarmCommandKind") ? other_field_index["AlarmCommandKind"] : null));
                        if (key_value == null)
                            throw new Exception("The `AlarmCommandKind' field is missing.");
                        JSONStringValue key_string_value = key_value.string_value();
                        if (key_string_value == null)
                            throw new Exception("The `AlarmCommandKind' field has a non-string value.");
                        return AlarmCommandJSON.createForKey(key_string_value.getData(), other_field_index);
                      }
                    break;
                case 'n':
                    if ((String.Compare(key, 2, "droidAppLauncherCommand", 0, 23, false) == 0) && (key.Length == 25))
                        return new AndroidAppLauncherCommandJSON();
                    break;
                case 's':
                    if ((String.Compare(key, 2, "tronomyDistanceFromEarthCommand", 0, 31, false) == 0) && (key.Length == 33))
                        return new AstronomyDistanceFromEarthCommandJSON();
                    break;
                default:
                    break;
              }
            break;
        case 'B':
            switch (key[1])
              {
                case 'a':
                    switch (key[2])
                      {
                        case 's':
                            if ((String.Compare(key, 3, "eConverterCommand", 0, 17, false) == 0) && (key.Length == 20))
                                return new BaseConverterCommandJSON();
                            break;
                        case 't':
                            if ((String.Compare(key, 3, "tleshipCommand", 0, 14, false) == 0) && (key.Length == 17))
                              {
                                JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("BattleshipCommandKind") ? other_field_index["BattleshipCommandKind"] : null));
                                if (key_value == null)
                                    throw new Exception("The `BattleshipCommandKind' field is missing.");
                                JSONStringValue key_string_value = key_value.string_value();
                                if (key_string_value == null)
                                    throw new Exception("The `BattleshipCommandKind' field has a non-string value.");
                                return BattleshipCommandJSON.createForKey(key_string_value.getData(), other_field_index);
                              }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'l':
                    if ((String.Compare(key, 2, "ackjackCommand", 0, 14, false) == 0) && (key.Length == 16))
                      {
                        JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("BlackjackCommandKind") ? other_field_index["BlackjackCommandKind"] : null));
                        if (key_value == null)
                            throw new Exception("The `BlackjackCommandKind' field is missing.");
                        JSONStringValue key_string_value = key_value.string_value();
                        if (key_string_value == null)
                            throw new Exception("The `BlackjackCommandKind' field has a non-string value.");
                        return BlackjackCommandJSON.createForKey(key_string_value.getData(), other_field_index);
                      }
                    break;
                case 'u':
                    if (String.Compare(key, 2, "sinessInformation", 0, 17, false) == 0)
                      {
                        switch (key[19])
                          {
                            case 'Q':
                                if ((String.Compare(key, 20, "ueries", 0, 6, false) == 0) && (key.Length == 26))
                                  {
                                    JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("BusinessInformationQueriesCommandKind") ? other_field_index["BusinessInformationQueriesCommandKind"] : null));
                                    if (key_value == null)
                                        throw new Exception("The `BusinessInformationQueriesCommandKind' field is missing.");
                                    JSONStringValue key_string_value = key_value.string_value();
                                    if (key_string_value == null)
                                        throw new Exception("The `BusinessInformationQueriesCommandKind' field has a non-string value.");
                                    return BusinessInformationQueriesCommandJSON.createForKey(key_string_value.getData(), other_field_index);
                                  }
                                break;
                            case 'U':
                                if ((String.Compare(key, 20, "ploadData", 0, 9, false) == 0) && (key.Length == 29))
                                  {
                                    JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("BusinessInformationUploadDataCommandKind") ? other_field_index["BusinessInformationUploadDataCommandKind"] : null));
                                    if (key_value == null)
                                        throw new Exception("The `BusinessInformationUploadDataCommandKind' field is missing.");
                                    JSONStringValue key_string_value = key_value.string_value();
                                    if (key_string_value == null)
                                        throw new Exception("The `BusinessInformationUploadDataCommandKind' field has a non-string value.");
                                    return BusinessInformationUploadDataCommandJSON.createForKey(key_string_value.getData(), other_field_index);
                                  }
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                default:
                    break;
              }
            break;
        case 'C':
            switch (key[1])
              {
                case 'a':
                    switch (key[2])
                      {
                        case 'l':
                            if ((String.Compare(key, 3, "endarCommand", 0, 12, false) == 0) && (key.Length == 15))
                              {
                                JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("CalendarCommandKind") ? other_field_index["CalendarCommandKind"] : null));
                                if (key_value == null)
                                    throw new Exception("The `CalendarCommandKind' field is missing.");
                                JSONStringValue key_string_value = key_value.string_value();
                                if (key_string_value == null)
                                    throw new Exception("The `CalendarCommandKind' field has a non-string value.");
                                return CalendarCommandJSON.createForKey(key_string_value.getData(), other_field_index);
                              }
                            break;
                        case 'r':
                            if ((String.Compare(key, 3, "ControlCommand", 0, 14, false) == 0) && (key.Length == 17))
                              {
                                JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("CarControlCommandKind") ? other_field_index["CarControlCommandKind"] : null));
                                if (key_value == null)
                                    throw new Exception("The `CarControlCommandKind' field is missing.");
                                JSONStringValue key_string_value = key_value.string_value();
                                if (key_string_value == null)
                                    throw new Exception("The `CarControlCommandKind' field has a non-string value.");
                                return CarControlCommandJSON.createForKey(key_string_value.getData(), other_field_index);
                              }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'l':
                    if (String.Compare(key, 2, "ient", 0, 4, false) == 0)
                      {
                        switch (key[6])
                          {
                            case 'C':
                                if ((String.Compare(key, 7, "ommand", 0, 6, false) == 0) && (key.Length == 13))
                                  {
                                    JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("ClientCommandKind") ? other_field_index["ClientCommandKind"] : null));
                                    if (key_value == null)
                                        throw new Exception("The `ClientCommandKind' field is missing.");
                                    JSONStringValue key_string_value = key_value.string_value();
                                    if (key_string_value == null)
                                        throw new Exception("The `ClientCommandKind' field has a non-string value.");
                                    return ClientCommandJSON.createForKey(key_string_value.getData(), other_field_index);
                                  }
                                break;
                            case 'M':
                                if ((String.Compare(key, 7, "atchCommand", 0, 11, false) == 0) && (key.Length == 18))
                                    return new ClientMatchCommandJSON();
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'o':
                    switch (key[2])
                      {
                        case 'm':
                            switch (key[3])
                              {
                                case 'm':
                                    if ((String.Compare(key, 4, "unicationCommand", 0, 16, false) == 0) && (key.Length == 20))
                                      {
                                        JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("CommunicationCommandKind") ? other_field_index["CommunicationCommandKind"] : null));
                                        if (key_value == null)
                                            throw new Exception("The `CommunicationCommandKind' field is missing.");
                                        JSONStringValue key_string_value = key_value.string_value();
                                        if (key_string_value == null)
                                            throw new Exception("The `CommunicationCommandKind' field has a non-string value.");
                                        return CommunicationCommandJSON.createForKey(key_string_value.getData(), other_field_index);
                                      }
                                    break;
                                case 'p':
                                    if ((String.Compare(key, 4, "oundResultCommand", 0, 17, false) == 0) && (key.Length == 21))
                                        return new CompoundResultCommandJSON();
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'u':
                            if ((String.Compare(key, 3, "ntdownCommand", 0, 13, false) == 0) && (key.Length == 16))
                                return new CountdownCommandJSON();
                            break;
                        default:
                            break;
                      }
                    break;
                case 'u':
                    if ((String.Compare(key, 2, "rrencyConverterCommand", 0, 22, false) == 0) && (key.Length == 24))
                        return new CurrencyConverterCommandJSON();
                    break;
                default:
                    break;
              }
            break;
        case 'D':
            switch (key[1])
              {
                case 'e':
                    if ((String.Compare(key, 2, "viceControlCommand", 0, 18, false) == 0) && (key.Length == 20))
                      {
                        JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("DeviceControlCommandKind") ? other_field_index["DeviceControlCommandKind"] : null));
                        if (key_value == null)
                            throw new Exception("The `DeviceControlCommandKind' field is missing.");
                        JSONStringValue key_string_value = key_value.string_value();
                        if (key_string_value == null)
                            throw new Exception("The `DeviceControlCommandKind' field has a non-string value.");
                        return DeviceControlCommandJSON.createForKey(key_string_value.getData(), other_field_index);
                      }
                    break;
                case 'i':
                    switch (key[2])
                      {
                        case 'c':
                            if ((String.Compare(key, 3, "tionaryCommand", 0, 14, false) == 0) && (key.Length == 17))
                                return new DictionaryCommandJSON();
                            break;
                        case 's':
                            if (String.Compare(key, 3, "ambiguate", 0, 9, false) == 0)
                              {
                                switch (key[12])
                                  {
                                    case 'C':
                                        if ((String.Compare(key, 13, "ommand", 0, 6, false) == 0) && (key.Length == 19))
                                          {
                                            JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("DisambiguateCommandKind") ? other_field_index["DisambiguateCommandKind"] : null));
                                            if (key_value == null)
                                                throw new Exception("The `DisambiguateCommandKind' field is missing.");
                                            JSONStringValue key_string_value = key_value.string_value();
                                            if (key_string_value == null)
                                                throw new Exception("The `DisambiguateCommandKind' field has a non-string value.");
                                            return DisambiguateCommandJSON.createForKey(key_string_value.getData(), other_field_index);
                                          }
                                        break;
                                    case 'L':
                                        if ((String.Compare(key, 13, "ocationCommand", 0, 14, false) == 0) && (key.Length == 27))
                                            return new DisambiguateLocationCommandJSON();
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        default:
                            break;
                      }
                    break;
                default:
                    break;
              }
            break;
        case 'E':
            switch (key[1])
              {
                case 'd':
                    if ((String.Compare(key, 2, "itDeviceCommand", 0, 15, false) == 0) && (key.Length == 17))
                      {
                        JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("EditDeviceCommandKind") ? other_field_index["EditDeviceCommandKind"] : null));
                        if (key_value == null)
                            throw new Exception("The `EditDeviceCommandKind' field is missing.");
                        JSONStringValue key_string_value = key_value.string_value();
                        if (key_string_value == null)
                            throw new Exception("The `EditDeviceCommandKind' field has a non-string value.");
                        return EditDeviceCommandJSON.createForKey(key_string_value.getData(), other_field_index);
                      }
                    break;
                case 'm':
                    if ((String.Compare(key, 2, "ailCommand", 0, 10, false) == 0) && (key.Length == 12))
                      {
                        JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("EmailCommandKind") ? other_field_index["EmailCommandKind"] : null));
                        if (key_value == null)
                            throw new Exception("The `EmailCommandKind' field is missing.");
                        JSONStringValue key_string_value = key_value.string_value();
                        if (key_string_value == null)
                            throw new Exception("The `EmailCommandKind' field has a non-string value.");
                        return EmailCommandJSON.createForKey(key_string_value.getData(), other_field_index);
                      }
                    break;
                case 'r':
                    if ((String.Compare(key, 2, "rorCommand", 0, 10, false) == 0) && (key.Length == 12))
                        return new ErrorCommandJSON();
                    break;
                default:
                    break;
              }
            break;
        case 'F':
            if (String.Compare(key, 1, "light", 0, 5, false) == 0)
              {
                switch (key[6])
                  {
                    case 'B':
                        if ((String.Compare(key, 7, "ookingCommand", 0, 13, false) == 0) && (key.Length == 20))
                            return new FlightBookingCommandJSON();
                        break;
                    case 'S':
                        if (String.Compare(key, 7, "tatus", 0, 5, false) == 0)
                          {
                            switch (key[12])
                              {
                                case 'C':
                                    if ((String.Compare(key, 13, "ommand", 0, 6, false) == 0) && (key.Length == 19))
                                        return new FlightStatusCommandJSON();
                                    break;
                                case 'M':
                                    if ((String.Compare(key, 13, "odeCommand", 0, 10, false) == 0) && (key.Length == 23))
                                        return new FlightStatusModeCommandJSON();
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    default:
                        break;
                  }
              }
            break;
        case 'G':
            switch (key[1])
              {
                case 'a':
                    if ((String.Compare(key, 2, "mesMenuCommand", 0, 14, false) == 0) && (key.Length == 16))
                      {
                        JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("GamesMenuCommandKind") ? other_field_index["GamesMenuCommandKind"] : null));
                        if (key_value == null)
                            throw new Exception("The `GamesMenuCommandKind' field is missing.");
                        JSONStringValue key_string_value = key_value.string_value();
                        if (key_string_value == null)
                            throw new Exception("The `GamesMenuCommandKind' field has a non-string value.");
                        return GamesMenuCommandJSON.createForKey(key_string_value.getData(), other_field_index);
                      }
                    break;
                case 'e':
                    if ((String.Compare(key, 2, "ometryCommand", 0, 13, false) == 0) && (key.Length == 15))
                      {
                        JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("GeometryCommandKind") ? other_field_index["GeometryCommandKind"] : null));
                        if (key_value == null)
                            throw new Exception("The `GeometryCommandKind' field is missing.");
                        JSONStringValue key_string_value = key_value.string_value();
                        if (key_string_value == null)
                            throw new Exception("The `GeometryCommandKind' field has a non-string value.");
                        return GeometryCommandJSON.createForKey(key_string_value.getData(), other_field_index);
                      }
                    break;
                case 'u':
                    if (String.Compare(key, 2, "essThatLyric", 0, 12, false) == 0)
                      {
                        switch (key[14])
                          {
                            case 'D':
                                if ((String.Compare(key, 15, "ecadeMenuCommand", 0, 16, false) == 0) && (key.Length == 31))
                                    return new GuessThatLyricDecadeMenuCommandJSON();
                                break;
                            case 'Q':
                                if ((String.Compare(key, 15, "uitGameCommand", 0, 14, false) == 0) && (key.Length == 29))
                                    return new GuessThatLyricQuitGameCommandJSON();
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                default:
                    break;
              }
            break;
        case 'H':
            switch (key[1])
              {
                case 'a':
                    if ((String.Compare(key, 2, "ngmanCommand", 0, 12, false) == 0) && (key.Length == 14))
                      {
                        JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("HangmanCommandKind") ? other_field_index["HangmanCommandKind"] : null));
                        if (key_value == null)
                            throw new Exception("The `HangmanCommandKind' field is missing.");
                        JSONStringValue key_string_value = key_value.string_value();
                        if (key_string_value == null)
                            throw new Exception("The `HangmanCommandKind' field has a non-string value.");
                        return HangmanCommandJSON.createForKey(key_string_value.getData(), other_field_index);
                      }
                    break;
                case 'o':
                    if (String.Compare(key, 2, "meAutomation", 0, 12, false) == 0)
                      {
                        switch (key[14])
                          {
                            case 'C':
                                switch (key[15])
                                  {
                                    case 'a':
                                        if ((String.Compare(key, 16, "ncelCommand", 0, 11, false) == 0) && (key.Length == 27))
                                            return new HomeAutomationCancelCommandJSON();
                                        break;
                                    case 'o':
                                        switch (key[16])
                                          {
                                            case 'm':
                                                if ((String.Compare(key, 17, "mand", 0, 4, false) == 0) && (key.Length == 21))
                                                  {
                                                    JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("HomeAutomationCommandKind") ? other_field_index["HomeAutomationCommandKind"] : null));
                                                    if (key_value == null)
                                                        throw new Exception("The `HomeAutomationCommandKind' field is missing.");
                                                    JSONStringValue key_string_value = key_value.string_value();
                                                    if (key_string_value == null)
                                                        throw new Exception("The `HomeAutomationCommandKind' field has a non-string value.");
                                                    return HomeAutomationCommandJSON.createForKey(key_string_value.getData(), other_field_index);
                                                  }
                                                break;
                                            case 'n':
                                                if ((String.Compare(key, 17, "trolCommand", 0, 11, false) == 0) && (key.Length == 28))
                                                  {
                                                    JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("HomeAutomationControlCommandKind") ? other_field_index["HomeAutomationControlCommandKind"] : null));
                                                    if (key_value == null)
                                                        throw new Exception("The `HomeAutomationControlCommandKind' field is missing.");
                                                    JSONStringValue key_string_value = key_value.string_value();
                                                    if (key_string_value == null)
                                                        throw new Exception("The `HomeAutomationControlCommandKind' field has a non-string value.");
                                                    return HomeAutomationControlCommandJSON.createForKey(key_string_value.getData(), other_field_index);
                                                  }
                                                break;
                                            default:
                                                break;
                                          }
                                        break;
                                    default:
                                        break;
                                  }
                                break;
                            case 'L':
                                if ((String.Compare(key, 15, "istUserDataCommand", 0, 18, false) == 0) && (key.Length == 33))
                                    return new HomeAutomationListUserDataCommandJSON();
                                break;
                            case 'Q':
                                if ((String.Compare(key, 15, "ueryCommand", 0, 11, false) == 0) && (key.Length == 26))
                                    return new HomeAutomationQueryCommandJSON();
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                default:
                    break;
              }
            break;
        case 'I':
            switch (key[1])
              {
                case 'H':
                    if ((String.Compare(key, 2, "eartRadioCommand", 0, 16, false) == 0) && (key.Length == 18))
                      {
                        JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("IHeartRadioCommandKind") ? other_field_index["IHeartRadioCommandKind"] : null));
                        if (key_value == null)
                            throw new Exception("The `IHeartRadioCommandKind' field is missing.");
                        JSONStringValue key_string_value = key_value.string_value();
                        if (key_string_value == null)
                            throw new Exception("The `IHeartRadioCommandKind' field has a non-string value.");
                        return IHeartRadioCommandJSON.createForKey(key_string_value.getData(), other_field_index);
                      }
                    break;
                case 'O':
                    if ((String.Compare(key, 2, "SAppLauncherCommand", 0, 19, false) == 0) && (key.Length == 21))
                        return new IOSAppLauncherCommandJSON();
                    break;
                case 'n':
                    switch (key[2])
                      {
                        case 'd':
                            if ((String.Compare(key, 3, "exUserAppsCommand", 0, 17, false) == 0) && (key.Length == 20))
                                return new IndexUserAppsCommandJSON();
                            break;
                        case 'f':
                            if ((String.Compare(key, 3, "ormationCommand", 0, 15, false) == 0) && (key.Length == 18))
                                return new InformationCommandJSON();
                            break;
                        case 't':
                            if ((String.Compare(key, 3, "entCommand", 0, 10, false) == 0) && (key.Length == 13))
                                return new IntentCommandJSON();
                            break;
                        default:
                            break;
                      }
                    break;
                default:
                    break;
              }
            break;
        case 'K':
            if ((String.Compare(key, 1, "nowledgeCommand", 0, 15, false) == 0) && (key.Length == 16))
                return new KnowledgeCommandJSON();
            break;
        case 'L':
            if ((String.Compare(key, 1, "ocalSearchCommand", 0, 17, false) == 0) && (key.Length == 18))
                return new LocalSearchCommandJSON();
            break;
        case 'M':
            switch (key[1])
              {
                case 'a':
                    if ((String.Compare(key, 2, "pCommand", 0, 8, false) == 0) && (key.Length == 10))
                      {
                        JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("MapCommandKind") ? other_field_index["MapCommandKind"] : null));
                        if (key_value == null)
                            throw new Exception("The `MapCommandKind' field is missing.");
                        JSONStringValue key_string_value = key_value.string_value();
                        if (key_string_value == null)
                            throw new Exception("The `MapCommandKind' field has a non-string value.");
                        return MapCommandJSON.createForKey(key_string_value.getData(), other_field_index);
                      }
                    break;
                case 'i':
                    if (String.Compare(key, 2, "nesweeper", 0, 9, false) == 0)
                      {
                        switch (key[11])
                          {
                            case 'F':
                                if (String.Compare(key, 12, "ailedTo", 0, 7, false) == 0)
                                  {
                                    switch (key[19])
                                      {
                                        case 'S':
                                            if (String.Compare(key, 20, "witchFlag", 0, 9, false) == 0)
                                              {
                                                switch (key[29])
                                                  {
                                                    case 'O':
                                                        if (String.Compare(key, 30, "n", 0, 1, false) == 0)
                                                          {
                                                            switch (key[31])
                                                              {
                                                                case 'O':
                                                                    if ((String.Compare(key, 32, "utOfBoardCellCommand", 0, 20, false) == 0) && (key.Length == 52))
                                                                        return new MinesweeperFailedToSwitchFlagOnOutOfBoardCellCommandJSON();
                                                                    break;
                                                                case 'U':
                                                                    if ((String.Compare(key, 32, "ncoverCellCommand", 0, 17, false) == 0) && (key.Length == 49))
                                                                        return new MinesweeperFailedToSwitchFlagOnUncoveredCellCommandJSON();
                                                                    break;
                                                                default:
                                                                    break;
                                                              }
                                                          }
                                                        break;
                                                    case 'T':
                                                        if ((String.Compare(key, 30, "oCurrentStateCommand", 0, 20, false) == 0) && (key.Length == 50))
                                                            return new MinesweeperFailedToSwitchFlagToCurrentStateCommandJSON();
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                              }
                                            break;
                                        case 'U':
                                            if (String.Compare(key, 20, "ncover", 0, 6, false) == 0)
                                              {
                                                switch (key[26])
                                                  {
                                                    case 'A':
                                                        if ((String.Compare(key, 27, "lreadyUncoveredCellCommand", 0, 26, false) == 0) && (key.Length == 53))
                                                            return new MinesweeperFailedToUncoverAlreadyUncoveredCellCommandJSON();
                                                        break;
                                                    case 'F':
                                                        if ((String.Compare(key, 27, "laggedCellCommand", 0, 17, false) == 0) && (key.Length == 44))
                                                            return new MinesweeperFailedToUncoverFlaggedCellCommandJSON();
                                                        break;
                                                    case 'O':
                                                        if ((String.Compare(key, 27, "utOfBoardCellCommand", 0, 20, false) == 0) && (key.Length == 47))
                                                            return new MinesweeperFailedToUncoverOutOfBoardCellCommandJSON();
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                              }
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'N':
                                if ((String.Compare(key, 12, "otUnderstoodCommand", 0, 19, false) == 0) && (key.Length == 31))
                                    return new MinesweeperNotUnderstoodCommandJSON();
                                break;
                            case 'Q':
                                if ((String.Compare(key, 12, "uitGameCommand", 0, 14, false) == 0) && (key.Length == 26))
                                    return new MinesweeperQuitGameCommandJSON();
                                break;
                            case 'S':
                                switch (key[12])
                                  {
                                    case 't':
                                        if ((String.Compare(key, 13, "artGameCommand", 0, 14, false) == 0) && (key.Length == 27))
                                            return new MinesweeperStartGameCommandJSON();
                                        break;
                                    case 'w':
                                        if ((String.Compare(key, 13, "itchedFlagCommand", 0, 17, false) == 0) && (key.Length == 30))
                                            return new MinesweeperSwitchedFlagCommandJSON();
                                        break;
                                    default:
                                        break;
                                  }
                                break;
                            case 'U':
                                if (String.Compare(key, 12, "ncovered", 0, 8, false) == 0)
                                  {
                                    switch (key[20])
                                      {
                                        case 'L':
                                            if ((String.Compare(key, 21, "astCellCommand", 0, 14, false) == 0) && (key.Length == 35))
                                                return new MinesweeperUncoveredLastCellCommandJSON();
                                            break;
                                        case 'M':
                                            if ((String.Compare(key, 21, "inedCellCommand", 0, 15, false) == 0) && (key.Length == 36))
                                                return new MinesweeperUncoveredMinedCellCommandJSON();
                                            break;
                                        case 'S':
                                            if ((String.Compare(key, 21, "afeCellCommand", 0, 14, false) == 0) && (key.Length == 35))
                                                return new MinesweeperUncoveredSafeCellCommandJSON();
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'o':
                    if ((String.Compare(key, 2, "rtgageCalculatorCommand", 0, 23, false) == 0) && (key.Length == 25))
                      {
                        JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("MortgageCalculatorCommandKind") ? other_field_index["MortgageCalculatorCommandKind"] : null));
                        if (key_value == null)
                            throw new Exception("The `MortgageCalculatorCommandKind' field is missing.");
                        JSONStringValue key_string_value = key_value.string_value();
                        if (key_string_value == null)
                            throw new Exception("The `MortgageCalculatorCommandKind' field has a non-string value.");
                        return MortgageCalculatorCommandJSON.createForKey(key_string_value.getData(), other_field_index);
                      }
                    break;
                case 'u':
                    switch (key[2])
                      {
                        case 'l':
                            if (String.Compare(key, 3, "tipleChoiceQuiz", 0, 15, false) == 0)
                              {
                                switch (key[18])
                                  {
                                    case 'A':
                                        if ((String.Compare(key, 19, "PIResult", 0, 8, false) == 0) && (key.Length == 27))
                                            return new MultipleChoiceQuizAPIResultJSON();
                                        break;
                                    case 'G':
                                        if ((String.Compare(key, 19, "oodbyeResponse", 0, 14, false) == 0) && (key.Length == 33))
                                            return new MultipleChoiceQuizGoodbyeResponseJSON();
                                        break;
                                    case 'N':
                                        if ((String.Compare(key, 19, "otUnderstoodResponse", 0, 20, false) == 0) && (key.Length == 39))
                                            return new MultipleChoiceQuizNotUnderstoodResponseJSON();
                                        break;
                                    case 'Q':
                                        if (String.Compare(key, 19, "uestion", 0, 7, false) == 0)
                                          {
                                            switch (key[26])
                                              {
                                                case 'C':
                                                    if ((String.Compare(key, 27, "ountResponse", 0, 12, false) == 0) && (key.Length == 39))
                                                        return new MultipleChoiceQuizQuestionCountResponseJSON();
                                                    break;
                                                case 'R':
                                                    if ((String.Compare(key, 27, "esult", 0, 5, false) == 0) && (key.Length == 32))
                                                        return new MultipleChoiceQuizQuestionResultJSON();
                                                    break;
                                                default:
                                                    break;
                                              }
                                          }
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 's':
                            if (String.Compare(key, 3, "ic", 0, 2, false) == 0)
                              {
                                switch (key[5])
                                  {
                                    case 'C':
                                        if ((String.Compare(key, 6, "ommand", 0, 6, false) == 0) && (key.Length == 12))
                                          {
                                            JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("MusicCommandKind") ? other_field_index["MusicCommandKind"] : null));
                                            if (key_value == null)
                                                throw new Exception("The `MusicCommandKind' field is missing.");
                                            JSONStringValue key_string_value = key_value.string_value();
                                            if (key_string_value == null)
                                                throw new Exception("The `MusicCommandKind' field has a non-string value.");
                                            return MusicCommandJSON.createForKey(key_string_value.getData(), other_field_index);
                                          }
                                        break;
                                    case 'P':
                                        if ((String.Compare(key, 6, "layerCommand", 0, 12, false) == 0) && (key.Length == 18))
                                            return new MusicPlayerCommandJSON();
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        default:
                            break;
                      }
                    break;
                default:
                    break;
              }
            break;
        case 'N':
            switch (key[1])
              {
                case 'a':
                    if (String.Compare(key, 2, "vigationCo", 0, 10, false) == 0)
                      {
                        switch (key[12])
                          {
                            case 'm':
                                if ((String.Compare(key, 13, "mand", 0, 4, false) == 0) && (key.Length == 17))
                                  {
                                    JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("NavigationCommandKind") ? other_field_index["NavigationCommandKind"] : null));
                                    if (key_value == null)
                                        throw new Exception("The `NavigationCommandKind' field is missing.");
                                    JSONStringValue key_string_value = key_value.string_value();
                                    if (key_string_value == null)
                                        throw new Exception("The `NavigationCommandKind' field has a non-string value.");
                                    return NavigationCommandJSON.createForKey(key_string_value.getData(), other_field_index);
                                  }
                                break;
                            case 'n':
                                if ((String.Compare(key, 13, "trolCommand", 0, 11, false) == 0) && (key.Length == 24))
                                  {
                                    JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("CommandType") ? other_field_index["CommandType"] : null));
                                    if (key_value == null)
                                        throw new Exception("The `CommandType' field is missing.");
                                    JSONStringValue key_string_value = key_value.string_value();
                                    if (key_string_value == null)
                                        throw new Exception("The `CommandType' field has a non-string value.");
                                    return NavigationControlCommandJSON.createForKey(key_string_value.getData(), other_field_index);
                                  }
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'u':
                    if ((String.Compare(key, 2, "mberGuessCommand", 0, 16, false) == 0) && (key.Length == 18))
                      {
                        JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("NumberGuessCommandKind") ? other_field_index["NumberGuessCommandKind"] : null));
                        if (key_value == null)
                            throw new Exception("The `NumberGuessCommandKind' field is missing.");
                        JSONStringValue key_string_value = key_value.string_value();
                        if (key_string_value == null)
                            throw new Exception("The `NumberGuessCommandKind' field has a non-string value.");
                        return NumberGuessCommandJSON.createForKey(key_string_value.getData(), other_field_index);
                      }
                    break;
                default:
                    break;
              }
            break;
        case 'O':
            if ((String.Compare(key, 1, "Auth2Command", 0, 12, false) == 0) && (key.Length == 13))
              {
                JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("OAuth2CommandKind") ? other_field_index["OAuth2CommandKind"] : null));
                if (key_value == null)
                    throw new Exception("The `OAuth2CommandKind' field is missing.");
                JSONStringValue key_string_value = key_value.string_value();
                if (key_string_value == null)
                    throw new Exception("The `OAuth2CommandKind' field has a non-string value.");
                return OAuth2CommandJSON.createForKey(key_string_value.getData(), other_field_index);
              }
            break;
        case 'P':
            if ((String.Compare(key, 1, "honeCommand", 0, 11, false) == 0) && (key.Length == 12))
              {
                JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("PhoneCommandKind") ? other_field_index["PhoneCommandKind"] : null));
                if (key_value == null)
                    throw new Exception("The `PhoneCommandKind' field is missing.");
                JSONStringValue key_string_value = key_value.string_value();
                if (key_string_value == null)
                    throw new Exception("The `PhoneCommandKind' field has a non-string value.");
                return PhoneCommandJSON.createForKey(key_string_value.getData(), other_field_index);
              }
            break;
        case 'R':
            switch (key[1])
              {
                case 'a':
                    if ((String.Compare(key, 2, "dioCommand", 0, 10, false) == 0) && (key.Length == 12))
                      {
                        JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("RadioCommandKind") ? other_field_index["RadioCommandKind"] : null));
                        if (key_value == null)
                            throw new Exception("The `RadioCommandKind' field is missing.");
                        JSONStringValue key_string_value = key_value.string_value();
                        if (key_string_value == null)
                            throw new Exception("The `RadioCommandKind' field has a non-string value.");
                        return RadioCommandJSON.createForKey(key_string_value.getData(), other_field_index);
                      }
                    break;
                case 'o':
                    switch (key[2])
                      {
                        case 'b':
                            if ((String.Compare(key, 3, "otCommand", 0, 9, false) == 0) && (key.Length == 12))
                              {
                                JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("RobotCommandKind") ? other_field_index["RobotCommandKind"] : null));
                                if (key_value == null)
                                    throw new Exception("The `RobotCommandKind' field is missing.");
                                JSONStringValue key_string_value = key_value.string_value();
                                if (key_string_value == null)
                                    throw new Exception("The `RobotCommandKind' field has a non-string value.");
                                return RobotCommandJSON.createForKey(key_string_value.getData(), other_field_index);
                              }
                            break;
                        case 'c':
                            if ((String.Compare(key, 3, "kPaperScissorsCommand", 0, 21, false) == 0) && (key.Length == 24))
                              {
                                JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("RockPaperScissorsCommandKind") ? other_field_index["RockPaperScissorsCommandKind"] : null));
                                if (key_value == null)
                                    throw new Exception("The `RockPaperScissorsCommandKind' field is missing.");
                                JSONStringValue key_string_value = key_value.string_value();
                                if (key_string_value == null)
                                    throw new Exception("The `RockPaperScissorsCommandKind' field has a non-string value.");
                                return RockPaperScissorsCommandJSON.createForKey(key_string_value.getData(), other_field_index);
                              }
                            break;
                        default:
                            break;
                      }
                    break;
                default:
                    break;
              }
            break;
        case 'S':
            switch (key[1])
              {
                case 'M':
                    if ((String.Compare(key, 2, "SCommand", 0, 8, false) == 0) && (key.Length == 10))
                      {
                        JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("SMSCommandKind") ? other_field_index["SMSCommandKind"] : null));
                        if (key_value == null)
                            throw new Exception("The `SMSCommandKind' field is missing.");
                        JSONStringValue key_string_value = key_value.string_value();
                        if (key_string_value == null)
                            throw new Exception("The `SMSCommandKind' field has a non-string value.");
                        return SMSCommandJSON.createForKey(key_string_value.getData(), other_field_index);
                      }
                    break;
                case 'o':
                    if ((String.Compare(key, 2, "undHoundNowCommand", 0, 18, false) == 0) && (key.Length == 20))
                        return new SoundHoundNowCommandJSON();
                    break;
                case 'p':
                    switch (key[2])
                      {
                        case 'e':
                            if ((String.Compare(key, 3, "echToTextOnlyCommand", 0, 20, false) == 0) && (key.Length == 23))
                                return new SpeechToTextOnlyCommandJSON();
                            break;
                        case 'o':
                            if ((String.Compare(key, 3, "rtsCommand", 0, 10, false) == 0) && (key.Length == 13))
                              {
                                JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("SportsCommandKind") ? other_field_index["SportsCommandKind"] : null));
                                if (key_value == null)
                                    throw new Exception("The `SportsCommandKind' field is missing.");
                                JSONStringValue key_string_value = key_value.string_value();
                                if (key_string_value == null)
                                    throw new Exception("The `SportsCommandKind' field has a non-string value.");
                                return SportsCommandJSON.createForKey(key_string_value.getData(), other_field_index);
                              }
                            break;
                        default:
                            break;
                      }
                    break;
                case 't':
                    switch (key[2])
                      {
                        case 'o':
                            switch (key[3])
                              {
                                case 'c':
                                    if ((String.Compare(key, 4, "kMarketCommand", 0, 14, false) == 0) && (key.Length == 18))
                                        return new StockMarketCommandJSON();
                                    break;
                                case 'r':
                                    if (String.Compare(key, 4, "ed", 0, 2, false) == 0)
                                      {
                                        switch (key[6])
                                          {
                                            case 'A':
                                                if ((String.Compare(key, 7, "lwaysMatchCommand", 0, 17, false) == 0) && (key.Length == 24))
                                                  {
                                                    JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("StoredAlwaysMatchCommandKind") ? other_field_index["StoredAlwaysMatchCommandKind"] : null));
                                                    if (key_value == null)
                                                        throw new Exception("The `StoredAlwaysMatchCommandKind' field is missing.");
                                                    JSONStringValue key_string_value = key_value.string_value();
                                                    if (key_string_value == null)
                                                        throw new Exception("The `StoredAlwaysMatchCommandKind' field has a non-string value.");
                                                    return StoredAlwaysMatchCommandJSON.createForKey(key_string_value.getData(), other_field_index);
                                                  }
                                                break;
                                            case 'P':
                                                if ((String.Compare(key, 7, "ageMatchCommand", 0, 15, false) == 0) && (key.Length == 22))
                                                  {
                                                    JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("StoredPageMatchCommandKind") ? other_field_index["StoredPageMatchCommandKind"] : null));
                                                    if (key_value == null)
                                                        throw new Exception("The `StoredPageMatchCommandKind' field is missing.");
                                                    JSONStringValue key_string_value = key_value.string_value();
                                                    if (key_string_value == null)
                                                        throw new Exception("The `StoredPageMatchCommandKind' field has a non-string value.");
                                                    return StoredPageMatchCommandJSON.createForKey(key_string_value.getData(), other_field_index);
                                                  }
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'r':
                            if ((String.Compare(key, 3, "eamAudio", 0, 8, false) == 0) && (key.Length == 11))
                              {
                                JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("StreamAudioKind") ? other_field_index["StreamAudioKind"] : null));
                                if (key_value == null)
                                    throw new Exception("The `StreamAudioKind' field is missing.");
                                JSONStringValue key_string_value = key_value.string_value();
                                if (key_string_value == null)
                                    throw new Exception("The `StreamAudioKind' field has a non-string value.");
                                return StreamAudioCommandJSON.createForKey(key_string_value.getData(), other_field_index);
                              }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'u':
                    if (String.Compare(key, 2, "rvey", 0, 4, false) == 0)
                      {
                        switch (key[6])
                          {
                            case 'A':
                                if ((String.Compare(key, 7, "PIResult", 0, 8, false) == 0) && (key.Length == 15))
                                    return new SurveyAPIResultJSON();
                                break;
                            case 'R':
                                if ((String.Compare(key, 7, "esult", 0, 5, false) == 0) && (key.Length == 12))
                                  {
                                    JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("SurveyResultType") ? other_field_index["SurveyResultType"] : null));
                                    if (key_value == null)
                                        throw new Exception("The `SurveyResultType' field is missing.");
                                    JSONStringValue key_string_value = key_value.string_value();
                                    if (key_string_value == null)
                                        throw new Exception("The `SurveyResultType' field has a non-string value.");
                                    return SurveyResultJSON.createForKey(key_string_value.getData(), other_field_index);
                                  }
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                default:
                    break;
              }
            break;
        case 'T':
            if (String.Compare(key, 1, "i", 0, 1, false) == 0)
              {
                switch (key[2])
                  {
                    case 'm':
                        if ((String.Compare(key, 3, "erCommand", 0, 9, false) == 0) && (key.Length == 12))
                          {
                            JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("TimerCommandKind") ? other_field_index["TimerCommandKind"] : null));
                            if (key_value == null)
                                throw new Exception("The `TimerCommandKind' field is missing.");
                            JSONStringValue key_string_value = key_value.string_value();
                            if (key_string_value == null)
                                throw new Exception("The `TimerCommandKind' field has a non-string value.");
                            return TimerCommandJSON.createForKey(key_string_value.getData(), other_field_index);
                          }
                        break;
                    case 'p':
                        if ((String.Compare(key, 3, "CalculatorCommand", 0, 17, false) == 0) && (key.Length == 20))
                          {
                            JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("TipCalculatorCommandKind") ? other_field_index["TipCalculatorCommandKind"] : null));
                            if (key_value == null)
                                throw new Exception("The `TipCalculatorCommandKind' field is missing.");
                            JSONStringValue key_string_value = key_value.string_value();
                            if (key_string_value == null)
                                throw new Exception("The `TipCalculatorCommandKind' field has a non-string value.");
                            return TipCalculatorCommandJSON.createForKey(key_string_value.getData(), other_field_index);
                          }
                        break;
                    default:
                        break;
                  }
              }
            break;
        case 'U':
            switch (key[1])
              {
                case 'b':
                    if ((String.Compare(key, 2, "erCommand", 0, 9, false) == 0) && (key.Length == 11))
                      {
                        JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("UberCommandKind") ? other_field_index["UberCommandKind"] : null));
                        if (key_value == null)
                            throw new Exception("The `UberCommandKind' field is missing.");
                        JSONStringValue key_string_value = key_value.string_value();
                        if (key_string_value == null)
                            throw new Exception("The `UberCommandKind' field has a non-string value.");
                        return UberCommandJSON.createForKey(key_string_value.getData(), other_field_index);
                      }
                    break;
                case 's':
                    if (String.Compare(key, 2, "er", 0, 2, false) == 0)
                      {
                        switch (key[4])
                          {
                            case 'C':
                                if ((String.Compare(key, 5, "ontactsCommand", 0, 14, false) == 0) && (key.Length == 19))
                                    return new UserContactsCommandJSON();
                                break;
                            case 'F':
                                if ((String.Compare(key, 5, "eedbackCommand", 0, 14, false) == 0) && (key.Length == 19))
                                    return new UserFeedbackCommandJSON();
                                break;
                            case 'I':
                                if ((String.Compare(key, 5, "dentificationDataIHeartMediaCommand", 0, 35, false) == 0) && (key.Length == 40))
                                  {
                                    JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("UserIdentificationDataIHeartMediaCommandKind") ? other_field_index["UserIdentificationDataIHeartMediaCommandKind"] : null));
                                    if (key_value == null)
                                        throw new Exception("The `UserIdentificationDataIHeartMediaCommandKind' field is missing.");
                                    JSONStringValue key_string_value = key_value.string_value();
                                    if (key_string_value == null)
                                        throw new Exception("The `UserIdentificationDataIHeartMediaCommandKind' field has a non-string value.");
                                    return UserIdentificationDataIHeartMediaCommandJSON.createForKey(key_string_value.getData(), other_field_index);
                                  }
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                default:
                    break;
              }
            break;
        default:
            break;
      }

        return new GenericCommandResultJSON(key);
      }
  };
