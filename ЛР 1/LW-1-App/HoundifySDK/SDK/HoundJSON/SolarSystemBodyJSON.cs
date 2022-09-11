/* file "SolarSystemBodyJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SolarSystemBodyJSON : GeneralizedThingJSON
  {
    public enum TypeEnglishNameKnownValues
      {
        EnglishName_the_x20_Moon,
        EnglishName_the_x20_Sun,
        EnglishName_Mercury,
        EnglishName_Venus,
        EnglishName_Earth,
        EnglishName_Mars,
        EnglishName_Jupiter,
        EnglishName_Saturn,
        EnglishName_Uranus,
        EnglishName_Neptune,
        EnglishName_Pluto,
        EnglishName__none
      };
    public struct TypeEnglishName
      {
        public bool in_known_list;
        public string string_value;
        public TypeEnglishNameKnownValues list_value;
      };

    public static TypeEnglishNameKnownValues  stringToEnglishName(string chars)
      {
        switch (chars[0])
          {
            case 'E':
                if ((String.Compare(chars, 1, "arth", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeEnglishNameKnownValues.EnglishName_Earth;
                break;
            case 'J':
                if ((String.Compare(chars, 1, "upiter", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeEnglishNameKnownValues.EnglishName_Jupiter;
                break;
            case 'M':
                switch (chars[1])
                  {
                    case 'a':
                        if ((String.Compare(chars, 2, "rs", 0, 2, false) == 0) && (chars.Length == 4))
                            return TypeEnglishNameKnownValues.EnglishName_Mars;
                        break;
                    case 'e':
                        if ((String.Compare(chars, 2, "rcury", 0, 5, false) == 0) && (chars.Length == 7))
                            return TypeEnglishNameKnownValues.EnglishName_Mercury;
                        break;
                    default:
                        break;
                  }
                break;
            case 'N':
                if ((String.Compare(chars, 1, "eptune", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeEnglishNameKnownValues.EnglishName_Neptune;
                break;
            case 'P':
                if ((String.Compare(chars, 1, "luto", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeEnglishNameKnownValues.EnglishName_Pluto;
                break;
            case 'S':
                if ((String.Compare(chars, 1, "aturn", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeEnglishNameKnownValues.EnglishName_Saturn;
                break;
            case 'U':
                if ((String.Compare(chars, 1, "ranus", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeEnglishNameKnownValues.EnglishName_Uranus;
                break;
            case 'V':
                if ((String.Compare(chars, 1, "enus", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeEnglishNameKnownValues.EnglishName_Venus;
                break;
            case 't':
                if (String.Compare(chars, 1, "he ", 0, 3, false) == 0)
                  {
                    switch (chars[4])
                      {
                        case 'M':
                            if ((String.Compare(chars, 5, "oon", 0, 3, false) == 0) && (chars.Length == 8))
                                return TypeEnglishNameKnownValues.EnglishName_the_x20_Moon;
                            break;
                        case 'S':
                            if ((String.Compare(chars, 5, "un", 0, 2, false) == 0) && (chars.Length == 7))
                                return TypeEnglishNameKnownValues.EnglishName_the_x20_Sun;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        return TypeEnglishNameKnownValues.EnglishName__none;
      }

    public static string  stringFromEnglishName(TypeEnglishNameKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeEnglishNameKnownValues.EnglishName_the_x20_Moon:
                return "the Moon";
            case TypeEnglishNameKnownValues.EnglishName_the_x20_Sun:
                return "the Sun";
            case TypeEnglishNameKnownValues.EnglishName_Mercury:
                return "Mercury";
            case TypeEnglishNameKnownValues.EnglishName_Venus:
                return "Venus";
            case TypeEnglishNameKnownValues.EnglishName_Earth:
                return "Earth";
            case TypeEnglishNameKnownValues.EnglishName_Mars:
                return "Mars";
            case TypeEnglishNameKnownValues.EnglishName_Jupiter:
                return "Jupiter";
            case TypeEnglishNameKnownValues.EnglishName_Saturn:
                return "Saturn";
            case TypeEnglishNameKnownValues.EnglishName_Uranus:
                return "Uranus";
            case TypeEnglishNameKnownValues.EnglishName_Neptune:
                return "Neptune";
            case TypeEnglishNameKnownValues.EnglishName_Pluto:
                return "Pluto";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasEnglishName;
    private TypeEnglishName storeEnglishName;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraEnglishNameToJSON()
      {
        JSONStringValue generated_string_EnglishName;
        if (!(storeEnglishName.in_known_list))
          {
        generated_string_EnglishName = new JSONStringValue(storeEnglishName.string_value);
          }
        else
          {
        switch (storeEnglishName.list_value)
          {
            case TypeEnglishNameKnownValues.EnglishName_the_x20_Moon:
                generated_string_EnglishName = new JSONStringValue("the Moon");
                break;
            case TypeEnglishNameKnownValues.EnglishName_the_x20_Sun:
                generated_string_EnglishName = new JSONStringValue("the Sun");
                break;
            case TypeEnglishNameKnownValues.EnglishName_Mercury:
                generated_string_EnglishName = new JSONStringValue("Mercury");
                break;
            case TypeEnglishNameKnownValues.EnglishName_Venus:
                generated_string_EnglishName = new JSONStringValue("Venus");
                break;
            case TypeEnglishNameKnownValues.EnglishName_Earth:
                generated_string_EnglishName = new JSONStringValue("Earth");
                break;
            case TypeEnglishNameKnownValues.EnglishName_Mars:
                generated_string_EnglishName = new JSONStringValue("Mars");
                break;
            case TypeEnglishNameKnownValues.EnglishName_Jupiter:
                generated_string_EnglishName = new JSONStringValue("Jupiter");
                break;
            case TypeEnglishNameKnownValues.EnglishName_Saturn:
                generated_string_EnglishName = new JSONStringValue("Saturn");
                break;
            case TypeEnglishNameKnownValues.EnglishName_Uranus:
                generated_string_EnglishName = new JSONStringValue("Uranus");
                break;
            case TypeEnglishNameKnownValues.EnglishName_Neptune:
                generated_string_EnglishName = new JSONStringValue("Neptune");
                break;
            case TypeEnglishNameKnownValues.EnglishName_Pluto:
                generated_string_EnglishName = new JSONStringValue("Pluto");
                break;
            default:
                Debug.Assert(false);
                generated_string_EnglishName = null;
                break;
          }
          }
        return generated_string_EnglishName;
      }


    private void  fromJSONEnglishName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field EnglishName of SolarSystemBodyJSON is not a string.");
        TypeEnglishName the_open_enum = new TypeEnglishName();
        switch (json_string.getData()[0])
          {
            case 'E':
                if ((String.Compare(json_string.getData(), 1, "arth", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeEnglishNameKnownValues.EnglishName_Earth;
                        goto open_enum_is_done;
                      }
                break;
            case 'J':
                if ((String.Compare(json_string.getData(), 1, "upiter", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeEnglishNameKnownValues.EnglishName_Jupiter;
                        goto open_enum_is_done;
                      }
                break;
            case 'M':
                switch (json_string.getData()[1])
                  {
                    case 'a':
                        if ((String.Compare(json_string.getData(), 2, "rs", 0, 2, false) == 0) && (json_string.getData().Length == 4))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeEnglishNameKnownValues.EnglishName_Mars;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'e':
                        if ((String.Compare(json_string.getData(), 2, "rcury", 0, 5, false) == 0) && (json_string.getData().Length == 7))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeEnglishNameKnownValues.EnglishName_Mercury;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'N':
                if ((String.Compare(json_string.getData(), 1, "eptune", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeEnglishNameKnownValues.EnglishName_Neptune;
                        goto open_enum_is_done;
                      }
                break;
            case 'P':
                if ((String.Compare(json_string.getData(), 1, "luto", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeEnglishNameKnownValues.EnglishName_Pluto;
                        goto open_enum_is_done;
                      }
                break;
            case 'S':
                if ((String.Compare(json_string.getData(), 1, "aturn", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeEnglishNameKnownValues.EnglishName_Saturn;
                        goto open_enum_is_done;
                      }
                break;
            case 'U':
                if ((String.Compare(json_string.getData(), 1, "ranus", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeEnglishNameKnownValues.EnglishName_Uranus;
                        goto open_enum_is_done;
                      }
                break;
            case 'V':
                if ((String.Compare(json_string.getData(), 1, "enus", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeEnglishNameKnownValues.EnglishName_Venus;
                        goto open_enum_is_done;
                      }
                break;
            case 't':
                if (String.Compare(json_string.getData(), 1, "he ", 0, 3, false) == 0)
                  {
                    switch (json_string.getData()[4])
                      {
                        case 'M':
                            if ((String.Compare(json_string.getData(), 5, "oon", 0, 3, false) == 0) && (json_string.getData().Length == 8))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeEnglishNameKnownValues.EnglishName_the_x20_Moon;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'S':
                            if ((String.Compare(json_string.getData(), 5, "un", 0, 2, false) == 0) && (json_string.getData().Length == 7))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeEnglishNameKnownValues.EnglishName_the_x20_Sun;
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
        setEnglishName(the_open_enum);
      }


    public SolarSystemBodyJSON()
      {
        flagHasEnglishName = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getThingKind()
      {
        return "SolarSystemBody";
      }

    public bool  hasEnglishName()
      {
        return flagHasEnglishName;
      }

    public TypeEnglishName  getEnglishName()
      {
        Debug.Assert(flagHasEnglishName);
        return storeEnglishName;
      }

    public string  getEnglishNameAsString()
      {
        TypeEnglishName result = getEnglishName();
        if (result.in_known_list)
            return stringFromEnglishName(result.list_value);
        else
            return result.string_value;
      }


    public virtual int extraSolarSystemBodyComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSolarSystemBodyComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSolarSystemBodyComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSolarSystemBodyLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraGeneralizedThingComponentCount()
      {
        int result = 0;
        if (flagHasEnglishName)
            ++result;
        result += extraSolarSystemBodyComponentCount();
        return result;
      }
    public override string extraGeneralizedThingComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasEnglishName)
          {
            if (remainder == 0)
                return "EnglishName";
            --remainder;
          }
        return extraSolarSystemBodyComponentKey(remainder);
      }
    public override JSONValue extraGeneralizedThingComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasEnglishName)
          {
            if (remainder == 0)
                return extraEnglishNameToJSON();
            --remainder;
          }
        return extraSolarSystemBodyComponentValue(remainder);
      }
    public override JSONValue extraGeneralizedThingLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "EnglishName", 0, 11, false) == 0) && (field_name.Length == 11))
            return (flagHasEnglishName ? extraEnglishNameToJSON() : null);
        return extraSolarSystemBodyLookup(field_name);
      }

    public void setEnglishName(TypeEnglishName new_value)
      {
        flagHasEnglishName = true;
        storeEnglishName = new_value;
      }
    public void setEnglishName(string chars)
      {
        TypeEnglishNameKnownValues known = stringToEnglishName(chars);
        TypeEnglishName new_value = new TypeEnglishName();
        if (known == TypeEnglishNameKnownValues.EnglishName__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setEnglishName(new_value);
      }
    public void setEnglishName(TypeEnglishNameKnownValues new_value)
      {
        TypeEnglishName new_full_value = new TypeEnglishName();
        Debug.Assert(new_value != TypeEnglishNameKnownValues.EnglishName__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setEnglishName(new_full_value);
      }
    public void unsetEnglishName()
      {
        flagHasEnglishName = false;
      }

    public virtual void extraSolarSystemBodyAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSolarSystemBodySetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSolarSystemBodyLookup(key);
        if (old_field == null)
          {
            extraSolarSystemBodyAppendPair(key, new_component);
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
    public override void extraGeneralizedThingAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "EnglishName", 0, 11, false) == 0) && (key.Length == 11))
            {
            fromJSONEnglishName(new_component, false);
            return;
            }
        extraSolarSystemBodyAppendPair(key, new_component);
      }
    public override void extraGeneralizedThingSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "EnglishName", 0, 11, false) == 0) && (key.Length == 11))
            {
            fromJSONEnglishName(new_component, false);
            return;
            }
        extraSolarSystemBodySetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasEnglishName);
        if (flagHasEnglishName)
          {
            handler.start_pair("EnglishName");
            if (storeEnglishName.in_known_list)
              {
                switch (storeEnglishName.list_value)
                  {
                    case TypeEnglishNameKnownValues.EnglishName_the_x20_Moon:
                        handler.string_value("the Moon");
                        break;
                    case TypeEnglishNameKnownValues.EnglishName_the_x20_Sun:
                        handler.string_value("the Sun");
                        break;
                    case TypeEnglishNameKnownValues.EnglishName_Mercury:
                        handler.string_value("Mercury");
                        break;
                    case TypeEnglishNameKnownValues.EnglishName_Venus:
                        handler.string_value("Venus");
                        break;
                    case TypeEnglishNameKnownValues.EnglishName_Earth:
                        handler.string_value("Earth");
                        break;
                    case TypeEnglishNameKnownValues.EnglishName_Mars:
                        handler.string_value("Mars");
                        break;
                    case TypeEnglishNameKnownValues.EnglishName_Jupiter:
                        handler.string_value("Jupiter");
                        break;
                    case TypeEnglishNameKnownValues.EnglishName_Saturn:
                        handler.string_value("Saturn");
                        break;
                    case TypeEnglishNameKnownValues.EnglishName_Uranus:
                        handler.string_value("Uranus");
                        break;
                    case TypeEnglishNameKnownValues.EnglishName_Neptune:
                        handler.string_value("Neptune");
                        break;
                    case TypeEnglishNameKnownValues.EnglishName_Pluto:
                        handler.string_value("Pluto");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeEnglishName.string_value);
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
    public override string missing_field_error(bool allow_unpolished)
      {
        if (!(hasEnglishName()))
          {
            return "When parsing the object for %what%, the \"EnglishName\" field was missing.";
          }
        return null;
      }

    public static new SolarSystemBodyJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SolarSystemBodyJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SolarSystemBody", ignore_extras);
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
    public static new SolarSystemBodyJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SolarSystemBodyJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SolarSystemBodyJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SolarSystemBody", ignore_extras);
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
    public static new SolarSystemBodyJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SolarSystemBodyJSON from_text(string text, bool ignore_extras)
      {
        SolarSystemBodyJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SolarSystemBody", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SolarSystemBodyJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new SolarSystemBodyJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SolarSystemBodyJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SolarSystemBody", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : GeneralizedThingJSON.Generator
      {
    private abstract class FieldGeneratorEnglishName : JSONStringGenerator
          {
            protected FieldGeneratorEnglishName(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorEnglishName()
              {
              }
            protected override void handle_result(string result)
              {
                TypeEnglishNameKnownValues known = stringToEnglishName(result);
                TypeEnglishName new_value = new TypeEnglishName();
                if (known == TypeEnglishNameKnownValues.EnglishName__none)
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
            protected abstract void handle_result(TypeEnglishName result);
          };
    private class FieldHoldingGeneratorEnglishName : FieldGeneratorEnglishName
  {
    protected override void handle_result(TypeEnglishName result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorEnglishName(String what)
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
    public TypeEnglishName value;
  };
    private class FieldHoldingArrayGeneratorEnglishName : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorEnglishName
      {
        private FieldHoldingArrayGeneratorEnglishName top;

        protected override void handle_result(TypeEnglishName result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorEnglishName init_top)
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
    protected virtual void handle_result(List<TypeEnglishName> result)
      {
      }

    public FieldHoldingArrayGeneratorEnglishName(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeEnglishName>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorEnglishName()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeEnglishName>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeEnglishName> value;
  };
        private FieldHoldingGeneratorEnglishName fieldGeneratorEnglishName;
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
            if (!(getGeneralizedThingJSONKey().Equals("SolarSystemBody")))
                throw new Exception("The key field has a value other than `SolarSystemBody'.");
            SolarSystemBodyJSON result = new SolarSystemBodyJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSolarSystemBodyAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(GeneralizedThingJSON new_result)
          {
            handle_result((SolarSystemBodyJSON )new_result);
          }
        protected void finish(SolarSystemBodyJSON result)
          {
            if (fieldGeneratorEnglishName.have_value)
              {
                result.setEnglishName(fieldGeneratorEnglishName.value);
                fieldGeneratorEnglishName.have_value = false;
              }
            else if ((!(result.hasEnglishName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"EnglishName\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(SolarSystemBodyJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "EnglishName", 0, 11, false) == 0) && (field_name.Length == 11))
                return fieldGeneratorEnglishName;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorEnglishName = new FieldHoldingGeneratorEnglishName("field \"EnglishName\" of the SolarSystemBody class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SolarSystemBody class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorEnglishName = new FieldHoldingGeneratorEnglishName("field \"EnglishName\" of the SolarSystemBody class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SolarSystemBody class");
          }

        public override void reset()
          {
            fieldGeneratorEnglishName.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(SolarSystemBodyJSON  result)
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
        public SolarSystemBodyJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SolarSystemBodyJSON  result)
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
    protected virtual void handle_result(List<SolarSystemBodyJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SolarSystemBodyJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SolarSystemBodyJSON>();
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
    public List<SolarSystemBodyJSON> value;
  };
  };
