/* file "HomeAutomationMotionStatusJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class HomeAutomationMotionStatusJSON : JSONBase
  {
    public enum TypeRecentStatusKnownValues
      {
        RecentStatus_NoMotionDetected,
        RecentStatus_MotionDetected,
        RecentStatus__none
      };
    public struct TypeRecentStatus
      {
        public bool in_known_list;
        public string string_value;
        public TypeRecentStatusKnownValues list_value;
      };

    public static TypeRecentStatusKnownValues  stringToRecentStatus(string chars)
      {
        switch (chars[0])
          {
            case 'M':
                if ((String.Compare(chars, 1, "otionDetected", 0, 13, false) == 0) && (chars.Length == 14))
                    return TypeRecentStatusKnownValues.RecentStatus_MotionDetected;
                break;
            case 'N':
                if ((String.Compare(chars, 1, "oMotionDetected", 0, 15, false) == 0) && (chars.Length == 16))
                    return TypeRecentStatusKnownValues.RecentStatus_NoMotionDetected;
                break;
            default:
                break;
          }
        return TypeRecentStatusKnownValues.RecentStatus__none;
      }

    public static string  stringFromRecentStatus(TypeRecentStatusKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeRecentStatusKnownValues.RecentStatus_NoMotionDetected:
                return "NoMotionDetected";
            case TypeRecentStatusKnownValues.RecentStatus_MotionDetected:
                return "MotionDetected";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasRecentStatus;
    private TypeRecentStatus storeRecentStatus;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONRecentStatus(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field RecentStatus of HomeAutomationMotionStatusJSON is not a string.");
        TypeRecentStatus the_open_enum = new TypeRecentStatus();
        switch (json_string.getData()[0])
          {
            case 'M':
                if ((String.Compare(json_string.getData(), 1, "otionDetected", 0, 13, false) == 0) && (json_string.getData().Length == 14))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeRecentStatusKnownValues.RecentStatus_MotionDetected;
                        goto open_enum_is_done;
                      }
                break;
            case 'N':
                if ((String.Compare(json_string.getData(), 1, "oMotionDetected", 0, 15, false) == 0) && (json_string.getData().Length == 16))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeRecentStatusKnownValues.RecentStatus_NoMotionDetected;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setRecentStatus(the_open_enum);
      }


    public HomeAutomationMotionStatusJSON()
      {
        flagHasRecentStatus = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasRecentStatus()
      {
        return flagHasRecentStatus;
      }

    public TypeRecentStatus  getRecentStatus()
      {
        Debug.Assert(flagHasRecentStatus);
        return storeRecentStatus;
      }

    public string  getRecentStatusAsString()
      {
        TypeRecentStatus result = getRecentStatus();
        if (result.in_known_list)
            return stringFromRecentStatus(result.list_value);
        else
            return result.string_value;
      }


    public virtual int extraHomeAutomationMotionStatusComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraHomeAutomationMotionStatusComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraHomeAutomationMotionStatusComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraHomeAutomationMotionStatusLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setRecentStatus(TypeRecentStatus new_value)
      {
        flagHasRecentStatus = true;
        storeRecentStatus = new_value;
      }
    public void setRecentStatus(string chars)
      {
        TypeRecentStatusKnownValues known = stringToRecentStatus(chars);
        TypeRecentStatus new_value = new TypeRecentStatus();
        if (known == TypeRecentStatusKnownValues.RecentStatus__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setRecentStatus(new_value);
      }
    public void setRecentStatus(TypeRecentStatusKnownValues new_value)
      {
        TypeRecentStatus new_full_value = new TypeRecentStatus();
        Debug.Assert(new_value != TypeRecentStatusKnownValues.RecentStatus__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setRecentStatus(new_full_value);
      }
    public void unsetRecentStatus()
      {
        flagHasRecentStatus = false;
      }

    public virtual void extraHomeAutomationMotionStatusAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraHomeAutomationMotionStatusSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraHomeAutomationMotionStatusLookup(key);
        if (old_field == null)
          {
            extraHomeAutomationMotionStatusAppendPair(key, new_component);
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
        if (flagHasRecentStatus)
          {
            handler.start_pair("RecentStatus");
            if (storeRecentStatus.in_known_list)
              {
                switch (storeRecentStatus.list_value)
                  {
                    case TypeRecentStatusKnownValues.RecentStatus_NoMotionDetected:
                        handler.string_value("NoMotionDetected");
                        break;
                    case TypeRecentStatusKnownValues.RecentStatus_MotionDetected:
                        handler.string_value("MotionDetected");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeRecentStatus.string_value);
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
        return null;
      }

    public static HomeAutomationMotionStatusJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HomeAutomationMotionStatusJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationMotionStatus", ignore_extras);
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
    public static HomeAutomationMotionStatusJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HomeAutomationMotionStatusJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HomeAutomationMotionStatusJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationMotionStatus", ignore_extras);
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
    public static HomeAutomationMotionStatusJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HomeAutomationMotionStatusJSON from_text(string text, bool ignore_extras)
      {
        HomeAutomationMotionStatusJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationMotionStatus", ignore_extras);
            JSONParse.parse_json_value(text, "Text for HomeAutomationMotionStatusJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static HomeAutomationMotionStatusJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        HomeAutomationMotionStatusJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationMotionStatus", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorRecentStatus : JSONStringGenerator
          {
            protected FieldGeneratorRecentStatus(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorRecentStatus()
              {
              }
            protected override void handle_result(string result)
              {
                TypeRecentStatusKnownValues known = stringToRecentStatus(result);
                TypeRecentStatus new_value = new TypeRecentStatus();
                if (known == TypeRecentStatusKnownValues.RecentStatus__none)
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
            protected abstract void handle_result(TypeRecentStatus result);
          };
    private class FieldHoldingGeneratorRecentStatus : FieldGeneratorRecentStatus
  {
    protected override void handle_result(TypeRecentStatus result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorRecentStatus(String what)
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
    public TypeRecentStatus value;
  };
    private class FieldHoldingArrayGeneratorRecentStatus : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorRecentStatus
      {
        private FieldHoldingArrayGeneratorRecentStatus top;

        protected override void handle_result(TypeRecentStatus result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorRecentStatus init_top)
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
    protected virtual void handle_result(List<TypeRecentStatus> result)
      {
      }

    public FieldHoldingArrayGeneratorRecentStatus(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeRecentStatus>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorRecentStatus()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeRecentStatus>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeRecentStatus> value;
  };
        private FieldHoldingGeneratorRecentStatus fieldGeneratorRecentStatus;
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
            HomeAutomationMotionStatusJSON result = new HomeAutomationMotionStatusJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraHomeAutomationMotionStatusAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(HomeAutomationMotionStatusJSON result)
          {
            if (fieldGeneratorRecentStatus.have_value)
              {
                result.setRecentStatus(fieldGeneratorRecentStatus.value);
                fieldGeneratorRecentStatus.have_value = false;
              }
          }
        protected abstract void handle_result(HomeAutomationMotionStatusJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "RecentStatus", 0, 12, false) == 0) && (field_name.Length == 12))
                return fieldGeneratorRecentStatus;
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorRecentStatus = new FieldHoldingGeneratorRecentStatus("field \"RecentStatus\" of the HomeAutomationMotionStatus class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the HomeAutomationMotionStatus class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorRecentStatus = new FieldHoldingGeneratorRecentStatus("field \"RecentStatus\" of the HomeAutomationMotionStatus class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the HomeAutomationMotionStatus class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorRecentStatus.reset();
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
        protected override void handle_result(HomeAutomationMotionStatusJSON  result)
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
        public HomeAutomationMotionStatusJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(HomeAutomationMotionStatusJSON  result)
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
    protected virtual void handle_result(List<HomeAutomationMotionStatusJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<HomeAutomationMotionStatusJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<HomeAutomationMotionStatusJSON>();
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
    public List<HomeAutomationMotionStatusJSON> value;
  };
  };
