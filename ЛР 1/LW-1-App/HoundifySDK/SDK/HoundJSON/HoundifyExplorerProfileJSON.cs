/* file "HoundifyExplorerProfileJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class HoundifyExplorerProfileJSON : JSONBase
  {
    public enum TypePartialTranscriptionDisplayAction
      {
        PartialTranscriptionDisplayAction_DisplayTextOverWrite,
        PartialTranscriptionDisplayAction_DisplayTextNoOverWrite,
        PartialTranscriptionDisplayAction_DisplayJSONFull,
        PartialTranscriptionDisplayAction_None
      };

    public static TypePartialTranscriptionDisplayAction  stringToPartialTranscriptionDisplayAction(string chars)
      {
        switch (chars[0])
          {
            case 'D':
                if (String.Compare(chars, 1, "isplay", 0, 6, false) == 0)
                  {
                    switch (chars[7])
                      {
                        case 'J':
                            if ((String.Compare(chars, 8, "SONFull", 0, 7, false) == 0) && (chars.Length == 15))
                                return TypePartialTranscriptionDisplayAction.PartialTranscriptionDisplayAction_DisplayJSONFull;
                            break;
                        case 'T':
                            if (String.Compare(chars, 8, "ext", 0, 3, false) == 0)
                              {
                                switch (chars[11])
                                  {
                                    case 'N':
                                        if ((String.Compare(chars, 12, "oOverWrite", 0, 10, false) == 0) && (chars.Length == 22))
                                            return TypePartialTranscriptionDisplayAction.PartialTranscriptionDisplayAction_DisplayTextNoOverWrite;
                                        break;
                                    case 'O':
                                        if ((String.Compare(chars, 12, "verWrite", 0, 8, false) == 0) && (chars.Length == 20))
                                            return TypePartialTranscriptionDisplayAction.PartialTranscriptionDisplayAction_DisplayTextOverWrite;
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
                if ((String.Compare(chars, 1, "one", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypePartialTranscriptionDisplayAction.PartialTranscriptionDisplayAction_None;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `PartialTranscriptionDisplayAction' is not one of the legal values.");
      }

    public static string  stringFromPartialTranscriptionDisplayAction(TypePartialTranscriptionDisplayAction the_enum)
      {
        switch (the_enum)
          {
            case TypePartialTranscriptionDisplayAction.PartialTranscriptionDisplayAction_DisplayTextOverWrite:
                return "DisplayTextOverWrite";
            case TypePartialTranscriptionDisplayAction.PartialTranscriptionDisplayAction_DisplayTextNoOverWrite:
                return "DisplayTextNoOverWrite";
            case TypePartialTranscriptionDisplayAction.PartialTranscriptionDisplayAction_DisplayJSONFull:
                return "DisplayJSONFull";
            case TypePartialTranscriptionDisplayAction.PartialTranscriptionDisplayAction_None:
                return "None";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasName;
    private string storeName;
    private bool flagHasClientID;
    private string storeClientID;
    private bool flagHasClientKey;
    private string storeClientKey;
    private bool flagHasUserID;
    private string storeUserID;
    private bool flagHasTextQueryBaseURL;
    private string storeTextQueryBaseURL;
    private bool flagHasVoiceQueryURL;
    private string storeVoiceQueryURL;
    private bool flagHasProxyHost;
    private string storeProxyHost;
    private bool flagHasProxyPort;
    private ushort storeProxyPort;
    private bool flagHasTimeOut;
    private BigInteger storeTimeOut;
    private bool flagHasExtraRequestInfo;
    private RequestInfoJSON  storeExtraRequestInfo;
    private bool flagHasPluginFiles;
    private List< string > storePluginFiles;
    private bool flagHasPartialTranscriptionDisplayAction;
    private TypePartialTranscriptionDisplayAction storePartialTranscriptionDisplayAction;
    private bool flagHasVoiceInputFileChunkByteCount;
    private BigInteger storeVoiceInputFileChunkByteCount;
    private bool flagHasVoiceInputFileChunkDelaySeconds;
    private double storeVoiceInputFileChunkDelaySeconds;
    private string textStoreVoiceInputFileChunkDelaySeconds;
    private bool flagHasAudioInputToUse;
    private string storeAudioInputToUse;
    private bool flagHasAudioOutputToUse;
    private string storeAudioOutputToUse;
    private bool flagHasOutputAudioDecoderToUse;
    private string storeOutputAudioDecoderToUse;
    private bool flagHasTextToSpeechToUse;
    private string storeTextToSpeechToUse;
    private bool flagHasClientDomainUnitsToUse;
    private List< string > storeClientDomainUnitsToUse;
    private bool flagHasListenStartSoundFile;
    private string storeListenStartSoundFile;
    private bool flagHasListenStopSoundFile;
    private string storeListenStopSoundFile;
    private bool flagHasLongStringFieldsToLimit;
    private List< string > storeLongStringFieldsToLimit;
    private bool flagHasLongStringFieldByteLimit;
    private BigInteger storeLongStringFieldByteLimit;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Name of HoundifyExplorerProfileJSON is not a string.");
        setName(json_string.getData());
      }


    private void  fromJSONClientID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ClientID of HoundifyExplorerProfileJSON is not a string.");
        setClientID(json_string.getData());
      }


    private void  fromJSONClientKey(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ClientKey of HoundifyExplorerProfileJSON is not a string.");
        setClientKey(json_string.getData());
      }


    private void  fromJSONUserID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field UserID of HoundifyExplorerProfileJSON is not a string.");
        setUserID(json_string.getData());
      }


    private void  fromJSONTextQueryBaseURL(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field TextQueryBaseURL of HoundifyExplorerProfileJSON is not a string.");
        setTextQueryBaseURL(json_string.getData());
      }


    private void  fromJSONVoiceQueryURL(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field VoiceQueryURL of HoundifyExplorerProfileJSON is not a string.");
        setVoiceQueryURL(json_string.getData());
      }


    private void  fromJSONProxyHost(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ProxyHost of HoundifyExplorerProfileJSON is not a string.");
        setProxyHost(json_string.getData());
      }


    private void  fromJSONProxyPort(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        ushort extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field ProxyPort of HoundifyExplorerProfileJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field ProxyPort of HoundifyExplorerProfileJSON is not an integer.");
              }
            extracted_integer = (ushort)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (ushort)(json_integer.getLongInt())        ;
          }
        setProxyPort(extracted_integer);
      }


    private void  fromJSONTimeOut(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field TimeOut of HoundifyExplorerProfileJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field TimeOut of HoundifyExplorerProfileJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setTimeOut(extracted_integer);
      }


    private void  fromJSONExtraRequestInfo(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        RequestInfoJSON convert_classy = RequestInfoJSON.from_json(json_value, ignore_extras, true);
        setExtraRequestInfo(convert_classy);
      }


    private void  fromJSONPluginFiles(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field PluginFiles of HoundifyExplorerProfileJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field PluginFiles of HoundifyExplorerProfileJSON has too few elements.");
        List< string > vector_PluginFiles1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field PluginFiles of HoundifyExplorerProfileJSON is not a string.");
            vector_PluginFiles1.Add(json_string.getData());
          }
        Debug.Assert(vector_PluginFiles1.Count >= 1);
        initPluginFiles();
        for (int num1 = 0; num1 < vector_PluginFiles1.Count; ++num1)
            appendPluginFiles(vector_PluginFiles1[num1]);
        for (int num1 = 0; num1 < vector_PluginFiles1.Count; ++num1)
          {
          }
      }


    private void  fromJSONPartialTranscriptionDisplayAction(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field PartialTranscriptionDisplayAction of HoundifyExplorerProfileJSON is not a string.");
        TypePartialTranscriptionDisplayAction the_enum;
        switch (json_string.getData()[0])
          {
            case 'D':
                if (String.Compare(json_string.getData(), 1, "isplay", 0, 6, false) == 0)
                  {
                    switch (json_string.getData()[7])
                      {
                        case 'J':
                            if ((String.Compare(json_string.getData(), 8, "SONFull", 0, 7, false) == 0) && (json_string.getData().Length == 15))
                                  {
                                    the_enum = TypePartialTranscriptionDisplayAction.PartialTranscriptionDisplayAction_DisplayJSONFull;
                                    goto enum_is_done;
                                  }
                            break;
                        case 'T':
                            if (String.Compare(json_string.getData(), 8, "ext", 0, 3, false) == 0)
                              {
                                switch (json_string.getData()[11])
                                  {
                                    case 'N':
                                        if ((String.Compare(json_string.getData(), 12, "oOverWrite", 0, 10, false) == 0) && (json_string.getData().Length == 22))
                                              {
                                                the_enum = TypePartialTranscriptionDisplayAction.PartialTranscriptionDisplayAction_DisplayTextNoOverWrite;
                                                goto enum_is_done;
                                              }
                                        break;
                                    case 'O':
                                        if ((String.Compare(json_string.getData(), 12, "verWrite", 0, 8, false) == 0) && (json_string.getData().Length == 20))
                                              {
                                                the_enum = TypePartialTranscriptionDisplayAction.PartialTranscriptionDisplayAction_DisplayTextOverWrite;
                                                goto enum_is_done;
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
                  }
                break;
            case 'N':
                if ((String.Compare(json_string.getData(), 1, "one", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_enum = TypePartialTranscriptionDisplayAction.PartialTranscriptionDisplayAction_None;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field PartialTranscriptionDisplayAction of HoundifyExplorerProfileJSON is not one of the legal strings.");
      enum_is_done:;
        setPartialTranscriptionDisplayAction(the_enum);
      }


    private void  fromJSONVoiceInputFileChunkByteCount(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field VoiceInputFileChunkByteCount of HoundifyExplorerProfileJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field VoiceInputFileChunkByteCount of HoundifyExplorerProfileJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setVoiceInputFileChunkByteCount(extracted_integer);
      }


    private void  fromJSONVoiceInputFileChunkDelaySeconds(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field VoiceInputFileChunkDelaySeconds of HoundifyExplorerProfileJSON is not a number.");
              }
          }
        setVoiceInputFileChunkDelaySecondsText(the_rational_text);
      }


    private void  fromJSONAudioInputToUse(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field AudioInputToUse of HoundifyExplorerProfileJSON is not a string.");
        setAudioInputToUse(json_string.getData());
      }


    private void  fromJSONAudioOutputToUse(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field AudioOutputToUse of HoundifyExplorerProfileJSON is not a string.");
        setAudioOutputToUse(json_string.getData());
      }


    private void  fromJSONOutputAudioDecoderToUse(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field OutputAudioDecoderToUse of HoundifyExplorerProfileJSON is not a string.");
        setOutputAudioDecoderToUse(json_string.getData());
      }


    private void  fromJSONTextToSpeechToUse(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field TextToSpeechToUse of HoundifyExplorerProfileJSON is not a string.");
        setTextToSpeechToUse(json_string.getData());
      }


    private void  fromJSONClientDomainUnitsToUse(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field ClientDomainUnitsToUse of HoundifyExplorerProfileJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field ClientDomainUnitsToUse of HoundifyExplorerProfileJSON has too few elements.");
        List< string > vector_ClientDomainUnitsToUse1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field ClientDomainUnitsToUse of HoundifyExplorerProfileJSON is not a string.");
            vector_ClientDomainUnitsToUse1.Add(json_string.getData());
          }
        Debug.Assert(vector_ClientDomainUnitsToUse1.Count >= 1);
        initClientDomainUnitsToUse();
        for (int num2 = 0; num2 < vector_ClientDomainUnitsToUse1.Count; ++num2)
            appendClientDomainUnitsToUse(vector_ClientDomainUnitsToUse1[num2]);
        for (int num1 = 0; num1 < vector_ClientDomainUnitsToUse1.Count; ++num1)
          {
          }
      }


    private void  fromJSONListenStartSoundFile(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ListenStartSoundFile of HoundifyExplorerProfileJSON is not a string.");
        setListenStartSoundFile(json_string.getData());
      }


    private void  fromJSONListenStopSoundFile(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ListenStopSoundFile of HoundifyExplorerProfileJSON is not a string.");
        setListenStopSoundFile(json_string.getData());
      }


    private void  fromJSONLongStringFieldsToLimit(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field LongStringFieldsToLimit of HoundifyExplorerProfileJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_LongStringFieldsToLimit1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field LongStringFieldsToLimit of HoundifyExplorerProfileJSON is not a string.");
            vector_LongStringFieldsToLimit1.Add(json_string.getData());
          }
        initLongStringFieldsToLimit();
        for (int num3 = 0; num3 < vector_LongStringFieldsToLimit1.Count; ++num3)
            appendLongStringFieldsToLimit(vector_LongStringFieldsToLimit1[num3]);
        for (int num1 = 0; num1 < vector_LongStringFieldsToLimit1.Count; ++num1)
          {
          }
      }


    private void  fromJSONLongStringFieldByteLimit(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field LongStringFieldByteLimit of HoundifyExplorerProfileJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field LongStringFieldByteLimit of HoundifyExplorerProfileJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setLongStringFieldByteLimit(extracted_integer);
      }


    public HoundifyExplorerProfileJSON()
      {
        flagHasName = false;
        flagHasClientID = false;
        flagHasClientKey = false;
        flagHasUserID = false;
        flagHasTextQueryBaseURL = false;
        flagHasVoiceQueryURL = false;
        flagHasProxyHost = false;
        flagHasProxyPort = false;
        flagHasTimeOut = false;
        flagHasExtraRequestInfo = false;
        flagHasPluginFiles = false;
        flagHasPartialTranscriptionDisplayAction = false;
        flagHasVoiceInputFileChunkByteCount = false;
        flagHasVoiceInputFileChunkDelaySeconds = false;
        flagHasAudioInputToUse = false;
        flagHasAudioOutputToUse = false;
        flagHasOutputAudioDecoderToUse = false;
        flagHasTextToSpeechToUse = false;
        flagHasClientDomainUnitsToUse = false;
        flagHasListenStartSoundFile = false;
        flagHasListenStopSoundFile = false;
        flagHasLongStringFieldsToLimit = false;
        flagHasLongStringFieldByteLimit = false;
        storeTimeOut = 30;
        storePluginFiles = new List< string >();
        storeClientDomainUnitsToUse = new List< string >();
        storeLongStringFieldsToLimit = new List< string >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasName()
      {
        return flagHasName;
      }

    public string  getName()
      {
        Debug.Assert(flagHasName);
        return storeName;
      }

    public bool  hasClientID()
      {
        return flagHasClientID;
      }

    public string  getClientID()
      {
        Debug.Assert(flagHasClientID);
        return storeClientID;
      }

    public bool  hasClientKey()
      {
        return flagHasClientKey;
      }

    public string  getClientKey()
      {
        Debug.Assert(flagHasClientKey);
        return storeClientKey;
      }

    public bool  hasUserID()
      {
        return flagHasUserID;
      }

    public string  getUserID()
      {
        Debug.Assert(flagHasUserID);
        return storeUserID;
      }

    public bool  hasTextQueryBaseURL()
      {
        return flagHasTextQueryBaseURL;
      }

    public string  getTextQueryBaseURL()
      {
        Debug.Assert(flagHasTextQueryBaseURL);
        return storeTextQueryBaseURL;
      }

    public bool  hasVoiceQueryURL()
      {
        return flagHasVoiceQueryURL;
      }

    public string  getVoiceQueryURL()
      {
        Debug.Assert(flagHasVoiceQueryURL);
        return storeVoiceQueryURL;
      }

    public bool  hasProxyHost()
      {
        return flagHasProxyHost;
      }

    public string  getProxyHost()
      {
        Debug.Assert(flagHasProxyHost);
        return storeProxyHost;
      }

    public bool  hasProxyPort()
      {
        return flagHasProxyPort;
      }

    public ushort  getProxyPort()
      {
        Debug.Assert(flagHasProxyPort);
        return storeProxyPort;
      }

    public bool  hasTimeOut()
      {
        return flagHasTimeOut;
      }

    public BigInteger  getTimeOut()
      {
        return storeTimeOut;
      }

    public bool  hasExtraRequestInfo()
      {
        return flagHasExtraRequestInfo;
      }

    public RequestInfoJSON   getExtraRequestInfo()
      {
        Debug.Assert(flagHasExtraRequestInfo);
        return storeExtraRequestInfo;
      }

    public bool  hasPluginFiles()
      {
        return flagHasPluginFiles;
      }

    public int  countOfPluginFiles()
      {
        Debug.Assert(flagHasPluginFiles);
        return storePluginFiles.Count;
      }

    public string  elementOfPluginFiles(int element_num)
      {
        Debug.Assert(flagHasPluginFiles);
        return storePluginFiles[element_num];
      }

    public List< string >  getPluginFiles()
      {
        Debug.Assert(flagHasPluginFiles);
        return storePluginFiles;
      }

    public bool  hasPartialTranscriptionDisplayAction()
      {
        return flagHasPartialTranscriptionDisplayAction;
      }

    public TypePartialTranscriptionDisplayAction  getPartialTranscriptionDisplayAction()
      {
        Debug.Assert(flagHasPartialTranscriptionDisplayAction);
        return storePartialTranscriptionDisplayAction;
      }

    public string  getPartialTranscriptionDisplayActionAsString()
      {
        return stringFromPartialTranscriptionDisplayAction(getPartialTranscriptionDisplayAction());
      }

    public bool  hasVoiceInputFileChunkByteCount()
      {
        return flagHasVoiceInputFileChunkByteCount;
      }

    public BigInteger  getVoiceInputFileChunkByteCount()
      {
        Debug.Assert(flagHasVoiceInputFileChunkByteCount);
        return storeVoiceInputFileChunkByteCount;
      }

    public bool  hasVoiceInputFileChunkDelaySeconds()
      {
        return flagHasVoiceInputFileChunkDelaySeconds;
      }

    public double  getVoiceInputFileChunkDelaySeconds()
      {
        Debug.Assert(flagHasVoiceInputFileChunkDelaySeconds);
        if (textStoreVoiceInputFileChunkDelaySeconds != "")
          {
            return Double.Parse(textStoreVoiceInputFileChunkDelaySeconds);
          }
        return storeVoiceInputFileChunkDelaySeconds;
      }

    public string  getVoiceInputFileChunkDelaySecondsAsText()
      {
        Debug.Assert(flagHasVoiceInputFileChunkDelaySeconds);
        if (textStoreVoiceInputFileChunkDelaySeconds == "")
          {
            return Convert.ToString(storeVoiceInputFileChunkDelaySeconds);
          }
        else
          {
            return (textStoreVoiceInputFileChunkDelaySeconds);
          }
      }

    public bool  hasAudioInputToUse()
      {
        return flagHasAudioInputToUse;
      }

    public string  getAudioInputToUse()
      {
        Debug.Assert(flagHasAudioInputToUse);
        return storeAudioInputToUse;
      }

    public bool  hasAudioOutputToUse()
      {
        return flagHasAudioOutputToUse;
      }

    public string  getAudioOutputToUse()
      {
        Debug.Assert(flagHasAudioOutputToUse);
        return storeAudioOutputToUse;
      }

    public bool  hasOutputAudioDecoderToUse()
      {
        return flagHasOutputAudioDecoderToUse;
      }

    public string  getOutputAudioDecoderToUse()
      {
        Debug.Assert(flagHasOutputAudioDecoderToUse);
        return storeOutputAudioDecoderToUse;
      }

    public bool  hasTextToSpeechToUse()
      {
        return flagHasTextToSpeechToUse;
      }

    public string  getTextToSpeechToUse()
      {
        Debug.Assert(flagHasTextToSpeechToUse);
        return storeTextToSpeechToUse;
      }

    public bool  hasClientDomainUnitsToUse()
      {
        return flagHasClientDomainUnitsToUse;
      }

    public int  countOfClientDomainUnitsToUse()
      {
        Debug.Assert(flagHasClientDomainUnitsToUse);
        return storeClientDomainUnitsToUse.Count;
      }

    public string  elementOfClientDomainUnitsToUse(int element_num)
      {
        Debug.Assert(flagHasClientDomainUnitsToUse);
        return storeClientDomainUnitsToUse[element_num];
      }

    public List< string >  getClientDomainUnitsToUse()
      {
        Debug.Assert(flagHasClientDomainUnitsToUse);
        return storeClientDomainUnitsToUse;
      }

    public bool  hasListenStartSoundFile()
      {
        return flagHasListenStartSoundFile;
      }

    public string  getListenStartSoundFile()
      {
        Debug.Assert(flagHasListenStartSoundFile);
        return storeListenStartSoundFile;
      }

    public bool  hasListenStopSoundFile()
      {
        return flagHasListenStopSoundFile;
      }

    public string  getListenStopSoundFile()
      {
        Debug.Assert(flagHasListenStopSoundFile);
        return storeListenStopSoundFile;
      }

    public bool  hasLongStringFieldsToLimit()
      {
        return flagHasLongStringFieldsToLimit;
      }

    public int  countOfLongStringFieldsToLimit()
      {
        Debug.Assert(flagHasLongStringFieldsToLimit);
        return storeLongStringFieldsToLimit.Count;
      }

    public string  elementOfLongStringFieldsToLimit(int element_num)
      {
        Debug.Assert(flagHasLongStringFieldsToLimit);
        return storeLongStringFieldsToLimit[element_num];
      }

    public List< string >  getLongStringFieldsToLimit()
      {
        Debug.Assert(flagHasLongStringFieldsToLimit);
        return storeLongStringFieldsToLimit;
      }

    public bool  hasLongStringFieldByteLimit()
      {
        return flagHasLongStringFieldByteLimit;
      }

    public BigInteger  getLongStringFieldByteLimit()
      {
        Debug.Assert(flagHasLongStringFieldByteLimit);
        return storeLongStringFieldByteLimit;
      }


    public virtual int extraHoundifyExplorerProfileComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraHoundifyExplorerProfileComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraHoundifyExplorerProfileComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraHoundifyExplorerProfileLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setName(string new_value)
      {
        flagHasName = true;
        storeName = new_value;
      }
    public void unsetName()
      {
        flagHasName = false;
      }
    public void setClientID(string new_value)
      {
        flagHasClientID = true;
        storeClientID = new_value;
      }
    public void unsetClientID()
      {
        flagHasClientID = false;
      }
    public void setClientKey(string new_value)
      {
        flagHasClientKey = true;
        storeClientKey = new_value;
      }
    public void unsetClientKey()
      {
        flagHasClientKey = false;
      }
    public void setUserID(string new_value)
      {
        flagHasUserID = true;
        storeUserID = new_value;
      }
    public void unsetUserID()
      {
        flagHasUserID = false;
      }
    public void setTextQueryBaseURL(string new_value)
      {
        flagHasTextQueryBaseURL = true;
        storeTextQueryBaseURL = new_value;
      }
    public void unsetTextQueryBaseURL()
      {
        flagHasTextQueryBaseURL = false;
      }
    public void setVoiceQueryURL(string new_value)
      {
        flagHasVoiceQueryURL = true;
        storeVoiceQueryURL = new_value;
      }
    public void unsetVoiceQueryURL()
      {
        flagHasVoiceQueryURL = false;
      }
    public void setProxyHost(string new_value)
      {
        flagHasProxyHost = true;
        storeProxyHost = new_value;
      }
    public void unsetProxyHost()
      {
        flagHasProxyHost = false;
      }
    public void setProxyPort(ushort new_value)
      {
        flagHasProxyPort = true;
        if (new_value < 0)
            throw new Exception("The value for field ProxyPort of HoundifyExplorerProfileJSON is less than the lower bound (0) for that field.");
        if (new_value > 65534)
            throw new Exception("The value for field ProxyPort of HoundifyExplorerProfileJSON is greater than the upper bound (65534) for that field.");
        storeProxyPort = new_value;
      }
    public void unsetProxyPort()
      {
        flagHasProxyPort = false;
      }
    public void setTimeOut(BigInteger new_value)
      {
        flagHasTimeOut = true;
        if (new_value < 0)
            throw new Exception("The value for field TimeOut of HoundifyExplorerProfileJSON is less than the lower bound (0) for that field.");
        storeTimeOut = new_value;
      }
    public void unsetTimeOut()
      {
        flagHasTimeOut = false;
      }
    public void setExtraRequestInfo(RequestInfoJSON  new_value)
      {
        if (flagHasExtraRequestInfo)
          {
          }
        flagHasExtraRequestInfo = true;
        storeExtraRequestInfo = new_value;
      }
    public void unsetExtraRequestInfo()
      {
        if (flagHasExtraRequestInfo)
          {
          }
        flagHasExtraRequestInfo = false;
      }
    public void initPluginFiles()
      {
        flagHasPluginFiles = true;
        storePluginFiles.Clear();
      }
    public void appendPluginFiles(string to_append)
      {
        if (!flagHasPluginFiles)
          {
            flagHasPluginFiles = true;
            storePluginFiles.Clear();
          }
        Debug.Assert(flagHasPluginFiles);
        storePluginFiles.Add(to_append);
      }
    public void unsetPluginFiles()
      {
        flagHasPluginFiles = false;
        storePluginFiles.Clear();
      }
    public void setPartialTranscriptionDisplayAction(TypePartialTranscriptionDisplayAction new_value)
      {
        flagHasPartialTranscriptionDisplayAction = true;
        storePartialTranscriptionDisplayAction = new_value;
      }
    public void setPartialTranscriptionDisplayAction(string chars)
      {
        setPartialTranscriptionDisplayAction(stringToPartialTranscriptionDisplayAction(chars));
      }
    public void unsetPartialTranscriptionDisplayAction()
      {
        flagHasPartialTranscriptionDisplayAction = false;
      }
    public void setVoiceInputFileChunkByteCount(BigInteger new_value)
      {
        flagHasVoiceInputFileChunkByteCount = true;
        if (new_value < 0)
            throw new Exception("The value for field VoiceInputFileChunkByteCount of HoundifyExplorerProfileJSON is less than the lower bound (0) for that field.");
        storeVoiceInputFileChunkByteCount = new_value;
      }
    public void unsetVoiceInputFileChunkByteCount()
      {
        flagHasVoiceInputFileChunkByteCount = false;
      }
    public void setVoiceInputFileChunkDelaySeconds(double new_value)
      {
        flagHasVoiceInputFileChunkDelaySeconds = true;
        if (new_value < 0)
            throw new Exception("The value for field VoiceInputFileChunkDelaySeconds of HoundifyExplorerProfileJSON is less than the lower bound (0) for that field.");
        storeVoiceInputFileChunkDelaySeconds = new_value;
        textStoreVoiceInputFileChunkDelaySeconds = "";
      }
    public void setVoiceInputFileChunkDelaySecondsText(string new_value)
      {
        flagHasVoiceInputFileChunkDelaySeconds = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field VoiceInputFileChunkDelaySeconds of HoundifyExplorerProfileJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field VoiceInputFileChunkDelaySeconds of HoundifyExplorerProfileJSON is less than the lower bound (0) for that field.");
        textStoreVoiceInputFileChunkDelaySeconds = new_value;
      }
    public void unsetVoiceInputFileChunkDelaySeconds()
      {
        flagHasVoiceInputFileChunkDelaySeconds = false;
      }
    public void setAudioInputToUse(string new_value)
      {
        flagHasAudioInputToUse = true;
        storeAudioInputToUse = new_value;
      }
    public void unsetAudioInputToUse()
      {
        flagHasAudioInputToUse = false;
      }
    public void setAudioOutputToUse(string new_value)
      {
        flagHasAudioOutputToUse = true;
        storeAudioOutputToUse = new_value;
      }
    public void unsetAudioOutputToUse()
      {
        flagHasAudioOutputToUse = false;
      }
    public void setOutputAudioDecoderToUse(string new_value)
      {
        flagHasOutputAudioDecoderToUse = true;
        storeOutputAudioDecoderToUse = new_value;
      }
    public void unsetOutputAudioDecoderToUse()
      {
        flagHasOutputAudioDecoderToUse = false;
      }
    public void setTextToSpeechToUse(string new_value)
      {
        flagHasTextToSpeechToUse = true;
        storeTextToSpeechToUse = new_value;
      }
    public void unsetTextToSpeechToUse()
      {
        flagHasTextToSpeechToUse = false;
      }
    public void initClientDomainUnitsToUse()
      {
        flagHasClientDomainUnitsToUse = true;
        storeClientDomainUnitsToUse.Clear();
      }
    public void appendClientDomainUnitsToUse(string to_append)
      {
        if (!flagHasClientDomainUnitsToUse)
          {
            flagHasClientDomainUnitsToUse = true;
            storeClientDomainUnitsToUse.Clear();
          }
        Debug.Assert(flagHasClientDomainUnitsToUse);
        storeClientDomainUnitsToUse.Add(to_append);
      }
    public void unsetClientDomainUnitsToUse()
      {
        flagHasClientDomainUnitsToUse = false;
        storeClientDomainUnitsToUse.Clear();
      }
    public void setListenStartSoundFile(string new_value)
      {
        flagHasListenStartSoundFile = true;
        storeListenStartSoundFile = new_value;
      }
    public void unsetListenStartSoundFile()
      {
        flagHasListenStartSoundFile = false;
      }
    public void setListenStopSoundFile(string new_value)
      {
        flagHasListenStopSoundFile = true;
        storeListenStopSoundFile = new_value;
      }
    public void unsetListenStopSoundFile()
      {
        flagHasListenStopSoundFile = false;
      }
    public void initLongStringFieldsToLimit()
      {
        flagHasLongStringFieldsToLimit = true;
        storeLongStringFieldsToLimit.Clear();
      }
    public void appendLongStringFieldsToLimit(string to_append)
      {
        if (!flagHasLongStringFieldsToLimit)
          {
            flagHasLongStringFieldsToLimit = true;
            storeLongStringFieldsToLimit.Clear();
          }
        Debug.Assert(flagHasLongStringFieldsToLimit);
        storeLongStringFieldsToLimit.Add(to_append);
      }
    public void unsetLongStringFieldsToLimit()
      {
        flagHasLongStringFieldsToLimit = false;
        storeLongStringFieldsToLimit.Clear();
      }
    public void setLongStringFieldByteLimit(BigInteger new_value)
      {
        flagHasLongStringFieldByteLimit = true;
        if (new_value < 0)
            throw new Exception("The value for field LongStringFieldByteLimit of HoundifyExplorerProfileJSON is less than the lower bound (0) for that field.");
        storeLongStringFieldByteLimit = new_value;
      }
    public void unsetLongStringFieldByteLimit()
      {
        flagHasLongStringFieldByteLimit = false;
      }

    public virtual void extraHoundifyExplorerProfileAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraHoundifyExplorerProfileSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraHoundifyExplorerProfileLookup(key);
        if (old_field == null)
          {
            extraHoundifyExplorerProfileAppendPair(key, new_component);
          }
        else
          {
            int count = extraKeys.Count;
            Debug.Assert(count == extraValues.Count);
            for (int num = 0; num < count; ++num)
              {
                if (extraKeys[num].Equals( key))
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

    public virtual void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public virtual void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        Debug.Assert(partial_allowed || flagHasName);
        if (flagHasName)
          {
            handler.start_pair("Name");
            handler.string_value(storeName);
          }
        Debug.Assert(partial_allowed || flagHasClientID);
        if (flagHasClientID)
          {
            handler.start_pair("ClientID");
            handler.string_value(storeClientID);
          }
        Debug.Assert(partial_allowed || flagHasClientKey);
        if (flagHasClientKey)
          {
            handler.start_pair("ClientKey");
            handler.string_value(storeClientKey);
          }
        Debug.Assert(partial_allowed || flagHasUserID);
        if (flagHasUserID)
          {
            handler.start_pair("UserID");
            handler.string_value(storeUserID);
          }
        if (flagHasTextQueryBaseURL)
          {
            handler.start_pair("TextQueryBaseURL");
            handler.string_value(storeTextQueryBaseURL);
          }
        if (flagHasVoiceQueryURL)
          {
            handler.start_pair("VoiceQueryURL");
            handler.string_value(storeVoiceQueryURL);
          }
        if (flagHasProxyHost)
          {
            handler.start_pair("ProxyHost");
            handler.string_value(storeProxyHost);
          }
        if (flagHasProxyPort)
          {
            handler.start_pair("ProxyPort");
            handler.number_value(storeProxyPort);
          }
        if (flagHasTimeOut)
          {
            handler.start_pair("TimeOut");
            handler.number_value(storeTimeOut);
          }
        if (flagHasExtraRequestInfo)
          {
            handler.start_pair("ExtraRequestInfo");
            if (partial_allowed)
                storeExtraRequestInfo.write_partial_as_json(handler);
            else
                storeExtraRequestInfo.write_as_json(handler);
          }
        if (flagHasPluginFiles)
          {
            handler.start_pair("PluginFiles");
            Debug.Assert(storePluginFiles.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storePluginFiles.Count; ++num1)
              {
                handler.string_value(storePluginFiles[num1]);
              }
            handler.finish_array();
          }
        if (flagHasPartialTranscriptionDisplayAction)
          {
            handler.start_pair("PartialTranscriptionDisplayAction");
            switch (storePartialTranscriptionDisplayAction)
              {
                case TypePartialTranscriptionDisplayAction.PartialTranscriptionDisplayAction_DisplayTextOverWrite:
                    handler.string_value("DisplayTextOverWrite");
                    break;
                case TypePartialTranscriptionDisplayAction.PartialTranscriptionDisplayAction_DisplayTextNoOverWrite:
                    handler.string_value("DisplayTextNoOverWrite");
                    break;
                case TypePartialTranscriptionDisplayAction.PartialTranscriptionDisplayAction_DisplayJSONFull:
                    handler.string_value("DisplayJSONFull");
                    break;
                case TypePartialTranscriptionDisplayAction.PartialTranscriptionDisplayAction_None:
                    handler.string_value("None");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasVoiceInputFileChunkByteCount)
          {
            handler.start_pair("VoiceInputFileChunkByteCount");
            handler.number_value(storeVoiceInputFileChunkByteCount);
          }
        if (flagHasVoiceInputFileChunkDelaySeconds)
          {
            handler.start_pair("VoiceInputFileChunkDelaySeconds");
            if (textStoreVoiceInputFileChunkDelaySeconds != "")
                handler.number_value(textStoreVoiceInputFileChunkDelaySeconds);
            else if (((double)(long)storeVoiceInputFileChunkDelaySeconds) == storeVoiceInputFileChunkDelaySeconds)
                handler.number_value((long)storeVoiceInputFileChunkDelaySeconds);
            else
                handler.number_value(storeVoiceInputFileChunkDelaySeconds);
          }
        if (flagHasAudioInputToUse)
          {
            handler.start_pair("AudioInputToUse");
            handler.string_value(storeAudioInputToUse);
          }
        if (flagHasAudioOutputToUse)
          {
            handler.start_pair("AudioOutputToUse");
            handler.string_value(storeAudioOutputToUse);
          }
        if (flagHasOutputAudioDecoderToUse)
          {
            handler.start_pair("OutputAudioDecoderToUse");
            handler.string_value(storeOutputAudioDecoderToUse);
          }
        if (flagHasTextToSpeechToUse)
          {
            handler.start_pair("TextToSpeechToUse");
            handler.string_value(storeTextToSpeechToUse);
          }
        if (flagHasClientDomainUnitsToUse)
          {
            handler.start_pair("ClientDomainUnitsToUse");
            Debug.Assert(storeClientDomainUnitsToUse.Count >= 1);
            handler.start_array();
            for (int num2 = 0; num2 < storeClientDomainUnitsToUse.Count; ++num2)
              {
                handler.string_value(storeClientDomainUnitsToUse[num2]);
              }
            handler.finish_array();
          }
        if (flagHasListenStartSoundFile)
          {
            handler.start_pair("ListenStartSoundFile");
            handler.string_value(storeListenStartSoundFile);
          }
        if (flagHasListenStopSoundFile)
          {
            handler.start_pair("ListenStopSoundFile");
            handler.string_value(storeListenStopSoundFile);
          }
        if (flagHasLongStringFieldsToLimit)
          {
            handler.start_pair("LongStringFieldsToLimit");
            handler.start_array();
            for (int num3 = 0; num3 < storeLongStringFieldsToLimit.Count; ++num3)
              {
                handler.string_value(storeLongStringFieldsToLimit[num3]);
              }
            handler.finish_array();
          }
        if (flagHasLongStringFieldByteLimit)
          {
            handler.start_pair("LongStringFieldByteLimit");
            handler.number_value(storeLongStringFieldByteLimit);
          }
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
    public virtual string missing_field_error(bool allow_unpolished)
      {
        if (!(hasName()))
          {
            return "When parsing the object for %what%, the \"Name\" field was missing.";
          }
        if (!(hasClientID()))
          {
            return "When parsing the object for %what%, the \"ClientID\" field was missing.";
          }
        if (!(hasClientKey()))
          {
            return "When parsing the object for %what%, the \"ClientKey\" field was missing.";
          }
        if (!(hasUserID()))
          {
            return "When parsing the object for %what%, the \"UserID\" field was missing.";
          }
        return null;
      }

    public static HoundifyExplorerProfileJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HoundifyExplorerProfileJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HoundifyExplorerProfile", ignore_extras);
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
    public static HoundifyExplorerProfileJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HoundifyExplorerProfileJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HoundifyExplorerProfileJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HoundifyExplorerProfile", ignore_extras);
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
    public static HoundifyExplorerProfileJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HoundifyExplorerProfileJSON from_text(string text, bool ignore_extras)
      {
        HoundifyExplorerProfileJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HoundifyExplorerProfile", ignore_extras);
            JSONParse.parse_json_value(text, "Text for HoundifyExplorerProfileJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static HoundifyExplorerProfileJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        HoundifyExplorerProfileJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HoundifyExplorerProfile", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorName;
        private JSONHoldingStringGenerator fieldGeneratorClientID;
        private JSONHoldingStringGenerator fieldGeneratorClientKey;
        private JSONHoldingStringGenerator fieldGeneratorUserID;
        private JSONHoldingStringGenerator fieldGeneratorTextQueryBaseURL;
        private JSONHoldingStringGenerator fieldGeneratorVoiceQueryURL;
        private JSONHoldingStringGenerator fieldGeneratorProxyHost;
    private class FieldHoldingGeneratorProxyPort : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorProxyPort(String what) : base(what, 0, 65534)
              {
              }
          };
    private class FieldHoldingArrayGeneratorProxyPort : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorProxyPort(String what) : base(what, 0, 65534)
              {
              }
          };
        private FieldHoldingGeneratorProxyPort fieldGeneratorProxyPort;
    private class FieldHoldingGeneratorTimeOut : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorTimeOut(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorTimeOut : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorTimeOut(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorTimeOut fieldGeneratorTimeOut;
        private RequestInfoJSON.HoldingGenerator fieldGeneratorExtraRequestInfo;
        private JSONHoldingStringArrayGenerator fieldGeneratorPluginFiles;
    private abstract class FieldGeneratorPartialTranscriptionDisplayAction : JSONStringGenerator
          {
            protected FieldGeneratorPartialTranscriptionDisplayAction(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorPartialTranscriptionDisplayAction()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToPartialTranscriptionDisplayAction(result));
              }
            protected abstract void handle_result(TypePartialTranscriptionDisplayAction result);
          };
    private class FieldHoldingGeneratorPartialTranscriptionDisplayAction : FieldGeneratorPartialTranscriptionDisplayAction
  {
    protected override void handle_result(TypePartialTranscriptionDisplayAction result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorPartialTranscriptionDisplayAction(String what)
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
    public TypePartialTranscriptionDisplayAction value;
  };
    private class FieldHoldingArrayGeneratorPartialTranscriptionDisplayAction : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorPartialTranscriptionDisplayAction
      {
        private FieldHoldingArrayGeneratorPartialTranscriptionDisplayAction top;

        protected override void handle_result(TypePartialTranscriptionDisplayAction result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorPartialTranscriptionDisplayAction init_top)
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
    protected virtual void handle_result(List<TypePartialTranscriptionDisplayAction> result)
      {
      }

    public FieldHoldingArrayGeneratorPartialTranscriptionDisplayAction(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypePartialTranscriptionDisplayAction>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorPartialTranscriptionDisplayAction()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypePartialTranscriptionDisplayAction>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypePartialTranscriptionDisplayAction> value;
  };
        private FieldHoldingGeneratorPartialTranscriptionDisplayAction fieldGeneratorPartialTranscriptionDisplayAction;
    private class FieldHoldingGeneratorVoiceInputFileChunkByteCount : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorVoiceInputFileChunkByteCount(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorVoiceInputFileChunkByteCount : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorVoiceInputFileChunkByteCount(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorVoiceInputFileChunkByteCount fieldGeneratorVoiceInputFileChunkByteCount;
        private JSONHoldingNumberTextGenerator fieldGeneratorVoiceInputFileChunkDelaySeconds;
        private JSONHoldingStringGenerator fieldGeneratorAudioInputToUse;
        private JSONHoldingStringGenerator fieldGeneratorAudioOutputToUse;
        private JSONHoldingStringGenerator fieldGeneratorOutputAudioDecoderToUse;
        private JSONHoldingStringGenerator fieldGeneratorTextToSpeechToUse;
        private JSONHoldingStringArrayGenerator fieldGeneratorClientDomainUnitsToUse;
        private JSONHoldingStringGenerator fieldGeneratorListenStartSoundFile;
        private JSONHoldingStringGenerator fieldGeneratorListenStopSoundFile;
        private JSONHoldingStringArrayGenerator fieldGeneratorLongStringFieldsToLimit;
    private class FieldHoldingGeneratorLongStringFieldByteLimit : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorLongStringFieldByteLimit(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorLongStringFieldByteLimit : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorLongStringFieldByteLimit(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorLongStringFieldByteLimit fieldGeneratorLongStringFieldByteLimit;
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
            HoundifyExplorerProfileJSON result = new HoundifyExplorerProfileJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraHoundifyExplorerProfileAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(HoundifyExplorerProfileJSON result)
          {
            if (fieldGeneratorName.have_value)
              {
                result.setName(fieldGeneratorName.value);
                fieldGeneratorName.have_value = false;
              }
            else if ((!(result.hasName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Name\" field was missing.");
              }
            if (fieldGeneratorClientID.have_value)
              {
                result.setClientID(fieldGeneratorClientID.value);
                fieldGeneratorClientID.have_value = false;
              }
            else if ((!(result.hasClientID())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ClientID\" field was missing.");
              }
            if (fieldGeneratorClientKey.have_value)
              {
                result.setClientKey(fieldGeneratorClientKey.value);
                fieldGeneratorClientKey.have_value = false;
              }
            else if ((!(result.hasClientKey())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ClientKey\" field was missing.");
              }
            if (fieldGeneratorUserID.have_value)
              {
                result.setUserID(fieldGeneratorUserID.value);
                fieldGeneratorUserID.have_value = false;
              }
            else if ((!(result.hasUserID())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"UserID\" field was missing.");
              }
            if (fieldGeneratorTextQueryBaseURL.have_value)
              {
                result.setTextQueryBaseURL(fieldGeneratorTextQueryBaseURL.value);
                fieldGeneratorTextQueryBaseURL.have_value = false;
              }
            if (fieldGeneratorVoiceQueryURL.have_value)
              {
                result.setVoiceQueryURL(fieldGeneratorVoiceQueryURL.value);
                fieldGeneratorVoiceQueryURL.have_value = false;
              }
            if (fieldGeneratorProxyHost.have_value)
              {
                result.setProxyHost(fieldGeneratorProxyHost.value);
                fieldGeneratorProxyHost.have_value = false;
              }
            if (fieldGeneratorProxyPort.have_value)
              {
                result.setProxyPort((ushort)(fieldGeneratorProxyPort.value));
                fieldGeneratorProxyPort.have_value = false;
              }
            if (fieldGeneratorTimeOut.have_value)
              {
                result.setTimeOut(fieldGeneratorTimeOut.value);
                fieldGeneratorTimeOut.have_value = false;
              }
            if (fieldGeneratorExtraRequestInfo.have_value)
              {
                result.setExtraRequestInfo(fieldGeneratorExtraRequestInfo.value);
                fieldGeneratorExtraRequestInfo.have_value = false;
              }
            if (fieldGeneratorPluginFiles.have_value)
              {
                result.initPluginFiles();
                int count = fieldGeneratorPluginFiles.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendPluginFiles(fieldGeneratorPluginFiles.value[num]);
                  }
                fieldGeneratorPluginFiles.value.Clear();
                fieldGeneratorPluginFiles.have_value = false;
              }
            if (fieldGeneratorPartialTranscriptionDisplayAction.have_value)
              {
                result.setPartialTranscriptionDisplayAction(fieldGeneratorPartialTranscriptionDisplayAction.value);
                fieldGeneratorPartialTranscriptionDisplayAction.have_value = false;
              }
            if (fieldGeneratorVoiceInputFileChunkByteCount.have_value)
              {
                result.setVoiceInputFileChunkByteCount(fieldGeneratorVoiceInputFileChunkByteCount.value);
                fieldGeneratorVoiceInputFileChunkByteCount.have_value = false;
              }
            if (fieldGeneratorVoiceInputFileChunkDelaySeconds.have_value)
              {
                result.setVoiceInputFileChunkDelaySecondsText(fieldGeneratorVoiceInputFileChunkDelaySeconds.value);
                fieldGeneratorVoiceInputFileChunkDelaySeconds.have_value = false;
              }
            if (fieldGeneratorAudioInputToUse.have_value)
              {
                result.setAudioInputToUse(fieldGeneratorAudioInputToUse.value);
                fieldGeneratorAudioInputToUse.have_value = false;
              }
            if (fieldGeneratorAudioOutputToUse.have_value)
              {
                result.setAudioOutputToUse(fieldGeneratorAudioOutputToUse.value);
                fieldGeneratorAudioOutputToUse.have_value = false;
              }
            if (fieldGeneratorOutputAudioDecoderToUse.have_value)
              {
                result.setOutputAudioDecoderToUse(fieldGeneratorOutputAudioDecoderToUse.value);
                fieldGeneratorOutputAudioDecoderToUse.have_value = false;
              }
            if (fieldGeneratorTextToSpeechToUse.have_value)
              {
                result.setTextToSpeechToUse(fieldGeneratorTextToSpeechToUse.value);
                fieldGeneratorTextToSpeechToUse.have_value = false;
              }
            if (fieldGeneratorClientDomainUnitsToUse.have_value)
              {
                result.initClientDomainUnitsToUse();
                int count = fieldGeneratorClientDomainUnitsToUse.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendClientDomainUnitsToUse(fieldGeneratorClientDomainUnitsToUse.value[num]);
                  }
                fieldGeneratorClientDomainUnitsToUse.value.Clear();
                fieldGeneratorClientDomainUnitsToUse.have_value = false;
              }
            if (fieldGeneratorListenStartSoundFile.have_value)
              {
                result.setListenStartSoundFile(fieldGeneratorListenStartSoundFile.value);
                fieldGeneratorListenStartSoundFile.have_value = false;
              }
            if (fieldGeneratorListenStopSoundFile.have_value)
              {
                result.setListenStopSoundFile(fieldGeneratorListenStopSoundFile.value);
                fieldGeneratorListenStopSoundFile.have_value = false;
              }
            if (fieldGeneratorLongStringFieldsToLimit.have_value)
              {
                result.initLongStringFieldsToLimit();
                int count = fieldGeneratorLongStringFieldsToLimit.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendLongStringFieldsToLimit(fieldGeneratorLongStringFieldsToLimit.value[num]);
                  }
                fieldGeneratorLongStringFieldsToLimit.value.Clear();
                fieldGeneratorLongStringFieldsToLimit.have_value = false;
              }
            if (fieldGeneratorLongStringFieldByteLimit.have_value)
              {
                result.setLongStringFieldByteLimit(fieldGeneratorLongStringFieldByteLimit.value);
                fieldGeneratorLongStringFieldByteLimit.have_value = false;
              }
          }
        protected abstract void handle_result(HoundifyExplorerProfileJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if (String.Compare(field_name, 1, "udio", 0, 4, false) == 0)
                      {
                        switch (field_name[5])
                          {
                            case 'I':
                                if ((String.Compare(field_name, 6, "nputToUse", 0, 9, false) == 0) && (field_name.Length == 15))
                                    return fieldGeneratorAudioInputToUse;
                                break;
                            case 'O':
                                if ((String.Compare(field_name, 6, "utputToUse", 0, 10, false) == 0) && (field_name.Length == 16))
                                    return fieldGeneratorAudioOutputToUse;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'C':
                    if (String.Compare(field_name, 1, "lient", 0, 5, false) == 0)
                      {
                        switch (field_name[6])
                          {
                            case 'D':
                                if ((String.Compare(field_name, 7, "omainUnitsToUse", 0, 15, false) == 0) && (field_name.Length == 22))
                                    return fieldGeneratorClientDomainUnitsToUse;
                                break;
                            case 'I':
                                if ((String.Compare(field_name, 7, "D", 0, 1, false) == 0) && (field_name.Length == 8))
                                    return fieldGeneratorClientID;
                                break;
                            case 'K':
                                if ((String.Compare(field_name, 7, "ey", 0, 2, false) == 0) && (field_name.Length == 9))
                                    return fieldGeneratorClientKey;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'E':
                    if ((String.Compare(field_name, 1, "xtraRequestInfo", 0, 15, false) == 0) && (field_name.Length == 16))
                        return fieldGeneratorExtraRequestInfo;
                    break;
                case 'L':
                    switch (field_name[1])
                      {
                        case 'i':
                            if (String.Compare(field_name, 2, "stenSt", 0, 6, false) == 0)
                              {
                                switch (field_name[8])
                                  {
                                    case 'a':
                                        if ((String.Compare(field_name, 9, "rtSoundFile", 0, 11, false) == 0) && (field_name.Length == 20))
                                            return fieldGeneratorListenStartSoundFile;
                                        break;
                                    case 'o':
                                        if ((String.Compare(field_name, 9, "pSoundFile", 0, 10, false) == 0) && (field_name.Length == 19))
                                            return fieldGeneratorListenStopSoundFile;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'o':
                            if (String.Compare(field_name, 2, "ngStringField", 0, 13, false) == 0)
                              {
                                switch (field_name[15])
                                  {
                                    case 'B':
                                        if ((String.Compare(field_name, 16, "yteLimit", 0, 8, false) == 0) && (field_name.Length == 24))
                                            return fieldGeneratorLongStringFieldByteLimit;
                                        break;
                                    case 's':
                                        if ((String.Compare(field_name, 16, "ToLimit", 0, 7, false) == 0) && (field_name.Length == 23))
                                            return fieldGeneratorLongStringFieldsToLimit;
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
                case 'N':
                    if ((String.Compare(field_name, 1, "ame", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorName;
                    break;
                case 'O':
                    if ((String.Compare(field_name, 1, "utputAudioDecoderToUse", 0, 22, false) == 0) && (field_name.Length == 23))
                        return fieldGeneratorOutputAudioDecoderToUse;
                    break;
                case 'P':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "rtialTranscriptionDisplayAction", 0, 31, false) == 0) && (field_name.Length == 33))
                                return fieldGeneratorPartialTranscriptionDisplayAction;
                            break;
                        case 'l':
                            if ((String.Compare(field_name, 2, "uginFiles", 0, 9, false) == 0) && (field_name.Length == 11))
                                return fieldGeneratorPluginFiles;
                            break;
                        case 'r':
                            if (String.Compare(field_name, 2, "oxy", 0, 3, false) == 0)
                              {
                                switch (field_name[5])
                                  {
                                    case 'H':
                                        if ((String.Compare(field_name, 6, "ost", 0, 3, false) == 0) && (field_name.Length == 9))
                                            return fieldGeneratorProxyHost;
                                        break;
                                    case 'P':
                                        if ((String.Compare(field_name, 6, "ort", 0, 3, false) == 0) && (field_name.Length == 9))
                                            return fieldGeneratorProxyPort;
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
                    switch (field_name[1])
                      {
                        case 'e':
                            if (String.Compare(field_name, 2, "xt", 0, 2, false) == 0)
                              {
                                switch (field_name[4])
                                  {
                                    case 'Q':
                                        if ((String.Compare(field_name, 5, "ueryBaseURL", 0, 11, false) == 0) && (field_name.Length == 16))
                                            return fieldGeneratorTextQueryBaseURL;
                                        break;
                                    case 'T':
                                        if ((String.Compare(field_name, 5, "oSpeechToUse", 0, 12, false) == 0) && (field_name.Length == 17))
                                            return fieldGeneratorTextToSpeechToUse;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'i':
                            if ((String.Compare(field_name, 2, "meOut", 0, 5, false) == 0) && (field_name.Length == 7))
                                return fieldGeneratorTimeOut;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'U':
                    if ((String.Compare(field_name, 1, "serID", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorUserID;
                    break;
                case 'V':
                    if (String.Compare(field_name, 1, "oice", 0, 4, false) == 0)
                      {
                        switch (field_name[5])
                          {
                            case 'I':
                                if (String.Compare(field_name, 6, "nputFileChunk", 0, 13, false) == 0)
                                  {
                                    switch (field_name[19])
                                      {
                                        case 'B':
                                            if ((String.Compare(field_name, 20, "yteCount", 0, 8, false) == 0) && (field_name.Length == 28))
                                                return fieldGeneratorVoiceInputFileChunkByteCount;
                                            break;
                                        case 'D':
                                            if ((String.Compare(field_name, 20, "elaySeconds", 0, 11, false) == 0) && (field_name.Length == 31))
                                                return fieldGeneratorVoiceInputFileChunkDelaySeconds;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'Q':
                                if ((String.Compare(field_name, 6, "ueryURL", 0, 7, false) == 0) && (field_name.Length == 13))
                                    return fieldGeneratorVoiceQueryURL;
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
            fieldGeneratorName = new JSONHoldingStringGenerator("field \"Name\" of the HoundifyExplorerProfile class");
            fieldGeneratorClientID = new JSONHoldingStringGenerator("field \"ClientID\" of the HoundifyExplorerProfile class");
            fieldGeneratorClientKey = new JSONHoldingStringGenerator("field \"ClientKey\" of the HoundifyExplorerProfile class");
            fieldGeneratorUserID = new JSONHoldingStringGenerator("field \"UserID\" of the HoundifyExplorerProfile class");
            fieldGeneratorTextQueryBaseURL = new JSONHoldingStringGenerator("field \"TextQueryBaseURL\" of the HoundifyExplorerProfile class");
            fieldGeneratorVoiceQueryURL = new JSONHoldingStringGenerator("field \"VoiceQueryURL\" of the HoundifyExplorerProfile class");
            fieldGeneratorProxyHost = new JSONHoldingStringGenerator("field \"ProxyHost\" of the HoundifyExplorerProfile class");
            fieldGeneratorProxyPort = new FieldHoldingGeneratorProxyPort("field \"ProxyPort\" of the HoundifyExplorerProfile class");
            fieldGeneratorTimeOut = new FieldHoldingGeneratorTimeOut("field \"TimeOut\" of the HoundifyExplorerProfile class");
            fieldGeneratorExtraRequestInfo = new RequestInfoJSON.HoldingGenerator("field \"ExtraRequestInfo\" of the HoundifyExplorerProfile class", ignore_extras);
            fieldGeneratorPluginFiles = new JSONHoldingStringArrayGenerator("field \"PluginFiles\" of the HoundifyExplorerProfile class");
            fieldGeneratorPartialTranscriptionDisplayAction = new FieldHoldingGeneratorPartialTranscriptionDisplayAction("field \"PartialTranscriptionDisplayAction\" of the HoundifyExplorerProfile class");
            fieldGeneratorVoiceInputFileChunkByteCount = new FieldHoldingGeneratorVoiceInputFileChunkByteCount("field \"VoiceInputFileChunkByteCount\" of the HoundifyExplorerProfile class");
            fieldGeneratorVoiceInputFileChunkDelaySeconds = new JSONHoldingNumberTextGenerator("field \"VoiceInputFileChunkDelaySeconds\" of the HoundifyExplorerProfile class");
            fieldGeneratorAudioInputToUse = new JSONHoldingStringGenerator("field \"AudioInputToUse\" of the HoundifyExplorerProfile class");
            fieldGeneratorAudioOutputToUse = new JSONHoldingStringGenerator("field \"AudioOutputToUse\" of the HoundifyExplorerProfile class");
            fieldGeneratorOutputAudioDecoderToUse = new JSONHoldingStringGenerator("field \"OutputAudioDecoderToUse\" of the HoundifyExplorerProfile class");
            fieldGeneratorTextToSpeechToUse = new JSONHoldingStringGenerator("field \"TextToSpeechToUse\" of the HoundifyExplorerProfile class");
            fieldGeneratorClientDomainUnitsToUse = new JSONHoldingStringArrayGenerator("field \"ClientDomainUnitsToUse\" of the HoundifyExplorerProfile class");
            fieldGeneratorListenStartSoundFile = new JSONHoldingStringGenerator("field \"ListenStartSoundFile\" of the HoundifyExplorerProfile class");
            fieldGeneratorListenStopSoundFile = new JSONHoldingStringGenerator("field \"ListenStopSoundFile\" of the HoundifyExplorerProfile class");
            fieldGeneratorLongStringFieldsToLimit = new JSONHoldingStringArrayGenerator("field \"LongStringFieldsToLimit\" of the HoundifyExplorerProfile class");
            fieldGeneratorLongStringFieldByteLimit = new FieldHoldingGeneratorLongStringFieldByteLimit("field \"LongStringFieldByteLimit\" of the HoundifyExplorerProfile class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the HoundifyExplorerProfile class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorName = new JSONHoldingStringGenerator("field \"Name\" of the HoundifyExplorerProfile class");
            fieldGeneratorClientID = new JSONHoldingStringGenerator("field \"ClientID\" of the HoundifyExplorerProfile class");
            fieldGeneratorClientKey = new JSONHoldingStringGenerator("field \"ClientKey\" of the HoundifyExplorerProfile class");
            fieldGeneratorUserID = new JSONHoldingStringGenerator("field \"UserID\" of the HoundifyExplorerProfile class");
            fieldGeneratorTextQueryBaseURL = new JSONHoldingStringGenerator("field \"TextQueryBaseURL\" of the HoundifyExplorerProfile class");
            fieldGeneratorVoiceQueryURL = new JSONHoldingStringGenerator("field \"VoiceQueryURL\" of the HoundifyExplorerProfile class");
            fieldGeneratorProxyHost = new JSONHoldingStringGenerator("field \"ProxyHost\" of the HoundifyExplorerProfile class");
            fieldGeneratorProxyPort = new FieldHoldingGeneratorProxyPort("field \"ProxyPort\" of the HoundifyExplorerProfile class");
            fieldGeneratorTimeOut = new FieldHoldingGeneratorTimeOut("field \"TimeOut\" of the HoundifyExplorerProfile class");
            fieldGeneratorExtraRequestInfo = new RequestInfoJSON.HoldingGenerator("field \"ExtraRequestInfo\" of the HoundifyExplorerProfile class", false);
            fieldGeneratorPluginFiles = new JSONHoldingStringArrayGenerator("field \"PluginFiles\" of the HoundifyExplorerProfile class");
            fieldGeneratorPartialTranscriptionDisplayAction = new FieldHoldingGeneratorPartialTranscriptionDisplayAction("field \"PartialTranscriptionDisplayAction\" of the HoundifyExplorerProfile class");
            fieldGeneratorVoiceInputFileChunkByteCount = new FieldHoldingGeneratorVoiceInputFileChunkByteCount("field \"VoiceInputFileChunkByteCount\" of the HoundifyExplorerProfile class");
            fieldGeneratorVoiceInputFileChunkDelaySeconds = new JSONHoldingNumberTextGenerator("field \"VoiceInputFileChunkDelaySeconds\" of the HoundifyExplorerProfile class");
            fieldGeneratorAudioInputToUse = new JSONHoldingStringGenerator("field \"AudioInputToUse\" of the HoundifyExplorerProfile class");
            fieldGeneratorAudioOutputToUse = new JSONHoldingStringGenerator("field \"AudioOutputToUse\" of the HoundifyExplorerProfile class");
            fieldGeneratorOutputAudioDecoderToUse = new JSONHoldingStringGenerator("field \"OutputAudioDecoderToUse\" of the HoundifyExplorerProfile class");
            fieldGeneratorTextToSpeechToUse = new JSONHoldingStringGenerator("field \"TextToSpeechToUse\" of the HoundifyExplorerProfile class");
            fieldGeneratorClientDomainUnitsToUse = new JSONHoldingStringArrayGenerator("field \"ClientDomainUnitsToUse\" of the HoundifyExplorerProfile class");
            fieldGeneratorListenStartSoundFile = new JSONHoldingStringGenerator("field \"ListenStartSoundFile\" of the HoundifyExplorerProfile class");
            fieldGeneratorListenStopSoundFile = new JSONHoldingStringGenerator("field \"ListenStopSoundFile\" of the HoundifyExplorerProfile class");
            fieldGeneratorLongStringFieldsToLimit = new JSONHoldingStringArrayGenerator("field \"LongStringFieldsToLimit\" of the HoundifyExplorerProfile class");
            fieldGeneratorLongStringFieldByteLimit = new FieldHoldingGeneratorLongStringFieldByteLimit("field \"LongStringFieldByteLimit\" of the HoundifyExplorerProfile class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the HoundifyExplorerProfile class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorName.reset();
            fieldGeneratorClientID.reset();
            fieldGeneratorClientKey.reset();
            fieldGeneratorUserID.reset();
            fieldGeneratorTextQueryBaseURL.reset();
            fieldGeneratorVoiceQueryURL.reset();
            fieldGeneratorProxyHost.reset();
            fieldGeneratorProxyPort.reset();
            fieldGeneratorTimeOut.reset();
            fieldGeneratorExtraRequestInfo.reset();
            fieldGeneratorPluginFiles.reset();
            fieldGeneratorPartialTranscriptionDisplayAction.reset();
            fieldGeneratorVoiceInputFileChunkByteCount.reset();
            fieldGeneratorVoiceInputFileChunkDelaySeconds.reset();
            fieldGeneratorAudioInputToUse.reset();
            fieldGeneratorAudioOutputToUse.reset();
            fieldGeneratorOutputAudioDecoderToUse.reset();
            fieldGeneratorTextToSpeechToUse.reset();
            fieldGeneratorClientDomainUnitsToUse.reset();
            fieldGeneratorListenStartSoundFile.reset();
            fieldGeneratorListenStopSoundFile.reset();
            fieldGeneratorLongStringFieldsToLimit.reset();
            fieldGeneratorLongStringFieldByteLimit.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorExtraRequestInfo.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorExtraRequestInfo.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(HoundifyExplorerProfileJSON  result)
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
        public HoundifyExplorerProfileJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(HoundifyExplorerProfileJSON  result)
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
    protected virtual void handle_result(List<HoundifyExplorerProfileJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<HoundifyExplorerProfileJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<HoundifyExplorerProfileJSON>();
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
    public List<HoundifyExplorerProfileJSON> value;
  };
  };
