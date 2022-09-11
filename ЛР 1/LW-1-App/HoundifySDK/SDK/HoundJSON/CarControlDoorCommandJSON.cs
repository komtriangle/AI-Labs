/* file "CarControlDoorCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class CarControlDoorCommandJSON : CarControlCommandJSON
  {
    public enum TypeCommandType
      {
        CommandType_OpenDoor,
        CommandType_CloseDoor,
        CommandType_LockDoor,
        CommandType_UnlockDoor
      };

    public static TypeCommandType  stringToCommandType(string chars)
      {
        switch (chars[0])
          {
            case 'C':
                if ((String.Compare(chars, 1, "loseDoor", 0, 8, false) == 0) && (chars.Length == 9))
                    return TypeCommandType.CommandType_CloseDoor;
                break;
            case 'L':
                if ((String.Compare(chars, 1, "ockDoor", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeCommandType.CommandType_LockDoor;
                break;
            case 'O':
                if ((String.Compare(chars, 1, "penDoor", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeCommandType.CommandType_OpenDoor;
                break;
            case 'U':
                if ((String.Compare(chars, 1, "nlockDoor", 0, 9, false) == 0) && (chars.Length == 10))
                    return TypeCommandType.CommandType_UnlockDoor;
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
            case TypeCommandType.CommandType_OpenDoor:
                return "OpenDoor";
            case TypeCommandType.CommandType_CloseDoor:
                return "CloseDoor";
            case TypeCommandType.CommandType_LockDoor:
                return "LockDoor";
            case TypeCommandType.CommandType_UnlockDoor:
                return "UnlockDoor";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasCommandType;
    private TypeCommandType storeCommandType;
    private bool flagHasDoorSelection;
    private CarControlDoorSelectionJSON  storeDoorSelection;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraCommandTypeToJSON()
      {
        JSONStringValue generated_string_CommandType;
        switch (storeCommandType)
          {
            case TypeCommandType.CommandType_OpenDoor:
                generated_string_CommandType = new JSONStringValue("OpenDoor");
                break;
            case TypeCommandType.CommandType_CloseDoor:
                generated_string_CommandType = new JSONStringValue("CloseDoor");
                break;
            case TypeCommandType.CommandType_LockDoor:
                generated_string_CommandType = new JSONStringValue("LockDoor");
                break;
            case TypeCommandType.CommandType_UnlockDoor:
                generated_string_CommandType = new JSONStringValue("UnlockDoor");
                break;
            default:
                Debug.Assert(false);
                generated_string_CommandType = null;
                break;
          }
        return generated_string_CommandType;
      }

    private JSONValue  extraDoorSelectionToJSON()
      {
        JSONValueHandler handler_DoorSelection = new JSONValueHandler();
        storeDoorSelection.write_as_json(handler_DoorSelection);
        return handler_DoorSelection.result;
      }


    private void  fromJSONCommandType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CommandType of CarControlDoorCommandJSON is not a string.");
        TypeCommandType the_enum;
        switch (json_string.getData()[0])
          {
            case 'C':
                if ((String.Compare(json_string.getData(), 1, "loseDoor", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                      {
                        the_enum = TypeCommandType.CommandType_CloseDoor;
                        goto enum_is_done;
                      }
                break;
            case 'L':
                if ((String.Compare(json_string.getData(), 1, "ockDoor", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_enum = TypeCommandType.CommandType_LockDoor;
                        goto enum_is_done;
                      }
                break;
            case 'O':
                if ((String.Compare(json_string.getData(), 1, "penDoor", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_enum = TypeCommandType.CommandType_OpenDoor;
                        goto enum_is_done;
                      }
                break;
            case 'U':
                if ((String.Compare(json_string.getData(), 1, "nlockDoor", 0, 9, false) == 0) && (json_string.getData().Length == 10))
                      {
                        the_enum = TypeCommandType.CommandType_UnlockDoor;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field CommandType of CarControlDoorCommandJSON is not one of the legal strings.");
      enum_is_done:;
        setCommandType(the_enum);
      }


    private void  fromJSONDoorSelection(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        CarControlDoorSelectionJSON convert_classy = CarControlDoorSelectionJSON.from_json(json_value, ignore_extras, true);
        setDoorSelection(convert_classy);
      }


    public CarControlDoorCommandJSON()
      {
        flagHasCommandType = false;
        flagHasDoorSelection = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getCarControlCommandKind()
      {
        return "CarControlDoorCommand";
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

    public bool  hasDoorSelection()
      {
        return flagHasDoorSelection;
      }

    public CarControlDoorSelectionJSON   getDoorSelection()
      {
        Debug.Assert(flagHasDoorSelection);
        return storeDoorSelection;
      }


    public virtual int extraCarControlDoorCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraCarControlDoorCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraCarControlDoorCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraCarControlDoorCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraCarControlCommandComponentCount()
      {
        int result = 0;
        if (flagHasCommandType)
            ++result;
        if (flagHasDoorSelection)
            ++result;
        result += extraCarControlDoorCommandComponentCount();
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
        if (flagHasDoorSelection)
          {
            if (remainder == 0)
                return "DoorSelection";
            --remainder;
          }
        return extraCarControlDoorCommandComponentKey(remainder);
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
        if (flagHasDoorSelection)
          {
            if (remainder == 0)
                return extraDoorSelectionToJSON();
            --remainder;
          }
        return extraCarControlDoorCommandComponentValue(remainder);
      }
    public override JSONValue extraCarControlCommandLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'C':
                if ((String.Compare(field_name, 1, "ommandType", 0, 10, false) == 0) && (field_name.Length == 11))
                    return (flagHasCommandType ? extraCommandTypeToJSON() : null);
                break;
            case 'D':
                if ((String.Compare(field_name, 1, "oorSelection", 0, 12, false) == 0) && (field_name.Length == 13))
                    return (flagHasDoorSelection ? extraDoorSelectionToJSON() : null);
                break;
            default:
                break;
          }
        return extraCarControlDoorCommandLookup(field_name);
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
    public void setDoorSelection(CarControlDoorSelectionJSON  new_value)
      {
        if (flagHasDoorSelection)
          {
          }
        flagHasDoorSelection = true;
        storeDoorSelection = new_value;
      }
    public void unsetDoorSelection()
      {
        if (flagHasDoorSelection)
          {
          }
        flagHasDoorSelection = false;
      }

    public virtual void extraCarControlDoorCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraCarControlDoorCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraCarControlDoorCommandLookup(key);
        if (old_field == null)
          {
            extraCarControlDoorCommandAppendPair(key, new_component);
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
            case 'D':
                if ((String.Compare(key, 1, "oorSelection", 0, 12, false) == 0) && (key.Length == 13))
                    {
                    fromJSONDoorSelection(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraCarControlDoorCommandAppendPair(key, new_component);
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
            case 'D':
                if ((String.Compare(key, 1, "oorSelection", 0, 12, false) == 0) && (key.Length == 13))
                    {
                    fromJSONDoorSelection(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraCarControlDoorCommandSetField(key, new_component);
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
                case TypeCommandType.CommandType_OpenDoor:
                    handler.string_value("OpenDoor");
                    break;
                case TypeCommandType.CommandType_CloseDoor:
                    handler.string_value("CloseDoor");
                    break;
                case TypeCommandType.CommandType_LockDoor:
                    handler.string_value("LockDoor");
                    break;
                case TypeCommandType.CommandType_UnlockDoor:
                    handler.string_value("UnlockDoor");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        Debug.Assert(partial_allowed || flagHasDoorSelection);
        if (flagHasDoorSelection)
          {
            handler.start_pair("DoorSelection");
            if (partial_allowed)
                storeDoorSelection.write_partial_as_json(handler);
            else
                storeDoorSelection.write_as_json(handler);
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
        if (!(hasDoorSelection()))
          {
            return "When parsing the object for %what%, the \"DoorSelection\" field was missing.";
          }
        return null;
      }

    public static new CarControlDoorCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CarControlDoorCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CarControlDoorCommand", ignore_extras);
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
    public static new CarControlDoorCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new CarControlDoorCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CarControlDoorCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CarControlDoorCommand", ignore_extras);
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
    public static new CarControlDoorCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new CarControlDoorCommandJSON from_text(string text, bool ignore_extras)
      {
        CarControlDoorCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CarControlDoorCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for CarControlDoorCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new CarControlDoorCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        CarControlDoorCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CarControlDoorCommand", ignore_extras);
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
        private CarControlDoorSelectionJSON.HoldingGenerator fieldGeneratorDoorSelection;
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
            if (!(getCarControlCommandJSONKey().Equals("CarControlDoorCommand")))
                throw new Exception("The key field has a value other than `CarControlDoorCommand'.");
            CarControlDoorCommandJSON result = new CarControlDoorCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraCarControlDoorCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(CarControlCommandJSON new_result)
          {
            handle_result((CarControlDoorCommandJSON )new_result);
          }
        protected void finish(CarControlDoorCommandJSON result)
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
            if (fieldGeneratorDoorSelection.have_value)
              {
                result.setDoorSelection(fieldGeneratorDoorSelection.value);
                fieldGeneratorDoorSelection.have_value = false;
              }
            else if ((!(result.hasDoorSelection())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"DoorSelection\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(CarControlDoorCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "ommandType", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorCommandType;
                    break;
                case 'D':
                    if ((String.Compare(field_name, 1, "oorSelection", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorDoorSelection;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorCommandType = new FieldHoldingGeneratorCommandType("field \"CommandType\" of the CarControlDoorCommand class");
            fieldGeneratorDoorSelection = new CarControlDoorSelectionJSON.HoldingGenerator("field \"DoorSelection\" of the CarControlDoorCommand class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the CarControlDoorCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorCommandType = new FieldHoldingGeneratorCommandType("field \"CommandType\" of the CarControlDoorCommand class");
            fieldGeneratorDoorSelection = new CarControlDoorSelectionJSON.HoldingGenerator("field \"DoorSelection\" of the CarControlDoorCommand class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the CarControlDoorCommand class");
          }

        public override void reset()
          {
            fieldGeneratorCommandType.reset();
            fieldGeneratorDoorSelection.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(CarControlDoorCommandJSON  result)
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
        public CarControlDoorCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(CarControlDoorCommandJSON  result)
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
    protected virtual void handle_result(List<CarControlDoorCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<CarControlDoorCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<CarControlDoorCommandJSON>();
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
    public List<CarControlDoorCommandJSON> value;
  };
  };
