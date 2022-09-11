/* file "TuneToStationUIDCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class TuneToStationUIDCommandJSON : RadioCommandJSON
  {
    private bool flagHasStationUID;
    private uint storeStationUID;
    private bool flagHasStationName;
    private string storeStationName;
    private bool flagHasStationNameInLocalScript;
    private string storeStationNameInLocalScript;
    private bool flagHasLocalScript;
    private string storeLocalScript;
    private bool flagHasStationNameSpoken;
    private string storeStationNameSpoken;
    private bool flagHasAlreadyOnResult;
    private DynamicResponseJSON  storeAlreadyOnResult;
    private bool flagHasSuggestions;
    private SuggestedStationsJSON  storeSuggestions;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraStationUIDToJSON()
      {
        JSONIntegerValue generated_integer_StationUID = new JSONIntegerValue(storeStationUID);
        return generated_integer_StationUID;
      }

    private JSONValue  extraStationNameToJSON()
      {
        JSONStringValue generated_string_StationName = new JSONStringValue(storeStationName);
        return generated_string_StationName;
      }

    private JSONValue  extraStationNameInLocalScriptToJSON()
      {
        JSONStringValue generated_string_StationNameInLocalScript = new JSONStringValue(storeStationNameInLocalScript);
        return generated_string_StationNameInLocalScript;
      }

    private JSONValue  extraLocalScriptToJSON()
      {
        JSONStringValue generated_string_LocalScript = new JSONStringValue(storeLocalScript);
        return generated_string_LocalScript;
      }

    private JSONValue  extraStationNameSpokenToJSON()
      {
        JSONStringValue generated_string_StationNameSpoken = new JSONStringValue(storeStationNameSpoken);
        return generated_string_StationNameSpoken;
      }

    private JSONValue  extraAlreadyOnResultToJSON()
      {
        JSONValueHandler handler_AlreadyOnResult = new JSONValueHandler();
        storeAlreadyOnResult.write_as_json(handler_AlreadyOnResult);
        return handler_AlreadyOnResult.result;
      }

    private JSONValue  extraSuggestionsToJSON()
      {
        JSONValueHandler handler_Suggestions = new JSONValueHandler();
        storeSuggestions.write_as_json(handler_Suggestions);
        return handler_Suggestions.result;
      }


    private void  fromJSONStationUID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        uint extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field StationUID of TuneToStationUIDCommandJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field StationUID of TuneToStationUIDCommandJSON is not an integer.");
              }
            extracted_integer = (uint)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (uint)(json_integer.getLongInt())        ;
          }
        setStationUID(extracted_integer);
      }


    private void  fromJSONStationName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field StationName of TuneToStationUIDCommandJSON is not a string.");
        setStationName(json_string.getData());
      }


    private void  fromJSONStationNameInLocalScript(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field StationNameInLocalScript of TuneToStationUIDCommandJSON is not a string.");
        setStationNameInLocalScript(json_string.getData());
      }


    private void  fromJSONLocalScript(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field LocalScript of TuneToStationUIDCommandJSON is not a string.");
        setLocalScript(json_string.getData());
      }


    private void  fromJSONStationNameSpoken(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field StationNameSpoken of TuneToStationUIDCommandJSON is not a string.");
        setStationNameSpoken(json_string.getData());
      }


    private void  fromJSONAlreadyOnResult(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setAlreadyOnResult(convert_classy);
      }


    private void  fromJSONSuggestions(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SuggestedStationsJSON convert_classy = SuggestedStationsJSON.from_json(json_value, ignore_extras, true);
        setSuggestions(convert_classy);
      }


    public TuneToStationUIDCommandJSON()
      {
        flagHasStationUID = false;
        flagHasStationName = false;
        flagHasStationNameInLocalScript = false;
        flagHasLocalScript = false;
        flagHasStationNameSpoken = false;
        flagHasAlreadyOnResult = false;
        flagHasSuggestions = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getRadioCommandKind()
      {
        return "TuneToStationUID";
      }

    public bool  hasStationUID()
      {
        return flagHasStationUID;
      }

    public uint  getStationUID()
      {
        Debug.Assert(flagHasStationUID);
        return storeStationUID;
      }

    public bool  hasStationName()
      {
        return flagHasStationName;
      }

    public string  getStationName()
      {
        Debug.Assert(flagHasStationName);
        return storeStationName;
      }

    public bool  hasStationNameInLocalScript()
      {
        return flagHasStationNameInLocalScript;
      }

    public string  getStationNameInLocalScript()
      {
        Debug.Assert(flagHasStationNameInLocalScript);
        return storeStationNameInLocalScript;
      }

    public bool  hasLocalScript()
      {
        return flagHasLocalScript;
      }

    public string  getLocalScript()
      {
        Debug.Assert(flagHasLocalScript);
        return storeLocalScript;
      }

    public bool  hasStationNameSpoken()
      {
        return flagHasStationNameSpoken;
      }

    public string  getStationNameSpoken()
      {
        Debug.Assert(flagHasStationNameSpoken);
        return storeStationNameSpoken;
      }

    public bool  hasAlreadyOnResult()
      {
        return flagHasAlreadyOnResult;
      }

    public DynamicResponseJSON   getAlreadyOnResult()
      {
        Debug.Assert(flagHasAlreadyOnResult);
        return storeAlreadyOnResult;
      }

    public bool  hasSuggestions()
      {
        return flagHasSuggestions;
      }

    public SuggestedStationsJSON   getSuggestions()
      {
        Debug.Assert(flagHasSuggestions);
        return storeSuggestions;
      }


    public virtual int extraTuneToStationUIDCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraTuneToStationUIDCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraTuneToStationUIDCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraTuneToStationUIDCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraRadioCommandComponentCount()
      {
        int result = 0;
        if (flagHasStationUID)
            ++result;
        if (flagHasStationName)
            ++result;
        if (flagHasStationNameInLocalScript)
            ++result;
        if (flagHasLocalScript)
            ++result;
        if (flagHasStationNameSpoken)
            ++result;
        if (flagHasAlreadyOnResult)
            ++result;
        if (flagHasSuggestions)
            ++result;
        result += extraTuneToStationUIDCommandComponentCount();
        return result;
      }
    public override string extraRadioCommandComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasStationUID)
          {
            if (remainder == 0)
                return "StationUID";
            --remainder;
          }
        if (flagHasStationName)
          {
            if (remainder == 0)
                return "StationName";
            --remainder;
          }
        if (flagHasStationNameInLocalScript)
          {
            if (remainder == 0)
                return "StationNameInLocalScript";
            --remainder;
          }
        if (flagHasLocalScript)
          {
            if (remainder == 0)
                return "LocalScript";
            --remainder;
          }
        if (flagHasStationNameSpoken)
          {
            if (remainder == 0)
                return "StationNameSpoken";
            --remainder;
          }
        if (flagHasAlreadyOnResult)
          {
            if (remainder == 0)
                return "AlreadyOnResult";
            --remainder;
          }
        if (flagHasSuggestions)
          {
            if (remainder == 0)
                return "Suggestions";
            --remainder;
          }
        return extraTuneToStationUIDCommandComponentKey(remainder);
      }
    public override JSONValue extraRadioCommandComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasStationUID)
          {
            if (remainder == 0)
                return extraStationUIDToJSON();
            --remainder;
          }
        if (flagHasStationName)
          {
            if (remainder == 0)
                return extraStationNameToJSON();
            --remainder;
          }
        if (flagHasStationNameInLocalScript)
          {
            if (remainder == 0)
                return extraStationNameInLocalScriptToJSON();
            --remainder;
          }
        if (flagHasLocalScript)
          {
            if (remainder == 0)
                return extraLocalScriptToJSON();
            --remainder;
          }
        if (flagHasStationNameSpoken)
          {
            if (remainder == 0)
                return extraStationNameSpokenToJSON();
            --remainder;
          }
        if (flagHasAlreadyOnResult)
          {
            if (remainder == 0)
                return extraAlreadyOnResultToJSON();
            --remainder;
          }
        if (flagHasSuggestions)
          {
            if (remainder == 0)
                return extraSuggestionsToJSON();
            --remainder;
          }
        return extraTuneToStationUIDCommandComponentValue(remainder);
      }
    public override JSONValue extraRadioCommandLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'A':
                if ((String.Compare(field_name, 1, "lreadyOnResult", 0, 14, false) == 0) && (field_name.Length == 15))
                    return (flagHasAlreadyOnResult ? extraAlreadyOnResultToJSON() : null);
                break;
            case 'L':
                if ((String.Compare(field_name, 1, "ocalScript", 0, 10, false) == 0) && (field_name.Length == 11))
                    return (flagHasLocalScript ? extraLocalScriptToJSON() : null);
                break;
            case 'S':
                switch (field_name[1])
                  {
                    case 't':
                        if (String.Compare(field_name, 2, "ation", 0, 5, false) == 0)
                          {
                            switch (field_name[7])
                              {
                                case 'N':
                                    if (String.Compare(field_name, 8, "ame", 0, 3, false) == 0)
                                      {
                                        if (field_name.Length == 11)
                                          {
                                            return (flagHasStationName ? extraStationNameToJSON() : null);
                                          }
                                        switch (field_name[11])
                                          {
                                            case 'I':
                                                if ((String.Compare(field_name, 12, "nLocalScript", 0, 12, false) == 0) && (field_name.Length == 24))
                                                    return (flagHasStationNameInLocalScript ? extraStationNameInLocalScriptToJSON() : null);
                                                break;
                                            case 'S':
                                                if ((String.Compare(field_name, 12, "poken", 0, 5, false) == 0) && (field_name.Length == 17))
                                                    return (flagHasStationNameSpoken ? extraStationNameSpokenToJSON() : null);
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'U':
                                    if ((String.Compare(field_name, 8, "ID", 0, 2, false) == 0) && (field_name.Length == 10))
                                        return (flagHasStationUID ? extraStationUIDToJSON() : null);
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'u':
                        if ((String.Compare(field_name, 2, "ggestions", 0, 9, false) == 0) && (field_name.Length == 11))
                            return (flagHasSuggestions ? extraSuggestionsToJSON() : null);
                        break;
                    default:
                        break;
                  }
                break;
            default:
                break;
          }
        return extraTuneToStationUIDCommandLookup(field_name);
      }

    public void setStationUID(uint new_value)
      {
        flagHasStationUID = true;
        if (new_value < 0)
            throw new Exception("The value for field StationUID of TuneToStationUIDCommandJSON is less than the lower bound (0) for that field.");
        if (new_value > 4294967295)
            throw new Exception("The value for field StationUID of TuneToStationUIDCommandJSON is greater than the upper bound (4294967295) for that field.");
        storeStationUID = new_value;
      }
    public void unsetStationUID()
      {
        flagHasStationUID = false;
      }
    public void setStationName(string new_value)
      {
        flagHasStationName = true;
        storeStationName = new_value;
      }
    public void unsetStationName()
      {
        flagHasStationName = false;
      }
    public void setStationNameInLocalScript(string new_value)
      {
        flagHasStationNameInLocalScript = true;
        storeStationNameInLocalScript = new_value;
      }
    public void unsetStationNameInLocalScript()
      {
        flagHasStationNameInLocalScript = false;
      }
    public void setLocalScript(string new_value)
      {
        flagHasLocalScript = true;
        storeLocalScript = new_value;
      }
    public void unsetLocalScript()
      {
        flagHasLocalScript = false;
      }
    public void setStationNameSpoken(string new_value)
      {
        flagHasStationNameSpoken = true;
        storeStationNameSpoken = new_value;
      }
    public void unsetStationNameSpoken()
      {
        flagHasStationNameSpoken = false;
      }
    public void setAlreadyOnResult(DynamicResponseJSON  new_value)
      {
        if (flagHasAlreadyOnResult)
          {
          }
        flagHasAlreadyOnResult = true;
        storeAlreadyOnResult = new_value;
      }
    public void unsetAlreadyOnResult()
      {
        if (flagHasAlreadyOnResult)
          {
          }
        flagHasAlreadyOnResult = false;
      }
    public void setSuggestions(SuggestedStationsJSON  new_value)
      {
        if (flagHasSuggestions)
          {
          }
        flagHasSuggestions = true;
        storeSuggestions = new_value;
      }
    public void unsetSuggestions()
      {
        if (flagHasSuggestions)
          {
          }
        flagHasSuggestions = false;
      }

    public virtual void extraTuneToStationUIDCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraTuneToStationUIDCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraTuneToStationUIDCommandLookup(key);
        if (old_field == null)
          {
            extraTuneToStationUIDCommandAppendPair(key, new_component);
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
    public override void extraRadioCommandAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                if ((String.Compare(key, 1, "lreadyOnResult", 0, 14, false) == 0) && (key.Length == 15))
                    {
                    fromJSONAlreadyOnResult(new_component, false);
                    return;
                    }
                break;
            case 'L':
                if ((String.Compare(key, 1, "ocalScript", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONLocalScript(new_component, false);
                    return;
                    }
                break;
            case 'S':
                switch (key[1])
                  {
                    case 't':
                        if (String.Compare(key, 2, "ation", 0, 5, false) == 0)
                          {
                            switch (key[7])
                              {
                                case 'N':
                                    if (String.Compare(key, 8, "ame", 0, 3, false) == 0)
                                      {
                                        if (key.Length == 11)
                                          {
                                            {
                                            fromJSONStationName(new_component, false);
                                            return;
                                            }
                                          }
                                        switch (key[11])
                                          {
                                            case 'I':
                                                if ((String.Compare(key, 12, "nLocalScript", 0, 12, false) == 0) && (key.Length == 24))
                                                    {
                                                    fromJSONStationNameInLocalScript(new_component, false);
                                                    return;
                                                    }
                                                break;
                                            case 'S':
                                                if ((String.Compare(key, 12, "poken", 0, 5, false) == 0) && (key.Length == 17))
                                                    {
                                                    fromJSONStationNameSpoken(new_component, false);
                                                    return;
                                                    }
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'U':
                                    if ((String.Compare(key, 8, "ID", 0, 2, false) == 0) && (key.Length == 10))
                                        {
                                        fromJSONStationUID(new_component, false);
                                        return;
                                        }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'u':
                        if ((String.Compare(key, 2, "ggestions", 0, 9, false) == 0) && (key.Length == 11))
                            {
                            fromJSONSuggestions(new_component, false);
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
        extraTuneToStationUIDCommandAppendPair(key, new_component);
      }
    public override void extraRadioCommandSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                if ((String.Compare(key, 1, "lreadyOnResult", 0, 14, false) == 0) && (key.Length == 15))
                    {
                    fromJSONAlreadyOnResult(new_component, false);
                    return;
                    }
                break;
            case 'L':
                if ((String.Compare(key, 1, "ocalScript", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONLocalScript(new_component, false);
                    return;
                    }
                break;
            case 'S':
                switch (key[1])
                  {
                    case 't':
                        if (String.Compare(key, 2, "ation", 0, 5, false) == 0)
                          {
                            switch (key[7])
                              {
                                case 'N':
                                    if (String.Compare(key, 8, "ame", 0, 3, false) == 0)
                                      {
                                        if (key.Length == 11)
                                          {
                                            {
                                            fromJSONStationName(new_component, false);
                                            return;
                                            }
                                          }
                                        switch (key[11])
                                          {
                                            case 'I':
                                                if ((String.Compare(key, 12, "nLocalScript", 0, 12, false) == 0) && (key.Length == 24))
                                                    {
                                                    fromJSONStationNameInLocalScript(new_component, false);
                                                    return;
                                                    }
                                                break;
                                            case 'S':
                                                if ((String.Compare(key, 12, "poken", 0, 5, false) == 0) && (key.Length == 17))
                                                    {
                                                    fromJSONStationNameSpoken(new_component, false);
                                                    return;
                                                    }
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'U':
                                    if ((String.Compare(key, 8, "ID", 0, 2, false) == 0) && (key.Length == 10))
                                        {
                                        fromJSONStationUID(new_component, false);
                                        return;
                                        }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'u':
                        if ((String.Compare(key, 2, "ggestions", 0, 9, false) == 0) && (key.Length == 11))
                            {
                            fromJSONSuggestions(new_component, false);
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
        extraTuneToStationUIDCommandSetField(key, new_component);
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
        if (flagHasStationUID)
          {
            handler.start_pair("StationUID");
            handler.number_value(storeStationUID);
          }
        Debug.Assert(partial_allowed || flagHasStationName);
        if (flagHasStationName)
          {
            handler.start_pair("StationName");
            handler.string_value(storeStationName);
          }
        if (flagHasStationNameInLocalScript)
          {
            handler.start_pair("StationNameInLocalScript");
            handler.string_value(storeStationNameInLocalScript);
          }
        if (flagHasLocalScript)
          {
            handler.start_pair("LocalScript");
            handler.string_value(storeLocalScript);
          }
        Debug.Assert(partial_allowed || flagHasStationNameSpoken);
        if (flagHasStationNameSpoken)
          {
            handler.start_pair("StationNameSpoken");
            handler.string_value(storeStationNameSpoken);
          }
        if (flagHasAlreadyOnResult)
          {
            handler.start_pair("AlreadyOnResult");
            if (partial_allowed)
                storeAlreadyOnResult.write_partial_as_json(handler);
            else
                storeAlreadyOnResult.write_as_json(handler);
          }
        if (flagHasSuggestions)
          {
            handler.start_pair("Suggestions");
            if (partial_allowed)
                storeSuggestions.write_partial_as_json(handler);
            else
                storeSuggestions.write_as_json(handler);
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
        if (!(hasStationName()))
          {
            return "When parsing the object for %what%, the \"StationName\" field was missing.";
          }
        if (!(hasStationNameSpoken()))
          {
            return "When parsing the object for %what%, the \"StationNameSpoken\" field was missing.";
          }
        return null;
      }

    public static new TuneToStationUIDCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TuneToStationUIDCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TuneToStationUIDCommand", ignore_extras);
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
    public static new TuneToStationUIDCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new TuneToStationUIDCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TuneToStationUIDCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TuneToStationUIDCommand", ignore_extras);
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
    public static new TuneToStationUIDCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new TuneToStationUIDCommandJSON from_text(string text, bool ignore_extras)
      {
        TuneToStationUIDCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TuneToStationUIDCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for TuneToStationUIDCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new TuneToStationUIDCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        TuneToStationUIDCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TuneToStationUIDCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : RadioCommandJSON.Generator
      {
    private class FieldHoldingGeneratorStationUID : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorStationUID(String what) : base(what, 0, 4294967295L)
              {
              }
          };
    private class FieldHoldingArrayGeneratorStationUID : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorStationUID(String what) : base(what, 0, 4294967295L)
              {
              }
          };
        private FieldHoldingGeneratorStationUID fieldGeneratorStationUID;
        private JSONHoldingStringGenerator fieldGeneratorStationName;
        private JSONHoldingStringGenerator fieldGeneratorStationNameInLocalScript;
        private JSONHoldingStringGenerator fieldGeneratorLocalScript;
        private JSONHoldingStringGenerator fieldGeneratorStationNameSpoken;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorAlreadyOnResult;
        private SuggestedStationsJSON.HoldingGenerator fieldGeneratorSuggestions;
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
            if (!(getRadioCommandJSONKey().Equals("TuneToStationUID")))
                throw new Exception("The key field has a value other than `TuneToStationUID'.");
            TuneToStationUIDCommandJSON result = new TuneToStationUIDCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraTuneToStationUIDCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(RadioCommandJSON new_result)
          {
            handle_result((TuneToStationUIDCommandJSON )new_result);
          }
        protected void finish(TuneToStationUIDCommandJSON result)
          {
            if (fieldGeneratorStationUID.have_value)
              {
                result.setStationUID((uint)(fieldGeneratorStationUID.value));
                fieldGeneratorStationUID.have_value = false;
              }
            if (fieldGeneratorStationName.have_value)
              {
                result.setStationName(fieldGeneratorStationName.value);
                fieldGeneratorStationName.have_value = false;
              }
            else if ((!(result.hasStationName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"StationName\" field was missing.");
              }
            if (fieldGeneratorStationNameInLocalScript.have_value)
              {
                result.setStationNameInLocalScript(fieldGeneratorStationNameInLocalScript.value);
                fieldGeneratorStationNameInLocalScript.have_value = false;
              }
            if (fieldGeneratorLocalScript.have_value)
              {
                result.setLocalScript(fieldGeneratorLocalScript.value);
                fieldGeneratorLocalScript.have_value = false;
              }
            if (fieldGeneratorStationNameSpoken.have_value)
              {
                result.setStationNameSpoken(fieldGeneratorStationNameSpoken.value);
                fieldGeneratorStationNameSpoken.have_value = false;
              }
            else if ((!(result.hasStationNameSpoken())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"StationNameSpoken\" field was missing.");
              }
            if (fieldGeneratorAlreadyOnResult.have_value)
              {
                result.setAlreadyOnResult(fieldGeneratorAlreadyOnResult.value);
                fieldGeneratorAlreadyOnResult.have_value = false;
              }
            if (fieldGeneratorSuggestions.have_value)
              {
                result.setSuggestions(fieldGeneratorSuggestions.value);
                fieldGeneratorSuggestions.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(TuneToStationUIDCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "lreadyOnResult", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorAlreadyOnResult;
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "ocalScript", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorLocalScript;
                    break;
                case 'S':
                    switch (field_name[1])
                      {
                        case 't':
                            if (String.Compare(field_name, 2, "ation", 0, 5, false) == 0)
                              {
                                switch (field_name[7])
                                  {
                                    case 'N':
                                        if (String.Compare(field_name, 8, "ame", 0, 3, false) == 0)
                                          {
                                            if (field_name.Length == 11)
                                              {
                                                return fieldGeneratorStationName;
                                              }
                                            switch (field_name[11])
                                              {
                                                case 'I':
                                                    if ((String.Compare(field_name, 12, "nLocalScript", 0, 12, false) == 0) && (field_name.Length == 24))
                                                        return fieldGeneratorStationNameInLocalScript;
                                                    break;
                                                case 'S':
                                                    if ((String.Compare(field_name, 12, "poken", 0, 5, false) == 0) && (field_name.Length == 17))
                                                        return fieldGeneratorStationNameSpoken;
                                                    break;
                                                default:
                                                    break;
                                              }
                                          }
                                        break;
                                    case 'U':
                                        if ((String.Compare(field_name, 8, "ID", 0, 2, false) == 0) && (field_name.Length == 10))
                                            return fieldGeneratorStationUID;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'u':
                            if ((String.Compare(field_name, 2, "ggestions", 0, 9, false) == 0) && (field_name.Length == 11))
                                return fieldGeneratorSuggestions;
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
            fieldGeneratorStationUID = new FieldHoldingGeneratorStationUID("field \"StationUID\" of the TuneToStationUIDCommand class");
            fieldGeneratorStationName = new JSONHoldingStringGenerator("field \"StationName\" of the TuneToStationUIDCommand class");
            fieldGeneratorStationNameInLocalScript = new JSONHoldingStringGenerator("field \"StationNameInLocalScript\" of the TuneToStationUIDCommand class");
            fieldGeneratorLocalScript = new JSONHoldingStringGenerator("field \"LocalScript\" of the TuneToStationUIDCommand class");
            fieldGeneratorStationNameSpoken = new JSONHoldingStringGenerator("field \"StationNameSpoken\" of the TuneToStationUIDCommand class");
            fieldGeneratorAlreadyOnResult = new DynamicResponseJSON.HoldingGenerator("field \"AlreadyOnResult\" of the TuneToStationUIDCommand class", ignore_extras);
            fieldGeneratorSuggestions = new SuggestedStationsJSON.HoldingGenerator("field \"Suggestions\" of the TuneToStationUIDCommand class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the TuneToStationUIDCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorStationUID = new FieldHoldingGeneratorStationUID("field \"StationUID\" of the TuneToStationUIDCommand class");
            fieldGeneratorStationName = new JSONHoldingStringGenerator("field \"StationName\" of the TuneToStationUIDCommand class");
            fieldGeneratorStationNameInLocalScript = new JSONHoldingStringGenerator("field \"StationNameInLocalScript\" of the TuneToStationUIDCommand class");
            fieldGeneratorLocalScript = new JSONHoldingStringGenerator("field \"LocalScript\" of the TuneToStationUIDCommand class");
            fieldGeneratorStationNameSpoken = new JSONHoldingStringGenerator("field \"StationNameSpoken\" of the TuneToStationUIDCommand class");
            fieldGeneratorAlreadyOnResult = new DynamicResponseJSON.HoldingGenerator("field \"AlreadyOnResult\" of the TuneToStationUIDCommand class", false);
            fieldGeneratorSuggestions = new SuggestedStationsJSON.HoldingGenerator("field \"Suggestions\" of the TuneToStationUIDCommand class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the TuneToStationUIDCommand class");
          }

        public override void reset()
          {
            fieldGeneratorStationUID.reset();
            fieldGeneratorStationName.reset();
            fieldGeneratorStationNameInLocalScript.reset();
            fieldGeneratorLocalScript.reset();
            fieldGeneratorStationNameSpoken.reset();
            fieldGeneratorAlreadyOnResult.reset();
            fieldGeneratorSuggestions.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(TuneToStationUIDCommandJSON  result)
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
        public TuneToStationUIDCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(TuneToStationUIDCommandJSON  result)
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
    protected virtual void handle_result(List<TuneToStationUIDCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TuneToStationUIDCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<TuneToStationUIDCommandJSON>();
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
    public List<TuneToStationUIDCommandJSON> value;
  };
  };
