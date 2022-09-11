/* file "TVChannelJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class TVChannelJSON : JSONBase
  {
    public enum TypeDefinitionKnownValues
      {
        Definition_SD,
        Definition_HD,
        Definition_FullHD,
        Definition_UHD4K,
        Definition_UHD8K,
        Definition__none
      };
    public struct TypeDefinition
      {
        public bool in_known_list;
        public string string_value;
        public TypeDefinitionKnownValues list_value;
      };

    public static TypeDefinitionKnownValues  stringToDefinition(string chars)
      {
        switch (chars[0])
          {
            case 'F':
                if ((String.Compare(chars, 1, "ullHD", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeDefinitionKnownValues.Definition_FullHD;
                break;
            case 'H':
                if ((String.Compare(chars, 1, "D", 0, 1, false) == 0) && (chars.Length == 2))
                    return TypeDefinitionKnownValues.Definition_HD;
                break;
            case 'S':
                if ((String.Compare(chars, 1, "D", 0, 1, false) == 0) && (chars.Length == 2))
                    return TypeDefinitionKnownValues.Definition_SD;
                break;
            case 'U':
                if (String.Compare(chars, 1, "HD", 0, 2, false) == 0)
                  {
                    switch (chars[3])
                      {
                        case '4':
                            if ((String.Compare(chars, 4, "K", 0, 1, false) == 0) && (chars.Length == 5))
                                return TypeDefinitionKnownValues.Definition_UHD4K;
                            break;
                        case '8':
                            if ((String.Compare(chars, 4, "K", 0, 1, false) == 0) && (chars.Length == 5))
                                return TypeDefinitionKnownValues.Definition_UHD8K;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        return TypeDefinitionKnownValues.Definition__none;
      }

    public static string  stringFromDefinition(TypeDefinitionKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeDefinitionKnownValues.Definition_SD:
                return "SD";
            case TypeDefinitionKnownValues.Definition_HD:
                return "HD";
            case TypeDefinitionKnownValues.Definition_FullHD:
                return "FullHD";
            case TypeDefinitionKnownValues.Definition_UHD4K:
                return "UHD4K";
            case TypeDefinitionKnownValues.Definition_UHD8K:
                return "UHD8K";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasChannelName;
    private string storeChannelName;
    private bool flagHasChannelNumber;
    private string storeChannelNumber;
    private bool flagHasCallLetters;
    private string storeCallLetters;
    private bool flagHasDefinition;
    private TypeDefinition storeDefinition;
    private bool flagHasHDR;
    private bool storeHDR;
    private bool flagHasSpokenChannelName;
    private string storeSpokenChannelName;
    private bool flagHasDisplayChannelName;
    private string storeDisplayChannelName;
    private bool flagHasSpokenChannelNumber;
    private string storeSpokenChannelNumber;
    private bool flagHasDisplayChannelNumber;
    private string storeDisplayChannelNumber;
    private bool flagHasSpokenChannelCallLetters;
    private string storeSpokenChannelCallLetters;
    private bool flagHasDisplayChannelCallLetters;
    private string storeDisplayChannelCallLetters;
    private bool flagHasAlternativeNames;
    private List< string > storeAlternativeNames;
    private bool flagHasChannelID;
    private string storeChannelID;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONChannelName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ChannelName of TVChannelJSON is not a string.");
        setChannelName(json_string.getData());
      }


    private void  fromJSONChannelNumber(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ChannelNumber of TVChannelJSON is not a string.");
        setChannelNumber(json_string.getData());
      }


    private void  fromJSONCallLetters(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CallLetters of TVChannelJSON is not a string.");
        setCallLetters(json_string.getData());
      }


    private void  fromJSONDefinition(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Definition of TVChannelJSON is not a string.");
        TypeDefinition the_open_enum = new TypeDefinition();
        switch (json_string.getData()[0])
          {
            case 'F':
                if ((String.Compare(json_string.getData(), 1, "ullHD", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeDefinitionKnownValues.Definition_FullHD;
                        goto open_enum_is_done;
                      }
                break;
            case 'H':
                if ((String.Compare(json_string.getData(), 1, "D", 0, 1, false) == 0) && (json_string.getData().Length == 2))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeDefinitionKnownValues.Definition_HD;
                        goto open_enum_is_done;
                      }
                break;
            case 'S':
                if ((String.Compare(json_string.getData(), 1, "D", 0, 1, false) == 0) && (json_string.getData().Length == 2))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeDefinitionKnownValues.Definition_SD;
                        goto open_enum_is_done;
                      }
                break;
            case 'U':
                if (String.Compare(json_string.getData(), 1, "HD", 0, 2, false) == 0)
                  {
                    switch (json_string.getData()[3])
                      {
                        case '4':
                            if ((String.Compare(json_string.getData(), 4, "K", 0, 1, false) == 0) && (json_string.getData().Length == 5))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeDefinitionKnownValues.Definition_UHD4K;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case '8':
                            if ((String.Compare(json_string.getData(), 4, "K", 0, 1, false) == 0) && (json_string.getData().Length == 5))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeDefinitionKnownValues.Definition_UHD8K;
                                    goto open_enum_is_done;
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
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setDefinition(the_open_enum);
      }


    private void  fromJSONHDR(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field HDR of TVChannelJSON is not true for false.");
              }
          }
        setHDR(the_bool);
      }


    private void  fromJSONSpokenChannelName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenChannelName of TVChannelJSON is not a string.");
        setSpokenChannelName(json_string.getData());
      }


    private void  fromJSONDisplayChannelName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field DisplayChannelName of TVChannelJSON is not a string.");
        setDisplayChannelName(json_string.getData());
      }


    private void  fromJSONSpokenChannelNumber(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenChannelNumber of TVChannelJSON is not a string.");
        setSpokenChannelNumber(json_string.getData());
      }


    private void  fromJSONDisplayChannelNumber(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field DisplayChannelNumber of TVChannelJSON is not a string.");
        setDisplayChannelNumber(json_string.getData());
      }


    private void  fromJSONSpokenChannelCallLetters(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenChannelCallLetters of TVChannelJSON is not a string.");
        setSpokenChannelCallLetters(json_string.getData());
      }


    private void  fromJSONDisplayChannelCallLetters(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field DisplayChannelCallLetters of TVChannelJSON is not a string.");
        setDisplayChannelCallLetters(json_string.getData());
      }


    private void  fromJSONAlternativeNames(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field AlternativeNames of TVChannelJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_AlternativeNames1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field AlternativeNames of TVChannelJSON is not a string.");
            vector_AlternativeNames1.Add(json_string.getData());
          }
        initAlternativeNames();
        for (int num1 = 0; num1 < vector_AlternativeNames1.Count; ++num1)
            appendAlternativeNames(vector_AlternativeNames1[num1]);
        for (int num1 = 0; num1 < vector_AlternativeNames1.Count; ++num1)
          {
          }
      }


    private void  fromJSONChannelID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ChannelID of TVChannelJSON is not a string.");
        setChannelID(json_string.getData());
      }


    public TVChannelJSON()
      {
        flagHasChannelName = false;
        flagHasChannelNumber = false;
        flagHasCallLetters = false;
        flagHasDefinition = false;
        flagHasHDR = false;
        flagHasSpokenChannelName = false;
        flagHasDisplayChannelName = false;
        flagHasSpokenChannelNumber = false;
        flagHasDisplayChannelNumber = false;
        flagHasSpokenChannelCallLetters = false;
        flagHasDisplayChannelCallLetters = false;
        flagHasAlternativeNames = false;
        flagHasChannelID = false;
        storeAlternativeNames = new List< string >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasChannelName()
      {
        return flagHasChannelName;
      }

    public string  getChannelName()
      {
        Debug.Assert(flagHasChannelName);
        return storeChannelName;
      }

    public bool  hasChannelNumber()
      {
        return flagHasChannelNumber;
      }

    public string  getChannelNumber()
      {
        Debug.Assert(flagHasChannelNumber);
        return storeChannelNumber;
      }

    public bool  hasCallLetters()
      {
        return flagHasCallLetters;
      }

    public string  getCallLetters()
      {
        Debug.Assert(flagHasCallLetters);
        return storeCallLetters;
      }

    public bool  hasDefinition()
      {
        return flagHasDefinition;
      }

    public TypeDefinition  getDefinition()
      {
        Debug.Assert(flagHasDefinition);
        return storeDefinition;
      }

    public string  getDefinitionAsString()
      {
        TypeDefinition result = getDefinition();
        if (result.in_known_list)
            return stringFromDefinition(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasHDR()
      {
        return flagHasHDR;
      }

    public bool  getHDR()
      {
        Debug.Assert(flagHasHDR);
        return storeHDR;
      }

    public bool  hasSpokenChannelName()
      {
        return flagHasSpokenChannelName;
      }

    public string  getSpokenChannelName()
      {
        Debug.Assert(flagHasSpokenChannelName);
        return storeSpokenChannelName;
      }

    public bool  hasDisplayChannelName()
      {
        return flagHasDisplayChannelName;
      }

    public string  getDisplayChannelName()
      {
        Debug.Assert(flagHasDisplayChannelName);
        return storeDisplayChannelName;
      }

    public bool  hasSpokenChannelNumber()
      {
        return flagHasSpokenChannelNumber;
      }

    public string  getSpokenChannelNumber()
      {
        Debug.Assert(flagHasSpokenChannelNumber);
        return storeSpokenChannelNumber;
      }

    public bool  hasDisplayChannelNumber()
      {
        return flagHasDisplayChannelNumber;
      }

    public string  getDisplayChannelNumber()
      {
        Debug.Assert(flagHasDisplayChannelNumber);
        return storeDisplayChannelNumber;
      }

    public bool  hasSpokenChannelCallLetters()
      {
        return flagHasSpokenChannelCallLetters;
      }

    public string  getSpokenChannelCallLetters()
      {
        Debug.Assert(flagHasSpokenChannelCallLetters);
        return storeSpokenChannelCallLetters;
      }

    public bool  hasDisplayChannelCallLetters()
      {
        return flagHasDisplayChannelCallLetters;
      }

    public string  getDisplayChannelCallLetters()
      {
        Debug.Assert(flagHasDisplayChannelCallLetters);
        return storeDisplayChannelCallLetters;
      }

    public bool  hasAlternativeNames()
      {
        return flagHasAlternativeNames;
      }

    public int  countOfAlternativeNames()
      {
        Debug.Assert(flagHasAlternativeNames);
        return storeAlternativeNames.Count;
      }

    public string  elementOfAlternativeNames(int element_num)
      {
        Debug.Assert(flagHasAlternativeNames);
        return storeAlternativeNames[element_num];
      }

    public List< string >  getAlternativeNames()
      {
        Debug.Assert(flagHasAlternativeNames);
        return storeAlternativeNames;
      }

    public bool  hasChannelID()
      {
        return flagHasChannelID;
      }

    public string  getChannelID()
      {
        Debug.Assert(flagHasChannelID);
        return storeChannelID;
      }


    public virtual int extraTVChannelComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraTVChannelComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraTVChannelComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraTVChannelLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setChannelName(string new_value)
      {
        flagHasChannelName = true;
        storeChannelName = new_value;
      }
    public void unsetChannelName()
      {
        flagHasChannelName = false;
      }
    public void setChannelNumber(string new_value)
      {
        flagHasChannelNumber = true;
        storeChannelNumber = new_value;
      }
    public void unsetChannelNumber()
      {
        flagHasChannelNumber = false;
      }
    public void setCallLetters(string new_value)
      {
        flagHasCallLetters = true;
        storeCallLetters = new_value;
      }
    public void unsetCallLetters()
      {
        flagHasCallLetters = false;
      }
    public void setDefinition(TypeDefinition new_value)
      {
        flagHasDefinition = true;
        storeDefinition = new_value;
      }
    public void setDefinition(string chars)
      {
        TypeDefinitionKnownValues known = stringToDefinition(chars);
        TypeDefinition new_value = new TypeDefinition();
        if (known == TypeDefinitionKnownValues.Definition__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setDefinition(new_value);
      }
    public void setDefinition(TypeDefinitionKnownValues new_value)
      {
        TypeDefinition new_full_value = new TypeDefinition();
        Debug.Assert(new_value != TypeDefinitionKnownValues.Definition__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setDefinition(new_full_value);
      }
    public void unsetDefinition()
      {
        flagHasDefinition = false;
      }
    public void setHDR(bool new_value)
      {
        flagHasHDR = true;
        storeHDR = new_value;
      }
    public void unsetHDR()
      {
        flagHasHDR = false;
      }
    public void setSpokenChannelName(string new_value)
      {
        flagHasSpokenChannelName = true;
        storeSpokenChannelName = new_value;
      }
    public void unsetSpokenChannelName()
      {
        flagHasSpokenChannelName = false;
      }
    public void setDisplayChannelName(string new_value)
      {
        flagHasDisplayChannelName = true;
        storeDisplayChannelName = new_value;
      }
    public void unsetDisplayChannelName()
      {
        flagHasDisplayChannelName = false;
      }
    public void setSpokenChannelNumber(string new_value)
      {
        flagHasSpokenChannelNumber = true;
        storeSpokenChannelNumber = new_value;
      }
    public void unsetSpokenChannelNumber()
      {
        flagHasSpokenChannelNumber = false;
      }
    public void setDisplayChannelNumber(string new_value)
      {
        flagHasDisplayChannelNumber = true;
        storeDisplayChannelNumber = new_value;
      }
    public void unsetDisplayChannelNumber()
      {
        flagHasDisplayChannelNumber = false;
      }
    public void setSpokenChannelCallLetters(string new_value)
      {
        flagHasSpokenChannelCallLetters = true;
        storeSpokenChannelCallLetters = new_value;
      }
    public void unsetSpokenChannelCallLetters()
      {
        flagHasSpokenChannelCallLetters = false;
      }
    public void setDisplayChannelCallLetters(string new_value)
      {
        flagHasDisplayChannelCallLetters = true;
        storeDisplayChannelCallLetters = new_value;
      }
    public void unsetDisplayChannelCallLetters()
      {
        flagHasDisplayChannelCallLetters = false;
      }
    public void initAlternativeNames()
      {
        flagHasAlternativeNames = true;
        storeAlternativeNames.Clear();
      }
    public void appendAlternativeNames(string to_append)
      {
        if (!flagHasAlternativeNames)
          {
            flagHasAlternativeNames = true;
            storeAlternativeNames.Clear();
          }
        Debug.Assert(flagHasAlternativeNames);
        storeAlternativeNames.Add(to_append);
      }
    public void unsetAlternativeNames()
      {
        flagHasAlternativeNames = false;
        storeAlternativeNames.Clear();
      }
    public void setChannelID(string new_value)
      {
        flagHasChannelID = true;
        storeChannelID = new_value;
      }
    public void unsetChannelID()
      {
        flagHasChannelID = false;
      }

    public virtual void extraTVChannelAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraTVChannelSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraTVChannelLookup(key);
        if (old_field == null)
          {
            extraTVChannelAppendPair(key, new_component);
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
        if (flagHasChannelName)
          {
            handler.start_pair("ChannelName");
            handler.string_value(storeChannelName);
          }
        if (flagHasChannelNumber)
          {
            handler.start_pair("ChannelNumber");
            handler.string_value(storeChannelNumber);
          }
        if (flagHasCallLetters)
          {
            handler.start_pair("CallLetters");
            handler.string_value(storeCallLetters);
          }
        if (flagHasDefinition)
          {
            handler.start_pair("Definition");
            if (storeDefinition.in_known_list)
              {
                switch (storeDefinition.list_value)
                  {
                    case TypeDefinitionKnownValues.Definition_SD:
                        handler.string_value("SD");
                        break;
                    case TypeDefinitionKnownValues.Definition_HD:
                        handler.string_value("HD");
                        break;
                    case TypeDefinitionKnownValues.Definition_FullHD:
                        handler.string_value("FullHD");
                        break;
                    case TypeDefinitionKnownValues.Definition_UHD4K:
                        handler.string_value("UHD4K");
                        break;
                    case TypeDefinitionKnownValues.Definition_UHD8K:
                        handler.string_value("UHD8K");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeDefinition.string_value);
              }
          }
        if (flagHasHDR)
          {
            handler.start_pair("HDR");
            handler.boolean_value(storeHDR);
          }
        if (flagHasSpokenChannelName)
          {
            handler.start_pair("SpokenChannelName");
            handler.string_value(storeSpokenChannelName);
          }
        if (flagHasDisplayChannelName)
          {
            handler.start_pair("DisplayChannelName");
            handler.string_value(storeDisplayChannelName);
          }
        if (flagHasSpokenChannelNumber)
          {
            handler.start_pair("SpokenChannelNumber");
            handler.string_value(storeSpokenChannelNumber);
          }
        if (flagHasDisplayChannelNumber)
          {
            handler.start_pair("DisplayChannelNumber");
            handler.string_value(storeDisplayChannelNumber);
          }
        if (flagHasSpokenChannelCallLetters)
          {
            handler.start_pair("SpokenChannelCallLetters");
            handler.string_value(storeSpokenChannelCallLetters);
          }
        if (flagHasDisplayChannelCallLetters)
          {
            handler.start_pair("DisplayChannelCallLetters");
            handler.string_value(storeDisplayChannelCallLetters);
          }
        if (flagHasAlternativeNames)
          {
            handler.start_pair("AlternativeNames");
            handler.start_array();
            for (int num1 = 0; num1 < storeAlternativeNames.Count; ++num1)
              {
                handler.string_value(storeAlternativeNames[num1]);
              }
            handler.finish_array();
          }
        if (flagHasChannelID)
          {
            handler.start_pair("ChannelID");
            handler.string_value(storeChannelID);
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
        return null;
      }

    public static TVChannelJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TVChannelJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TVChannel", ignore_extras);
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
    public static TVChannelJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static TVChannelJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TVChannelJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TVChannel", ignore_extras);
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
    public static TVChannelJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static TVChannelJSON from_text(string text, bool ignore_extras)
      {
        TVChannelJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TVChannel", ignore_extras);
            JSONParse.parse_json_value(text, "Text for TVChannelJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static TVChannelJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        TVChannelJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TVChannel", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorChannelName;
        private JSONHoldingStringGenerator fieldGeneratorChannelNumber;
        private JSONHoldingStringGenerator fieldGeneratorCallLetters;
    private abstract class FieldGeneratorDefinition : JSONStringGenerator
          {
            protected FieldGeneratorDefinition(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorDefinition()
              {
              }
            protected override void handle_result(string result)
              {
                TypeDefinitionKnownValues known = stringToDefinition(result);
                TypeDefinition new_value = new TypeDefinition();
                if (known == TypeDefinitionKnownValues.Definition__none)
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
            protected abstract void handle_result(TypeDefinition result);
          };
    private class FieldHoldingGeneratorDefinition : FieldGeneratorDefinition
  {
    protected override void handle_result(TypeDefinition result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorDefinition(String what)
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
    public TypeDefinition value;
  };
    private class FieldHoldingArrayGeneratorDefinition : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorDefinition
      {
        private FieldHoldingArrayGeneratorDefinition top;

        protected override void handle_result(TypeDefinition result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorDefinition init_top)
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
    protected virtual void handle_result(List<TypeDefinition> result)
      {
      }

    public FieldHoldingArrayGeneratorDefinition(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeDefinition>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorDefinition()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeDefinition>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeDefinition> value;
  };
        private FieldHoldingGeneratorDefinition fieldGeneratorDefinition;
        private JSONHoldingBooleanGenerator fieldGeneratorHDR;
        private JSONHoldingStringGenerator fieldGeneratorSpokenChannelName;
        private JSONHoldingStringGenerator fieldGeneratorDisplayChannelName;
        private JSONHoldingStringGenerator fieldGeneratorSpokenChannelNumber;
        private JSONHoldingStringGenerator fieldGeneratorDisplayChannelNumber;
        private JSONHoldingStringGenerator fieldGeneratorSpokenChannelCallLetters;
        private JSONHoldingStringGenerator fieldGeneratorDisplayChannelCallLetters;
        private JSONHoldingStringArrayGenerator fieldGeneratorAlternativeNames;
        private JSONHoldingStringGenerator fieldGeneratorChannelID;
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
            TVChannelJSON result = new TVChannelJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraTVChannelAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(TVChannelJSON result)
          {
            if (fieldGeneratorChannelName.have_value)
              {
                result.setChannelName(fieldGeneratorChannelName.value);
                fieldGeneratorChannelName.have_value = false;
              }
            if (fieldGeneratorChannelNumber.have_value)
              {
                result.setChannelNumber(fieldGeneratorChannelNumber.value);
                fieldGeneratorChannelNumber.have_value = false;
              }
            if (fieldGeneratorCallLetters.have_value)
              {
                result.setCallLetters(fieldGeneratorCallLetters.value);
                fieldGeneratorCallLetters.have_value = false;
              }
            if (fieldGeneratorDefinition.have_value)
              {
                result.setDefinition(fieldGeneratorDefinition.value);
                fieldGeneratorDefinition.have_value = false;
              }
            if (fieldGeneratorHDR.have_value)
              {
                result.setHDR(fieldGeneratorHDR.value);
                fieldGeneratorHDR.have_value = false;
              }
            if (fieldGeneratorSpokenChannelName.have_value)
              {
                result.setSpokenChannelName(fieldGeneratorSpokenChannelName.value);
                fieldGeneratorSpokenChannelName.have_value = false;
              }
            if (fieldGeneratorDisplayChannelName.have_value)
              {
                result.setDisplayChannelName(fieldGeneratorDisplayChannelName.value);
                fieldGeneratorDisplayChannelName.have_value = false;
              }
            if (fieldGeneratorSpokenChannelNumber.have_value)
              {
                result.setSpokenChannelNumber(fieldGeneratorSpokenChannelNumber.value);
                fieldGeneratorSpokenChannelNumber.have_value = false;
              }
            if (fieldGeneratorDisplayChannelNumber.have_value)
              {
                result.setDisplayChannelNumber(fieldGeneratorDisplayChannelNumber.value);
                fieldGeneratorDisplayChannelNumber.have_value = false;
              }
            if (fieldGeneratorSpokenChannelCallLetters.have_value)
              {
                result.setSpokenChannelCallLetters(fieldGeneratorSpokenChannelCallLetters.value);
                fieldGeneratorSpokenChannelCallLetters.have_value = false;
              }
            if (fieldGeneratorDisplayChannelCallLetters.have_value)
              {
                result.setDisplayChannelCallLetters(fieldGeneratorDisplayChannelCallLetters.value);
                fieldGeneratorDisplayChannelCallLetters.have_value = false;
              }
            if (fieldGeneratorAlternativeNames.have_value)
              {
                result.initAlternativeNames();
                int count = fieldGeneratorAlternativeNames.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendAlternativeNames(fieldGeneratorAlternativeNames.value[num]);
                  }
                fieldGeneratorAlternativeNames.value.Clear();
                fieldGeneratorAlternativeNames.have_value = false;
              }
            if (fieldGeneratorChannelID.have_value)
              {
                result.setChannelID(fieldGeneratorChannelID.value);
                fieldGeneratorChannelID.have_value = false;
              }
          }
        protected abstract void handle_result(TVChannelJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "lternativeNames", 0, 15, false) == 0) && (field_name.Length == 16))
                        return fieldGeneratorAlternativeNames;
                    break;
                case 'C':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "llLetters", 0, 9, false) == 0) && (field_name.Length == 11))
                                return fieldGeneratorCallLetters;
                            break;
                        case 'h':
                            if (String.Compare(field_name, 2, "annel", 0, 5, false) == 0)
                              {
                                switch (field_name[7])
                                  {
                                    case 'I':
                                        if ((String.Compare(field_name, 8, "D", 0, 1, false) == 0) && (field_name.Length == 9))
                                            return fieldGeneratorChannelID;
                                        break;
                                    case 'N':
                                        switch (field_name[8])
                                          {
                                            case 'a':
                                                if ((String.Compare(field_name, 9, "me", 0, 2, false) == 0) && (field_name.Length == 11))
                                                    return fieldGeneratorChannelName;
                                                break;
                                            case 'u':
                                                if ((String.Compare(field_name, 9, "mber", 0, 4, false) == 0) && (field_name.Length == 13))
                                                    return fieldGeneratorChannelNumber;
                                                break;
                                            default:
                                                break;
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
                case 'D':
                    switch (field_name[1])
                      {
                        case 'e':
                            if ((String.Compare(field_name, 2, "finition", 0, 8, false) == 0) && (field_name.Length == 10))
                                return fieldGeneratorDefinition;
                            break;
                        case 'i':
                            if (String.Compare(field_name, 2, "splayChannel", 0, 12, false) == 0)
                              {
                                switch (field_name[14])
                                  {
                                    case 'C':
                                        if ((String.Compare(field_name, 15, "allLetters", 0, 10, false) == 0) && (field_name.Length == 25))
                                            return fieldGeneratorDisplayChannelCallLetters;
                                        break;
                                    case 'N':
                                        switch (field_name[15])
                                          {
                                            case 'a':
                                                if ((String.Compare(field_name, 16, "me", 0, 2, false) == 0) && (field_name.Length == 18))
                                                    return fieldGeneratorDisplayChannelName;
                                                break;
                                            case 'u':
                                                if ((String.Compare(field_name, 16, "mber", 0, 4, false) == 0) && (field_name.Length == 20))
                                                    return fieldGeneratorDisplayChannelNumber;
                                                break;
                                            default:
                                                break;
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
                case 'H':
                    if ((String.Compare(field_name, 1, "DR", 0, 2, false) == 0) && (field_name.Length == 3))
                        return fieldGeneratorHDR;
                    break;
                case 'S':
                    if (String.Compare(field_name, 1, "pokenChannel", 0, 12, false) == 0)
                      {
                        switch (field_name[13])
                          {
                            case 'C':
                                if ((String.Compare(field_name, 14, "allLetters", 0, 10, false) == 0) && (field_name.Length == 24))
                                    return fieldGeneratorSpokenChannelCallLetters;
                                break;
                            case 'N':
                                switch (field_name[14])
                                  {
                                    case 'a':
                                        if ((String.Compare(field_name, 15, "me", 0, 2, false) == 0) && (field_name.Length == 17))
                                            return fieldGeneratorSpokenChannelName;
                                        break;
                                    case 'u':
                                        if ((String.Compare(field_name, 15, "mber", 0, 4, false) == 0) && (field_name.Length == 19))
                                            return fieldGeneratorSpokenChannelNumber;
                                        break;
                                    default:
                                        break;
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
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorChannelName = new JSONHoldingStringGenerator("field \"ChannelName\" of the TVChannel class");
            fieldGeneratorChannelNumber = new JSONHoldingStringGenerator("field \"ChannelNumber\" of the TVChannel class");
            fieldGeneratorCallLetters = new JSONHoldingStringGenerator("field \"CallLetters\" of the TVChannel class");
            fieldGeneratorDefinition = new FieldHoldingGeneratorDefinition("field \"Definition\" of the TVChannel class");
            fieldGeneratorHDR = new JSONHoldingBooleanGenerator("field \"HDR\" of the TVChannel class");
            fieldGeneratorSpokenChannelName = new JSONHoldingStringGenerator("field \"SpokenChannelName\" of the TVChannel class");
            fieldGeneratorDisplayChannelName = new JSONHoldingStringGenerator("field \"DisplayChannelName\" of the TVChannel class");
            fieldGeneratorSpokenChannelNumber = new JSONHoldingStringGenerator("field \"SpokenChannelNumber\" of the TVChannel class");
            fieldGeneratorDisplayChannelNumber = new JSONHoldingStringGenerator("field \"DisplayChannelNumber\" of the TVChannel class");
            fieldGeneratorSpokenChannelCallLetters = new JSONHoldingStringGenerator("field \"SpokenChannelCallLetters\" of the TVChannel class");
            fieldGeneratorDisplayChannelCallLetters = new JSONHoldingStringGenerator("field \"DisplayChannelCallLetters\" of the TVChannel class");
            fieldGeneratorAlternativeNames = new JSONHoldingStringArrayGenerator("field \"AlternativeNames\" of the TVChannel class");
            fieldGeneratorChannelID = new JSONHoldingStringGenerator("field \"ChannelID\" of the TVChannel class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the TVChannel class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorChannelName = new JSONHoldingStringGenerator("field \"ChannelName\" of the TVChannel class");
            fieldGeneratorChannelNumber = new JSONHoldingStringGenerator("field \"ChannelNumber\" of the TVChannel class");
            fieldGeneratorCallLetters = new JSONHoldingStringGenerator("field \"CallLetters\" of the TVChannel class");
            fieldGeneratorDefinition = new FieldHoldingGeneratorDefinition("field \"Definition\" of the TVChannel class");
            fieldGeneratorHDR = new JSONHoldingBooleanGenerator("field \"HDR\" of the TVChannel class");
            fieldGeneratorSpokenChannelName = new JSONHoldingStringGenerator("field \"SpokenChannelName\" of the TVChannel class");
            fieldGeneratorDisplayChannelName = new JSONHoldingStringGenerator("field \"DisplayChannelName\" of the TVChannel class");
            fieldGeneratorSpokenChannelNumber = new JSONHoldingStringGenerator("field \"SpokenChannelNumber\" of the TVChannel class");
            fieldGeneratorDisplayChannelNumber = new JSONHoldingStringGenerator("field \"DisplayChannelNumber\" of the TVChannel class");
            fieldGeneratorSpokenChannelCallLetters = new JSONHoldingStringGenerator("field \"SpokenChannelCallLetters\" of the TVChannel class");
            fieldGeneratorDisplayChannelCallLetters = new JSONHoldingStringGenerator("field \"DisplayChannelCallLetters\" of the TVChannel class");
            fieldGeneratorAlternativeNames = new JSONHoldingStringArrayGenerator("field \"AlternativeNames\" of the TVChannel class");
            fieldGeneratorChannelID = new JSONHoldingStringGenerator("field \"ChannelID\" of the TVChannel class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the TVChannel class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorChannelName.reset();
            fieldGeneratorChannelNumber.reset();
            fieldGeneratorCallLetters.reset();
            fieldGeneratorDefinition.reset();
            fieldGeneratorHDR.reset();
            fieldGeneratorSpokenChannelName.reset();
            fieldGeneratorDisplayChannelName.reset();
            fieldGeneratorSpokenChannelNumber.reset();
            fieldGeneratorDisplayChannelNumber.reset();
            fieldGeneratorSpokenChannelCallLetters.reset();
            fieldGeneratorDisplayChannelCallLetters.reset();
            fieldGeneratorAlternativeNames.reset();
            fieldGeneratorChannelID.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(TVChannelJSON  result)
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
        public TVChannelJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(TVChannelJSON  result)
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
    protected virtual void handle_result(List<TVChannelJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TVChannelJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<TVChannelJSON>();
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
    public List<TVChannelJSON> value;
  };
  };
