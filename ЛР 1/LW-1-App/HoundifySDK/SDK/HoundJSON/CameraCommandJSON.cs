/* file "CameraCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class CameraCommandJSON : DeviceControlCommandJSON
  {
    public enum TypeCommandType
      {
        CommandType_TakeAPicture,
        CommandType_TurnOn,
        CommandType_TurnOff
      };

    public static TypeCommandType  stringToCommandType(string chars)
      {
        if (String.Compare(chars, 0, "T", 0, 1, false) == 0)
          {
            switch (chars[1])
              {
                case 'a':
                    if ((String.Compare(chars, 2, "keAPicture", 0, 10, false) == 0) && (chars.Length == 12))
                        return TypeCommandType.CommandType_TakeAPicture;
                    break;
                case 'u':
                    if (String.Compare(chars, 2, "rnO", 0, 3, false) == 0)
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
          }
        throw new Exception("The value for field `CommandType' is not one of the legal values.");
      }

    public static string  stringFromCommandType(TypeCommandType the_enum)
      {
        switch (the_enum)
          {
            case TypeCommandType.CommandType_TakeAPicture:
                return "TakeAPicture";
            case TypeCommandType.CommandType_TurnOn:
                return "TurnOn";
            case TypeCommandType.CommandType_TurnOff:
                return "TurnOff";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasCommandType;
    private TypeCommandType storeCommandType;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraCommandTypeToJSON()
      {
        JSONStringValue generated_string_CommandType;
        switch (storeCommandType)
          {
            case TypeCommandType.CommandType_TakeAPicture:
                generated_string_CommandType = new JSONStringValue("TakeAPicture");
                break;
            case TypeCommandType.CommandType_TurnOn:
                generated_string_CommandType = new JSONStringValue("TurnOn");
                break;
            case TypeCommandType.CommandType_TurnOff:
                generated_string_CommandType = new JSONStringValue("TurnOff");
                break;
            default:
                Debug.Assert(false);
                generated_string_CommandType = null;
                break;
          }
        return generated_string_CommandType;
      }


    private void  fromJSONCommandType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CommandType of CameraCommandJSON is not a string.");
        TypeCommandType the_enum;
        if (String.Compare(json_string.getData(), 0, "T", 0, 1, false) == 0)
          {
            switch (json_string.getData()[1])
              {
                case 'a':
                    if ((String.Compare(json_string.getData(), 2, "keAPicture", 0, 10, false) == 0) && (json_string.getData().Length == 12))
                          {
                            the_enum = TypeCommandType.CommandType_TakeAPicture;
                            goto enum_is_done;
                          }
                    break;
                case 'u':
                    if (String.Compare(json_string.getData(), 2, "rnO", 0, 3, false) == 0)
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
          }
        throw new Exception("The value for field CommandType of CameraCommandJSON is not one of the legal strings.");
      enum_is_done:;
        setCommandType(the_enum);
      }


    public CameraCommandJSON()
      {
        flagHasCommandType = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getDeviceControlCommandKind()
      {
        return "CameraCommand";
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


    public virtual int extraCameraCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraCameraCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraCameraCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraCameraCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraDeviceControlCommandComponentCount()
      {
        int result = 0;
        if (flagHasCommandType)
            ++result;
        result += extraCameraCommandComponentCount();
        return result;
      }
    public override string extraDeviceControlCommandComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasCommandType)
          {
            if (remainder == 0)
                return "CommandType";
            --remainder;
          }
        return extraCameraCommandComponentKey(remainder);
      }
    public override JSONValue extraDeviceControlCommandComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasCommandType)
          {
            if (remainder == 0)
                return extraCommandTypeToJSON();
            --remainder;
          }
        return extraCameraCommandComponentValue(remainder);
      }
    public override JSONValue extraDeviceControlCommandLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "CommandType", 0, 11, false) == 0) && (field_name.Length == 11))
            return (flagHasCommandType ? extraCommandTypeToJSON() : null);
        return extraCameraCommandLookup(field_name);
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

    public virtual void extraCameraCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraCameraCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraCameraCommandLookup(key);
        if (old_field == null)
          {
            extraCameraCommandAppendPair(key, new_component);
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
    public override void extraDeviceControlCommandAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "CommandType", 0, 11, false) == 0) && (key.Length == 11))
            {
            fromJSONCommandType(new_component, false);
            return;
            }
        extraCameraCommandAppendPair(key, new_component);
      }
    public override void extraDeviceControlCommandSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "CommandType", 0, 11, false) == 0) && (key.Length == 11))
            {
            fromJSONCommandType(new_component, false);
            return;
            }
        extraCameraCommandSetField(key, new_component);
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
                case TypeCommandType.CommandType_TakeAPicture:
                    handler.string_value("TakeAPicture");
                    break;
                case TypeCommandType.CommandType_TurnOn:
                    handler.string_value("TurnOn");
                    break;
                case TypeCommandType.CommandType_TurnOff:
                    handler.string_value("TurnOff");
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
        return null;
      }

    public static new CameraCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CameraCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CameraCommand", ignore_extras);
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
    public static new CameraCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new CameraCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CameraCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CameraCommand", ignore_extras);
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
    public static new CameraCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new CameraCommandJSON from_text(string text, bool ignore_extras)
      {
        CameraCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CameraCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for CameraCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new CameraCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        CameraCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CameraCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : DeviceControlCommandJSON.Generator
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
            if (!(getDeviceControlCommandJSONKey().Equals("CameraCommand")))
                throw new Exception("The key field has a value other than `CameraCommand'.");
            CameraCommandJSON result = new CameraCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraCameraCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(DeviceControlCommandJSON new_result)
          {
            handle_result((CameraCommandJSON )new_result);
          }
        protected void finish(CameraCommandJSON result)
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
            base.finish(result);
          }
        protected abstract void handle_result(CameraCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "CommandType", 0, 11, false) == 0) && (field_name.Length == 11))
                return fieldGeneratorCommandType;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorCommandType = new FieldHoldingGeneratorCommandType("field \"CommandType\" of the CameraCommand class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the CameraCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorCommandType = new FieldHoldingGeneratorCommandType("field \"CommandType\" of the CameraCommand class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the CameraCommand class");
          }

        public override void reset()
          {
            fieldGeneratorCommandType.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(CameraCommandJSON  result)
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
        public CameraCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(CameraCommandJSON  result)
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
    protected virtual void handle_result(List<CameraCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<CameraCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<CameraCommandJSON>();
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
    public List<CameraCommandJSON> value;
  };
  };
