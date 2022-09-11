/* file "CarControlSeatHeaterCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class CarControlSeatHeaterCommandJSON : CarControlCommandJSON
  {
    public enum TypeCommandType
      {
        CommandType_TurnOff,
        CommandType_TurnOn,
        CommandType_SetLow,
        CommandType_SetMedium,
        CommandType_SetHigh,
        CommandType_SetLower,
        CommandType_SetHigher
      };

    public static TypeCommandType  stringToCommandType(string chars)
      {
        switch (chars[0])
          {
            case 'S':
                if (String.Compare(chars, 1, "et", 0, 2, false) == 0)
                  {
                    switch (chars[3])
                      {
                        case 'H':
                            if (String.Compare(chars, 4, "igh", 0, 3, false) == 0)
                              {
                                if (chars.Length == 7)
                                  {
                                    return TypeCommandType.CommandType_SetHigh;
                                  }
                                switch (chars[7])
                                  {
                                    case 'e':
                                        if ((String.Compare(chars, 8, "r", 0, 1, false) == 0) && (chars.Length == 9))
                                            return TypeCommandType.CommandType_SetHigher;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'L':
                            if (String.Compare(chars, 4, "ow", 0, 2, false) == 0)
                              {
                                if (chars.Length == 6)
                                  {
                                    return TypeCommandType.CommandType_SetLow;
                                  }
                                switch (chars[6])
                                  {
                                    case 'e':
                                        if ((String.Compare(chars, 7, "r", 0, 1, false) == 0) && (chars.Length == 8))
                                            return TypeCommandType.CommandType_SetLower;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'M':
                            if ((String.Compare(chars, 4, "edium", 0, 5, false) == 0) && (chars.Length == 9))
                                return TypeCommandType.CommandType_SetMedium;
                            break;
                        default:
                            break;
                      }
                  }
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
            case TypeCommandType.CommandType_TurnOff:
                return "TurnOff";
            case TypeCommandType.CommandType_TurnOn:
                return "TurnOn";
            case TypeCommandType.CommandType_SetLow:
                return "SetLow";
            case TypeCommandType.CommandType_SetMedium:
                return "SetMedium";
            case TypeCommandType.CommandType_SetHigh:
                return "SetHigh";
            case TypeCommandType.CommandType_SetLower:
                return "SetLower";
            case TypeCommandType.CommandType_SetHigher:
                return "SetHigher";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasCommandType;
    private TypeCommandType storeCommandType;
    private bool flagHasSeatSelection;
    private CarSeatSelectionJSON  storeSeatSelection;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraCommandTypeToJSON()
      {
        JSONStringValue generated_string_CommandType;
        switch (storeCommandType)
          {
            case TypeCommandType.CommandType_TurnOff:
                generated_string_CommandType = new JSONStringValue("TurnOff");
                break;
            case TypeCommandType.CommandType_TurnOn:
                generated_string_CommandType = new JSONStringValue("TurnOn");
                break;
            case TypeCommandType.CommandType_SetLow:
                generated_string_CommandType = new JSONStringValue("SetLow");
                break;
            case TypeCommandType.CommandType_SetMedium:
                generated_string_CommandType = new JSONStringValue("SetMedium");
                break;
            case TypeCommandType.CommandType_SetHigh:
                generated_string_CommandType = new JSONStringValue("SetHigh");
                break;
            case TypeCommandType.CommandType_SetLower:
                generated_string_CommandType = new JSONStringValue("SetLower");
                break;
            case TypeCommandType.CommandType_SetHigher:
                generated_string_CommandType = new JSONStringValue("SetHigher");
                break;
            default:
                Debug.Assert(false);
                generated_string_CommandType = null;
                break;
          }
        return generated_string_CommandType;
      }

    private JSONValue  extraSeatSelectionToJSON()
      {
        JSONValueHandler handler_SeatSelection = new JSONValueHandler();
        storeSeatSelection.write_as_json(handler_SeatSelection);
        return handler_SeatSelection.result;
      }


    private void  fromJSONCommandType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CommandType of CarControlSeatHeaterCommandJSON is not a string.");
        TypeCommandType the_enum;
        switch (json_string.getData()[0])
          {
            case 'S':
                if (String.Compare(json_string.getData(), 1, "et", 0, 2, false) == 0)
                  {
                    switch (json_string.getData()[3])
                      {
                        case 'H':
                            if (String.Compare(json_string.getData(), 4, "igh", 0, 3, false) == 0)
                              {
                                if (json_string.getData().Length == 7)
                                  {
                                      {
                                        the_enum = TypeCommandType.CommandType_SetHigh;
                                        goto enum_is_done;
                                      }
                                  }
                                switch (json_string.getData()[7])
                                  {
                                    case 'e':
                                        if ((String.Compare(json_string.getData(), 8, "r", 0, 1, false) == 0) && (json_string.getData().Length == 9))
                                              {
                                                the_enum = TypeCommandType.CommandType_SetHigher;
                                                goto enum_is_done;
                                              }
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'L':
                            if (String.Compare(json_string.getData(), 4, "ow", 0, 2, false) == 0)
                              {
                                if (json_string.getData().Length == 6)
                                  {
                                      {
                                        the_enum = TypeCommandType.CommandType_SetLow;
                                        goto enum_is_done;
                                      }
                                  }
                                switch (json_string.getData()[6])
                                  {
                                    case 'e':
                                        if ((String.Compare(json_string.getData(), 7, "r", 0, 1, false) == 0) && (json_string.getData().Length == 8))
                                              {
                                                the_enum = TypeCommandType.CommandType_SetLower;
                                                goto enum_is_done;
                                              }
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'M':
                            if ((String.Compare(json_string.getData(), 4, "edium", 0, 5, false) == 0) && (json_string.getData().Length == 9))
                                  {
                                    the_enum = TypeCommandType.CommandType_SetMedium;
                                    goto enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
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
        throw new Exception("The value for field CommandType of CarControlSeatHeaterCommandJSON is not one of the legal strings.");
      enum_is_done:;
        setCommandType(the_enum);
      }


    private void  fromJSONSeatSelection(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        CarSeatSelectionJSON convert_classy = CarSeatSelectionJSON.from_json(json_value, ignore_extras, true);
        setSeatSelection(convert_classy);
      }


    public CarControlSeatHeaterCommandJSON()
      {
        flagHasCommandType = false;
        flagHasSeatSelection = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getCarControlCommandKind()
      {
        return "CarControlSeatHeaterCommand";
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

    public bool  hasSeatSelection()
      {
        return flagHasSeatSelection;
      }

    public CarSeatSelectionJSON   getSeatSelection()
      {
        Debug.Assert(flagHasSeatSelection);
        return storeSeatSelection;
      }


    public virtual int extraCarControlSeatHeaterCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraCarControlSeatHeaterCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraCarControlSeatHeaterCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraCarControlSeatHeaterCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraCarControlCommandComponentCount()
      {
        int result = 0;
        if (flagHasCommandType)
            ++result;
        if (flagHasSeatSelection)
            ++result;
        result += extraCarControlSeatHeaterCommandComponentCount();
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
        if (flagHasSeatSelection)
          {
            if (remainder == 0)
                return "SeatSelection";
            --remainder;
          }
        return extraCarControlSeatHeaterCommandComponentKey(remainder);
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
        if (flagHasSeatSelection)
          {
            if (remainder == 0)
                return extraSeatSelectionToJSON();
            --remainder;
          }
        return extraCarControlSeatHeaterCommandComponentValue(remainder);
      }
    public override JSONValue extraCarControlCommandLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'C':
                if ((String.Compare(field_name, 1, "ommandType", 0, 10, false) == 0) && (field_name.Length == 11))
                    return (flagHasCommandType ? extraCommandTypeToJSON() : null);
                break;
            case 'S':
                if ((String.Compare(field_name, 1, "eatSelection", 0, 12, false) == 0) && (field_name.Length == 13))
                    return (flagHasSeatSelection ? extraSeatSelectionToJSON() : null);
                break;
            default:
                break;
          }
        return extraCarControlSeatHeaterCommandLookup(field_name);
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
    public void setSeatSelection(CarSeatSelectionJSON  new_value)
      {
        if (flagHasSeatSelection)
          {
          }
        flagHasSeatSelection = true;
        storeSeatSelection = new_value;
      }
    public void unsetSeatSelection()
      {
        if (flagHasSeatSelection)
          {
          }
        flagHasSeatSelection = false;
      }

    public virtual void extraCarControlSeatHeaterCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraCarControlSeatHeaterCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraCarControlSeatHeaterCommandLookup(key);
        if (old_field == null)
          {
            extraCarControlSeatHeaterCommandAppendPair(key, new_component);
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
            case 'S':
                if ((String.Compare(key, 1, "eatSelection", 0, 12, false) == 0) && (key.Length == 13))
                    {
                    fromJSONSeatSelection(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraCarControlSeatHeaterCommandAppendPair(key, new_component);
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
            case 'S':
                if ((String.Compare(key, 1, "eatSelection", 0, 12, false) == 0) && (key.Length == 13))
                    {
                    fromJSONSeatSelection(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraCarControlSeatHeaterCommandSetField(key, new_component);
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
                case TypeCommandType.CommandType_TurnOff:
                    handler.string_value("TurnOff");
                    break;
                case TypeCommandType.CommandType_TurnOn:
                    handler.string_value("TurnOn");
                    break;
                case TypeCommandType.CommandType_SetLow:
                    handler.string_value("SetLow");
                    break;
                case TypeCommandType.CommandType_SetMedium:
                    handler.string_value("SetMedium");
                    break;
                case TypeCommandType.CommandType_SetHigh:
                    handler.string_value("SetHigh");
                    break;
                case TypeCommandType.CommandType_SetLower:
                    handler.string_value("SetLower");
                    break;
                case TypeCommandType.CommandType_SetHigher:
                    handler.string_value("SetHigher");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        Debug.Assert(partial_allowed || flagHasSeatSelection);
        if (flagHasSeatSelection)
          {
            handler.start_pair("SeatSelection");
            if (partial_allowed)
                storeSeatSelection.write_partial_as_json(handler);
            else
                storeSeatSelection.write_as_json(handler);
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
        if (!(hasSeatSelection()))
          {
            return "When parsing the object for %what%, the \"SeatSelection\" field was missing.";
          }
        return null;
      }

    public static new CarControlSeatHeaterCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CarControlSeatHeaterCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CarControlSeatHeaterCommand", ignore_extras);
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
    public static new CarControlSeatHeaterCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new CarControlSeatHeaterCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CarControlSeatHeaterCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CarControlSeatHeaterCommand", ignore_extras);
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
    public static new CarControlSeatHeaterCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new CarControlSeatHeaterCommandJSON from_text(string text, bool ignore_extras)
      {
        CarControlSeatHeaterCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CarControlSeatHeaterCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for CarControlSeatHeaterCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new CarControlSeatHeaterCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        CarControlSeatHeaterCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CarControlSeatHeaterCommand", ignore_extras);
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
        private CarSeatSelectionJSON.HoldingGenerator fieldGeneratorSeatSelection;
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
            if (!(getCarControlCommandJSONKey().Equals("CarControlSeatHeaterCommand")))
                throw new Exception("The key field has a value other than `CarControlSeatHeaterCommand'.");
            CarControlSeatHeaterCommandJSON result = new CarControlSeatHeaterCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraCarControlSeatHeaterCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(CarControlCommandJSON new_result)
          {
            handle_result((CarControlSeatHeaterCommandJSON )new_result);
          }
        protected void finish(CarControlSeatHeaterCommandJSON result)
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
            if (fieldGeneratorSeatSelection.have_value)
              {
                result.setSeatSelection(fieldGeneratorSeatSelection.value);
                fieldGeneratorSeatSelection.have_value = false;
              }
            else if ((!(result.hasSeatSelection())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"SeatSelection\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(CarControlSeatHeaterCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "ommandType", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorCommandType;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "eatSelection", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorSeatSelection;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorCommandType = new FieldHoldingGeneratorCommandType("field \"CommandType\" of the CarControlSeatHeaterCommand class");
            fieldGeneratorSeatSelection = new CarSeatSelectionJSON.HoldingGenerator("field \"SeatSelection\" of the CarControlSeatHeaterCommand class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the CarControlSeatHeaterCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorCommandType = new FieldHoldingGeneratorCommandType("field \"CommandType\" of the CarControlSeatHeaterCommand class");
            fieldGeneratorSeatSelection = new CarSeatSelectionJSON.HoldingGenerator("field \"SeatSelection\" of the CarControlSeatHeaterCommand class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the CarControlSeatHeaterCommand class");
          }

        public override void reset()
          {
            fieldGeneratorCommandType.reset();
            fieldGeneratorSeatSelection.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(CarControlSeatHeaterCommandJSON  result)
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
        public CarControlSeatHeaterCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(CarControlSeatHeaterCommandJSON  result)
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
    protected virtual void handle_result(List<CarControlSeatHeaterCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<CarControlSeatHeaterCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<CarControlSeatHeaterCommandJSON>();
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
    public List<CarControlSeatHeaterCommandJSON> value;
  };
  };
