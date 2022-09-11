/* file "SportsStatsArgumentTypeModifierJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SportsStatsArgumentTypeModifierJSON : JSONBase
  {
    public enum TypeArgumentType
      {
        ArgumentType_SportsStatsArgumentTypeModifier
      };

    public static TypeArgumentType  stringToArgumentType(string chars)
      {
        if ((String.Compare(chars, 0, "SportsStatsArgumentTypeModifier", 0, 31, false) == 0) && (chars.Length == 31))
            return TypeArgumentType.ArgumentType_SportsStatsArgumentTypeModifier;
        throw new Exception("The value for field `ArgumentType' is not one of the legal values.");
      }

    public static string  stringFromArgumentType(TypeArgumentType the_enum)
      {
        switch (the_enum)
          {
            case TypeArgumentType.ArgumentType_SportsStatsArgumentTypeModifier:
                return "SportsStatsArgumentTypeModifier";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeModifierNameKnownValues
      {
        ModifierName_PerGame,
        ModifierName_HockeyEvenStrength,
        ModifierName_HockeyPowerPlay,
        ModifierName_HockeyShortHanded,
        ModifierName_HockeyPenalty,
        ModifierName_HockeyEmptyNet,
        ModifierName_HockeyShootout,
        ModifierName__none
      };
    public struct TypeModifierName
      {
        public bool in_known_list;
        public string string_value;
        public TypeModifierNameKnownValues list_value;
      };

    public static TypeModifierNameKnownValues  stringToModifierName(string chars)
      {
        switch (chars[0])
          {
            case 'H':
                if (String.Compare(chars, 1, "ockey", 0, 5, false) == 0)
                  {
                    switch (chars[6])
                      {
                        case 'E':
                            switch (chars[7])
                              {
                                case 'm':
                                    if ((String.Compare(chars, 8, "ptyNet", 0, 6, false) == 0) && (chars.Length == 14))
                                        return TypeModifierNameKnownValues.ModifierName_HockeyEmptyNet;
                                    break;
                                case 'v':
                                    if ((String.Compare(chars, 8, "enStrength", 0, 10, false) == 0) && (chars.Length == 18))
                                        return TypeModifierNameKnownValues.ModifierName_HockeyEvenStrength;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'P':
                            switch (chars[7])
                              {
                                case 'e':
                                    if ((String.Compare(chars, 8, "nalty", 0, 5, false) == 0) && (chars.Length == 13))
                                        return TypeModifierNameKnownValues.ModifierName_HockeyPenalty;
                                    break;
                                case 'o':
                                    if ((String.Compare(chars, 8, "werPlay", 0, 7, false) == 0) && (chars.Length == 15))
                                        return TypeModifierNameKnownValues.ModifierName_HockeyPowerPlay;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'S':
                            if (String.Compare(chars, 7, "ho", 0, 2, false) == 0)
                              {
                                switch (chars[9])
                                  {
                                    case 'o':
                                        if ((String.Compare(chars, 10, "tout", 0, 4, false) == 0) && (chars.Length == 14))
                                            return TypeModifierNameKnownValues.ModifierName_HockeyShootout;
                                        break;
                                    case 'r':
                                        if ((String.Compare(chars, 10, "tHanded", 0, 7, false) == 0) && (chars.Length == 17))
                                            return TypeModifierNameKnownValues.ModifierName_HockeyShortHanded;
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
            case 'P':
                if ((String.Compare(chars, 1, "erGame", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeModifierNameKnownValues.ModifierName_PerGame;
                break;
            default:
                break;
          }
        return TypeModifierNameKnownValues.ModifierName__none;
      }

    public static string  stringFromModifierName(TypeModifierNameKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeModifierNameKnownValues.ModifierName_PerGame:
                return "PerGame";
            case TypeModifierNameKnownValues.ModifierName_HockeyEvenStrength:
                return "HockeyEvenStrength";
            case TypeModifierNameKnownValues.ModifierName_HockeyPowerPlay:
                return "HockeyPowerPlay";
            case TypeModifierNameKnownValues.ModifierName_HockeyShortHanded:
                return "HockeyShortHanded";
            case TypeModifierNameKnownValues.ModifierName_HockeyPenalty:
                return "HockeyPenalty";
            case TypeModifierNameKnownValues.ModifierName_HockeyEmptyNet:
                return "HockeyEmptyNet";
            case TypeModifierNameKnownValues.ModifierName_HockeyShootout:
                return "HockeyShootout";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasArgumentType;
    private bool flagHasModifierName;
    private TypeModifierName storeModifierName;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONArgumentType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ArgumentType of SportsStatsArgumentTypeModifierJSON is not a string.");
        if (!(json_string.getData().Equals("SportsStatsArgumentTypeModifier")))
            throw new Exception("The value for field ArgumentType of SportsStatsArgumentTypeModifierJSON is not `SportsStatsArgumentTypeModifier'.");
        setArgumentType();
      }


    private void  fromJSONModifierName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ModifierName of SportsStatsArgumentTypeModifierJSON is not a string.");
        TypeModifierName the_open_enum = new TypeModifierName();
        switch (json_string.getData()[0])
          {
            case 'H':
                if (String.Compare(json_string.getData(), 1, "ockey", 0, 5, false) == 0)
                  {
                    switch (json_string.getData()[6])
                      {
                        case 'E':
                            switch (json_string.getData()[7])
                              {
                                case 'm':
                                    if ((String.Compare(json_string.getData(), 8, "ptyNet", 0, 6, false) == 0) && (json_string.getData().Length == 14))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeModifierNameKnownValues.ModifierName_HockeyEmptyNet;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'v':
                                    if ((String.Compare(json_string.getData(), 8, "enStrength", 0, 10, false) == 0) && (json_string.getData().Length == 18))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeModifierNameKnownValues.ModifierName_HockeyEvenStrength;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'P':
                            switch (json_string.getData()[7])
                              {
                                case 'e':
                                    if ((String.Compare(json_string.getData(), 8, "nalty", 0, 5, false) == 0) && (json_string.getData().Length == 13))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeModifierNameKnownValues.ModifierName_HockeyPenalty;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'o':
                                    if ((String.Compare(json_string.getData(), 8, "werPlay", 0, 7, false) == 0) && (json_string.getData().Length == 15))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeModifierNameKnownValues.ModifierName_HockeyPowerPlay;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'S':
                            if (String.Compare(json_string.getData(), 7, "ho", 0, 2, false) == 0)
                              {
                                switch (json_string.getData()[9])
                                  {
                                    case 'o':
                                        if ((String.Compare(json_string.getData(), 10, "tout", 0, 4, false) == 0) && (json_string.getData().Length == 14))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeModifierNameKnownValues.ModifierName_HockeyShootout;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'r':
                                        if ((String.Compare(json_string.getData(), 10, "tHanded", 0, 7, false) == 0) && (json_string.getData().Length == 17))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeModifierNameKnownValues.ModifierName_HockeyShortHanded;
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
                  }
                break;
            case 'P':
                if ((String.Compare(json_string.getData(), 1, "erGame", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeModifierNameKnownValues.ModifierName_PerGame;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setModifierName(the_open_enum);
      }


    public SportsStatsArgumentTypeModifierJSON()
      {
        flagHasArgumentType = false;
        flagHasModifierName = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasArgumentType()
      {
        return flagHasArgumentType;
      }

    public TypeArgumentType  getArgumentType()
      {
        Debug.Assert(flagHasArgumentType);
        return TypeArgumentType.ArgumentType_SportsStatsArgumentTypeModifier;
      }

    public string  getArgumentTypeAsString()
      {
        return stringFromArgumentType(getArgumentType());
      }

    public bool  hasModifierName()
      {
        return flagHasModifierName;
      }

    public TypeModifierName  getModifierName()
      {
        Debug.Assert(flagHasModifierName);
        return storeModifierName;
      }

    public string  getModifierNameAsString()
      {
        TypeModifierName result = getModifierName();
        if (result.in_known_list)
            return stringFromModifierName(result.list_value);
        else
            return result.string_value;
      }


    public virtual int extraSportsStatsArgumentTypeModifierComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSportsStatsArgumentTypeModifierComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSportsStatsArgumentTypeModifierComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSportsStatsArgumentTypeModifierLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setArgumentType()
      {
        flagHasArgumentType = true;
      }
    public void setArgumentType(TypeArgumentType new_value)
      {
        setArgumentType();
      }
    public void setArgumentType(string chars)
      {
        setArgumentType(stringToArgumentType(chars));
      }
    public void unsetArgumentType()
      {
        flagHasArgumentType = false;
      }
    public void setModifierName(TypeModifierName new_value)
      {
        flagHasModifierName = true;
        storeModifierName = new_value;
      }
    public void setModifierName(string chars)
      {
        TypeModifierNameKnownValues known = stringToModifierName(chars);
        TypeModifierName new_value = new TypeModifierName();
        if (known == TypeModifierNameKnownValues.ModifierName__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setModifierName(new_value);
      }
    public void setModifierName(TypeModifierNameKnownValues new_value)
      {
        TypeModifierName new_full_value = new TypeModifierName();
        Debug.Assert(new_value != TypeModifierNameKnownValues.ModifierName__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setModifierName(new_full_value);
      }
    public void unsetModifierName()
      {
        flagHasModifierName = false;
      }

    public virtual void extraSportsStatsArgumentTypeModifierAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSportsStatsArgumentTypeModifierSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSportsStatsArgumentTypeModifierLookup(key);
        if (old_field == null)
          {
            extraSportsStatsArgumentTypeModifierAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasArgumentType);
        if (flagHasArgumentType)
          {
            handler.start_pair("ArgumentType");
            handler.string_value("SportsStatsArgumentTypeModifier");
          }
        Debug.Assert(partial_allowed || flagHasModifierName);
        if (flagHasModifierName)
          {
            handler.start_pair("ModifierName");
            if (storeModifierName.in_known_list)
              {
                switch (storeModifierName.list_value)
                  {
                    case TypeModifierNameKnownValues.ModifierName_PerGame:
                        handler.string_value("PerGame");
                        break;
                    case TypeModifierNameKnownValues.ModifierName_HockeyEvenStrength:
                        handler.string_value("HockeyEvenStrength");
                        break;
                    case TypeModifierNameKnownValues.ModifierName_HockeyPowerPlay:
                        handler.string_value("HockeyPowerPlay");
                        break;
                    case TypeModifierNameKnownValues.ModifierName_HockeyShortHanded:
                        handler.string_value("HockeyShortHanded");
                        break;
                    case TypeModifierNameKnownValues.ModifierName_HockeyPenalty:
                        handler.string_value("HockeyPenalty");
                        break;
                    case TypeModifierNameKnownValues.ModifierName_HockeyEmptyNet:
                        handler.string_value("HockeyEmptyNet");
                        break;
                    case TypeModifierNameKnownValues.ModifierName_HockeyShootout:
                        handler.string_value("HockeyShootout");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeModifierName.string_value);
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
        if (!(hasArgumentType()))
          {
            return "When parsing the object for %what%, the \"ArgumentType\" field was missing.";
          }
        if (!(hasModifierName()))
          {
            return "When parsing the object for %what%, the \"ModifierName\" field was missing.";
          }
        return null;
      }

    public static SportsStatsArgumentTypeModifierJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsStatsArgumentTypeModifierJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStatsArgumentTypeModifier", ignore_extras);
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
    public static SportsStatsArgumentTypeModifierJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsStatsArgumentTypeModifierJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsStatsArgumentTypeModifierJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStatsArgumentTypeModifier", ignore_extras);
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
    public static SportsStatsArgumentTypeModifierJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsStatsArgumentTypeModifierJSON from_text(string text, bool ignore_extras)
      {
        SportsStatsArgumentTypeModifierJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStatsArgumentTypeModifier", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsStatsArgumentTypeModifierJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SportsStatsArgumentTypeModifierJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsStatsArgumentTypeModifierJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStatsArgumentTypeModifier", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorArgumentType : JSONStringGenerator
          {
            protected FieldGeneratorArgumentType(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorArgumentType()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToArgumentType(result));
              }
            protected abstract void handle_result(TypeArgumentType result);
          };
    private class FieldHoldingGeneratorArgumentType : FieldGeneratorArgumentType
  {
    protected override void handle_result(TypeArgumentType result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorArgumentType(String what)
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
    public TypeArgumentType value;
  };
    private class FieldHoldingArrayGeneratorArgumentType : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorArgumentType
      {
        private FieldHoldingArrayGeneratorArgumentType top;

        protected override void handle_result(TypeArgumentType result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorArgumentType init_top)
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
    protected virtual void handle_result(List<TypeArgumentType> result)
      {
      }

    public FieldHoldingArrayGeneratorArgumentType(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeArgumentType>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorArgumentType()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeArgumentType>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeArgumentType> value;
  };
        private FieldHoldingGeneratorArgumentType fieldGeneratorArgumentType;
    private abstract class FieldGeneratorModifierName : JSONStringGenerator
          {
            protected FieldGeneratorModifierName(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorModifierName()
              {
              }
            protected override void handle_result(string result)
              {
                TypeModifierNameKnownValues known = stringToModifierName(result);
                TypeModifierName new_value = new TypeModifierName();
                if (known == TypeModifierNameKnownValues.ModifierName__none)
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
            protected abstract void handle_result(TypeModifierName result);
          };
    private class FieldHoldingGeneratorModifierName : FieldGeneratorModifierName
  {
    protected override void handle_result(TypeModifierName result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorModifierName(String what)
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
    public TypeModifierName value;
  };
    private class FieldHoldingArrayGeneratorModifierName : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorModifierName
      {
        private FieldHoldingArrayGeneratorModifierName top;

        protected override void handle_result(TypeModifierName result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorModifierName init_top)
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
    protected virtual void handle_result(List<TypeModifierName> result)
      {
      }

    public FieldHoldingArrayGeneratorModifierName(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeModifierName>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorModifierName()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeModifierName>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeModifierName> value;
  };
        private FieldHoldingGeneratorModifierName fieldGeneratorModifierName;
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
            SportsStatsArgumentTypeModifierJSON result = new SportsStatsArgumentTypeModifierJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsStatsArgumentTypeModifierAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(SportsStatsArgumentTypeModifierJSON result)
          {
            if (fieldGeneratorArgumentType.have_value)
              {
                result.setArgumentType();
                fieldGeneratorArgumentType.have_value = false;
              }
            else if ((!(result.hasArgumentType())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ArgumentType\" field was missing.");
              }
            if (fieldGeneratorModifierName.have_value)
              {
                result.setModifierName(fieldGeneratorModifierName.value);
                fieldGeneratorModifierName.have_value = false;
              }
            else if ((!(result.hasModifierName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ModifierName\" field was missing.");
              }
          }
        protected abstract void handle_result(SportsStatsArgumentTypeModifierJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "rgumentType", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorArgumentType;
                    break;
                case 'M':
                    if ((String.Compare(field_name, 1, "odifierName", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorModifierName;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorArgumentType = new FieldHoldingGeneratorArgumentType("field \"ArgumentType\" of the SportsStatsArgumentTypeModifier class");
            fieldGeneratorModifierName = new FieldHoldingGeneratorModifierName("field \"ModifierName\" of the SportsStatsArgumentTypeModifier class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SportsStatsArgumentTypeModifier class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorArgumentType = new FieldHoldingGeneratorArgumentType("field \"ArgumentType\" of the SportsStatsArgumentTypeModifier class");
            fieldGeneratorModifierName = new FieldHoldingGeneratorModifierName("field \"ModifierName\" of the SportsStatsArgumentTypeModifier class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SportsStatsArgumentTypeModifier class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorArgumentType.reset();
            fieldGeneratorModifierName.reset();
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
        protected override void handle_result(SportsStatsArgumentTypeModifierJSON  result)
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
        public SportsStatsArgumentTypeModifierJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsStatsArgumentTypeModifierJSON  result)
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
    protected virtual void handle_result(List<SportsStatsArgumentTypeModifierJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsStatsArgumentTypeModifierJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsStatsArgumentTypeModifierJSON>();
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
    public List<SportsStatsArgumentTypeModifierJSON> value;
  };
  };
