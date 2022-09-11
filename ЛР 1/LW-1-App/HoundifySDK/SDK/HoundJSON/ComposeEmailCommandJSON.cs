/* file "ComposeEmailCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class ComposeEmailCommandJSON : EmailCommandJSON
  {
    private bool flagHasNativeData;
    private ComposeEmailCommandNativeDataJSON  storeNativeData;
    private bool flagHasNoEmailAppResult;
    private DynamicResponseJSON  storeNoEmailAppResult;
    private bool flagHasComposeEmailResult;
    private DynamicResponseJSON  storeComposeEmailResult;
    private bool flagHasDisambiguationEmailResult;
    private DynamicResponseJSON  storeDisambiguationEmailResult;
    private bool flagHasSendingEmailResult;
    private DynamicResponseJSON  storeSendingEmailResult;
    private bool flagHasSentEmailResult;
    private DynamicResponseJSON  storeSentEmailResult;
    private bool flagHasExitEmailResult;
    private DynamicResponseJSON  storeExitEmailResult;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraNativeDataToJSON()
      {
        JSONValueHandler handler_NativeData = new JSONValueHandler();
        storeNativeData.write_as_json(handler_NativeData);
        return handler_NativeData.result;
      }

    private JSONValue  extraNoEmailAppResultToJSON()
      {
        JSONValueHandler handler_NoEmailAppResult = new JSONValueHandler();
        storeNoEmailAppResult.write_as_json(handler_NoEmailAppResult);
        return handler_NoEmailAppResult.result;
      }

    private JSONValue  extraComposeEmailResultToJSON()
      {
        JSONValueHandler handler_ComposeEmailResult = new JSONValueHandler();
        storeComposeEmailResult.write_as_json(handler_ComposeEmailResult);
        return handler_ComposeEmailResult.result;
      }

    private JSONValue  extraDisambiguationEmailResultToJSON()
      {
        JSONValueHandler handler_DisambiguationEmailResult = new JSONValueHandler();
        storeDisambiguationEmailResult.write_as_json(handler_DisambiguationEmailResult);
        return handler_DisambiguationEmailResult.result;
      }

    private JSONValue  extraSendingEmailResultToJSON()
      {
        JSONValueHandler handler_SendingEmailResult = new JSONValueHandler();
        storeSendingEmailResult.write_as_json(handler_SendingEmailResult);
        return handler_SendingEmailResult.result;
      }

    private JSONValue  extraSentEmailResultToJSON()
      {
        JSONValueHandler handler_SentEmailResult = new JSONValueHandler();
        storeSentEmailResult.write_as_json(handler_SentEmailResult);
        return handler_SentEmailResult.result;
      }

    private JSONValue  extraExitEmailResultToJSON()
      {
        JSONValueHandler handler_ExitEmailResult = new JSONValueHandler();
        storeExitEmailResult.write_as_json(handler_ExitEmailResult);
        return handler_ExitEmailResult.result;
      }


    private void  fromJSONNativeData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        ComposeEmailCommandNativeDataJSON convert_classy = ComposeEmailCommandNativeDataJSON.from_json(json_value, ignore_extras, true);
        setNativeData(convert_classy);
      }


    private void  fromJSONNoEmailAppResult(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setNoEmailAppResult(convert_classy);
      }


    private void  fromJSONComposeEmailResult(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setComposeEmailResult(convert_classy);
      }


    private void  fromJSONDisambiguationEmailResult(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setDisambiguationEmailResult(convert_classy);
      }


    private void  fromJSONSendingEmailResult(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setSendingEmailResult(convert_classy);
      }


    private void  fromJSONSentEmailResult(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setSentEmailResult(convert_classy);
      }


    private void  fromJSONExitEmailResult(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setExitEmailResult(convert_classy);
      }


    public ComposeEmailCommandJSON()
      {
        flagHasNativeData = false;
        flagHasNoEmailAppResult = false;
        flagHasComposeEmailResult = false;
        flagHasDisambiguationEmailResult = false;
        flagHasSendingEmailResult = false;
        flagHasSentEmailResult = false;
        flagHasExitEmailResult = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getEmailCommandKind()
      {
        return "ComposeEmailCommand";
      }

    public bool  hasNativeData()
      {
        return flagHasNativeData;
      }

    public ComposeEmailCommandNativeDataJSON   getNativeData()
      {
        Debug.Assert(flagHasNativeData);
        return storeNativeData;
      }

    public bool  hasNoEmailAppResult()
      {
        return flagHasNoEmailAppResult;
      }

    public DynamicResponseJSON   getNoEmailAppResult()
      {
        Debug.Assert(flagHasNoEmailAppResult);
        return storeNoEmailAppResult;
      }

    public bool  hasComposeEmailResult()
      {
        return flagHasComposeEmailResult;
      }

    public DynamicResponseJSON   getComposeEmailResult()
      {
        Debug.Assert(flagHasComposeEmailResult);
        return storeComposeEmailResult;
      }

    public bool  hasDisambiguationEmailResult()
      {
        return flagHasDisambiguationEmailResult;
      }

    public DynamicResponseJSON   getDisambiguationEmailResult()
      {
        Debug.Assert(flagHasDisambiguationEmailResult);
        return storeDisambiguationEmailResult;
      }

    public bool  hasSendingEmailResult()
      {
        return flagHasSendingEmailResult;
      }

    public DynamicResponseJSON   getSendingEmailResult()
      {
        Debug.Assert(flagHasSendingEmailResult);
        return storeSendingEmailResult;
      }

    public bool  hasSentEmailResult()
      {
        return flagHasSentEmailResult;
      }

    public DynamicResponseJSON   getSentEmailResult()
      {
        Debug.Assert(flagHasSentEmailResult);
        return storeSentEmailResult;
      }

    public bool  hasExitEmailResult()
      {
        return flagHasExitEmailResult;
      }

    public DynamicResponseJSON   getExitEmailResult()
      {
        Debug.Assert(flagHasExitEmailResult);
        return storeExitEmailResult;
      }


    public virtual int extraComposeEmailCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraComposeEmailCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraComposeEmailCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraComposeEmailCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraEmailCommandComponentCount()
      {
        int result = 0;
        if (flagHasNativeData)
            ++result;
        if (flagHasNoEmailAppResult)
            ++result;
        if (flagHasComposeEmailResult)
            ++result;
        if (flagHasDisambiguationEmailResult)
            ++result;
        if (flagHasSendingEmailResult)
            ++result;
        if (flagHasSentEmailResult)
            ++result;
        if (flagHasExitEmailResult)
            ++result;
        result += extraComposeEmailCommandComponentCount();
        return result;
      }
    public override string extraEmailCommandComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasNativeData)
          {
            if (remainder == 0)
                return "NativeData";
            --remainder;
          }
        if (flagHasNoEmailAppResult)
          {
            if (remainder == 0)
                return "NoEmailAppResult";
            --remainder;
          }
        if (flagHasComposeEmailResult)
          {
            if (remainder == 0)
                return "ComposeEmailResult";
            --remainder;
          }
        if (flagHasDisambiguationEmailResult)
          {
            if (remainder == 0)
                return "DisambiguationEmailResult";
            --remainder;
          }
        if (flagHasSendingEmailResult)
          {
            if (remainder == 0)
                return "SendingEmailResult";
            --remainder;
          }
        if (flagHasSentEmailResult)
          {
            if (remainder == 0)
                return "SentEmailResult";
            --remainder;
          }
        if (flagHasExitEmailResult)
          {
            if (remainder == 0)
                return "ExitEmailResult";
            --remainder;
          }
        return extraComposeEmailCommandComponentKey(remainder);
      }
    public override JSONValue extraEmailCommandComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasNativeData)
          {
            if (remainder == 0)
                return extraNativeDataToJSON();
            --remainder;
          }
        if (flagHasNoEmailAppResult)
          {
            if (remainder == 0)
                return extraNoEmailAppResultToJSON();
            --remainder;
          }
        if (flagHasComposeEmailResult)
          {
            if (remainder == 0)
                return extraComposeEmailResultToJSON();
            --remainder;
          }
        if (flagHasDisambiguationEmailResult)
          {
            if (remainder == 0)
                return extraDisambiguationEmailResultToJSON();
            --remainder;
          }
        if (flagHasSendingEmailResult)
          {
            if (remainder == 0)
                return extraSendingEmailResultToJSON();
            --remainder;
          }
        if (flagHasSentEmailResult)
          {
            if (remainder == 0)
                return extraSentEmailResultToJSON();
            --remainder;
          }
        if (flagHasExitEmailResult)
          {
            if (remainder == 0)
                return extraExitEmailResultToJSON();
            --remainder;
          }
        return extraComposeEmailCommandComponentValue(remainder);
      }
    public override JSONValue extraEmailCommandLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'C':
                if ((String.Compare(field_name, 1, "omposeEmailResult", 0, 17, false) == 0) && (field_name.Length == 18))
                    return (flagHasComposeEmailResult ? extraComposeEmailResultToJSON() : null);
                break;
            case 'D':
                if ((String.Compare(field_name, 1, "isambiguationEmailResult", 0, 24, false) == 0) && (field_name.Length == 25))
                    return (flagHasDisambiguationEmailResult ? extraDisambiguationEmailResultToJSON() : null);
                break;
            case 'E':
                if ((String.Compare(field_name, 1, "xitEmailResult", 0, 14, false) == 0) && (field_name.Length == 15))
                    return (flagHasExitEmailResult ? extraExitEmailResultToJSON() : null);
                break;
            case 'N':
                switch (field_name[1])
                  {
                    case 'a':
                        if ((String.Compare(field_name, 2, "tiveData", 0, 8, false) == 0) && (field_name.Length == 10))
                            return (flagHasNativeData ? extraNativeDataToJSON() : null);
                        break;
                    case 'o':
                        if ((String.Compare(field_name, 2, "EmailAppResult", 0, 14, false) == 0) && (field_name.Length == 16))
                            return (flagHasNoEmailAppResult ? extraNoEmailAppResultToJSON() : null);
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
                            if ((String.Compare(field_name, 4, "ingEmailResult", 0, 14, false) == 0) && (field_name.Length == 18))
                                return (flagHasSendingEmailResult ? extraSendingEmailResultToJSON() : null);
                            break;
                        case 't':
                            if ((String.Compare(field_name, 4, "EmailResult", 0, 11, false) == 0) && (field_name.Length == 15))
                                return (flagHasSentEmailResult ? extraSentEmailResultToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        return extraComposeEmailCommandLookup(field_name);
      }

    public void setNativeData(ComposeEmailCommandNativeDataJSON  new_value)
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
    public void setNoEmailAppResult(DynamicResponseJSON  new_value)
      {
        if (flagHasNoEmailAppResult)
          {
          }
        flagHasNoEmailAppResult = true;
        storeNoEmailAppResult = new_value;
      }
    public void unsetNoEmailAppResult()
      {
        if (flagHasNoEmailAppResult)
          {
          }
        flagHasNoEmailAppResult = false;
      }
    public void setComposeEmailResult(DynamicResponseJSON  new_value)
      {
        if (flagHasComposeEmailResult)
          {
          }
        flagHasComposeEmailResult = true;
        storeComposeEmailResult = new_value;
      }
    public void unsetComposeEmailResult()
      {
        if (flagHasComposeEmailResult)
          {
          }
        flagHasComposeEmailResult = false;
      }
    public void setDisambiguationEmailResult(DynamicResponseJSON  new_value)
      {
        if (flagHasDisambiguationEmailResult)
          {
          }
        flagHasDisambiguationEmailResult = true;
        storeDisambiguationEmailResult = new_value;
      }
    public void unsetDisambiguationEmailResult()
      {
        if (flagHasDisambiguationEmailResult)
          {
          }
        flagHasDisambiguationEmailResult = false;
      }
    public void setSendingEmailResult(DynamicResponseJSON  new_value)
      {
        if (flagHasSendingEmailResult)
          {
          }
        flagHasSendingEmailResult = true;
        storeSendingEmailResult = new_value;
      }
    public void unsetSendingEmailResult()
      {
        if (flagHasSendingEmailResult)
          {
          }
        flagHasSendingEmailResult = false;
      }
    public void setSentEmailResult(DynamicResponseJSON  new_value)
      {
        if (flagHasSentEmailResult)
          {
          }
        flagHasSentEmailResult = true;
        storeSentEmailResult = new_value;
      }
    public void unsetSentEmailResult()
      {
        if (flagHasSentEmailResult)
          {
          }
        flagHasSentEmailResult = false;
      }
    public void setExitEmailResult(DynamicResponseJSON  new_value)
      {
        if (flagHasExitEmailResult)
          {
          }
        flagHasExitEmailResult = true;
        storeExitEmailResult = new_value;
      }
    public void unsetExitEmailResult()
      {
        if (flagHasExitEmailResult)
          {
          }
        flagHasExitEmailResult = false;
      }

    public virtual void extraComposeEmailCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraComposeEmailCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraComposeEmailCommandLookup(key);
        if (old_field == null)
          {
            extraComposeEmailCommandAppendPair(key, new_component);
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
    public override void extraEmailCommandAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                if ((String.Compare(key, 1, "omposeEmailResult", 0, 17, false) == 0) && (key.Length == 18))
                    {
                    fromJSONComposeEmailResult(new_component, false);
                    return;
                    }
                break;
            case 'D':
                if ((String.Compare(key, 1, "isambiguationEmailResult", 0, 24, false) == 0) && (key.Length == 25))
                    {
                    fromJSONDisambiguationEmailResult(new_component, false);
                    return;
                    }
                break;
            case 'E':
                if ((String.Compare(key, 1, "xitEmailResult", 0, 14, false) == 0) && (key.Length == 15))
                    {
                    fromJSONExitEmailResult(new_component, false);
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
                        if ((String.Compare(key, 2, "EmailAppResult", 0, 14, false) == 0) && (key.Length == 16))
                            {
                            fromJSONNoEmailAppResult(new_component, false);
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
                            if ((String.Compare(key, 4, "ingEmailResult", 0, 14, false) == 0) && (key.Length == 18))
                                {
                                fromJSONSendingEmailResult(new_component, false);
                                return;
                                }
                            break;
                        case 't':
                            if ((String.Compare(key, 4, "EmailResult", 0, 11, false) == 0) && (key.Length == 15))
                                {
                                fromJSONSentEmailResult(new_component, false);
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
        extraComposeEmailCommandAppendPair(key, new_component);
      }
    public override void extraEmailCommandSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                if ((String.Compare(key, 1, "omposeEmailResult", 0, 17, false) == 0) && (key.Length == 18))
                    {
                    fromJSONComposeEmailResult(new_component, false);
                    return;
                    }
                break;
            case 'D':
                if ((String.Compare(key, 1, "isambiguationEmailResult", 0, 24, false) == 0) && (key.Length == 25))
                    {
                    fromJSONDisambiguationEmailResult(new_component, false);
                    return;
                    }
                break;
            case 'E':
                if ((String.Compare(key, 1, "xitEmailResult", 0, 14, false) == 0) && (key.Length == 15))
                    {
                    fromJSONExitEmailResult(new_component, false);
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
                        if ((String.Compare(key, 2, "EmailAppResult", 0, 14, false) == 0) && (key.Length == 16))
                            {
                            fromJSONNoEmailAppResult(new_component, false);
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
                            if ((String.Compare(key, 4, "ingEmailResult", 0, 14, false) == 0) && (key.Length == 18))
                                {
                                fromJSONSendingEmailResult(new_component, false);
                                return;
                                }
                            break;
                        case 't':
                            if ((String.Compare(key, 4, "EmailResult", 0, 11, false) == 0) && (key.Length == 15))
                                {
                                fromJSONSentEmailResult(new_component, false);
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
        extraComposeEmailCommandSetField(key, new_component);
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
        if (flagHasNoEmailAppResult)
          {
            handler.start_pair("NoEmailAppResult");
            if (partial_allowed)
                storeNoEmailAppResult.write_partial_as_json(handler);
            else
                storeNoEmailAppResult.write_as_json(handler);
          }
        if (flagHasComposeEmailResult)
          {
            handler.start_pair("ComposeEmailResult");
            if (partial_allowed)
                storeComposeEmailResult.write_partial_as_json(handler);
            else
                storeComposeEmailResult.write_as_json(handler);
          }
        if (flagHasDisambiguationEmailResult)
          {
            handler.start_pair("DisambiguationEmailResult");
            if (partial_allowed)
                storeDisambiguationEmailResult.write_partial_as_json(handler);
            else
                storeDisambiguationEmailResult.write_as_json(handler);
          }
        if (flagHasSendingEmailResult)
          {
            handler.start_pair("SendingEmailResult");
            if (partial_allowed)
                storeSendingEmailResult.write_partial_as_json(handler);
            else
                storeSendingEmailResult.write_as_json(handler);
          }
        if (flagHasSentEmailResult)
          {
            handler.start_pair("SentEmailResult");
            if (partial_allowed)
                storeSentEmailResult.write_partial_as_json(handler);
            else
                storeSentEmailResult.write_as_json(handler);
          }
        if (flagHasExitEmailResult)
          {
            handler.start_pair("ExitEmailResult");
            if (partial_allowed)
                storeExitEmailResult.write_partial_as_json(handler);
            else
                storeExitEmailResult.write_as_json(handler);
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

    public static new ComposeEmailCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ComposeEmailCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ComposeEmailCommand", ignore_extras);
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
    public static new ComposeEmailCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ComposeEmailCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ComposeEmailCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ComposeEmailCommand", ignore_extras);
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
    public static new ComposeEmailCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ComposeEmailCommandJSON from_text(string text, bool ignore_extras)
      {
        ComposeEmailCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ComposeEmailCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ComposeEmailCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new ComposeEmailCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ComposeEmailCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ComposeEmailCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : EmailCommandJSON.Generator
      {
        private ComposeEmailCommandNativeDataJSON.HoldingGenerator fieldGeneratorNativeData;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorNoEmailAppResult;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorComposeEmailResult;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorDisambiguationEmailResult;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorSendingEmailResult;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorSentEmailResult;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorExitEmailResult;
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
            if (!(getEmailCommandJSONKey().Equals("ComposeEmailCommand")))
                throw new Exception("The key field has a value other than `ComposeEmailCommand'.");
            ComposeEmailCommandJSON result = new ComposeEmailCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraComposeEmailCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(EmailCommandJSON new_result)
          {
            handle_result((ComposeEmailCommandJSON )new_result);
          }
        protected void finish(ComposeEmailCommandJSON result)
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
            if (fieldGeneratorNoEmailAppResult.have_value)
              {
                result.setNoEmailAppResult(fieldGeneratorNoEmailAppResult.value);
                fieldGeneratorNoEmailAppResult.have_value = false;
              }
            if (fieldGeneratorComposeEmailResult.have_value)
              {
                result.setComposeEmailResult(fieldGeneratorComposeEmailResult.value);
                fieldGeneratorComposeEmailResult.have_value = false;
              }
            if (fieldGeneratorDisambiguationEmailResult.have_value)
              {
                result.setDisambiguationEmailResult(fieldGeneratorDisambiguationEmailResult.value);
                fieldGeneratorDisambiguationEmailResult.have_value = false;
              }
            if (fieldGeneratorSendingEmailResult.have_value)
              {
                result.setSendingEmailResult(fieldGeneratorSendingEmailResult.value);
                fieldGeneratorSendingEmailResult.have_value = false;
              }
            if (fieldGeneratorSentEmailResult.have_value)
              {
                result.setSentEmailResult(fieldGeneratorSentEmailResult.value);
                fieldGeneratorSentEmailResult.have_value = false;
              }
            if (fieldGeneratorExitEmailResult.have_value)
              {
                result.setExitEmailResult(fieldGeneratorExitEmailResult.value);
                fieldGeneratorExitEmailResult.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(ComposeEmailCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "omposeEmailResult", 0, 17, false) == 0) && (field_name.Length == 18))
                        return fieldGeneratorComposeEmailResult;
                    break;
                case 'D':
                    if ((String.Compare(field_name, 1, "isambiguationEmailResult", 0, 24, false) == 0) && (field_name.Length == 25))
                        return fieldGeneratorDisambiguationEmailResult;
                    break;
                case 'E':
                    if ((String.Compare(field_name, 1, "xitEmailResult", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorExitEmailResult;
                    break;
                case 'N':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "tiveData", 0, 8, false) == 0) && (field_name.Length == 10))
                                return fieldGeneratorNativeData;
                            break;
                        case 'o':
                            if ((String.Compare(field_name, 2, "EmailAppResult", 0, 14, false) == 0) && (field_name.Length == 16))
                                return fieldGeneratorNoEmailAppResult;
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
                                if ((String.Compare(field_name, 4, "ingEmailResult", 0, 14, false) == 0) && (field_name.Length == 18))
                                    return fieldGeneratorSendingEmailResult;
                                break;
                            case 't':
                                if ((String.Compare(field_name, 4, "EmailResult", 0, 11, false) == 0) && (field_name.Length == 15))
                                    return fieldGeneratorSentEmailResult;
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
            fieldGeneratorNativeData = new ComposeEmailCommandNativeDataJSON.HoldingGenerator("field \"NativeData\" of the ComposeEmailCommand class", ignore_extras);
            fieldGeneratorNoEmailAppResult = new DynamicResponseJSON.HoldingGenerator("field \"NoEmailAppResult\" of the ComposeEmailCommand class", ignore_extras);
            fieldGeneratorComposeEmailResult = new DynamicResponseJSON.HoldingGenerator("field \"ComposeEmailResult\" of the ComposeEmailCommand class", ignore_extras);
            fieldGeneratorDisambiguationEmailResult = new DynamicResponseJSON.HoldingGenerator("field \"DisambiguationEmailResult\" of the ComposeEmailCommand class", ignore_extras);
            fieldGeneratorSendingEmailResult = new DynamicResponseJSON.HoldingGenerator("field \"SendingEmailResult\" of the ComposeEmailCommand class", ignore_extras);
            fieldGeneratorSentEmailResult = new DynamicResponseJSON.HoldingGenerator("field \"SentEmailResult\" of the ComposeEmailCommand class", ignore_extras);
            fieldGeneratorExitEmailResult = new DynamicResponseJSON.HoldingGenerator("field \"ExitEmailResult\" of the ComposeEmailCommand class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the ComposeEmailCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorNativeData = new ComposeEmailCommandNativeDataJSON.HoldingGenerator("field \"NativeData\" of the ComposeEmailCommand class", false);
            fieldGeneratorNoEmailAppResult = new DynamicResponseJSON.HoldingGenerator("field \"NoEmailAppResult\" of the ComposeEmailCommand class", false);
            fieldGeneratorComposeEmailResult = new DynamicResponseJSON.HoldingGenerator("field \"ComposeEmailResult\" of the ComposeEmailCommand class", false);
            fieldGeneratorDisambiguationEmailResult = new DynamicResponseJSON.HoldingGenerator("field \"DisambiguationEmailResult\" of the ComposeEmailCommand class", false);
            fieldGeneratorSendingEmailResult = new DynamicResponseJSON.HoldingGenerator("field \"SendingEmailResult\" of the ComposeEmailCommand class", false);
            fieldGeneratorSentEmailResult = new DynamicResponseJSON.HoldingGenerator("field \"SentEmailResult\" of the ComposeEmailCommand class", false);
            fieldGeneratorExitEmailResult = new DynamicResponseJSON.HoldingGenerator("field \"ExitEmailResult\" of the ComposeEmailCommand class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the ComposeEmailCommand class");
          }

        public override void reset()
          {
            fieldGeneratorNativeData.reset();
            fieldGeneratorNoEmailAppResult.reset();
            fieldGeneratorComposeEmailResult.reset();
            fieldGeneratorDisambiguationEmailResult.reset();
            fieldGeneratorSendingEmailResult.reset();
            fieldGeneratorSentEmailResult.reset();
            fieldGeneratorExitEmailResult.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(ComposeEmailCommandJSON  result)
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
        public ComposeEmailCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ComposeEmailCommandJSON  result)
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
    protected virtual void handle_result(List<ComposeEmailCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ComposeEmailCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ComposeEmailCommandJSON>();
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
    public List<ComposeEmailCommandJSON> value;
  };
  };
