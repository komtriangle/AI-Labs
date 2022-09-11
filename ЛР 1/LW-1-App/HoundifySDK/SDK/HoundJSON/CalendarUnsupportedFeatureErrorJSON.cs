/* file "CalendarUnsupportedFeatureErrorJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class CalendarUnsupportedFeatureErrorJSON : ThirdPartyCalendarErrorJSON
  {
    public enum TypeUnsupportedFeatureKnownValues
      {
        UnsupportedFeature_Outlook_FindMeetingTimes,
        UnsupportedFeature__none
      };
    public struct TypeUnsupportedFeature
      {
        public bool in_known_list;
        public string string_value;
        public TypeUnsupportedFeatureKnownValues list_value;
      };

    public static TypeUnsupportedFeatureKnownValues  stringToUnsupportedFeature(string chars)
      {
        if ((String.Compare(chars, 0, "Outlook_FindMeetingTimes", 0, 24, false) == 0) && (chars.Length == 24))
            return TypeUnsupportedFeatureKnownValues.UnsupportedFeature_Outlook_FindMeetingTimes;
        return TypeUnsupportedFeatureKnownValues.UnsupportedFeature__none;
      }

    public static string  stringFromUnsupportedFeature(TypeUnsupportedFeatureKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeUnsupportedFeatureKnownValues.UnsupportedFeature_Outlook_FindMeetingTimes:
                return "Outlook_FindMeetingTimes";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasUnsupportedFeature;
    private TypeUnsupportedFeature storeUnsupportedFeature;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraUnsupportedFeatureToJSON()
      {
        JSONStringValue generated_string_UnsupportedFeature;
        if (!(storeUnsupportedFeature.in_known_list))
          {
        generated_string_UnsupportedFeature = new JSONStringValue(storeUnsupportedFeature.string_value);
          }
        else
          {
        switch (storeUnsupportedFeature.list_value)
          {
            case TypeUnsupportedFeatureKnownValues.UnsupportedFeature_Outlook_FindMeetingTimes:
                generated_string_UnsupportedFeature = new JSONStringValue("Outlook_FindMeetingTimes");
                break;
            default:
                Debug.Assert(false);
                generated_string_UnsupportedFeature = null;
                break;
          }
          }
        return generated_string_UnsupportedFeature;
      }


    private void  fromJSONUnsupportedFeature(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field UnsupportedFeature of CalendarUnsupportedFeatureErrorJSON is not a string.");
        TypeUnsupportedFeature the_open_enum = new TypeUnsupportedFeature();
        if ((String.Compare(json_string.getData(), 0, "Outlook_FindMeetingTimes", 0, 24, false) == 0) && (json_string.getData().Length == 24))
              {
                the_open_enum.in_known_list = true;
                the_open_enum.list_value = TypeUnsupportedFeatureKnownValues.UnsupportedFeature_Outlook_FindMeetingTimes;
                goto open_enum_is_done;
              }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setUnsupportedFeature(the_open_enum);
      }


    public CalendarUnsupportedFeatureErrorJSON()
      {
        flagHasUnsupportedFeature = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getThirdPartyCalendarErrorKind()
      {
        return "CalendarUnsupportedFeatureError";
      }

    public bool  hasUnsupportedFeature()
      {
        return flagHasUnsupportedFeature;
      }

    public TypeUnsupportedFeature  getUnsupportedFeature()
      {
        Debug.Assert(flagHasUnsupportedFeature);
        return storeUnsupportedFeature;
      }

    public string  getUnsupportedFeatureAsString()
      {
        TypeUnsupportedFeature result = getUnsupportedFeature();
        if (result.in_known_list)
            return stringFromUnsupportedFeature(result.list_value);
        else
            return result.string_value;
      }


    public virtual int extraCalendarUnsupportedFeatureErrorComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraCalendarUnsupportedFeatureErrorComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraCalendarUnsupportedFeatureErrorComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraCalendarUnsupportedFeatureErrorLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraThirdPartyCalendarErrorComponentCount()
      {
        int result = 0;
        if (flagHasUnsupportedFeature)
            ++result;
        result += extraCalendarUnsupportedFeatureErrorComponentCount();
        return result;
      }
    public override string extraThirdPartyCalendarErrorComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasUnsupportedFeature)
          {
            if (remainder == 0)
                return "UnsupportedFeature";
            --remainder;
          }
        return extraCalendarUnsupportedFeatureErrorComponentKey(remainder);
      }
    public override JSONValue extraThirdPartyCalendarErrorComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasUnsupportedFeature)
          {
            if (remainder == 0)
                return extraUnsupportedFeatureToJSON();
            --remainder;
          }
        return extraCalendarUnsupportedFeatureErrorComponentValue(remainder);
      }
    public override JSONValue extraThirdPartyCalendarErrorLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "UnsupportedFeature", 0, 18, false) == 0) && (field_name.Length == 18))
            return (flagHasUnsupportedFeature ? extraUnsupportedFeatureToJSON() : null);
        return extraCalendarUnsupportedFeatureErrorLookup(field_name);
      }

    public void setUnsupportedFeature(TypeUnsupportedFeature new_value)
      {
        flagHasUnsupportedFeature = true;
        storeUnsupportedFeature = new_value;
      }
    public void setUnsupportedFeature(string chars)
      {
        TypeUnsupportedFeatureKnownValues known = stringToUnsupportedFeature(chars);
        TypeUnsupportedFeature new_value = new TypeUnsupportedFeature();
        if (known == TypeUnsupportedFeatureKnownValues.UnsupportedFeature__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setUnsupportedFeature(new_value);
      }
    public void setUnsupportedFeature(TypeUnsupportedFeatureKnownValues new_value)
      {
        TypeUnsupportedFeature new_full_value = new TypeUnsupportedFeature();
        Debug.Assert(new_value != TypeUnsupportedFeatureKnownValues.UnsupportedFeature__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setUnsupportedFeature(new_full_value);
      }
    public void unsetUnsupportedFeature()
      {
        flagHasUnsupportedFeature = false;
      }

    public virtual void extraCalendarUnsupportedFeatureErrorAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraCalendarUnsupportedFeatureErrorSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraCalendarUnsupportedFeatureErrorLookup(key);
        if (old_field == null)
          {
            extraCalendarUnsupportedFeatureErrorAppendPair(key, new_component);
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
        if ((String.Compare(key, 0, "UnsupportedFeature", 0, 18, false) == 0) && (key.Length == 18))
            {
            fromJSONUnsupportedFeature(new_component, false);
            return;
            }
        extraCalendarUnsupportedFeatureErrorAppendPair(key, new_component);
      }
    public override void extraThirdPartyCalendarErrorSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "UnsupportedFeature", 0, 18, false) == 0) && (key.Length == 18))
            {
            fromJSONUnsupportedFeature(new_component, false);
            return;
            }
        extraCalendarUnsupportedFeatureErrorSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasUnsupportedFeature);
        if (flagHasUnsupportedFeature)
          {
            handler.start_pair("UnsupportedFeature");
            if (storeUnsupportedFeature.in_known_list)
              {
                switch (storeUnsupportedFeature.list_value)
                  {
                    case TypeUnsupportedFeatureKnownValues.UnsupportedFeature_Outlook_FindMeetingTimes:
                        handler.string_value("Outlook_FindMeetingTimes");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeUnsupportedFeature.string_value);
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
        if (!(hasUnsupportedFeature()))
          {
            return "When parsing the object for %what%, the \"UnsupportedFeature\" field was missing.";
          }
        return null;
      }

    public static new CalendarUnsupportedFeatureErrorJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CalendarUnsupportedFeatureErrorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CalendarUnsupportedFeatureError", ignore_extras);
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
    public static new CalendarUnsupportedFeatureErrorJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new CalendarUnsupportedFeatureErrorJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CalendarUnsupportedFeatureErrorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CalendarUnsupportedFeatureError", ignore_extras);
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
    public static new CalendarUnsupportedFeatureErrorJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new CalendarUnsupportedFeatureErrorJSON from_text(string text, bool ignore_extras)
      {
        CalendarUnsupportedFeatureErrorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CalendarUnsupportedFeatureError", ignore_extras);
            JSONParse.parse_json_value(text, "Text for CalendarUnsupportedFeatureErrorJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new CalendarUnsupportedFeatureErrorJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        CalendarUnsupportedFeatureErrorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CalendarUnsupportedFeatureError", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : ThirdPartyCalendarErrorJSON.Generator
      {
    private abstract class FieldGeneratorUnsupportedFeature : JSONStringGenerator
          {
            protected FieldGeneratorUnsupportedFeature(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorUnsupportedFeature()
              {
              }
            protected override void handle_result(string result)
              {
                TypeUnsupportedFeatureKnownValues known = stringToUnsupportedFeature(result);
                TypeUnsupportedFeature new_value = new TypeUnsupportedFeature();
                if (known == TypeUnsupportedFeatureKnownValues.UnsupportedFeature__none)
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
            protected abstract void handle_result(TypeUnsupportedFeature result);
          };
    private class FieldHoldingGeneratorUnsupportedFeature : FieldGeneratorUnsupportedFeature
  {
    protected override void handle_result(TypeUnsupportedFeature result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorUnsupportedFeature(String what)
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
    public TypeUnsupportedFeature value;
  };
    private class FieldHoldingArrayGeneratorUnsupportedFeature : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorUnsupportedFeature
      {
        private FieldHoldingArrayGeneratorUnsupportedFeature top;

        protected override void handle_result(TypeUnsupportedFeature result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorUnsupportedFeature init_top)
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
    protected virtual void handle_result(List<TypeUnsupportedFeature> result)
      {
      }

    public FieldHoldingArrayGeneratorUnsupportedFeature(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeUnsupportedFeature>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorUnsupportedFeature()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeUnsupportedFeature>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeUnsupportedFeature> value;
  };
        private FieldHoldingGeneratorUnsupportedFeature fieldGeneratorUnsupportedFeature;
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
            if (!(getThirdPartyCalendarErrorJSONKey().Equals("CalendarUnsupportedFeatureError")))
                throw new Exception("The key field has a value other than `CalendarUnsupportedFeatureError'.");
            CalendarUnsupportedFeatureErrorJSON result = new CalendarUnsupportedFeatureErrorJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraCalendarUnsupportedFeatureErrorAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(ThirdPartyCalendarErrorJSON new_result)
          {
            handle_result((CalendarUnsupportedFeatureErrorJSON )new_result);
          }
        protected void finish(CalendarUnsupportedFeatureErrorJSON result)
          {
            if (fieldGeneratorUnsupportedFeature.have_value)
              {
                result.setUnsupportedFeature(fieldGeneratorUnsupportedFeature.value);
                fieldGeneratorUnsupportedFeature.have_value = false;
              }
            else if ((!(result.hasUnsupportedFeature())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"UnsupportedFeature\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(CalendarUnsupportedFeatureErrorJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "UnsupportedFeature", 0, 18, false) == 0) && (field_name.Length == 18))
                return fieldGeneratorUnsupportedFeature;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorUnsupportedFeature = new FieldHoldingGeneratorUnsupportedFeature("field \"UnsupportedFeature\" of the CalendarUnsupportedFeatureError class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the CalendarUnsupportedFeatureError class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorUnsupportedFeature = new FieldHoldingGeneratorUnsupportedFeature("field \"UnsupportedFeature\" of the CalendarUnsupportedFeatureError class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the CalendarUnsupportedFeatureError class");
          }

        public override void reset()
          {
            fieldGeneratorUnsupportedFeature.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(CalendarUnsupportedFeatureErrorJSON  result)
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
        public CalendarUnsupportedFeatureErrorJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(CalendarUnsupportedFeatureErrorJSON  result)
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
    protected virtual void handle_result(List<CalendarUnsupportedFeatureErrorJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<CalendarUnsupportedFeatureErrorJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<CalendarUnsupportedFeatureErrorJSON>();
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
    public List<CalendarUnsupportedFeatureErrorJSON> value;
  };
  };
