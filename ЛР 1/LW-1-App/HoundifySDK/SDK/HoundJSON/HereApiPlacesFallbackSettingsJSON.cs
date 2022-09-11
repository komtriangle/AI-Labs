/* file "HereApiPlacesFallbackSettingsJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class HereApiPlacesFallbackSettingsJSON : JSONBase
  {
    public enum TypeMatchingLoosenessLevelKnownValues
      {
        MatchingLoosenessLevel_Standard,
        MatchingLoosenessLevel_Picard,
        MatchingLoosenessLevel_Janeway,
        MatchingLoosenessLevel_Tarzan,
        MatchingLoosenessLevel_WebSearch,
        MatchingLoosenessLevel__none
      };
    public struct TypeMatchingLoosenessLevel
      {
        public bool in_known_list;
        public string string_value;
        public TypeMatchingLoosenessLevelKnownValues list_value;
      };

    public static TypeMatchingLoosenessLevelKnownValues  stringToMatchingLoosenessLevel(string chars)
      {
        switch (chars[0])
          {
            case 'J':
                if ((String.Compare(chars, 1, "aneway", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeMatchingLoosenessLevelKnownValues.MatchingLoosenessLevel_Janeway;
                break;
            case 'P':
                if ((String.Compare(chars, 1, "icard", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeMatchingLoosenessLevelKnownValues.MatchingLoosenessLevel_Picard;
                break;
            case 'S':
                if ((String.Compare(chars, 1, "tandard", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeMatchingLoosenessLevelKnownValues.MatchingLoosenessLevel_Standard;
                break;
            case 'T':
                if ((String.Compare(chars, 1, "arzan", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeMatchingLoosenessLevelKnownValues.MatchingLoosenessLevel_Tarzan;
                break;
            case 'W':
                if ((String.Compare(chars, 1, "ebSearch", 0, 8, false) == 0) && (chars.Length == 9))
                    return TypeMatchingLoosenessLevelKnownValues.MatchingLoosenessLevel_WebSearch;
                break;
            default:
                break;
          }
        return TypeMatchingLoosenessLevelKnownValues.MatchingLoosenessLevel__none;
      }

    public static string  stringFromMatchingLoosenessLevel(TypeMatchingLoosenessLevelKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeMatchingLoosenessLevelKnownValues.MatchingLoosenessLevel_Standard:
                return "Standard";
            case TypeMatchingLoosenessLevelKnownValues.MatchingLoosenessLevel_Picard:
                return "Picard";
            case TypeMatchingLoosenessLevelKnownValues.MatchingLoosenessLevel_Janeway:
                return "Janeway";
            case TypeMatchingLoosenessLevelKnownValues.MatchingLoosenessLevel_Tarzan:
                return "Tarzan";
            case TypeMatchingLoosenessLevelKnownValues.MatchingLoosenessLevel_WebSearch:
                return "WebSearch";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypePhrasingContextRequiredForKnownValues
      {
        PhrasingContextRequiredFor_PlaceNamesOnly,
        PhrasingContextRequiredFor_None,
        PhrasingContextRequiredFor__none
      };
    public struct TypePhrasingContextRequiredFor
      {
        public bool in_known_list;
        public string string_value;
        public TypePhrasingContextRequiredForKnownValues list_value;
      };

    public static TypePhrasingContextRequiredForKnownValues  stringToPhrasingContextRequiredFor(string chars)
      {
        switch (chars[0])
          {
            case 'N':
                if ((String.Compare(chars, 1, "one", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypePhrasingContextRequiredForKnownValues.PhrasingContextRequiredFor_None;
                break;
            case 'P':
                if ((String.Compare(chars, 1, "laceNamesOnly", 0, 13, false) == 0) && (chars.Length == 14))
                    return TypePhrasingContextRequiredForKnownValues.PhrasingContextRequiredFor_PlaceNamesOnly;
                break;
            default:
                break;
          }
        return TypePhrasingContextRequiredForKnownValues.PhrasingContextRequiredFor__none;
      }

    public static string  stringFromPhrasingContextRequiredFor(TypePhrasingContextRequiredForKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypePhrasingContextRequiredForKnownValues.PhrasingContextRequiredFor_PlaceNamesOnly:
                return "PlaceNamesOnly";
            case TypePhrasingContextRequiredForKnownValues.PhrasingContextRequiredFor_None:
                return "None";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasHerePlacesApi;
    private HerePlacesApiSettingsJSON  storeHerePlacesApi;
    private bool flagHasMatchingLoosenessLevel;
    private TypeMatchingLoosenessLevel storeMatchingLoosenessLevel;
    private bool flagHasPhrasingContextRequiredFor;
    private TypePhrasingContextRequiredFor storePhrasingContextRequiredFor;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONHerePlacesApi(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        HerePlacesApiSettingsJSON convert_classy = HerePlacesApiSettingsJSON.from_json(json_value, ignore_extras, true);
        setHerePlacesApi(convert_classy);
      }


    private void  fromJSONMatchingLoosenessLevel(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field MatchingLoosenessLevel of HereApiPlacesFallbackSettingsJSON is not a string.");
        TypeMatchingLoosenessLevel the_open_enum = new TypeMatchingLoosenessLevel();
        switch (json_string.getData()[0])
          {
            case 'J':
                if ((String.Compare(json_string.getData(), 1, "aneway", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeMatchingLoosenessLevelKnownValues.MatchingLoosenessLevel_Janeway;
                        goto open_enum_is_done;
                      }
                break;
            case 'P':
                if ((String.Compare(json_string.getData(), 1, "icard", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeMatchingLoosenessLevelKnownValues.MatchingLoosenessLevel_Picard;
                        goto open_enum_is_done;
                      }
                break;
            case 'S':
                if ((String.Compare(json_string.getData(), 1, "tandard", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeMatchingLoosenessLevelKnownValues.MatchingLoosenessLevel_Standard;
                        goto open_enum_is_done;
                      }
                break;
            case 'T':
                if ((String.Compare(json_string.getData(), 1, "arzan", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeMatchingLoosenessLevelKnownValues.MatchingLoosenessLevel_Tarzan;
                        goto open_enum_is_done;
                      }
                break;
            case 'W':
                if ((String.Compare(json_string.getData(), 1, "ebSearch", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeMatchingLoosenessLevelKnownValues.MatchingLoosenessLevel_WebSearch;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setMatchingLoosenessLevel(the_open_enum);
      }


    private void  fromJSONPhrasingContextRequiredFor(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field PhrasingContextRequiredFor of HereApiPlacesFallbackSettingsJSON is not a string.");
        TypePhrasingContextRequiredFor the_open_enum = new TypePhrasingContextRequiredFor();
        switch (json_string.getData()[0])
          {
            case 'N':
                if ((String.Compare(json_string.getData(), 1, "one", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypePhrasingContextRequiredForKnownValues.PhrasingContextRequiredFor_None;
                        goto open_enum_is_done;
                      }
                break;
            case 'P':
                if ((String.Compare(json_string.getData(), 1, "laceNamesOnly", 0, 13, false) == 0) && (json_string.getData().Length == 14))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypePhrasingContextRequiredForKnownValues.PhrasingContextRequiredFor_PlaceNamesOnly;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setPhrasingContextRequiredFor(the_open_enum);
      }


    public HereApiPlacesFallbackSettingsJSON()
      {
        flagHasHerePlacesApi = false;
        flagHasMatchingLoosenessLevel = false;
        flagHasPhrasingContextRequiredFor = false;
        storeMatchingLoosenessLevel.in_known_list = true;
        storeMatchingLoosenessLevel.list_value = TypeMatchingLoosenessLevelKnownValues.MatchingLoosenessLevel_WebSearch;
        storePhrasingContextRequiredFor.in_known_list = true;
        storePhrasingContextRequiredFor.list_value = TypePhrasingContextRequiredForKnownValues.PhrasingContextRequiredFor_PlaceNamesOnly;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasHerePlacesApi()
      {
        return flagHasHerePlacesApi;
      }

    public HerePlacesApiSettingsJSON   getHerePlacesApi()
      {
        Debug.Assert(flagHasHerePlacesApi);
        return storeHerePlacesApi;
      }

    public bool  hasMatchingLoosenessLevel()
      {
        return flagHasMatchingLoosenessLevel;
      }

    public TypeMatchingLoosenessLevel  getMatchingLoosenessLevel()
      {
        return storeMatchingLoosenessLevel;
      }

    public string  getMatchingLoosenessLevelAsString()
      {
        TypeMatchingLoosenessLevel result = getMatchingLoosenessLevel();
        if (result.in_known_list)
            return stringFromMatchingLoosenessLevel(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasPhrasingContextRequiredFor()
      {
        return flagHasPhrasingContextRequiredFor;
      }

    public TypePhrasingContextRequiredFor  getPhrasingContextRequiredFor()
      {
        return storePhrasingContextRequiredFor;
      }

    public string  getPhrasingContextRequiredForAsString()
      {
        TypePhrasingContextRequiredFor result = getPhrasingContextRequiredFor();
        if (result.in_known_list)
            return stringFromPhrasingContextRequiredFor(result.list_value);
        else
            return result.string_value;
      }


    public virtual int extraHereApiPlacesFallbackSettingsComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraHereApiPlacesFallbackSettingsComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraHereApiPlacesFallbackSettingsComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraHereApiPlacesFallbackSettingsLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setHerePlacesApi(HerePlacesApiSettingsJSON  new_value)
      {
        if (flagHasHerePlacesApi)
          {
          }
        flagHasHerePlacesApi = true;
        storeHerePlacesApi = new_value;
      }
    public void unsetHerePlacesApi()
      {
        if (flagHasHerePlacesApi)
          {
          }
        flagHasHerePlacesApi = false;
      }
    public void setMatchingLoosenessLevel(TypeMatchingLoosenessLevel new_value)
      {
        flagHasMatchingLoosenessLevel = true;
        storeMatchingLoosenessLevel = new_value;
      }
    public void setMatchingLoosenessLevel(string chars)
      {
        TypeMatchingLoosenessLevelKnownValues known = stringToMatchingLoosenessLevel(chars);
        TypeMatchingLoosenessLevel new_value = new TypeMatchingLoosenessLevel();
        if (known == TypeMatchingLoosenessLevelKnownValues.MatchingLoosenessLevel__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setMatchingLoosenessLevel(new_value);
      }
    public void setMatchingLoosenessLevel(TypeMatchingLoosenessLevelKnownValues new_value)
      {
        TypeMatchingLoosenessLevel new_full_value = new TypeMatchingLoosenessLevel();
        Debug.Assert(new_value != TypeMatchingLoosenessLevelKnownValues.MatchingLoosenessLevel__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setMatchingLoosenessLevel(new_full_value);
      }
    public void unsetMatchingLoosenessLevel()
      {
        flagHasMatchingLoosenessLevel = false;
      }
    public void setPhrasingContextRequiredFor(TypePhrasingContextRequiredFor new_value)
      {
        flagHasPhrasingContextRequiredFor = true;
        storePhrasingContextRequiredFor = new_value;
      }
    public void setPhrasingContextRequiredFor(string chars)
      {
        TypePhrasingContextRequiredForKnownValues known = stringToPhrasingContextRequiredFor(chars);
        TypePhrasingContextRequiredFor new_value = new TypePhrasingContextRequiredFor();
        if (known == TypePhrasingContextRequiredForKnownValues.PhrasingContextRequiredFor__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setPhrasingContextRequiredFor(new_value);
      }
    public void setPhrasingContextRequiredFor(TypePhrasingContextRequiredForKnownValues new_value)
      {
        TypePhrasingContextRequiredFor new_full_value = new TypePhrasingContextRequiredFor();
        Debug.Assert(new_value != TypePhrasingContextRequiredForKnownValues.PhrasingContextRequiredFor__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setPhrasingContextRequiredFor(new_full_value);
      }
    public void unsetPhrasingContextRequiredFor()
      {
        flagHasPhrasingContextRequiredFor = false;
      }

    public virtual void extraHereApiPlacesFallbackSettingsAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraHereApiPlacesFallbackSettingsSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraHereApiPlacesFallbackSettingsLookup(key);
        if (old_field == null)
          {
            extraHereApiPlacesFallbackSettingsAppendPair(key, new_component);
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
        if (flagHasHerePlacesApi)
          {
            handler.start_pair("HerePlacesApi");
            if (partial_allowed)
                storeHerePlacesApi.write_partial_as_json(handler);
            else
                storeHerePlacesApi.write_as_json(handler);
          }
        if (flagHasMatchingLoosenessLevel)
          {
            handler.start_pair("MatchingLoosenessLevel");
            if (storeMatchingLoosenessLevel.in_known_list)
              {
                switch (storeMatchingLoosenessLevel.list_value)
                  {
                    case TypeMatchingLoosenessLevelKnownValues.MatchingLoosenessLevel_Standard:
                        handler.string_value("Standard");
                        break;
                    case TypeMatchingLoosenessLevelKnownValues.MatchingLoosenessLevel_Picard:
                        handler.string_value("Picard");
                        break;
                    case TypeMatchingLoosenessLevelKnownValues.MatchingLoosenessLevel_Janeway:
                        handler.string_value("Janeway");
                        break;
                    case TypeMatchingLoosenessLevelKnownValues.MatchingLoosenessLevel_Tarzan:
                        handler.string_value("Tarzan");
                        break;
                    case TypeMatchingLoosenessLevelKnownValues.MatchingLoosenessLevel_WebSearch:
                        handler.string_value("WebSearch");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeMatchingLoosenessLevel.string_value);
              }
          }
        if (flagHasPhrasingContextRequiredFor)
          {
            handler.start_pair("PhrasingContextRequiredFor");
            if (storePhrasingContextRequiredFor.in_known_list)
              {
                switch (storePhrasingContextRequiredFor.list_value)
                  {
                    case TypePhrasingContextRequiredForKnownValues.PhrasingContextRequiredFor_PlaceNamesOnly:
                        handler.string_value("PlaceNamesOnly");
                        break;
                    case TypePhrasingContextRequiredForKnownValues.PhrasingContextRequiredFor_None:
                        handler.string_value("None");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storePhrasingContextRequiredFor.string_value);
              }
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

    public static HereApiPlacesFallbackSettingsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HereApiPlacesFallbackSettingsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HereApiPlacesFallbackSettings", ignore_extras);
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
    public static HereApiPlacesFallbackSettingsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HereApiPlacesFallbackSettingsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HereApiPlacesFallbackSettingsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HereApiPlacesFallbackSettings", ignore_extras);
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
    public static HereApiPlacesFallbackSettingsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HereApiPlacesFallbackSettingsJSON from_text(string text, bool ignore_extras)
      {
        HereApiPlacesFallbackSettingsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HereApiPlacesFallbackSettings", ignore_extras);
            JSONParse.parse_json_value(text, "Text for HereApiPlacesFallbackSettingsJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static HereApiPlacesFallbackSettingsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        HereApiPlacesFallbackSettingsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HereApiPlacesFallbackSettings", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private HerePlacesApiSettingsJSON.HoldingGenerator fieldGeneratorHerePlacesApi;
    private abstract class FieldGeneratorMatchingLoosenessLevel : JSONStringGenerator
          {
            protected FieldGeneratorMatchingLoosenessLevel(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorMatchingLoosenessLevel()
              {
              }
            protected override void handle_result(string result)
              {
                TypeMatchingLoosenessLevelKnownValues known = stringToMatchingLoosenessLevel(result);
                TypeMatchingLoosenessLevel new_value = new TypeMatchingLoosenessLevel();
                if (known == TypeMatchingLoosenessLevelKnownValues.MatchingLoosenessLevel__none)
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
            protected abstract void handle_result(TypeMatchingLoosenessLevel result);
          };
    private class FieldHoldingGeneratorMatchingLoosenessLevel : FieldGeneratorMatchingLoosenessLevel
  {
    protected override void handle_result(TypeMatchingLoosenessLevel result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorMatchingLoosenessLevel(String what)
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
    public TypeMatchingLoosenessLevel value;
  };
    private class FieldHoldingArrayGeneratorMatchingLoosenessLevel : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorMatchingLoosenessLevel
      {
        private FieldHoldingArrayGeneratorMatchingLoosenessLevel top;

        protected override void handle_result(TypeMatchingLoosenessLevel result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorMatchingLoosenessLevel init_top)
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
    protected virtual void handle_result(List<TypeMatchingLoosenessLevel> result)
      {
      }

    public FieldHoldingArrayGeneratorMatchingLoosenessLevel(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeMatchingLoosenessLevel>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorMatchingLoosenessLevel()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeMatchingLoosenessLevel>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeMatchingLoosenessLevel> value;
  };
        private FieldHoldingGeneratorMatchingLoosenessLevel fieldGeneratorMatchingLoosenessLevel;
    private abstract class FieldGeneratorPhrasingContextRequiredFor : JSONStringGenerator
          {
            protected FieldGeneratorPhrasingContextRequiredFor(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorPhrasingContextRequiredFor()
              {
              }
            protected override void handle_result(string result)
              {
                TypePhrasingContextRequiredForKnownValues known = stringToPhrasingContextRequiredFor(result);
                TypePhrasingContextRequiredFor new_value = new TypePhrasingContextRequiredFor();
                if (known == TypePhrasingContextRequiredForKnownValues.PhrasingContextRequiredFor__none)
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
            protected abstract void handle_result(TypePhrasingContextRequiredFor result);
          };
    private class FieldHoldingGeneratorPhrasingContextRequiredFor : FieldGeneratorPhrasingContextRequiredFor
  {
    protected override void handle_result(TypePhrasingContextRequiredFor result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorPhrasingContextRequiredFor(String what)
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
    public TypePhrasingContextRequiredFor value;
  };
    private class FieldHoldingArrayGeneratorPhrasingContextRequiredFor : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorPhrasingContextRequiredFor
      {
        private FieldHoldingArrayGeneratorPhrasingContextRequiredFor top;

        protected override void handle_result(TypePhrasingContextRequiredFor result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorPhrasingContextRequiredFor init_top)
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
    protected virtual void handle_result(List<TypePhrasingContextRequiredFor> result)
      {
      }

    public FieldHoldingArrayGeneratorPhrasingContextRequiredFor(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypePhrasingContextRequiredFor>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorPhrasingContextRequiredFor()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypePhrasingContextRequiredFor>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypePhrasingContextRequiredFor> value;
  };
        private FieldHoldingGeneratorPhrasingContextRequiredFor fieldGeneratorPhrasingContextRequiredFor;
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
            HereApiPlacesFallbackSettingsJSON result = new HereApiPlacesFallbackSettingsJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraHereApiPlacesFallbackSettingsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(HereApiPlacesFallbackSettingsJSON result)
          {
            if (fieldGeneratorHerePlacesApi.have_value)
              {
                result.setHerePlacesApi(fieldGeneratorHerePlacesApi.value);
                fieldGeneratorHerePlacesApi.have_value = false;
              }
            if (fieldGeneratorMatchingLoosenessLevel.have_value)
              {
                result.setMatchingLoosenessLevel(fieldGeneratorMatchingLoosenessLevel.value);
                fieldGeneratorMatchingLoosenessLevel.have_value = false;
              }
            if (fieldGeneratorPhrasingContextRequiredFor.have_value)
              {
                result.setPhrasingContextRequiredFor(fieldGeneratorPhrasingContextRequiredFor.value);
                fieldGeneratorPhrasingContextRequiredFor.have_value = false;
              }
          }
        protected abstract void handle_result(HereApiPlacesFallbackSettingsJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'H':
                    if ((String.Compare(field_name, 1, "erePlacesApi", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorHerePlacesApi;
                    break;
                case 'M':
                    if ((String.Compare(field_name, 1, "atchingLoosenessLevel", 0, 21, false) == 0) && (field_name.Length == 22))
                        return fieldGeneratorMatchingLoosenessLevel;
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "hrasingContextRequiredFor", 0, 25, false) == 0) && (field_name.Length == 26))
                        return fieldGeneratorPhrasingContextRequiredFor;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorHerePlacesApi = new HerePlacesApiSettingsJSON.HoldingGenerator("field \"HerePlacesApi\" of the HereApiPlacesFallbackSettings class", ignore_extras);
            fieldGeneratorMatchingLoosenessLevel = new FieldHoldingGeneratorMatchingLoosenessLevel("field \"MatchingLoosenessLevel\" of the HereApiPlacesFallbackSettings class");
            fieldGeneratorPhrasingContextRequiredFor = new FieldHoldingGeneratorPhrasingContextRequiredFor("field \"PhrasingContextRequiredFor\" of the HereApiPlacesFallbackSettings class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the HereApiPlacesFallbackSettings class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorHerePlacesApi = new HerePlacesApiSettingsJSON.HoldingGenerator("field \"HerePlacesApi\" of the HereApiPlacesFallbackSettings class", false);
            fieldGeneratorMatchingLoosenessLevel = new FieldHoldingGeneratorMatchingLoosenessLevel("field \"MatchingLoosenessLevel\" of the HereApiPlacesFallbackSettings class");
            fieldGeneratorPhrasingContextRequiredFor = new FieldHoldingGeneratorPhrasingContextRequiredFor("field \"PhrasingContextRequiredFor\" of the HereApiPlacesFallbackSettings class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the HereApiPlacesFallbackSettings class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorHerePlacesApi.reset();
            fieldGeneratorMatchingLoosenessLevel.reset();
            fieldGeneratorPhrasingContextRequiredFor.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorHerePlacesApi.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorHerePlacesApi.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(HereApiPlacesFallbackSettingsJSON  result)
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
        public HereApiPlacesFallbackSettingsJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(HereApiPlacesFallbackSettingsJSON  result)
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
    protected virtual void handle_result(List<HereApiPlacesFallbackSettingsJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<HereApiPlacesFallbackSettingsJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<HereApiPlacesFallbackSettingsJSON>();
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
    public List<HereApiPlacesFallbackSettingsJSON> value;
  };
  };
