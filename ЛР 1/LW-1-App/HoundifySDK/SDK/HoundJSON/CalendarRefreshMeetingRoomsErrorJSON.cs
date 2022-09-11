/* file "CalendarRefreshMeetingRoomsErrorJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class CalendarRefreshMeetingRoomsErrorJSON : ThirdPartyCalendarErrorJSON
  {
    public enum TypeMeetingRoomErrorTypeKnownValues
      {
        MeetingRoomErrorType_IndividualAccount,
        MeetingRoomErrorType__none
      };
    public struct TypeMeetingRoomErrorType
      {
        public bool in_known_list;
        public string string_value;
        public TypeMeetingRoomErrorTypeKnownValues list_value;
      };

    public static TypeMeetingRoomErrorTypeKnownValues  stringToMeetingRoomErrorType(string chars)
      {
        if ((String.Compare(chars, 0, "IndividualAccount", 0, 17, false) == 0) && (chars.Length == 17))
            return TypeMeetingRoomErrorTypeKnownValues.MeetingRoomErrorType_IndividualAccount;
        return TypeMeetingRoomErrorTypeKnownValues.MeetingRoomErrorType__none;
      }

    public static string  stringFromMeetingRoomErrorType(TypeMeetingRoomErrorTypeKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeMeetingRoomErrorTypeKnownValues.MeetingRoomErrorType_IndividualAccount:
                return "IndividualAccount";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasMeetingRoomErrorType;
    private TypeMeetingRoomErrorType storeMeetingRoomErrorType;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraMeetingRoomErrorTypeToJSON()
      {
        JSONStringValue generated_string_MeetingRoomErrorType;
        if (!(storeMeetingRoomErrorType.in_known_list))
          {
        generated_string_MeetingRoomErrorType = new JSONStringValue(storeMeetingRoomErrorType.string_value);
          }
        else
          {
        switch (storeMeetingRoomErrorType.list_value)
          {
            case TypeMeetingRoomErrorTypeKnownValues.MeetingRoomErrorType_IndividualAccount:
                generated_string_MeetingRoomErrorType = new JSONStringValue("IndividualAccount");
                break;
            default:
                Debug.Assert(false);
                generated_string_MeetingRoomErrorType = null;
                break;
          }
          }
        return generated_string_MeetingRoomErrorType;
      }


    private void  fromJSONMeetingRoomErrorType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field MeetingRoomErrorType of CalendarRefreshMeetingRoomsErrorJSON is not a string.");
        TypeMeetingRoomErrorType the_open_enum = new TypeMeetingRoomErrorType();
        if ((String.Compare(json_string.getData(), 0, "IndividualAccount", 0, 17, false) == 0) && (json_string.getData().Length == 17))
              {
                the_open_enum.in_known_list = true;
                the_open_enum.list_value = TypeMeetingRoomErrorTypeKnownValues.MeetingRoomErrorType_IndividualAccount;
                goto open_enum_is_done;
              }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setMeetingRoomErrorType(the_open_enum);
      }


    public CalendarRefreshMeetingRoomsErrorJSON()
      {
        flagHasMeetingRoomErrorType = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getThirdPartyCalendarErrorKind()
      {
        return "CalendarRefreshMeetingRoomsError";
      }

    public bool  hasMeetingRoomErrorType()
      {
        return flagHasMeetingRoomErrorType;
      }

    public TypeMeetingRoomErrorType  getMeetingRoomErrorType()
      {
        Debug.Assert(flagHasMeetingRoomErrorType);
        return storeMeetingRoomErrorType;
      }

    public string  getMeetingRoomErrorTypeAsString()
      {
        TypeMeetingRoomErrorType result = getMeetingRoomErrorType();
        if (result.in_known_list)
            return stringFromMeetingRoomErrorType(result.list_value);
        else
            return result.string_value;
      }


    public virtual int extraCalendarRefreshMeetingRoomsErrorComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraCalendarRefreshMeetingRoomsErrorComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraCalendarRefreshMeetingRoomsErrorComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraCalendarRefreshMeetingRoomsErrorLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraThirdPartyCalendarErrorComponentCount()
      {
        int result = 0;
        if (flagHasMeetingRoomErrorType)
            ++result;
        result += extraCalendarRefreshMeetingRoomsErrorComponentCount();
        return result;
      }
    public override string extraThirdPartyCalendarErrorComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasMeetingRoomErrorType)
          {
            if (remainder == 0)
                return "MeetingRoomErrorType";
            --remainder;
          }
        return extraCalendarRefreshMeetingRoomsErrorComponentKey(remainder);
      }
    public override JSONValue extraThirdPartyCalendarErrorComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasMeetingRoomErrorType)
          {
            if (remainder == 0)
                return extraMeetingRoomErrorTypeToJSON();
            --remainder;
          }
        return extraCalendarRefreshMeetingRoomsErrorComponentValue(remainder);
      }
    public override JSONValue extraThirdPartyCalendarErrorLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "MeetingRoomErrorType", 0, 20, false) == 0) && (field_name.Length == 20))
            return (flagHasMeetingRoomErrorType ? extraMeetingRoomErrorTypeToJSON() : null);
        return extraCalendarRefreshMeetingRoomsErrorLookup(field_name);
      }

    public void setMeetingRoomErrorType(TypeMeetingRoomErrorType new_value)
      {
        flagHasMeetingRoomErrorType = true;
        storeMeetingRoomErrorType = new_value;
      }
    public void setMeetingRoomErrorType(string chars)
      {
        TypeMeetingRoomErrorTypeKnownValues known = stringToMeetingRoomErrorType(chars);
        TypeMeetingRoomErrorType new_value = new TypeMeetingRoomErrorType();
        if (known == TypeMeetingRoomErrorTypeKnownValues.MeetingRoomErrorType__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setMeetingRoomErrorType(new_value);
      }
    public void setMeetingRoomErrorType(TypeMeetingRoomErrorTypeKnownValues new_value)
      {
        TypeMeetingRoomErrorType new_full_value = new TypeMeetingRoomErrorType();
        Debug.Assert(new_value != TypeMeetingRoomErrorTypeKnownValues.MeetingRoomErrorType__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setMeetingRoomErrorType(new_full_value);
      }
    public void unsetMeetingRoomErrorType()
      {
        flagHasMeetingRoomErrorType = false;
      }

    public virtual void extraCalendarRefreshMeetingRoomsErrorAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraCalendarRefreshMeetingRoomsErrorSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraCalendarRefreshMeetingRoomsErrorLookup(key);
        if (old_field == null)
          {
            extraCalendarRefreshMeetingRoomsErrorAppendPair(key, new_component);
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
        if ((String.Compare(key, 0, "MeetingRoomErrorType", 0, 20, false) == 0) && (key.Length == 20))
            {
            fromJSONMeetingRoomErrorType(new_component, false);
            return;
            }
        extraCalendarRefreshMeetingRoomsErrorAppendPair(key, new_component);
      }
    public override void extraThirdPartyCalendarErrorSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "MeetingRoomErrorType", 0, 20, false) == 0) && (key.Length == 20))
            {
            fromJSONMeetingRoomErrorType(new_component, false);
            return;
            }
        extraCalendarRefreshMeetingRoomsErrorSetField(key, new_component);
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
        if (flagHasMeetingRoomErrorType)
          {
            handler.start_pair("MeetingRoomErrorType");
            if (storeMeetingRoomErrorType.in_known_list)
              {
                switch (storeMeetingRoomErrorType.list_value)
                  {
                    case TypeMeetingRoomErrorTypeKnownValues.MeetingRoomErrorType_IndividualAccount:
                        handler.string_value("IndividualAccount");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeMeetingRoomErrorType.string_value);
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

    public static new CalendarRefreshMeetingRoomsErrorJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CalendarRefreshMeetingRoomsErrorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CalendarRefreshMeetingRoomsError", ignore_extras);
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
    public static new CalendarRefreshMeetingRoomsErrorJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new CalendarRefreshMeetingRoomsErrorJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CalendarRefreshMeetingRoomsErrorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CalendarRefreshMeetingRoomsError", ignore_extras);
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
    public static new CalendarRefreshMeetingRoomsErrorJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new CalendarRefreshMeetingRoomsErrorJSON from_text(string text, bool ignore_extras)
      {
        CalendarRefreshMeetingRoomsErrorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CalendarRefreshMeetingRoomsError", ignore_extras);
            JSONParse.parse_json_value(text, "Text for CalendarRefreshMeetingRoomsErrorJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new CalendarRefreshMeetingRoomsErrorJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        CalendarRefreshMeetingRoomsErrorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CalendarRefreshMeetingRoomsError", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : ThirdPartyCalendarErrorJSON.Generator
      {
    private abstract class FieldGeneratorMeetingRoomErrorType : JSONStringGenerator
          {
            protected FieldGeneratorMeetingRoomErrorType(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorMeetingRoomErrorType()
              {
              }
            protected override void handle_result(string result)
              {
                TypeMeetingRoomErrorTypeKnownValues known = stringToMeetingRoomErrorType(result);
                TypeMeetingRoomErrorType new_value = new TypeMeetingRoomErrorType();
                if (known == TypeMeetingRoomErrorTypeKnownValues.MeetingRoomErrorType__none)
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
            protected abstract void handle_result(TypeMeetingRoomErrorType result);
          };
    private class FieldHoldingGeneratorMeetingRoomErrorType : FieldGeneratorMeetingRoomErrorType
  {
    protected override void handle_result(TypeMeetingRoomErrorType result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorMeetingRoomErrorType(String what)
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
    public TypeMeetingRoomErrorType value;
  };
    private class FieldHoldingArrayGeneratorMeetingRoomErrorType : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorMeetingRoomErrorType
      {
        private FieldHoldingArrayGeneratorMeetingRoomErrorType top;

        protected override void handle_result(TypeMeetingRoomErrorType result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorMeetingRoomErrorType init_top)
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
    protected virtual void handle_result(List<TypeMeetingRoomErrorType> result)
      {
      }

    public FieldHoldingArrayGeneratorMeetingRoomErrorType(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeMeetingRoomErrorType>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorMeetingRoomErrorType()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeMeetingRoomErrorType>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeMeetingRoomErrorType> value;
  };
        private FieldHoldingGeneratorMeetingRoomErrorType fieldGeneratorMeetingRoomErrorType;
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
            if (!(getThirdPartyCalendarErrorJSONKey().Equals("CalendarRefreshMeetingRoomsError")))
                throw new Exception("The key field has a value other than `CalendarRefreshMeetingRoomsError'.");
            CalendarRefreshMeetingRoomsErrorJSON result = new CalendarRefreshMeetingRoomsErrorJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraCalendarRefreshMeetingRoomsErrorAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(ThirdPartyCalendarErrorJSON new_result)
          {
            handle_result((CalendarRefreshMeetingRoomsErrorJSON )new_result);
          }
        protected void finish(CalendarRefreshMeetingRoomsErrorJSON result)
          {
            if (fieldGeneratorMeetingRoomErrorType.have_value)
              {
                result.setMeetingRoomErrorType(fieldGeneratorMeetingRoomErrorType.value);
                fieldGeneratorMeetingRoomErrorType.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(CalendarRefreshMeetingRoomsErrorJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "MeetingRoomErrorType", 0, 20, false) == 0) && (field_name.Length == 20))
                return fieldGeneratorMeetingRoomErrorType;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorMeetingRoomErrorType = new FieldHoldingGeneratorMeetingRoomErrorType("field \"MeetingRoomErrorType\" of the CalendarRefreshMeetingRoomsError class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the CalendarRefreshMeetingRoomsError class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorMeetingRoomErrorType = new FieldHoldingGeneratorMeetingRoomErrorType("field \"MeetingRoomErrorType\" of the CalendarRefreshMeetingRoomsError class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the CalendarRefreshMeetingRoomsError class");
          }

        public override void reset()
          {
            fieldGeneratorMeetingRoomErrorType.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(CalendarRefreshMeetingRoomsErrorJSON  result)
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
        public CalendarRefreshMeetingRoomsErrorJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(CalendarRefreshMeetingRoomsErrorJSON  result)
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
    protected virtual void handle_result(List<CalendarRefreshMeetingRoomsErrorJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<CalendarRefreshMeetingRoomsErrorJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<CalendarRefreshMeetingRoomsErrorJSON>();
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
    public List<CalendarRefreshMeetingRoomsErrorJSON> value;
  };
  };
