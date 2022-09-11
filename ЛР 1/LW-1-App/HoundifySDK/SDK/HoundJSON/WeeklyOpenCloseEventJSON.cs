/* file "WeeklyOpenCloseEventJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class WeeklyOpenCloseEventJSON : OpenCloseEventJSON
  {
    private bool flagHasDayOfWeek;
    private DayOfWeekJSON  storeDayOfWeek;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraDayOfWeekToJSON()
      {
        JSONValueHandler handler_DayOfWeek = new JSONValueHandler();
        storeDayOfWeek.write_as_json(handler_DayOfWeek);
        return handler_DayOfWeek.result;
      }


    private void  fromJSONDayOfWeek(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DayOfWeekJSON convert_classy = DayOfWeekJSON.from_json(json_value, ignore_extras, true);
        setDayOfWeek(convert_classy);
      }


    public WeeklyOpenCloseEventJSON()
      {
        flagHasDayOfWeek = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasDayOfWeek()
      {
        return flagHasDayOfWeek;
      }

    public DayOfWeekJSON   getDayOfWeek()
      {
        Debug.Assert(flagHasDayOfWeek);
        return storeDayOfWeek;
      }

    public DayOfWeekJSON.TypeValue  getDayOfWeekValue()
      {
        return getDayOfWeek().getValue();
      }

    public string  getDayOfWeekAsString()
      {
        return getDayOfWeek().getValueAsString();
      }


    public virtual int extraWeeklyOpenCloseEventComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraWeeklyOpenCloseEventComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraWeeklyOpenCloseEventComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraWeeklyOpenCloseEventLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraOpenCloseEventComponentCount()
      {
        int result = 0;
        if (flagHasDayOfWeek)
            ++result;
        result += extraWeeklyOpenCloseEventComponentCount();
        return result;
      }
    public override string extraOpenCloseEventComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasDayOfWeek)
          {
            if (remainder == 0)
                return "DayOfWeek";
            --remainder;
          }
        return extraWeeklyOpenCloseEventComponentKey(remainder);
      }
    public override JSONValue extraOpenCloseEventComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasDayOfWeek)
          {
            if (remainder == 0)
                return extraDayOfWeekToJSON();
            --remainder;
          }
        return extraWeeklyOpenCloseEventComponentValue(remainder);
      }
    public override JSONValue extraOpenCloseEventLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "DayOfWeek", 0, 9, false) == 0) && (field_name.Length == 9))
            return (flagHasDayOfWeek ? extraDayOfWeekToJSON() : null);
        return extraWeeklyOpenCloseEventLookup(field_name);
      }

    public void setDayOfWeek(DayOfWeekJSON  new_value)
      {
        if (flagHasDayOfWeek)
          {
          }
        flagHasDayOfWeek = true;
        storeDayOfWeek = new_value;
      }
    public void setDayOfWeek(DayOfWeekJSON.TypeValue new_value)
      {
        setDayOfWeek(new DayOfWeekJSON(new_value));
      }
    public void setDayOfWeek(string chars)
      {
        setDayOfWeek(new DayOfWeekJSON(chars));
      }
    public void unsetDayOfWeek()
      {
        if (flagHasDayOfWeek)
          {
          }
        flagHasDayOfWeek = false;
      }

    public virtual void extraWeeklyOpenCloseEventAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraWeeklyOpenCloseEventSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraWeeklyOpenCloseEventLookup(key);
        if (old_field == null)
          {
            extraWeeklyOpenCloseEventAppendPair(key, new_component);
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
    public override void extraOpenCloseEventAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "DayOfWeek", 0, 9, false) == 0) && (key.Length == 9))
            {
            fromJSONDayOfWeek(new_component, false);
            return;
            }
        extraWeeklyOpenCloseEventAppendPair(key, new_component);
      }
    public override void extraOpenCloseEventSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "DayOfWeek", 0, 9, false) == 0) && (key.Length == 9))
            {
            fromJSONDayOfWeek(new_component, false);
            return;
            }
        extraWeeklyOpenCloseEventSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasDayOfWeek);
        if (flagHasDayOfWeek)
          {
            handler.start_pair("DayOfWeek");
            if (partial_allowed)
                storeDayOfWeek.write_partial_as_json(handler);
            else
                storeDayOfWeek.write_as_json(handler);
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
        if (!(hasDayOfWeek()))
          {
            return "When parsing the object for %what%, the \"DayOfWeek\" field was missing.";
          }
        return null;
      }

    public static new WeeklyOpenCloseEventJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        WeeklyOpenCloseEventJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WeeklyOpenCloseEvent", ignore_extras);
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
    public static new WeeklyOpenCloseEventJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new WeeklyOpenCloseEventJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        WeeklyOpenCloseEventJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WeeklyOpenCloseEvent", ignore_extras);
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
    public static new WeeklyOpenCloseEventJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new WeeklyOpenCloseEventJSON from_text(string text, bool ignore_extras)
      {
        WeeklyOpenCloseEventJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WeeklyOpenCloseEvent", ignore_extras);
            JSONParse.parse_json_value(text, "Text for WeeklyOpenCloseEventJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new WeeklyOpenCloseEventJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        WeeklyOpenCloseEventJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WeeklyOpenCloseEvent", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : OpenCloseEventJSON.Generator
      {
        private DayOfWeekJSON.HoldingGenerator fieldGeneratorDayOfWeek;
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
            WeeklyOpenCloseEventJSON result = new WeeklyOpenCloseEventJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraWeeklyOpenCloseEventAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(OpenCloseEventJSON new_result)
          {
            handle_result((WeeklyOpenCloseEventJSON )new_result);
          }
        protected void finish(WeeklyOpenCloseEventJSON result)
          {
            if (fieldGeneratorDayOfWeek.have_value)
              {
                result.setDayOfWeek(fieldGeneratorDayOfWeek.value);
                fieldGeneratorDayOfWeek.have_value = false;
              }
            else if ((!(result.hasDayOfWeek())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"DayOfWeek\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(WeeklyOpenCloseEventJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "DayOfWeek", 0, 9, false) == 0) && (field_name.Length == 9))
                return fieldGeneratorDayOfWeek;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorDayOfWeek = new DayOfWeekJSON.HoldingGenerator("field \"DayOfWeek\" of the WeeklyOpenCloseEvent class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the WeeklyOpenCloseEvent class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorDayOfWeek = new DayOfWeekJSON.HoldingGenerator("field \"DayOfWeek\" of the WeeklyOpenCloseEvent class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the WeeklyOpenCloseEvent class");
          }

        public override void reset()
          {
            fieldGeneratorDayOfWeek.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(WeeklyOpenCloseEventJSON  result)
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
        public WeeklyOpenCloseEventJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(WeeklyOpenCloseEventJSON  result)
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
    protected virtual void handle_result(List<WeeklyOpenCloseEventJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<WeeklyOpenCloseEventJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<WeeklyOpenCloseEventJSON>();
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
    public List<WeeklyOpenCloseEventJSON> value;
  };
    public static WeeklyOpenCloseEventJSON from_OpenCloseEventJSON_json(OpenCloseEventJSON  ancestor, bool ignore_extras)
      {
        Debug.Assert(ancestor != null);
        WeeklyOpenCloseEventJSON  result;
          {
            HoldingGenerator handler = new HoldingGenerator("Type WeeklyOpenCloseEvent", ignore_extras);
            ancestor.write_as_json(handler);
            result = handler.value;
          }
        return result;
      }
  };
