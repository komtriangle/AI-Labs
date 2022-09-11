/* file "CarControlLightsCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class CarControlLightsCommandJSON : CarControlCommandJSON
  {
    public enum TypeCommandType
      {
        CommandType_TurnOn,
        CommandType_TurnOff,
        CommandType_SetAuto,
        CommandType_Flash
      };

    public static TypeCommandType  stringToCommandType(string chars)
      {
        switch (chars[0])
          {
            case 'F':
                if ((String.Compare(chars, 1, "lash", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeCommandType.CommandType_Flash;
                break;
            case 'S':
                if ((String.Compare(chars, 1, "etAuto", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeCommandType.CommandType_SetAuto;
                break;
            case 'T':
                if (String.Compare(chars, 1, "urnO", 0, 4, false) == 0)
                  {
                    switch (chars[5])
                      {
                        case 'f':
                            if ((String.Compare(chars, 6, "f", 0, 1, false) == 0) && (chars.Length == 7))
                                return TypeCommandType.CommandType_TurnOff;
                            break;
                        case 'n':
                            if (chars.Length == 6)
                                return TypeCommandType.CommandType_TurnOn;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        throw new Exception("The value for field `CommandType' is not one of the legal values.");
      }

    public static string  stringFromCommandType(TypeCommandType the_enum)
      {
        switch (the_enum)
          {
            case TypeCommandType.CommandType_TurnOn:
                return "TurnOn";
            case TypeCommandType.CommandType_TurnOff:
                return "TurnOff";
            case TypeCommandType.CommandType_SetAuto:
                return "SetAuto";
            case TypeCommandType.CommandType_Flash:
                return "Flash";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeLightSelection
      {
        LightSelection_LowBeams,
        LightSelection_HighBeams,
        LightSelection_FogLights,
        LightSelection_LeftTurnSignal,
        LightSelection_RightTurnSignal,
        LightSelection_BothTurnSignals,
        LightSelection_HazardLights
      };

    public static TypeLightSelection  stringToLightSelection(string chars)
      {
        switch (chars[0])
          {
            case 'B':
                if ((String.Compare(chars, 1, "othTurnSignals", 0, 14, false) == 0) && (chars.Length == 15))
                    return TypeLightSelection.LightSelection_BothTurnSignals;
                break;
            case 'F':
                if ((String.Compare(chars, 1, "ogLights", 0, 8, false) == 0) && (chars.Length == 9))
                    return TypeLightSelection.LightSelection_FogLights;
                break;
            case 'H':
                switch (chars[1])
                  {
                    case 'a':
                        if ((String.Compare(chars, 2, "zardLights", 0, 10, false) == 0) && (chars.Length == 12))
                            return TypeLightSelection.LightSelection_HazardLights;
                        break;
                    case 'i':
                        if ((String.Compare(chars, 2, "ghBeams", 0, 7, false) == 0) && (chars.Length == 9))
                            return TypeLightSelection.LightSelection_HighBeams;
                        break;
                    default:
                        break;
                  }
                break;
            case 'L':
                switch (chars[1])
                  {
                    case 'e':
                        if ((String.Compare(chars, 2, "ftTurnSignal", 0, 12, false) == 0) && (chars.Length == 14))
                            return TypeLightSelection.LightSelection_LeftTurnSignal;
                        break;
                    case 'o':
                        if ((String.Compare(chars, 2, "wBeams", 0, 6, false) == 0) && (chars.Length == 8))
                            return TypeLightSelection.LightSelection_LowBeams;
                        break;
                    default:
                        break;
                  }
                break;
            case 'R':
                if ((String.Compare(chars, 1, "ightTurnSignal", 0, 14, false) == 0) && (chars.Length == 15))
                    return TypeLightSelection.LightSelection_RightTurnSignal;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `LightSelection' is not one of the legal values.");
      }

    public static string  stringFromLightSelection(TypeLightSelection the_enum)
      {
        switch (the_enum)
          {
            case TypeLightSelection.LightSelection_LowBeams:
                return "LowBeams";
            case TypeLightSelection.LightSelection_HighBeams:
                return "HighBeams";
            case TypeLightSelection.LightSelection_FogLights:
                return "FogLights";
            case TypeLightSelection.LightSelection_LeftTurnSignal:
                return "LeftTurnSignal";
            case TypeLightSelection.LightSelection_RightTurnSignal:
                return "RightTurnSignal";
            case TypeLightSelection.LightSelection_BothTurnSignals:
                return "BothTurnSignals";
            case TypeLightSelection.LightSelection_HazardLights:
                return "HazardLights";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasCommandType;
    private TypeCommandType storeCommandType;
    private bool flagHasLightSelection;
    private TypeLightSelection storeLightSelection;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraCommandTypeToJSON()
      {
        JSONStringValue generated_string_CommandType;
        switch (storeCommandType)
          {
            case TypeCommandType.CommandType_TurnOn:
                generated_string_CommandType = new JSONStringValue("TurnOn");
                break;
            case TypeCommandType.CommandType_TurnOff:
                generated_string_CommandType = new JSONStringValue("TurnOff");
                break;
            case TypeCommandType.CommandType_SetAuto:
                generated_string_CommandType = new JSONStringValue("SetAuto");
                break;
            case TypeCommandType.CommandType_Flash:
                generated_string_CommandType = new JSONStringValue("Flash");
                break;
            default:
                Debug.Assert(false);
                generated_string_CommandType = null;
                break;
          }
        return generated_string_CommandType;
      }

    private JSONValue  extraLightSelectionToJSON()
      {
        JSONStringValue generated_string_LightSelection;
        switch (storeLightSelection)
          {
            case TypeLightSelection.LightSelection_LowBeams:
                generated_string_LightSelection = new JSONStringValue("LowBeams");
                break;
            case TypeLightSelection.LightSelection_HighBeams:
                generated_string_LightSelection = new JSONStringValue("HighBeams");
                break;
            case TypeLightSelection.LightSelection_FogLights:
                generated_string_LightSelection = new JSONStringValue("FogLights");
                break;
            case TypeLightSelection.LightSelection_LeftTurnSignal:
                generated_string_LightSelection = new JSONStringValue("LeftTurnSignal");
                break;
            case TypeLightSelection.LightSelection_RightTurnSignal:
                generated_string_LightSelection = new JSONStringValue("RightTurnSignal");
                break;
            case TypeLightSelection.LightSelection_BothTurnSignals:
                generated_string_LightSelection = new JSONStringValue("BothTurnSignals");
                break;
            case TypeLightSelection.LightSelection_HazardLights:
                generated_string_LightSelection = new JSONStringValue("HazardLights");
                break;
            default:
                Debug.Assert(false);
                generated_string_LightSelection = null;
                break;
          }
        return generated_string_LightSelection;
      }


    private void  fromJSONCommandType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CommandType of CarControlLightsCommandJSON is not a string.");
        TypeCommandType the_enum;
        switch (json_string.getData()[0])
          {
            case 'F':
                if ((String.Compare(json_string.getData(), 1, "lash", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_enum = TypeCommandType.CommandType_Flash;
                        goto enum_is_done;
                      }
                break;
            case 'S':
                if ((String.Compare(json_string.getData(), 1, "etAuto", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_enum = TypeCommandType.CommandType_SetAuto;
                        goto enum_is_done;
                      }
                break;
            case 'T':
                if (String.Compare(json_string.getData(), 1, "urnO", 0, 4, false) == 0)
                  {
                    switch (json_string.getData()[5])
                      {
                        case 'f':
                            if ((String.Compare(json_string.getData(), 6, "f", 0, 1, false) == 0) && (json_string.getData().Length == 7))
                                  {
                                    the_enum = TypeCommandType.CommandType_TurnOff;
                                    goto enum_is_done;
                                  }
                            break;
                        case 'n':
                            if (json_string.getData().Length == 6)
                                  {
                                    the_enum = TypeCommandType.CommandType_TurnOn;
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
        throw new Exception("The value for field CommandType of CarControlLightsCommandJSON is not one of the legal strings.");
      enum_is_done:;
        setCommandType(the_enum);
      }


    private void  fromJSONLightSelection(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field LightSelection of CarControlLightsCommandJSON is not a string.");
        TypeLightSelection the_enum;
        switch (json_string.getData()[0])
          {
            case 'B':
                if ((String.Compare(json_string.getData(), 1, "othTurnSignals", 0, 14, false) == 0) && (json_string.getData().Length == 15))
                      {
                        the_enum = TypeLightSelection.LightSelection_BothTurnSignals;
                        goto enum_is_done;
                      }
                break;
            case 'F':
                if ((String.Compare(json_string.getData(), 1, "ogLights", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                      {
                        the_enum = TypeLightSelection.LightSelection_FogLights;
                        goto enum_is_done;
                      }
                break;
            case 'H':
                switch (json_string.getData()[1])
                  {
                    case 'a':
                        if ((String.Compare(json_string.getData(), 2, "zardLights", 0, 10, false) == 0) && (json_string.getData().Length == 12))
                              {
                                the_enum = TypeLightSelection.LightSelection_HazardLights;
                                goto enum_is_done;
                              }
                        break;
                    case 'i':
                        if ((String.Compare(json_string.getData(), 2, "ghBeams", 0, 7, false) == 0) && (json_string.getData().Length == 9))
                              {
                                the_enum = TypeLightSelection.LightSelection_HighBeams;
                                goto enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'L':
                switch (json_string.getData()[1])
                  {
                    case 'e':
                        if ((String.Compare(json_string.getData(), 2, "ftTurnSignal", 0, 12, false) == 0) && (json_string.getData().Length == 14))
                              {
                                the_enum = TypeLightSelection.LightSelection_LeftTurnSignal;
                                goto enum_is_done;
                              }
                        break;
                    case 'o':
                        if ((String.Compare(json_string.getData(), 2, "wBeams", 0, 6, false) == 0) && (json_string.getData().Length == 8))
                              {
                                the_enum = TypeLightSelection.LightSelection_LowBeams;
                                goto enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'R':
                if ((String.Compare(json_string.getData(), 1, "ightTurnSignal", 0, 14, false) == 0) && (json_string.getData().Length == 15))
                      {
                        the_enum = TypeLightSelection.LightSelection_RightTurnSignal;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field LightSelection of CarControlLightsCommandJSON is not one of the legal strings.");
      enum_is_done:;
        setLightSelection(the_enum);
      }


    public CarControlLightsCommandJSON()
      {
        flagHasCommandType = false;
        flagHasLightSelection = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getCarControlCommandKind()
      {
        return "CarControlLightCommand";
      }

    public bool  hasCommandType()
      {
        return flagHasCommandType;
      }

    public TypeCommandType  getCommandType()
      {
        Debug.Assert(flagHasCommandType);
        return storeCommandType;
      }

    public string  getCommandTypeAsString()
      {
        return stringFromCommandType(getCommandType());
      }

    public bool  hasLightSelection()
      {
        return flagHasLightSelection;
      }

    public TypeLightSelection  getLightSelection()
      {
        Debug.Assert(flagHasLightSelection);
        return storeLightSelection;
      }

    public string  getLightSelectionAsString()
      {
        return stringFromLightSelection(getLightSelection());
      }


    public virtual int extraCarControlLightsCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraCarControlLightsCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraCarControlLightsCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraCarControlLightsCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraCarControlCommandComponentCount()
      {
        int result = 0;
        if (flagHasCommandType)
            ++result;
        if (flagHasLightSelection)
            ++result;
        result += extraCarControlLightsCommandComponentCount();
        return result;
      }
    public override string extraCarControlCommandComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasCommandType)
          {
            if (remainder == 0)
                return "CommandType";
            --remainder;
          }
        if (flagHasLightSelection)
          {
            if (remainder == 0)
                return "LightSelection";
            --remainder;
          }
        return extraCarControlLightsCommandComponentKey(remainder);
      }
    public override JSONValue extraCarControlCommandComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasCommandType)
          {
            if (remainder == 0)
                return extraCommandTypeToJSON();
            --remainder;
          }
        if (flagHasLightSelection)
          {
            if (remainder == 0)
                return extraLightSelectionToJSON();
            --remainder;
          }
        return extraCarControlLightsCommandComponentValue(remainder);
      }
    public override JSONValue extraCarControlCommandLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'C':
                if ((String.Compare(field_name, 1, "ommandType", 0, 10, false) == 0) && (field_name.Length == 11))
                    return (flagHasCommandType ? extraCommandTypeToJSON() : null);
                break;
            case 'L':
                if ((String.Compare(field_name, 1, "ightSelection", 0, 13, false) == 0) && (field_name.Length == 14))
                    return (flagHasLightSelection ? extraLightSelectionToJSON() : null);
                break;
            default:
                break;
          }
        return extraCarControlLightsCommandLookup(field_name);
      }

    public void setCommandType(TypeCommandType new_value)
      {
        flagHasCommandType = true;
        storeCommandType = new_value;
      }
    public void setCommandType(string chars)
      {
        setCommandType(stringToCommandType(chars));
      }
    public void unsetCommandType()
      {
        flagHasCommandType = false;
      }
    public void setLightSelection(TypeLightSelection new_value)
      {
        flagHasLightSelection = true;
        storeLightSelection = new_value;
      }
    public void setLightSelection(string chars)
      {
        setLightSelection(stringToLightSelection(chars));
      }
    public void unsetLightSelection()
      {
        flagHasLightSelection = false;
      }

    public virtual void extraCarControlLightsCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraCarControlLightsCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraCarControlLightsCommandLookup(key);
        if (old_field == null)
          {
            extraCarControlLightsCommandAppendPair(key, new_component);
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
    public override void extraCarControlCommandAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                if ((String.Compare(key, 1, "ommandType", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONCommandType(new_component, false);
                    return;
                    }
                break;
            case 'L':
                if ((String.Compare(key, 1, "ightSelection", 0, 13, false) == 0) && (key.Length == 14))
                    {
                    fromJSONLightSelection(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraCarControlLightsCommandAppendPair(key, new_component);
      }
    public override void extraCarControlCommandSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                if ((String.Compare(key, 1, "ommandType", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONCommandType(new_component, false);
                    return;
                    }
                break;
            case 'L':
                if ((String.Compare(key, 1, "ightSelection", 0, 13, false) == 0) && (key.Length == 14))
                    {
                    fromJSONLightSelection(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraCarControlLightsCommandSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasCommandType);
        if (flagHasCommandType)
          {
            handler.start_pair("CommandType");
            switch (storeCommandType)
              {
                case TypeCommandType.CommandType_TurnOn:
                    handler.string_value("TurnOn");
                    break;
                case TypeCommandType.CommandType_TurnOff:
                    handler.string_value("TurnOff");
                    break;
                case TypeCommandType.CommandType_SetAuto:
                    handler.string_value("SetAuto");
                    break;
                case TypeCommandType.CommandType_Flash:
                    handler.string_value("Flash");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        Debug.Assert(partial_allowed || flagHasLightSelection);
        if (flagHasLightSelection)
          {
            handler.start_pair("LightSelection");
            switch (storeLightSelection)
              {
                case TypeLightSelection.LightSelection_LowBeams:
                    handler.string_value("LowBeams");
                    break;
                case TypeLightSelection.LightSelection_HighBeams:
                    handler.string_value("HighBeams");
                    break;
                case TypeLightSelection.LightSelection_FogLights:
                    handler.string_value("FogLights");
                    break;
                case TypeLightSelection.LightSelection_LeftTurnSignal:
                    handler.string_value("LeftTurnSignal");
                    break;
                case TypeLightSelection.LightSelection_RightTurnSignal:
                    handler.string_value("RightTurnSignal");
                    break;
                case TypeLightSelection.LightSelection_BothTurnSignals:
                    handler.string_value("BothTurnSignals");
                    break;
                case TypeLightSelection.LightSelection_HazardLights:
                    handler.string_value("HazardLights");
                    break;
                default:
                    Debug.Assert(false);
                    break;
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
        if (!(hasCommandType()))
          {
            return "When parsing the object for %what%, the \"CommandType\" field was missing.";
          }
        if (!(hasLightSelection()))
          {
            return "When parsing the object for %what%, the \"LightSelection\" field was missing.";
          }
        return null;
      }

    public static new CarControlLightsCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CarControlLightsCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CarControlLightsCommand", ignore_extras);
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
    public static new CarControlLightsCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new CarControlLightsCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CarControlLightsCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CarControlLightsCommand", ignore_extras);
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
    public static new CarControlLightsCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new CarControlLightsCommandJSON from_text(string text, bool ignore_extras)
      {
        CarControlLightsCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CarControlLightsCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for CarControlLightsCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new CarControlLightsCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        CarControlLightsCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CarControlLightsCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : CarControlCommandJSON.Generator
      {
    private abstract class FieldGeneratorCommandType : JSONStringGenerator
          {
            protected FieldGeneratorCommandType(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorCommandType()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToCommandType(result));
              }
            protected abstract void handle_result(TypeCommandType result);
          };
    private class FieldHoldingGeneratorCommandType : FieldGeneratorCommandType
  {
    protected override void handle_result(TypeCommandType result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorCommandType(String what)
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
    public TypeCommandType value;
  };
    private class FieldHoldingArrayGeneratorCommandType : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorCommandType
      {
        private FieldHoldingArrayGeneratorCommandType top;

        protected override void handle_result(TypeCommandType result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorCommandType init_top)
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
    protected virtual void handle_result(List<TypeCommandType> result)
      {
      }

    public FieldHoldingArrayGeneratorCommandType(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeCommandType>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorCommandType()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeCommandType>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeCommandType> value;
  };
        private FieldHoldingGeneratorCommandType fieldGeneratorCommandType;
    private abstract class FieldGeneratorLightSelection : JSONStringGenerator
          {
            protected FieldGeneratorLightSelection(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorLightSelection()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToLightSelection(result));
              }
            protected abstract void handle_result(TypeLightSelection result);
          };
    private class FieldHoldingGeneratorLightSelection : FieldGeneratorLightSelection
  {
    protected override void handle_result(TypeLightSelection result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorLightSelection(String what)
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
    public TypeLightSelection value;
  };
    private class FieldHoldingArrayGeneratorLightSelection : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorLightSelection
      {
        private FieldHoldingArrayGeneratorLightSelection top;

        protected override void handle_result(TypeLightSelection result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorLightSelection init_top)
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
    protected virtual void handle_result(List<TypeLightSelection> result)
      {
      }

    public FieldHoldingArrayGeneratorLightSelection(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeLightSelection>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorLightSelection()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeLightSelection>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeLightSelection> value;
  };
        private FieldHoldingGeneratorLightSelection fieldGeneratorLightSelection;
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
            if (!(getCarControlCommandJSONKey().Equals("CarControlLightCommand")))
                throw new Exception("The key field has a value other than `CarControlLightCommand'.");
            CarControlLightsCommandJSON result = new CarControlLightsCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraCarControlLightsCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(CarControlCommandJSON new_result)
          {
            handle_result((CarControlLightsCommandJSON )new_result);
          }
        protected void finish(CarControlLightsCommandJSON result)
          {
            if (fieldGeneratorCommandType.have_value)
              {
                result.setCommandType(fieldGeneratorCommandType.value);
                fieldGeneratorCommandType.have_value = false;
              }
            else if ((!(result.hasCommandType())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"CommandType\" field was missing.");
              }
            if (fieldGeneratorLightSelection.have_value)
              {
                result.setLightSelection(fieldGeneratorLightSelection.value);
                fieldGeneratorLightSelection.have_value = false;
              }
            else if ((!(result.hasLightSelection())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"LightSelection\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(CarControlLightsCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "ommandType", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorCommandType;
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "ightSelection", 0, 13, false) == 0) && (field_name.Length == 14))
                        return fieldGeneratorLightSelection;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorCommandType = new FieldHoldingGeneratorCommandType("field \"CommandType\" of the CarControlLightsCommand class");
            fieldGeneratorLightSelection = new FieldHoldingGeneratorLightSelection("field \"LightSelection\" of the CarControlLightsCommand class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the CarControlLightsCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorCommandType = new FieldHoldingGeneratorCommandType("field \"CommandType\" of the CarControlLightsCommand class");
            fieldGeneratorLightSelection = new FieldHoldingGeneratorLightSelection("field \"LightSelection\" of the CarControlLightsCommand class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the CarControlLightsCommand class");
          }

        public override void reset()
          {
            fieldGeneratorCommandType.reset();
            fieldGeneratorLightSelection.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(CarControlLightsCommandJSON  result)
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
        public CarControlLightsCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(CarControlLightsCommandJSON  result)
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
    protected virtual void handle_result(List<CarControlLightsCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<CarControlLightsCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<CarControlLightsCommandJSON>();
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
    public List<CarControlLightsCommandJSON> value;
  };
  };
