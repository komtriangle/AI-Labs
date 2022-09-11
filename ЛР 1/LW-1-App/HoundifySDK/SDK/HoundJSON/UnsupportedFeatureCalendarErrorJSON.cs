/* file "UnsupportedFeatureCalendarErrorJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class UnsupportedFeatureCalendarErrorJSON : ThirdPartyCalendarErrorJSON
  {
    public enum TypeUnsupportedFeature
      {
        UnsupportedFeature_Outlook_FindMeetingTimes
      };

    public static TypeUnsupportedFeature  stringToUnsupportedFeature(string chars)
      {
        if ((String.Compare(chars, 0, "Outlook_FindMeetingTimes", 0, 24, false) == 0) && (chars.Length == 24))
            return TypeUnsupportedFeature.UnsupportedFeature_Outlook_FindMeetingTimes;
        throw new Exception("The value for field `UnsupportedFeature' is not one of the legal values.");
      }

    public static string  stringFromUnsupportedFeature(TypeUnsupportedFeature the_enum)
      {
        switch (the_enum)
          {
            case TypeUnsupportedFeature.UnsupportedFeature_Outlook_FindMeetingTimes:
                return "Outlook_FindMeetingTimes";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasUnsupportedFeature;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraUnsupportedFeatureToJSON()
      {
        JSONStringValue generated_string_UnsupportedFeature;
        generated_string_UnsupportedFeature = new JSONStringValue("Outlook_FindMeetingTimes");
        return generated_string_UnsupportedFeature;
      }


    private void  fromJSONUnsupportedFeature(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field UnsupportedFeature of UnsupportedFeatureCalendarErrorJSON is not a string.");
        if (!(json_string.getData().Equals("Outlook_FindMeetingTimes")))
            throw new Exception("The value for field UnsupportedFeature of UnsupportedFeatureCalendarErrorJSON is not `Outlook_FindMeetingTimes'.");
        setUnsupportedFeature();
      }


    public UnsupportedFeatureCalendarErrorJSON()
      {
        flagHasUnsupportedFeature = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getThirdPartyCalendarErrorKind()
      {
        return "UnsupportedFeatureCalendarError";
      }

    public bool  hasUnsupportedFeature()
      {
        return flagHasUnsupportedFeature;
      }

    public TypeUnsupportedFeature  getUnsupportedFeature()
      {
        Debug.Assert(flagHasUnsupportedFeature);
        return TypeUnsupportedFeature.UnsupportedFeature_Outlook_FindMeetingTimes;
      }

    public string  getUnsupportedFeatureAsString()
      {
        return stringFromUnsupportedFeature(getUnsupportedFeature());
      }


    public virtual int extraUnsupportedFeatureCalendarErrorComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraUnsupportedFeatureCalendarErrorComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraUnsupportedFeatureCalendarErrorComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraUnsupportedFeatureCalendarErrorLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraThirdPartyCalendarErrorComponentCount()
      {
        int result = 0;
        if (flagHasUnsupportedFeature)
            ++result;
        result += extraUnsupportedFeatureCalendarErrorComponentCount();
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
        return extraUnsupportedFeatureCalendarErrorComponentKey(remainder);
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
        return extraUnsupportedFeatureCalendarErrorComponentValue(remainder);
      }
    public override JSONValue extraThirdPartyCalendarErrorLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "UnsupportedFeature", 0, 18, false) == 0) && (field_name.Length == 18))
            return (flagHasUnsupportedFeature ? extraUnsupportedFeatureToJSON() : null);
        return extraUnsupportedFeatureCalendarErrorLookup(field_name);
      }

    public void setUnsupportedFeature()
      {
        flagHasUnsupportedFeature = true;
      }
    public void setUnsupportedFeature(TypeUnsupportedFeature new_value)
      {
        setUnsupportedFeature();
      }
    public void setUnsupportedFeature(string chars)
      {
        setUnsupportedFeature(stringToUnsupportedFeature(chars));
      }
    public void unsetUnsupportedFeature()
      {
        flagHasUnsupportedFeature = false;
      }

    public virtual void extraUnsupportedFeatureCalendarErrorAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraUnsupportedFeatureCalendarErrorSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraUnsupportedFeatureCalendarErrorLookup(key);
        if (old_field == null)
          {
            extraUnsupportedFeatureCalendarErrorAppendPair(key, new_component);
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
        extraUnsupportedFeatureCalendarErrorAppendPair(key, new_component);
      }
    public override void extraThirdPartyCalendarErrorSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "UnsupportedFeature", 0, 18, false) == 0) && (key.Length == 18))
            {
            fromJSONUnsupportedFeature(new_component, false);
            return;
            }
        extraUnsupportedFeatureCalendarErrorSetField(key, new_component);
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
            handler.string_value("Outlook_FindMeetingTimes");
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

    public static new UnsupportedFeatureCalendarErrorJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UnsupportedFeatureCalendarErrorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UnsupportedFeatureCalendarError", ignore_extras);
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
    public static new UnsupportedFeatureCalendarErrorJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new UnsupportedFeatureCalendarErrorJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UnsupportedFeatureCalendarErrorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UnsupportedFeatureCalendarError", ignore_extras);
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
    public static new UnsupportedFeatureCalendarErrorJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new UnsupportedFeatureCalendarErrorJSON from_text(string text, bool ignore_extras)
      {
        UnsupportedFeatureCalendarErrorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UnsupportedFeatureCalendarError", ignore_extras);
            JSONParse.parse_json_value(text, "Text for UnsupportedFeatureCalendarErrorJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new UnsupportedFeatureCalendarErrorJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        UnsupportedFeatureCalendarErrorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UnsupportedFeatureCalendarError", ignore_extras);
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
                handle_result(stringToUnsupportedFeature(result));
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
            if (!(getThirdPartyCalendarErrorJSONKey().Equals("UnsupportedFeatureCalendarError")))
                throw new Exception("The key field has a value other than `UnsupportedFeatureCalendarError'.");
            UnsupportedFeatureCalendarErrorJSON result = new UnsupportedFeatureCalendarErrorJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraUnsupportedFeatureCalendarErrorAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(ThirdPartyCalendarErrorJSON new_result)
          {
            handle_result((UnsupportedFeatureCalendarErrorJSON )new_result);
          }
        protected void finish(UnsupportedFeatureCalendarErrorJSON result)
          {
            if (fieldGeneratorUnsupportedFeature.have_value)
              {
                result.setUnsupportedFeature();
                fieldGeneratorUnsupportedFeature.have_value = false;
              }
            else if ((!(result.hasUnsupportedFeature())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"UnsupportedFeature\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(UnsupportedFeatureCalendarErrorJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "UnsupportedFeature", 0, 18, false) == 0) && (field_name.Length == 18))
                return fieldGeneratorUnsupportedFeature;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorUnsupportedFeature = new FieldHoldingGeneratorUnsupportedFeature("field \"UnsupportedFeature\" of the UnsupportedFeatureCalendarError class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the UnsupportedFeatureCalendarError class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorUnsupportedFeature = new FieldHoldingGeneratorUnsupportedFeature("field \"UnsupportedFeature\" of the UnsupportedFeatureCalendarError class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the UnsupportedFeatureCalendarError class");
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
        protected override void handle_result(UnsupportedFeatureCalendarErrorJSON  result)
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
        public UnsupportedFeatureCalendarErrorJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(UnsupportedFeatureCalendarErrorJSON  result)
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
    protected virtual void handle_result(List<UnsupportedFeatureCalendarErrorJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<UnsupportedFeatureCalendarErrorJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<UnsupportedFeatureCalendarErrorJSON>();
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
    public List<UnsupportedFeatureCalendarErrorJSON> value;
  };
  };
