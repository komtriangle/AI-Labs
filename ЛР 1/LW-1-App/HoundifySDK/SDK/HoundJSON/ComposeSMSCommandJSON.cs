/* file "ComposeSMSCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class ComposeSMSCommandJSON : SMSCommandJSON
  {
    private bool flagHasNativeData;
    private ComposeSMSCommandNativeDataJSON  storeNativeData;
    private bool flagHasNoSMSAppResult;
    private DynamicResponseJSON  storeNoSMSAppResult;
    private bool flagHasComposeSMSResult;
    private DynamicResponseJSON  storeComposeSMSResult;
    private bool flagHasDisambiguationSMSResult;
    private DynamicResponseJSON  storeDisambiguationSMSResult;
    private bool flagHasSendingSMSResult;
    private DynamicResponseJSON  storeSendingSMSResult;
    private bool flagHasSentSMSResult;
    private DynamicResponseJSON  storeSentSMSResult;
    private bool flagHasExitSMSResult;
    private DynamicResponseJSON  storeExitSMSResult;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraNativeDataToJSON()
      {
        JSONValueHandler handler_NativeData = new JSONValueHandler();
        storeNativeData.write_as_json(handler_NativeData);
        return handler_NativeData.result;
      }

    private JSONValue  extraNoSMSAppResultToJSON()
      {
        JSONValueHandler handler_NoSMSAppResult = new JSONValueHandler();
        storeNoSMSAppResult.write_as_json(handler_NoSMSAppResult);
        return handler_NoSMSAppResult.result;
      }

    private JSONValue  extraComposeSMSResultToJSON()
      {
        JSONValueHandler handler_ComposeSMSResult = new JSONValueHandler();
        storeComposeSMSResult.write_as_json(handler_ComposeSMSResult);
        return handler_ComposeSMSResult.result;
      }

    private JSONValue  extraDisambiguationSMSResultToJSON()
      {
        JSONValueHandler handler_DisambiguationSMSResult = new JSONValueHandler();
        storeDisambiguationSMSResult.write_as_json(handler_DisambiguationSMSResult);
        return handler_DisambiguationSMSResult.result;
      }

    private JSONValue  extraSendingSMSResultToJSON()
      {
        JSONValueHandler handler_SendingSMSResult = new JSONValueHandler();
        storeSendingSMSResult.write_as_json(handler_SendingSMSResult);
        return handler_SendingSMSResult.result;
      }

    private JSONValue  extraSentSMSResultToJSON()
      {
        JSONValueHandler handler_SentSMSResult = new JSONValueHandler();
        storeSentSMSResult.write_as_json(handler_SentSMSResult);
        return handler_SentSMSResult.result;
      }

    private JSONValue  extraExitSMSResultToJSON()
      {
        JSONValueHandler handler_ExitSMSResult = new JSONValueHandler();
        storeExitSMSResult.write_as_json(handler_ExitSMSResult);
        return handler_ExitSMSResult.result;
      }


    private void  fromJSONNativeData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        ComposeSMSCommandNativeDataJSON convert_classy = ComposeSMSCommandNativeDataJSON.from_json(json_value, ignore_extras, true);
        setNativeData(convert_classy);
      }


    private void  fromJSONNoSMSAppResult(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setNoSMSAppResult(convert_classy);
      }


    private void  fromJSONComposeSMSResult(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setComposeSMSResult(convert_classy);
      }


    private void  fromJSONDisambiguationSMSResult(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setDisambiguationSMSResult(convert_classy);
      }


    private void  fromJSONSendingSMSResult(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setSendingSMSResult(convert_classy);
      }


    private void  fromJSONSentSMSResult(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setSentSMSResult(convert_classy);
      }


    private void  fromJSONExitSMSResult(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setExitSMSResult(convert_classy);
      }


    public ComposeSMSCommandJSON()
      {
        flagHasNativeData = false;
        flagHasNoSMSAppResult = false;
        flagHasComposeSMSResult = false;
        flagHasDisambiguationSMSResult = false;
        flagHasSendingSMSResult = false;
        flagHasSentSMSResult = false;
        flagHasExitSMSResult = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getSMSCommandKind()
      {
        return "ComposeSMSCommand";
      }

    public bool  hasNativeData()
      {
        return flagHasNativeData;
      }

    public ComposeSMSCommandNativeDataJSON   getNativeData()
      {
        Debug.Assert(flagHasNativeData);
        return storeNativeData;
      }

    public bool  hasNoSMSAppResult()
      {
        return flagHasNoSMSAppResult;
      }

    public DynamicResponseJSON   getNoSMSAppResult()
      {
        Debug.Assert(flagHasNoSMSAppResult);
        return storeNoSMSAppResult;
      }

    public bool  hasComposeSMSResult()
      {
        return flagHasComposeSMSResult;
      }

    public DynamicResponseJSON   getComposeSMSResult()
      {
        Debug.Assert(flagHasComposeSMSResult);
        return storeComposeSMSResult;
      }

    public bool  hasDisambiguationSMSResult()
      {
        return flagHasDisambiguationSMSResult;
      }

    public DynamicResponseJSON   getDisambiguationSMSResult()
      {
        Debug.Assert(flagHasDisambiguationSMSResult);
        return storeDisambiguationSMSResult;
      }

    public bool  hasSendingSMSResult()
      {
        return flagHasSendingSMSResult;
      }

    public DynamicResponseJSON   getSendingSMSResult()
      {
        Debug.Assert(flagHasSendingSMSResult);
        return storeSendingSMSResult;
      }

    public bool  hasSentSMSResult()
      {
        return flagHasSentSMSResult;
      }

    public DynamicResponseJSON   getSentSMSResult()
      {
        Debug.Assert(flagHasSentSMSResult);
        return storeSentSMSResult;
      }

    public bool  hasExitSMSResult()
      {
        return flagHasExitSMSResult;
      }

    public DynamicResponseJSON   getExitSMSResult()
      {
        Debug.Assert(flagHasExitSMSResult);
        return storeExitSMSResult;
      }


    public virtual int extraComposeSMSCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraComposeSMSCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraComposeSMSCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraComposeSMSCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraSMSCommandComponentCount()
      {
        int result = 0;
        if (flagHasNativeData)
            ++result;
        if (flagHasNoSMSAppResult)
            ++result;
        if (flagHasComposeSMSResult)
            ++result;
        if (flagHasDisambiguationSMSResult)
            ++result;
        if (flagHasSendingSMSResult)
            ++result;
        if (flagHasSentSMSResult)
            ++result;
        if (flagHasExitSMSResult)
            ++result;
        result += extraComposeSMSCommandComponentCount();
        return result;
      }
    public override string extraSMSCommandComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasNativeData)
          {
            if (remainder == 0)
                return "NativeData";
            --remainder;
          }
        if (flagHasNoSMSAppResult)
          {
            if (remainder == 0)
                return "NoSMSAppResult";
            --remainder;
          }
        if (flagHasComposeSMSResult)
          {
            if (remainder == 0)
                return "ComposeSMSResult";
            --remainder;
          }
        if (flagHasDisambiguationSMSResult)
          {
            if (remainder == 0)
                return "DisambiguationSMSResult";
            --remainder;
          }
        if (flagHasSendingSMSResult)
          {
            if (remainder == 0)
                return "SendingSMSResult";
            --remainder;
          }
        if (flagHasSentSMSResult)
          {
            if (remainder == 0)
                return "SentSMSResult";
            --remainder;
          }
        if (flagHasExitSMSResult)
          {
            if (remainder == 0)
                return "ExitSMSResult";
            --remainder;
          }
        return extraComposeSMSCommandComponentKey(remainder);
      }
    public override JSONValue extraSMSCommandComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasNativeData)
          {
            if (remainder == 0)
                return extraNativeDataToJSON();
            --remainder;
          }
        if (flagHasNoSMSAppResult)
          {
            if (remainder == 0)
                return extraNoSMSAppResultToJSON();
            --remainder;
          }
        if (flagHasComposeSMSResult)
          {
            if (remainder == 0)
                return extraComposeSMSResultToJSON();
            --remainder;
          }
        if (flagHasDisambiguationSMSResult)
          {
            if (remainder == 0)
                return extraDisambiguationSMSResultToJSON();
            --remainder;
          }
        if (flagHasSendingSMSResult)
          {
            if (remainder == 0)
                return extraSendingSMSResultToJSON();
            --remainder;
          }
        if (flagHasSentSMSResult)
          {
            if (remainder == 0)
                return extraSentSMSResultToJSON();
            --remainder;
          }
        if (flagHasExitSMSResult)
          {
            if (remainder == 0)
                return extraExitSMSResultToJSON();
            --remainder;
          }
        return extraComposeSMSCommandComponentValue(remainder);
      }
    public override JSONValue extraSMSCommandLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'C':
                if ((String.Compare(field_name, 1, "omposeSMSResult", 0, 15, false) == 0) && (field_name.Length == 16))
                    return (flagHasComposeSMSResult ? extraComposeSMSResultToJSON() : null);
                break;
            case 'D':
                if ((String.Compare(field_name, 1, "isambiguationSMSResult", 0, 22, false) == 0) && (field_name.Length == 23))
                    return (flagHasDisambiguationSMSResult ? extraDisambiguationSMSResultToJSON() : null);
                break;
            case 'E':
                if ((String.Compare(field_name, 1, "xitSMSResult", 0, 12, false) == 0) && (field_name.Length == 13))
                    return (flagHasExitSMSResult ? extraExitSMSResultToJSON() : null);
                break;
            case 'N':
                switch (field_name[1])
                  {
                    case 'a':
                        if ((String.Compare(field_name, 2, "tiveData", 0, 8, false) == 0) && (field_name.Length == 10))
                            return (flagHasNativeData ? extraNativeDataToJSON() : null);
                        break;
                    case 'o':
                        if ((String.Compare(field_name, 2, "SMSAppResult", 0, 12, false) == 0) && (field_name.Length == 14))
                            return (flagHasNoSMSAppResult ? extraNoSMSAppResultToJSON() : null);
                        break;
                    default:
                        break;
                  }
                break;
            case 'S':
                if (String.Compare(field_name, 1, "en", 0, 2, false) == 0)
                  {
                    switch (field_name[3])
                      {
                        case 'd':
                            if ((String.Compare(field_name, 4, "ingSMSResult", 0, 12, false) == 0) && (field_name.Length == 16))
                                return (flagHasSendingSMSResult ? extraSendingSMSResultToJSON() : null);
                            break;
                        case 't':
                            if ((String.Compare(field_name, 4, "SMSResult", 0, 9, false) == 0) && (field_name.Length == 13))
                                return (flagHasSentSMSResult ? extraSentSMSResultToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        return extraComposeSMSCommandLookup(field_name);
      }

    public void setNativeData(ComposeSMSCommandNativeDataJSON  new_value)
      {
        if (flagHasNativeData)
          {
          }
        flagHasNativeData = true;
        storeNativeData = new_value;
      }
    public void unsetNativeData()
      {
        if (flagHasNativeData)
          {
          }
        flagHasNativeData = false;
      }
    public void setNoSMSAppResult(DynamicResponseJSON  new_value)
      {
        if (flagHasNoSMSAppResult)
          {
          }
        flagHasNoSMSAppResult = true;
        storeNoSMSAppResult = new_value;
      }
    public void unsetNoSMSAppResult()
      {
        if (flagHasNoSMSAppResult)
          {
          }
        flagHasNoSMSAppResult = false;
      }
    public void setComposeSMSResult(DynamicResponseJSON  new_value)
      {
        if (flagHasComposeSMSResult)
          {
          }
        flagHasComposeSMSResult = true;
        storeComposeSMSResult = new_value;
      }
    public void unsetComposeSMSResult()
      {
        if (flagHasComposeSMSResult)
          {
          }
        flagHasComposeSMSResult = false;
      }
    public void setDisambiguationSMSResult(DynamicResponseJSON  new_value)
      {
        if (flagHasDisambiguationSMSResult)
          {
          }
        flagHasDisambiguationSMSResult = true;
        storeDisambiguationSMSResult = new_value;
      }
    public void unsetDisambiguationSMSResult()
      {
        if (flagHasDisambiguationSMSResult)
          {
          }
        flagHasDisambiguationSMSResult = false;
      }
    public void setSendingSMSResult(DynamicResponseJSON  new_value)
      {
        if (flagHasSendingSMSResult)
          {
          }
        flagHasSendingSMSResult = true;
        storeSendingSMSResult = new_value;
      }
    public void unsetSendingSMSResult()
      {
        if (flagHasSendingSMSResult)
          {
          }
        flagHasSendingSMSResult = false;
      }
    public void setSentSMSResult(DynamicResponseJSON  new_value)
      {
        if (flagHasSentSMSResult)
          {
          }
        flagHasSentSMSResult = true;
        storeSentSMSResult = new_value;
      }
    public void unsetSentSMSResult()
      {
        if (flagHasSentSMSResult)
          {
          }
        flagHasSentSMSResult = false;
      }
    public void setExitSMSResult(DynamicResponseJSON  new_value)
      {
        if (flagHasExitSMSResult)
          {
          }
        flagHasExitSMSResult = true;
        storeExitSMSResult = new_value;
      }
    public void unsetExitSMSResult()
      {
        if (flagHasExitSMSResult)
          {
          }
        flagHasExitSMSResult = false;
      }

    public virtual void extraComposeSMSCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraComposeSMSCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraComposeSMSCommandLookup(key);
        if (old_field == null)
          {
            extraComposeSMSCommandAppendPair(key, new_component);
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
    public override void extraSMSCommandAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                if ((String.Compare(key, 1, "omposeSMSResult", 0, 15, false) == 0) && (key.Length == 16))
                    {
                    fromJSONComposeSMSResult(new_component, false);
                    return;
                    }
                break;
            case 'D':
                if ((String.Compare(key, 1, "isambiguationSMSResult", 0, 22, false) == 0) && (key.Length == 23))
                    {
                    fromJSONDisambiguationSMSResult(new_component, false);
                    return;
                    }
                break;
            case 'E':
                if ((String.Compare(key, 1, "xitSMSResult", 0, 12, false) == 0) && (key.Length == 13))
                    {
                    fromJSONExitSMSResult(new_component, false);
                    return;
                    }
                break;
            case 'N':
                switch (key[1])
                  {
                    case 'a':
                        if ((String.Compare(key, 2, "tiveData", 0, 8, false) == 0) && (key.Length == 10))
                            {
                            fromJSONNativeData(new_component, false);
                            return;
                            }
                        break;
                    case 'o':
                        if ((String.Compare(key, 2, "SMSAppResult", 0, 12, false) == 0) && (key.Length == 14))
                            {
                            fromJSONNoSMSAppResult(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'S':
                if (String.Compare(key, 1, "en", 0, 2, false) == 0)
                  {
                    switch (key[3])
                      {
                        case 'd':
                            if ((String.Compare(key, 4, "ingSMSResult", 0, 12, false) == 0) && (key.Length == 16))
                                {
                                fromJSONSendingSMSResult(new_component, false);
                                return;
                                }
                            break;
                        case 't':
                            if ((String.Compare(key, 4, "SMSResult", 0, 9, false) == 0) && (key.Length == 13))
                                {
                                fromJSONSentSMSResult(new_component, false);
                                return;
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
        extraComposeSMSCommandAppendPair(key, new_component);
      }
    public override void extraSMSCommandSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                if ((String.Compare(key, 1, "omposeSMSResult", 0, 15, false) == 0) && (key.Length == 16))
                    {
                    fromJSONComposeSMSResult(new_component, false);
                    return;
                    }
                break;
            case 'D':
                if ((String.Compare(key, 1, "isambiguationSMSResult", 0, 22, false) == 0) && (key.Length == 23))
                    {
                    fromJSONDisambiguationSMSResult(new_component, false);
                    return;
                    }
                break;
            case 'E':
                if ((String.Compare(key, 1, "xitSMSResult", 0, 12, false) == 0) && (key.Length == 13))
                    {
                    fromJSONExitSMSResult(new_component, false);
                    return;
                    }
                break;
            case 'N':
                switch (key[1])
                  {
                    case 'a':
                        if ((String.Compare(key, 2, "tiveData", 0, 8, false) == 0) && (key.Length == 10))
                            {
                            fromJSONNativeData(new_component, false);
                            return;
                            }
                        break;
                    case 'o':
                        if ((String.Compare(key, 2, "SMSAppResult", 0, 12, false) == 0) && (key.Length == 14))
                            {
                            fromJSONNoSMSAppResult(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'S':
                if (String.Compare(key, 1, "en", 0, 2, false) == 0)
                  {
                    switch (key[3])
                      {
                        case 'd':
                            if ((String.Compare(key, 4, "ingSMSResult", 0, 12, false) == 0) && (key.Length == 16))
                                {
                                fromJSONSendingSMSResult(new_component, false);
                                return;
                                }
                            break;
                        case 't':
                            if ((String.Compare(key, 4, "SMSResult", 0, 9, false) == 0) && (key.Length == 13))
                                {
                                fromJSONSentSMSResult(new_component, false);
                                return;
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
        extraComposeSMSCommandSetField(key, new_component);
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

    public override void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public override void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        base.write_fields_as_json(handler, partial_allowed);
        Debug.Assert(partial_allowed || flagHasNativeData);
        if (flagHasNativeData)
          {
            handler.start_pair("NativeData");
            if (partial_allowed)
                storeNativeData.write_partial_as_json(handler);
            else
                storeNativeData.write_as_json(handler);
          }
        if (flagHasNoSMSAppResult)
          {
            handler.start_pair("NoSMSAppResult");
            if (partial_allowed)
                storeNoSMSAppResult.write_partial_as_json(handler);
            else
                storeNoSMSAppResult.write_as_json(handler);
          }
        if (flagHasComposeSMSResult)
          {
            handler.start_pair("ComposeSMSResult");
            if (partial_allowed)
                storeComposeSMSResult.write_partial_as_json(handler);
            else
                storeComposeSMSResult.write_as_json(handler);
          }
        if (flagHasDisambiguationSMSResult)
          {
            handler.start_pair("DisambiguationSMSResult");
            if (partial_allowed)
                storeDisambiguationSMSResult.write_partial_as_json(handler);
            else
                storeDisambiguationSMSResult.write_as_json(handler);
          }
        if (flagHasSendingSMSResult)
          {
            handler.start_pair("SendingSMSResult");
            if (partial_allowed)
                storeSendingSMSResult.write_partial_as_json(handler);
            else
                storeSendingSMSResult.write_as_json(handler);
          }
        if (flagHasSentSMSResult)
          {
            handler.start_pair("SentSMSResult");
            if (partial_allowed)
                storeSentSMSResult.write_partial_as_json(handler);
            else
                storeSentSMSResult.write_as_json(handler);
          }
        if (flagHasExitSMSResult)
          {
            handler.start_pair("ExitSMSResult");
            if (partial_allowed)
                storeExitSMSResult.write_partial_as_json(handler);
            else
                storeExitSMSResult.write_as_json(handler);
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
    public override string missing_field_error(bool allow_unpolished)
      {
        if (!(hasNativeData()))
          {
            return "When parsing the object for %what%, the \"NativeData\" field was missing.";
          }
        return null;
      }

    public static new ComposeSMSCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ComposeSMSCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ComposeSMSCommand", ignore_extras);
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
    public static new ComposeSMSCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ComposeSMSCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ComposeSMSCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ComposeSMSCommand", ignore_extras);
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
    public static new ComposeSMSCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ComposeSMSCommandJSON from_text(string text, bool ignore_extras)
      {
        ComposeSMSCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ComposeSMSCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ComposeSMSCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new ComposeSMSCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ComposeSMSCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ComposeSMSCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : SMSCommandJSON.Generator
      {
        private ComposeSMSCommandNativeDataJSON.HoldingGenerator fieldGeneratorNativeData;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorNoSMSAppResult;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorComposeSMSResult;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorDisambiguationSMSResult;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorSendingSMSResult;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorSentSMSResult;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorExitSMSResult;
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
            if (!(getSMSCommandJSONKey().Equals("ComposeSMSCommand")))
                throw new Exception("The key field has a value other than `ComposeSMSCommand'.");
            ComposeSMSCommandJSON result = new ComposeSMSCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraComposeSMSCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(SMSCommandJSON new_result)
          {
            handle_result((ComposeSMSCommandJSON )new_result);
          }
        protected void finish(ComposeSMSCommandJSON result)
          {
            if (fieldGeneratorNativeData.have_value)
              {
                result.setNativeData(fieldGeneratorNativeData.value);
                fieldGeneratorNativeData.have_value = false;
              }
            else if ((!(result.hasNativeData())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"NativeData\" field was missing.");
              }
            if (fieldGeneratorNoSMSAppResult.have_value)
              {
                result.setNoSMSAppResult(fieldGeneratorNoSMSAppResult.value);
                fieldGeneratorNoSMSAppResult.have_value = false;
              }
            if (fieldGeneratorComposeSMSResult.have_value)
              {
                result.setComposeSMSResult(fieldGeneratorComposeSMSResult.value);
                fieldGeneratorComposeSMSResult.have_value = false;
              }
            if (fieldGeneratorDisambiguationSMSResult.have_value)
              {
                result.setDisambiguationSMSResult(fieldGeneratorDisambiguationSMSResult.value);
                fieldGeneratorDisambiguationSMSResult.have_value = false;
              }
            if (fieldGeneratorSendingSMSResult.have_value)
              {
                result.setSendingSMSResult(fieldGeneratorSendingSMSResult.value);
                fieldGeneratorSendingSMSResult.have_value = false;
              }
            if (fieldGeneratorSentSMSResult.have_value)
              {
                result.setSentSMSResult(fieldGeneratorSentSMSResult.value);
                fieldGeneratorSentSMSResult.have_value = false;
              }
            if (fieldGeneratorExitSMSResult.have_value)
              {
                result.setExitSMSResult(fieldGeneratorExitSMSResult.value);
                fieldGeneratorExitSMSResult.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(ComposeSMSCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "omposeSMSResult", 0, 15, false) == 0) && (field_name.Length == 16))
                        return fieldGeneratorComposeSMSResult;
                    break;
                case 'D':
                    if ((String.Compare(field_name, 1, "isambiguationSMSResult", 0, 22, false) == 0) && (field_name.Length == 23))
                        return fieldGeneratorDisambiguationSMSResult;
                    break;
                case 'E':
                    if ((String.Compare(field_name, 1, "xitSMSResult", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorExitSMSResult;
                    break;
                case 'N':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "tiveData", 0, 8, false) == 0) && (field_name.Length == 10))
                                return fieldGeneratorNativeData;
                            break;
                        case 'o':
                            if ((String.Compare(field_name, 2, "SMSAppResult", 0, 12, false) == 0) && (field_name.Length == 14))
                                return fieldGeneratorNoSMSAppResult;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'S':
                    if (String.Compare(field_name, 1, "en", 0, 2, false) == 0)
                      {
                        switch (field_name[3])
                          {
                            case 'd':
                                if ((String.Compare(field_name, 4, "ingSMSResult", 0, 12, false) == 0) && (field_name.Length == 16))
                                    return fieldGeneratorSendingSMSResult;
                                break;
                            case 't':
                                if ((String.Compare(field_name, 4, "SMSResult", 0, 9, false) == 0) && (field_name.Length == 13))
                                    return fieldGeneratorSentSMSResult;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorNativeData = new ComposeSMSCommandNativeDataJSON.HoldingGenerator("field \"NativeData\" of the ComposeSMSCommand class", ignore_extras);
            fieldGeneratorNoSMSAppResult = new DynamicResponseJSON.HoldingGenerator("field \"NoSMSAppResult\" of the ComposeSMSCommand class", ignore_extras);
            fieldGeneratorComposeSMSResult = new DynamicResponseJSON.HoldingGenerator("field \"ComposeSMSResult\" of the ComposeSMSCommand class", ignore_extras);
            fieldGeneratorDisambiguationSMSResult = new DynamicResponseJSON.HoldingGenerator("field \"DisambiguationSMSResult\" of the ComposeSMSCommand class", ignore_extras);
            fieldGeneratorSendingSMSResult = new DynamicResponseJSON.HoldingGenerator("field \"SendingSMSResult\" of the ComposeSMSCommand class", ignore_extras);
            fieldGeneratorSentSMSResult = new DynamicResponseJSON.HoldingGenerator("field \"SentSMSResult\" of the ComposeSMSCommand class", ignore_extras);
            fieldGeneratorExitSMSResult = new DynamicResponseJSON.HoldingGenerator("field \"ExitSMSResult\" of the ComposeSMSCommand class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the ComposeSMSCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorNativeData = new ComposeSMSCommandNativeDataJSON.HoldingGenerator("field \"NativeData\" of the ComposeSMSCommand class", false);
            fieldGeneratorNoSMSAppResult = new DynamicResponseJSON.HoldingGenerator("field \"NoSMSAppResult\" of the ComposeSMSCommand class", false);
            fieldGeneratorComposeSMSResult = new DynamicResponseJSON.HoldingGenerator("field \"ComposeSMSResult\" of the ComposeSMSCommand class", false);
            fieldGeneratorDisambiguationSMSResult = new DynamicResponseJSON.HoldingGenerator("field \"DisambiguationSMSResult\" of the ComposeSMSCommand class", false);
            fieldGeneratorSendingSMSResult = new DynamicResponseJSON.HoldingGenerator("field \"SendingSMSResult\" of the ComposeSMSCommand class", false);
            fieldGeneratorSentSMSResult = new DynamicResponseJSON.HoldingGenerator("field \"SentSMSResult\" of the ComposeSMSCommand class", false);
            fieldGeneratorExitSMSResult = new DynamicResponseJSON.HoldingGenerator("field \"ExitSMSResult\" of the ComposeSMSCommand class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the ComposeSMSCommand class");
          }

        public override void reset()
          {
            fieldGeneratorNativeData.reset();
            fieldGeneratorNoSMSAppResult.reset();
            fieldGeneratorComposeSMSResult.reset();
            fieldGeneratorDisambiguationSMSResult.reset();
            fieldGeneratorSendingSMSResult.reset();
            fieldGeneratorSentSMSResult.reset();
            fieldGeneratorExitSMSResult.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(ComposeSMSCommandJSON  result)
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
        public ComposeSMSCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ComposeSMSCommandJSON  result)
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
    protected virtual void handle_result(List<ComposeSMSCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ComposeSMSCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ComposeSMSCommandJSON>();
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
    public List<ComposeSMSCommandJSON> value;
  };
  };
