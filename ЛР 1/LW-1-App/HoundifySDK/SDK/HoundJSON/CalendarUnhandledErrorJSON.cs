/* file "CalendarUnhandledErrorJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class CalendarUnhandledErrorJSON : ThirdPartyCalendarErrorJSON
  {
    public enum TypeUnhandledErrorTypeKnownValues
      {
        UnhandledErrorType_Other,
        UnhandledErrorType_UnexpectedJSON,
        UnhandledErrorType_APIParsingError,
        UnhandledErrorType_MissingData,
        UnhandledErrorType_UnexpectedStatus,
        UnhandledErrorType__none
      };
    public struct TypeUnhandledErrorType
      {
        public bool in_known_list;
        public string string_value;
        public TypeUnhandledErrorTypeKnownValues list_value;
      };

    public static TypeUnhandledErrorTypeKnownValues  stringToUnhandledErrorType(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                if ((String.Compare(chars, 1, "PIParsingError", 0, 14, false) == 0) && (chars.Length == 15))
                    return TypeUnhandledErrorTypeKnownValues.UnhandledErrorType_APIParsingError;
                break;
            case 'M':
                if ((String.Compare(chars, 1, "issingData", 0, 10, false) == 0) && (chars.Length == 11))
                    return TypeUnhandledErrorTypeKnownValues.UnhandledErrorType_MissingData;
                break;
            case 'O':
                if ((String.Compare(chars, 1, "ther", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeUnhandledErrorTypeKnownValues.UnhandledErrorType_Other;
                break;
            case 'U':
                if (String.Compare(chars, 1, "nexpected", 0, 9, false) == 0)
                  {
                    switch (chars[10])
                      {
                        case 'J':
                            if ((String.Compare(chars, 11, "SON", 0, 3, false) == 0) && (chars.Length == 14))
                                return TypeUnhandledErrorTypeKnownValues.UnhandledErrorType_UnexpectedJSON;
                            break;
                        case 'S':
                            if ((String.Compare(chars, 11, "tatus", 0, 5, false) == 0) && (chars.Length == 16))
                                return TypeUnhandledErrorTypeKnownValues.UnhandledErrorType_UnexpectedStatus;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        return TypeUnhandledErrorTypeKnownValues.UnhandledErrorType__none;
      }

    public static string  stringFromUnhandledErrorType(TypeUnhandledErrorTypeKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeUnhandledErrorTypeKnownValues.UnhandledErrorType_Other:
                return "Other";
            case TypeUnhandledErrorTypeKnownValues.UnhandledErrorType_UnexpectedJSON:
                return "UnexpectedJSON";
            case TypeUnhandledErrorTypeKnownValues.UnhandledErrorType_APIParsingError:
                return "APIParsingError";
            case TypeUnhandledErrorTypeKnownValues.UnhandledErrorType_MissingData:
                return "MissingData";
            case TypeUnhandledErrorTypeKnownValues.UnhandledErrorType_UnexpectedStatus:
                return "UnexpectedStatus";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasUnhandledErrorType;
    private TypeUnhandledErrorType storeUnhandledErrorType;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraUnhandledErrorTypeToJSON()
      {
        JSONStringValue generated_string_UnhandledErrorType;
        if (!(storeUnhandledErrorType.in_known_list))
          {
        generated_string_UnhandledErrorType = new JSONStringValue(storeUnhandledErrorType.string_value);
          }
        else
          {
        switch (storeUnhandledErrorType.list_value)
          {
            case TypeUnhandledErrorTypeKnownValues.UnhandledErrorType_Other:
                generated_string_UnhandledErrorType = new JSONStringValue("Other");
                break;
            case TypeUnhandledErrorTypeKnownValues.UnhandledErrorType_UnexpectedJSON:
                generated_string_UnhandledErrorType = new JSONStringValue("UnexpectedJSON");
                break;
            case TypeUnhandledErrorTypeKnownValues.UnhandledErrorType_APIParsingError:
                generated_string_UnhandledErrorType = new JSONStringValue("APIParsingError");
                break;
            case TypeUnhandledErrorTypeKnownValues.UnhandledErrorType_MissingData:
                generated_string_UnhandledErrorType = new JSONStringValue("MissingData");
                break;
            case TypeUnhandledErrorTypeKnownValues.UnhandledErrorType_UnexpectedStatus:
                generated_string_UnhandledErrorType = new JSONStringValue("UnexpectedStatus");
                break;
            default:
                Debug.Assert(false);
                generated_string_UnhandledErrorType = null;
                break;
          }
          }
        return generated_string_UnhandledErrorType;
      }


    private void  fromJSONUnhandledErrorType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field UnhandledErrorType of CalendarUnhandledErrorJSON is not a string.");
        TypeUnhandledErrorType the_open_enum = new TypeUnhandledErrorType();
        switch (json_string.getData()[0])
          {
            case 'A':
                if ((String.Compare(json_string.getData(), 1, "PIParsingError", 0, 14, false) == 0) && (json_string.getData().Length == 15))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeUnhandledErrorTypeKnownValues.UnhandledErrorType_APIParsingError;
                        goto open_enum_is_done;
                      }
                break;
            case 'M':
                if ((String.Compare(json_string.getData(), 1, "issingData", 0, 10, false) == 0) && (json_string.getData().Length == 11))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeUnhandledErrorTypeKnownValues.UnhandledErrorType_MissingData;
                        goto open_enum_is_done;
                      }
                break;
            case 'O':
                if ((String.Compare(json_string.getData(), 1, "ther", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeUnhandledErrorTypeKnownValues.UnhandledErrorType_Other;
                        goto open_enum_is_done;
                      }
                break;
            case 'U':
                if (String.Compare(json_string.getData(), 1, "nexpected", 0, 9, false) == 0)
                  {
                    switch (json_string.getData()[10])
                      {
                        case 'J':
                            if ((String.Compare(json_string.getData(), 11, "SON", 0, 3, false) == 0) && (json_string.getData().Length == 14))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeUnhandledErrorTypeKnownValues.UnhandledErrorType_UnexpectedJSON;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'S':
                            if ((String.Compare(json_string.getData(), 11, "tatus", 0, 5, false) == 0) && (json_string.getData().Length == 16))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeUnhandledErrorTypeKnownValues.UnhandledErrorType_UnexpectedStatus;
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
        setUnhandledErrorType(the_open_enum);
      }


    public CalendarUnhandledErrorJSON()
      {
        flagHasUnhandledErrorType = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getThirdPartyCalendarErrorKind()
      {
        return "CalendarUnhandledError";
      }

    public bool  hasUnhandledErrorType()
      {
        return flagHasUnhandledErrorType;
      }

    public TypeUnhandledErrorType  getUnhandledErrorType()
      {
        Debug.Assert(flagHasUnhandledErrorType);
        return storeUnhandledErrorType;
      }

    public string  getUnhandledErrorTypeAsString()
      {
        TypeUnhandledErrorType result = getUnhandledErrorType();
        if (result.in_known_list)
            return stringFromUnhandledErrorType(result.list_value);
        else
            return result.string_value;
      }


    public virtual int extraCalendarUnhandledErrorComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraCalendarUnhandledErrorComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraCalendarUnhandledErrorComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraCalendarUnhandledErrorLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraThirdPartyCalendarErrorComponentCount()
      {
        int result = 0;
        if (flagHasUnhandledErrorType)
            ++result;
        result += extraCalendarUnhandledErrorComponentCount();
        return result;
      }
    public override string extraThirdPartyCalendarErrorComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasUnhandledErrorType)
          {
            if (remainder == 0)
                return "UnhandledErrorType";
            --remainder;
          }
        return extraCalendarUnhandledErrorComponentKey(remainder);
      }
    public override JSONValue extraThirdPartyCalendarErrorComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasUnhandledErrorType)
          {
            if (remainder == 0)
                return extraUnhandledErrorTypeToJSON();
            --remainder;
          }
        return extraCalendarUnhandledErrorComponentValue(remainder);
      }
    public override JSONValue extraThirdPartyCalendarErrorLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "UnhandledErrorType", 0, 18, false) == 0) && (field_name.Length == 18))
            return (flagHasUnhandledErrorType ? extraUnhandledErrorTypeToJSON() : null);
        return extraCalendarUnhandledErrorLookup(field_name);
      }

    public void setUnhandledErrorType(TypeUnhandledErrorType new_value)
      {
        flagHasUnhandledErrorType = true;
        storeUnhandledErrorType = new_value;
      }
    public void setUnhandledErrorType(string chars)
      {
        TypeUnhandledErrorTypeKnownValues known = stringToUnhandledErrorType(chars);
        TypeUnhandledErrorType new_value = new TypeUnhandledErrorType();
        if (known == TypeUnhandledErrorTypeKnownValues.UnhandledErrorType__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setUnhandledErrorType(new_value);
      }
    public void setUnhandledErrorType(TypeUnhandledErrorTypeKnownValues new_value)
      {
        TypeUnhandledErrorType new_full_value = new TypeUnhandledErrorType();
        Debug.Assert(new_value != TypeUnhandledErrorTypeKnownValues.UnhandledErrorType__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setUnhandledErrorType(new_full_value);
      }
    public void unsetUnhandledErrorType()
      {
        flagHasUnhandledErrorType = false;
      }

    public virtual void extraCalendarUnhandledErrorAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraCalendarUnhandledErrorSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraCalendarUnhandledErrorLookup(key);
        if (old_field == null)
          {
            extraCalendarUnhandledErrorAppendPair(key, new_component);
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
    public override void extraThirdPartyCalendarErrorAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "UnhandledErrorType", 0, 18, false) == 0) && (key.Length == 18))
            {
            fromJSONUnhandledErrorType(new_component, false);
            return;
            }
        extraCalendarUnhandledErrorAppendPair(key, new_component);
      }
    public override void extraThirdPartyCalendarErrorSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "UnhandledErrorType", 0, 18, false) == 0) && (key.Length == 18))
            {
            fromJSONUnhandledErrorType(new_component, false);
            return;
            }
        extraCalendarUnhandledErrorSetField(key, new_component);
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
        if (flagHasUnhandledErrorType)
          {
            handler.start_pair("UnhandledErrorType");
            if (storeUnhandledErrorType.in_known_list)
              {
                switch (storeUnhandledErrorType.list_value)
                  {
                    case TypeUnhandledErrorTypeKnownValues.UnhandledErrorType_Other:
                        handler.string_value("Other");
                        break;
                    case TypeUnhandledErrorTypeKnownValues.UnhandledErrorType_UnexpectedJSON:
                        handler.string_value("UnexpectedJSON");
                        break;
                    case TypeUnhandledErrorTypeKnownValues.UnhandledErrorType_APIParsingError:
                        handler.string_value("APIParsingError");
                        break;
                    case TypeUnhandledErrorTypeKnownValues.UnhandledErrorType_MissingData:
                        handler.string_value("MissingData");
                        break;
                    case TypeUnhandledErrorTypeKnownValues.UnhandledErrorType_UnexpectedStatus:
                        handler.string_value("UnexpectedStatus");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeUnhandledErrorType.string_value);
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
        return null;
      }

    public static new CalendarUnhandledErrorJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CalendarUnhandledErrorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CalendarUnhandledError", ignore_extras);
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
    public static new CalendarUnhandledErrorJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new CalendarUnhandledErrorJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CalendarUnhandledErrorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CalendarUnhandledError", ignore_extras);
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
    public static new CalendarUnhandledErrorJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new CalendarUnhandledErrorJSON from_text(string text, bool ignore_extras)
      {
        CalendarUnhandledErrorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CalendarUnhandledError", ignore_extras);
            JSONParse.parse_json_value(text, "Text for CalendarUnhandledErrorJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new CalendarUnhandledErrorJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        CalendarUnhandledErrorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CalendarUnhandledError", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : ThirdPartyCalendarErrorJSON.Generator
      {
    private abstract class FieldGeneratorUnhandledErrorType : JSONStringGenerator
          {
            protected FieldGeneratorUnhandledErrorType(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorUnhandledErrorType()
              {
              }
            protected override void handle_result(string result)
              {
                TypeUnhandledErrorTypeKnownValues known = stringToUnhandledErrorType(result);
                TypeUnhandledErrorType new_value = new TypeUnhandledErrorType();
                if (known == TypeUnhandledErrorTypeKnownValues.UnhandledErrorType__none)
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
            protected abstract void handle_result(TypeUnhandledErrorType result);
          };
    private class FieldHoldingGeneratorUnhandledErrorType : FieldGeneratorUnhandledErrorType
  {
    protected override void handle_result(TypeUnhandledErrorType result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorUnhandledErrorType(String what)
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
    public TypeUnhandledErrorType value;
  };
    private class FieldHoldingArrayGeneratorUnhandledErrorType : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorUnhandledErrorType
      {
        private FieldHoldingArrayGeneratorUnhandledErrorType top;

        protected override void handle_result(TypeUnhandledErrorType result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorUnhandledErrorType init_top)
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
    protected virtual void handle_result(List<TypeUnhandledErrorType> result)
      {
      }

    public FieldHoldingArrayGeneratorUnhandledErrorType(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeUnhandledErrorType>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorUnhandledErrorType()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeUnhandledErrorType>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeUnhandledErrorType> value;
  };
        private FieldHoldingGeneratorUnhandledErrorType fieldGeneratorUnhandledErrorType;
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
            if (!(getThirdPartyCalendarErrorJSONKey().Equals("CalendarUnhandledError")))
                throw new Exception("The key field has a value other than `CalendarUnhandledError'.");
            CalendarUnhandledErrorJSON result = new CalendarUnhandledErrorJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraCalendarUnhandledErrorAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(ThirdPartyCalendarErrorJSON new_result)
          {
            handle_result((CalendarUnhandledErrorJSON )new_result);
          }
        protected void finish(CalendarUnhandledErrorJSON result)
          {
            if (fieldGeneratorUnhandledErrorType.have_value)
              {
                result.setUnhandledErrorType(fieldGeneratorUnhandledErrorType.value);
                fieldGeneratorUnhandledErrorType.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(CalendarUnhandledErrorJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "UnhandledErrorType", 0, 18, false) == 0) && (field_name.Length == 18))
                return fieldGeneratorUnhandledErrorType;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorUnhandledErrorType = new FieldHoldingGeneratorUnhandledErrorType("field \"UnhandledErrorType\" of the CalendarUnhandledError class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the CalendarUnhandledError class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorUnhandledErrorType = new FieldHoldingGeneratorUnhandledErrorType("field \"UnhandledErrorType\" of the CalendarUnhandledError class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the CalendarUnhandledError class");
          }

        public override void reset()
          {
            fieldGeneratorUnhandledErrorType.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(CalendarUnhandledErrorJSON  result)
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
        public CalendarUnhandledErrorJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(CalendarUnhandledErrorJSON  result)
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
    protected virtual void handle_result(List<CalendarUnhandledErrorJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<CalendarUnhandledErrorJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<CalendarUnhandledErrorJSON>();
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
    public List<CalendarUnhandledErrorJSON> value;
  };
  };
