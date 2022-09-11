/* file "SMSDisambiguatePersonsCommandNativeDataJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SMSDisambiguatePersonsCommandNativeDataJSON : DisambiguateCommandNativeDataJSON
  {
    private bool flagHasWhichContactChoices;
    private WhichContactChoicesJSON  storeWhichContactChoices;
    private bool flagHasPreviousMessage;
    private string storePreviousMessage;
    private bool flagHasSpokenBody;
    private string storeSpokenBody;
    private bool flagHasWrittenBody;
    private string storeWrittenBody;
    private bool flagHasErrorMessage;
    private string storeErrorMessage;
    private bool flagHasUserSpecifiedName;
    private string storeUserSpecifiedName;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraWhichContactChoicesToJSON()
      {
        JSONValueHandler handler_WhichContactChoices = new JSONValueHandler();
        storeWhichContactChoices.write_as_json(handler_WhichContactChoices);
        return handler_WhichContactChoices.result;
      }

    private JSONValue  extraPreviousMessageToJSON()
      {
        JSONStringValue generated_string_PreviousMessage = new JSONStringValue(storePreviousMessage);
        return generated_string_PreviousMessage;
      }

    private JSONValue  extraSpokenBodyToJSON()
      {
        JSONStringValue generated_string_SpokenBody = new JSONStringValue(storeSpokenBody);
        return generated_string_SpokenBody;
      }

    private JSONValue  extraWrittenBodyToJSON()
      {
        JSONStringValue generated_string_WrittenBody = new JSONStringValue(storeWrittenBody);
        return generated_string_WrittenBody;
      }

    private JSONValue  extraErrorMessageToJSON()
      {
        JSONStringValue generated_string_ErrorMessage = new JSONStringValue(storeErrorMessage);
        return generated_string_ErrorMessage;
      }

    private JSONValue  extraUserSpecifiedNameToJSON()
      {
        JSONStringValue generated_string_UserSpecifiedName = new JSONStringValue(storeUserSpecifiedName);
        return generated_string_UserSpecifiedName;
      }


    private void  fromJSONWhichContactChoices(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        WhichContactChoicesJSON convert_classy = WhichContactChoicesJSON.from_json(json_value, ignore_extras, true);
        setWhichContactChoices(convert_classy);
      }


    private void  fromJSONPreviousMessage(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field PreviousMessage of SMSDisambiguatePersonsCommandNativeDataJSON is not a string.");
        setPreviousMessage(json_string.getData());
      }


    private void  fromJSONSpokenBody(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenBody of SMSDisambiguatePersonsCommandNativeDataJSON is not a string.");
        setSpokenBody(json_string.getData());
      }


    private void  fromJSONWrittenBody(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field WrittenBody of SMSDisambiguatePersonsCommandNativeDataJSON is not a string.");
        setWrittenBody(json_string.getData());
      }


    private void  fromJSONErrorMessage(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ErrorMessage of SMSDisambiguatePersonsCommandNativeDataJSON is not a string.");
        setErrorMessage(json_string.getData());
      }


    private void  fromJSONUserSpecifiedName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field UserSpecifiedName of SMSDisambiguatePersonsCommandNativeDataJSON is not a string.");
        setUserSpecifiedName(json_string.getData());
      }


    public SMSDisambiguatePersonsCommandNativeDataJSON()
      {
        flagHasWhichContactChoices = false;
        flagHasPreviousMessage = false;
        flagHasSpokenBody = false;
        flagHasWrittenBody = false;
        flagHasErrorMessage = false;
        flagHasUserSpecifiedName = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasWhichContactChoices()
      {
        return flagHasWhichContactChoices;
      }

    public WhichContactChoicesJSON   getWhichContactChoices()
      {
        Debug.Assert(flagHasWhichContactChoices);
        return storeWhichContactChoices;
      }

    public bool  hasPreviousMessage()
      {
        return flagHasPreviousMessage;
      }

    public string  getPreviousMessage()
      {
        Debug.Assert(flagHasPreviousMessage);
        return storePreviousMessage;
      }

    public bool  hasSpokenBody()
      {
        return flagHasSpokenBody;
      }

    public string  getSpokenBody()
      {
        Debug.Assert(flagHasSpokenBody);
        return storeSpokenBody;
      }

    public bool  hasWrittenBody()
      {
        return flagHasWrittenBody;
      }

    public string  getWrittenBody()
      {
        Debug.Assert(flagHasWrittenBody);
        return storeWrittenBody;
      }

    public bool  hasErrorMessage()
      {
        return flagHasErrorMessage;
      }

    public string  getErrorMessage()
      {
        Debug.Assert(flagHasErrorMessage);
        return storeErrorMessage;
      }

    public bool  hasUserSpecifiedName()
      {
        return flagHasUserSpecifiedName;
      }

    public string  getUserSpecifiedName()
      {
        Debug.Assert(flagHasUserSpecifiedName);
        return storeUserSpecifiedName;
      }


    public virtual int extraSMSDisambiguatePersonsCommandNativeDataComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSMSDisambiguatePersonsCommandNativeDataComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSMSDisambiguatePersonsCommandNativeDataComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSMSDisambiguatePersonsCommandNativeDataLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraDisambiguateCommandNativeDataComponentCount()
      {
        int result = 0;
        if (flagHasWhichContactChoices)
            ++result;
        if (flagHasPreviousMessage)
            ++result;
        if (flagHasSpokenBody)
            ++result;
        if (flagHasWrittenBody)
            ++result;
        if (flagHasErrorMessage)
            ++result;
        if (flagHasUserSpecifiedName)
            ++result;
        result += extraSMSDisambiguatePersonsCommandNativeDataComponentCount();
        return result;
      }
    public override string extraDisambiguateCommandNativeDataComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasWhichContactChoices)
          {
            if (remainder == 0)
                return "WhichContactChoices";
            --remainder;
          }
        if (flagHasPreviousMessage)
          {
            if (remainder == 0)
                return "PreviousMessage";
            --remainder;
          }
        if (flagHasSpokenBody)
          {
            if (remainder == 0)
                return "SpokenBody";
            --remainder;
          }
        if (flagHasWrittenBody)
          {
            if (remainder == 0)
                return "WrittenBody";
            --remainder;
          }
        if (flagHasErrorMessage)
          {
            if (remainder == 0)
                return "ErrorMessage";
            --remainder;
          }
        if (flagHasUserSpecifiedName)
          {
            if (remainder == 0)
                return "UserSpecifiedName";
            --remainder;
          }
        return extraSMSDisambiguatePersonsCommandNativeDataComponentKey(remainder);
      }
    public override JSONValue extraDisambiguateCommandNativeDataComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasWhichContactChoices)
          {
            if (remainder == 0)
                return extraWhichContactChoicesToJSON();
            --remainder;
          }
        if (flagHasPreviousMessage)
          {
            if (remainder == 0)
                return extraPreviousMessageToJSON();
            --remainder;
          }
        if (flagHasSpokenBody)
          {
            if (remainder == 0)
                return extraSpokenBodyToJSON();
            --remainder;
          }
        if (flagHasWrittenBody)
          {
            if (remainder == 0)
                return extraWrittenBodyToJSON();
            --remainder;
          }
        if (flagHasErrorMessage)
          {
            if (remainder == 0)
                return extraErrorMessageToJSON();
            --remainder;
          }
        if (flagHasUserSpecifiedName)
          {
            if (remainder == 0)
                return extraUserSpecifiedNameToJSON();
            --remainder;
          }
        return extraSMSDisambiguatePersonsCommandNativeDataComponentValue(remainder);
      }
    public override JSONValue extraDisambiguateCommandNativeDataLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'E':
                if ((String.Compare(field_name, 1, "rrorMessage", 0, 11, false) == 0) && (field_name.Length == 12))
                    return (flagHasErrorMessage ? extraErrorMessageToJSON() : null);
                break;
            case 'P':
                if ((String.Compare(field_name, 1, "reviousMessage", 0, 14, false) == 0) && (field_name.Length == 15))
                    return (flagHasPreviousMessage ? extraPreviousMessageToJSON() : null);
                break;
            case 'S':
                if ((String.Compare(field_name, 1, "pokenBody", 0, 9, false) == 0) && (field_name.Length == 10))
                    return (flagHasSpokenBody ? extraSpokenBodyToJSON() : null);
                break;
            case 'U':
                if ((String.Compare(field_name, 1, "serSpecifiedName", 0, 16, false) == 0) && (field_name.Length == 17))
                    return (flagHasUserSpecifiedName ? extraUserSpecifiedNameToJSON() : null);
                break;
            case 'W':
                switch (field_name[1])
                  {
                    case 'h':
                        if ((String.Compare(field_name, 2, "ichContactChoices", 0, 17, false) == 0) && (field_name.Length == 19))
                            return (flagHasWhichContactChoices ? extraWhichContactChoicesToJSON() : null);
                        break;
                    case 'r':
                        if ((String.Compare(field_name, 2, "ittenBody", 0, 9, false) == 0) && (field_name.Length == 11))
                            return (flagHasWrittenBody ? extraWrittenBodyToJSON() : null);
                        break;
                    default:
                        break;
                  }
                break;
            default:
                break;
          }
        return extraSMSDisambiguatePersonsCommandNativeDataLookup(field_name);
      }

    public void setWhichContactChoices(WhichContactChoicesJSON  new_value)
      {
        if (flagHasWhichContactChoices)
          {
          }
        flagHasWhichContactChoices = true;
        storeWhichContactChoices = new_value;
      }
    public void unsetWhichContactChoices()
      {
        if (flagHasWhichContactChoices)
          {
          }
        flagHasWhichContactChoices = false;
      }
    public void setPreviousMessage(string new_value)
      {
        flagHasPreviousMessage = true;
        storePreviousMessage = new_value;
      }
    public void unsetPreviousMessage()
      {
        flagHasPreviousMessage = false;
      }
    public void setSpokenBody(string new_value)
      {
        flagHasSpokenBody = true;
        storeSpokenBody = new_value;
      }
    public void unsetSpokenBody()
      {
        flagHasSpokenBody = false;
      }
    public void setWrittenBody(string new_value)
      {
        flagHasWrittenBody = true;
        storeWrittenBody = new_value;
      }
    public void unsetWrittenBody()
      {
        flagHasWrittenBody = false;
      }
    public void setErrorMessage(string new_value)
      {
        flagHasErrorMessage = true;
        storeErrorMessage = new_value;
      }
    public void unsetErrorMessage()
      {
        flagHasErrorMessage = false;
      }
    public void setUserSpecifiedName(string new_value)
      {
        flagHasUserSpecifiedName = true;
        storeUserSpecifiedName = new_value;
      }
    public void unsetUserSpecifiedName()
      {
        flagHasUserSpecifiedName = false;
      }

    public virtual void extraSMSDisambiguatePersonsCommandNativeDataAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSMSDisambiguatePersonsCommandNativeDataSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSMSDisambiguatePersonsCommandNativeDataLookup(key);
        if (old_field == null)
          {
            extraSMSDisambiguatePersonsCommandNativeDataAppendPair(key, new_component);
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
    public override void extraDisambiguateCommandNativeDataAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'E':
                if ((String.Compare(key, 1, "rrorMessage", 0, 11, false) == 0) && (key.Length == 12))
                    {
                    fromJSONErrorMessage(new_component, false);
                    return;
                    }
                break;
            case 'P':
                if ((String.Compare(key, 1, "reviousMessage", 0, 14, false) == 0) && (key.Length == 15))
                    {
                    fromJSONPreviousMessage(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if ((String.Compare(key, 1, "pokenBody", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONSpokenBody(new_component, false);
                    return;
                    }
                break;
            case 'U':
                if ((String.Compare(key, 1, "serSpecifiedName", 0, 16, false) == 0) && (key.Length == 17))
                    {
                    fromJSONUserSpecifiedName(new_component, false);
                    return;
                    }
                break;
            case 'W':
                switch (key[1])
                  {
                    case 'h':
                        if ((String.Compare(key, 2, "ichContactChoices", 0, 17, false) == 0) && (key.Length == 19))
                            {
                            fromJSONWhichContactChoices(new_component, false);
                            return;
                            }
                        break;
                    case 'r':
                        if ((String.Compare(key, 2, "ittenBody", 0, 9, false) == 0) && (key.Length == 11))
                            {
                            fromJSONWrittenBody(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            default:
                break;
          }
        extraSMSDisambiguatePersonsCommandNativeDataAppendPair(key, new_component);
      }
    public override void extraDisambiguateCommandNativeDataSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'E':
                if ((String.Compare(key, 1, "rrorMessage", 0, 11, false) == 0) && (key.Length == 12))
                    {
                    fromJSONErrorMessage(new_component, false);
                    return;
                    }
                break;
            case 'P':
                if ((String.Compare(key, 1, "reviousMessage", 0, 14, false) == 0) && (key.Length == 15))
                    {
                    fromJSONPreviousMessage(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if ((String.Compare(key, 1, "pokenBody", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONSpokenBody(new_component, false);
                    return;
                    }
                break;
            case 'U':
                if ((String.Compare(key, 1, "serSpecifiedName", 0, 16, false) == 0) && (key.Length == 17))
                    {
                    fromJSONUserSpecifiedName(new_component, false);
                    return;
                    }
                break;
            case 'W':
                switch (key[1])
                  {
                    case 'h':
                        if ((String.Compare(key, 2, "ichContactChoices", 0, 17, false) == 0) && (key.Length == 19))
                            {
                            fromJSONWhichContactChoices(new_component, false);
                            return;
                            }
                        break;
                    case 'r':
                        if ((String.Compare(key, 2, "ittenBody", 0, 9, false) == 0) && (key.Length == 11))
                            {
                            fromJSONWrittenBody(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            default:
                break;
          }
        extraSMSDisambiguatePersonsCommandNativeDataSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasWhichContactChoices);
        if (flagHasWhichContactChoices)
          {
            handler.start_pair("WhichContactChoices");
            if (partial_allowed)
                storeWhichContactChoices.write_partial_as_json(handler);
            else
                storeWhichContactChoices.write_as_json(handler);
          }
        if (flagHasPreviousMessage)
          {
            handler.start_pair("PreviousMessage");
            handler.string_value(storePreviousMessage);
          }
        if (flagHasSpokenBody)
          {
            handler.start_pair("SpokenBody");
            handler.string_value(storeSpokenBody);
          }
        if (flagHasWrittenBody)
          {
            handler.start_pair("WrittenBody");
            handler.string_value(storeWrittenBody);
          }
        if (flagHasErrorMessage)
          {
            handler.start_pair("ErrorMessage");
            handler.string_value(storeErrorMessage);
          }
        if (flagHasUserSpecifiedName)
          {
            handler.start_pair("UserSpecifiedName");
            handler.string_value(storeUserSpecifiedName);
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
        if (!(hasWhichContactChoices()))
          {
            return "When parsing the object for %what%, the \"WhichContactChoices\" field was missing.";
          }
        return null;
      }

    public static new SMSDisambiguatePersonsCommandNativeDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SMSDisambiguatePersonsCommandNativeDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SMSDisambiguatePersonsCommandNativeData", ignore_extras);
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
    public static new SMSDisambiguatePersonsCommandNativeDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SMSDisambiguatePersonsCommandNativeDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SMSDisambiguatePersonsCommandNativeDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SMSDisambiguatePersonsCommandNativeData", ignore_extras);
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
    public static new SMSDisambiguatePersonsCommandNativeDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SMSDisambiguatePersonsCommandNativeDataJSON from_text(string text, bool ignore_extras)
      {
        SMSDisambiguatePersonsCommandNativeDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SMSDisambiguatePersonsCommandNativeData", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SMSDisambiguatePersonsCommandNativeDataJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new SMSDisambiguatePersonsCommandNativeDataJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SMSDisambiguatePersonsCommandNativeDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SMSDisambiguatePersonsCommandNativeData", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : DisambiguateCommandNativeDataJSON.Generator
      {
        private WhichContactChoicesJSON.HoldingGenerator fieldGeneratorWhichContactChoices;
        private JSONHoldingStringGenerator fieldGeneratorPreviousMessage;
        private JSONHoldingStringGenerator fieldGeneratorSpokenBody;
        private JSONHoldingStringGenerator fieldGeneratorWrittenBody;
        private JSONHoldingStringGenerator fieldGeneratorErrorMessage;
        private JSONHoldingStringGenerator fieldGeneratorUserSpecifiedName;
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
            SMSDisambiguatePersonsCommandNativeDataJSON result = new SMSDisambiguatePersonsCommandNativeDataJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSMSDisambiguatePersonsCommandNativeDataAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(DisambiguateCommandNativeDataJSON new_result)
          {
            handle_result((SMSDisambiguatePersonsCommandNativeDataJSON )new_result);
          }
        protected void finish(SMSDisambiguatePersonsCommandNativeDataJSON result)
          {
            if (fieldGeneratorWhichContactChoices.have_value)
              {
                result.setWhichContactChoices(fieldGeneratorWhichContactChoices.value);
                fieldGeneratorWhichContactChoices.have_value = false;
              }
            else if ((!(result.hasWhichContactChoices())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"WhichContactChoices\" field was missing.");
              }
            if (fieldGeneratorPreviousMessage.have_value)
              {
                result.setPreviousMessage(fieldGeneratorPreviousMessage.value);
                fieldGeneratorPreviousMessage.have_value = false;
              }
            if (fieldGeneratorSpokenBody.have_value)
              {
                result.setSpokenBody(fieldGeneratorSpokenBody.value);
                fieldGeneratorSpokenBody.have_value = false;
              }
            if (fieldGeneratorWrittenBody.have_value)
              {
                result.setWrittenBody(fieldGeneratorWrittenBody.value);
                fieldGeneratorWrittenBody.have_value = false;
              }
            if (fieldGeneratorErrorMessage.have_value)
              {
                result.setErrorMessage(fieldGeneratorErrorMessage.value);
                fieldGeneratorErrorMessage.have_value = false;
              }
            if (fieldGeneratorUserSpecifiedName.have_value)
              {
                result.setUserSpecifiedName(fieldGeneratorUserSpecifiedName.value);
                fieldGeneratorUserSpecifiedName.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(SMSDisambiguatePersonsCommandNativeDataJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'E':
                    if ((String.Compare(field_name, 1, "rrorMessage", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorErrorMessage;
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "reviousMessage", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorPreviousMessage;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "pokenBody", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorSpokenBody;
                    break;
                case 'U':
                    if ((String.Compare(field_name, 1, "serSpecifiedName", 0, 16, false) == 0) && (field_name.Length == 17))
                        return fieldGeneratorUserSpecifiedName;
                    break;
                case 'W':
                    switch (field_name[1])
                      {
                        case 'h':
                            if ((String.Compare(field_name, 2, "ichContactChoices", 0, 17, false) == 0) && (field_name.Length == 19))
                                return fieldGeneratorWhichContactChoices;
                            break;
                        case 'r':
                            if ((String.Compare(field_name, 2, "ittenBody", 0, 9, false) == 0) && (field_name.Length == 11))
                                return fieldGeneratorWrittenBody;
                            break;
                        default:
                            break;
                      }
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorWhichContactChoices = new WhichContactChoicesJSON.HoldingGenerator("field \"WhichContactChoices\" of the SMSDisambiguatePersonsCommandNativeData class", ignore_extras);
            fieldGeneratorPreviousMessage = new JSONHoldingStringGenerator("field \"PreviousMessage\" of the SMSDisambiguatePersonsCommandNativeData class");
            fieldGeneratorSpokenBody = new JSONHoldingStringGenerator("field \"SpokenBody\" of the SMSDisambiguatePersonsCommandNativeData class");
            fieldGeneratorWrittenBody = new JSONHoldingStringGenerator("field \"WrittenBody\" of the SMSDisambiguatePersonsCommandNativeData class");
            fieldGeneratorErrorMessage = new JSONHoldingStringGenerator("field \"ErrorMessage\" of the SMSDisambiguatePersonsCommandNativeData class");
            fieldGeneratorUserSpecifiedName = new JSONHoldingStringGenerator("field \"UserSpecifiedName\" of the SMSDisambiguatePersonsCommandNativeData class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SMSDisambiguatePersonsCommandNativeData class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorWhichContactChoices = new WhichContactChoicesJSON.HoldingGenerator("field \"WhichContactChoices\" of the SMSDisambiguatePersonsCommandNativeData class", false);
            fieldGeneratorPreviousMessage = new JSONHoldingStringGenerator("field \"PreviousMessage\" of the SMSDisambiguatePersonsCommandNativeData class");
            fieldGeneratorSpokenBody = new JSONHoldingStringGenerator("field \"SpokenBody\" of the SMSDisambiguatePersonsCommandNativeData class");
            fieldGeneratorWrittenBody = new JSONHoldingStringGenerator("field \"WrittenBody\" of the SMSDisambiguatePersonsCommandNativeData class");
            fieldGeneratorErrorMessage = new JSONHoldingStringGenerator("field \"ErrorMessage\" of the SMSDisambiguatePersonsCommandNativeData class");
            fieldGeneratorUserSpecifiedName = new JSONHoldingStringGenerator("field \"UserSpecifiedName\" of the SMSDisambiguatePersonsCommandNativeData class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SMSDisambiguatePersonsCommandNativeData class");
          }

        public override void reset()
          {
            fieldGeneratorWhichContactChoices.reset();
            fieldGeneratorPreviousMessage.reset();
            fieldGeneratorSpokenBody.reset();
            fieldGeneratorWrittenBody.reset();
            fieldGeneratorErrorMessage.reset();
            fieldGeneratorUserSpecifiedName.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(SMSDisambiguatePersonsCommandNativeDataJSON  result)
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
        public SMSDisambiguatePersonsCommandNativeDataJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SMSDisambiguatePersonsCommandNativeDataJSON  result)
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
    protected virtual void handle_result(List<SMSDisambiguatePersonsCommandNativeDataJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SMSDisambiguatePersonsCommandNativeDataJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SMSDisambiguatePersonsCommandNativeDataJSON>();
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
    public List<SMSDisambiguatePersonsCommandNativeDataJSON> value;
  };
    public static SMSDisambiguatePersonsCommandNativeDataJSON from_DisambiguateCommandNativeDataJSON_json(DisambiguateCommandNativeDataJSON  ancestor, bool ignore_extras)
      {
        Debug.Assert(ancestor != null);
        SMSDisambiguatePersonsCommandNativeDataJSON  result;
          {
            HoldingGenerator handler = new HoldingGenerator("Type SMSDisambiguatePersonsCommandNativeData", ignore_extras);
            ancestor.write_as_json(handler);
            result = handler.value;
          }
        return result;
      }
  };
